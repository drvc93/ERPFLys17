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
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    public partial class frmRptRegistroVenta : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptRegistroVenta()
        {
            InitializeComponent();
        }

        private void frmRptRegistroVenta_Load(object sender, EventArgs e)
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
            
            //Version
            cmbVersion.Properties.DataSource = fnListasDat.ListRptLBContableVersion();
            cmbVersion.Properties.DisplayMember = "Nombre";
            cmbVersion.Properties.ValueMember = "Codigo";

            //Consultas
            List<entComboList> LstB = new List<entComboList>();
            LstB.Add(new entComboList() { Codigo = "RV", Nombre = "Registro de Ventas" });            
            cmbConsulta.Properties.DataSource = LstB;
            cmbConsulta.Properties.DisplayMember = "Nombre";
            cmbConsulta.Properties.ValueMember = "Codigo";
            LstB = null;
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            Int32 nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            String sPerAnt = fnGeneral.PeriodoAnt(DateTime.Today);

            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            cmbVersion.EditValue = fnConst.RepVersionLBContableV500Cod;
            cmbConsulta.EditValue = "RV";
            txtPeriodo.Text = sPerAnt;
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
            String sTip = cmbConsulta.EditValue.ToString();
            String sTRp = "1";            
            String sVer = cmbVersion.EditValue.ToString();
            sPer = sPer + sTRp;

            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                switch(sVer){
                    case fnConst.RepVersionLBContableV409Cod:
                        rpt_RegistroVentaV409 oRpt = new rpt_RegistroVentaV409();
                        oRpt.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt;
                        FnReportW = xPrmR;
                        oRpt = null;
                        break;
                    case fnConst.RepVersionLBContableV500Cod:
                        rpt_RegistroVentaV500 oRptV = new rpt_RegistroVentaV500();
                        oRptV.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRptV;
                        FnReportW = xPrmR;
                        oRptV = null;
                        break;
                }
            }catch(Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

        #region "==EventObject=="

        private void btnGenerarFileTXT_Click(object sender, EventArgs e)
        {
            String sCia = "", sPer = "", sMon = "", sRuc="", sFil = "", sRut = "", sConInf="0";
            
            if (uf_validarBuscar()) {
                try{
                    OpenFormEspere(this);
                    ue_Buscar();

                    //Ruta a Guardar
                    sCia = FnReportW.GetValue("Compania").ToString();
                    sPer = FnReportW.GetValue("Periodo").ToString();
                    sConInf = (FnReportW.ContReg > 0) ? "1" : "0";
                    sPer = sPer.Substring(0, 6) + "2";

                    sRuc = negCompania.GetDatosDocFiscal(sCia);
                    sFil = "LE" + sRuc + sPer + "001401" + "0000" + "1" + sConInf + sMon + "1";
                    sRut = GlobalVar.DirRegSunat + sFil + ".txt";
                    if (!fnFile.ExisteDirectorio(GlobalVar.DirRegSunat)) {
                        fnMensaje.MensajeInfo("No existe Directorio donde exportar");
                        CloseFormEspere();
                        return;
                    }

                    //Exportar Informacion
                    FnReportW.SetValue("Periodo", sPer);
                    Int32 nReturn = fnExportar.CreateTXTFile(FnReportW.GetQueryProcPK(), sRut, false);
                    CloseFormEspere();
                    if (nReturn != 1) {
                        fnMensaje.MensajeInfo(fnExportar.MensajeError(nReturn));                    
                        return;
                    }
                    fnMensaje.MensajeInfo("Archivo de TXT se generó satisfactoriamente. " + sRut);
                }catch(Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);
                }
            }
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}
