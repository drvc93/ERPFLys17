using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Domain.Sistema;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad
{
    public partial class frmRptLibroDiario : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptLibroDiario()
        {
            InitializeComponent();
        }

        private void frmRptLibroDiario_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxCargarCombosXCia();
            fxSetearInicio();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListaXUsuario(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo,fnConst.StringT, new String[] { fnConst.TextNingunoCod, fnConst.TextSeleccioneNom});
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;

            //Moneda
            cmbMoneda.Properties.DataSource = fnListasDat.ListMoneda();
            cmbMoneda.Properties.DisplayMember = "Nombre";
            cmbMoneda.Properties.ValueMember = "Codigo";
            
            //Tipo Cuenta
            cmbTipoCuenta.Properties.DataSource = fnListasDat.ListTipoCuentaContable();
            cmbTipoCuenta.Properties.DisplayMember = "Nombre";
            cmbTipoCuenta.Properties.ValueMember = "Codigo";

            //Tipo C.Costo
            cmbTCCosto.Properties.DataSource = fnListasDat.ListRptGrupoCCosto();
            cmbTCCosto.Properties.DisplayMember = "Nombre";
            cmbTCCosto.Properties.ValueMember = "Codigo";
            
            //Version
            cmbVersion.Properties.DataSource = fnListasDat.ListRptLBContableVersion();
            cmbVersion.Properties.DisplayMember = "Nombre";
            cmbVersion.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;

            cmbMoneda.EditValue = fnConst.MonedaLocalCod;
            cmbTipoCuenta.EditValue = fnConst.TipoCuentaGenCod;
            cmbTCCosto.EditValue = fnConst.RepCCostoGrupoXCCostoCod;
            cmbVersion.EditValue = fnConst.RepVersionLBContableV500Cod;
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");            

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)) {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return false;
            }
            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sMon = cmbMoneda.EditValue.ToString();
            String sTip = cmbTipoCuenta.EditValue.ToString();
            String sInc = (chkIncluirPeriodoRelacionado.Checked) ? "S" : "N";
            String sTRp = "1";
            String sTcc = cmbTCCosto.EditValue.ToString();
            String sVer = cmbVersion.EditValue.ToString();
            
            xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "Moneda", Valor = sMon });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoCuenta", Valor = sTip });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "IncPeriodo", Valor = sInc });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = sTRp });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "TCCosto", Valor = sTcc });

            switch(sVer){
                case fnConst.RepVersionLBContableV409Cod:
                    rpt_LibroDiario oRpt = new rpt_LibroDiario();
                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;
                    break;
                case fnConst.RepVersionLBContableV500Cod:
                    rpt_LibroDiarioV500 oRptV = new rpt_LibroDiarioV500();
                    oRptV.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRptV;
                    FnReportW = xPrmR;
                    oRptV = null;
                    break;
            }            
        }

        #endregion

        #region "==EventObject=="

        private void btnGenerarFileTXT_Click(object sender, EventArgs e)
        {
            String sCia = "", sPer = "", sMon = "", sRuc="", sFil = "", sRut = "";
            
            if (uf_validarBuscar()) {
                GenerarBuscar();

                //Ruta a Guardar
                sCia = FnReportW.GetValue("Compania").ToString();
                sPer = FnReportW.GetValue("Periodo").ToString();
                sMon = FnReportW.GetValue("Moneda").ToString();
                sMon = (sMon.Equals("L")) ? "1" : "2";

                sRuc = negCompania.GetDatosDocFiscal(sCia);
                sFil = "LE" + sRuc + sPer + "000501" + "0000" + "11" + sMon + "1";
                sRut = GlobalVar.DirRegSunat + sFil;
                if (!fnFile.ExisteDirectorio(GlobalVar.DirRegSunat)) {
                    fnMensaje.MensajeInfo("No existe Directorio donde exportar");
                    return;
                }

                FnReportW.SetValue("TipoReporte", "2");
                Int32 nReturn = fnExportar.CreateTXTFile(FnReportW.GetQueryProcPK(),"D:\\midatos.txt",false);
                if (nReturn != 1) {
                    fnMensaje.MensajeInfo(fnExportar.MensajeError(nReturn));
                    return;
                }
                fnMensaje.MensajeInfo("Archivo de TXT se generó satisfactoriamente. " + sRut);
            }
        }

        #endregion

    }
}
