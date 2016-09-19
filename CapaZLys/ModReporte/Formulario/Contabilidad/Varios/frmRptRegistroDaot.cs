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
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Varios;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.Varios
{
    public partial class frmRptRegistroDaot : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptRegistroDaot()
        {
            InitializeComponent();
        }

        private void frmRptDaot_Load(object sender, EventArgs e)
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

            //SuperaLimite
            cmbSuperaLimite.Properties.DataSource = fnListasDat.ListEstadoSiNoAmbos();
            cmbSuperaLimite.Properties.DisplayMember = "Nombre";
            cmbSuperaLimite.Properties.ValueMember = "Codigo";

            //Moneda
            List<entComboList> LstB = new List<entComboList>();
            LstB.Add(new entComboList() { Codigo = "1", Nombre = "1. Ventas Resumen (Ingresos)" });
            LstB.Add(new entComboList() { Codigo = "2", Nombre = "2. Ventas Detalle" });
            LstB.Add(new entComboList() { Codigo = "3", Nombre = "3. Compras Resumen (Costos)" });
            LstB.Add(new entComboList() { Codigo = "4", Nombre = "4. Compras Detalle" });
            cmbConsulta.Properties.DataSource = LstB;
            cmbConsulta.Properties.DisplayMember = "Nombre";
            cmbConsulta.Properties.ValueMember = "Codigo";
            LstB = null;
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;

            cmbConsulta.EditValue = "1";
            cmbSuperaLimite.EditValue = fnConst.StringAmbosCod;
            txtPeriodo.Text = (DateTime.Today.Year-1).ToString();
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
            String sPer = txtPeriodo.Text.Trim();
            String sTRp = cmbConsulta.EditValue.ToString();
            String sSLm = cmbSuperaLimite.EditValue.ToString();
            String sCiaNombre = cmbCompania.Text.Trim();

            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagSupera", Valor = sSLm });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CompaniaNombre", Valor = sCiaNombre, OtrosDatos = true });

                switch(sTRp){
                    case "1":
                        xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = 1 });
                        rpt_RegistroVentaDaotRes oRpt1 = new rpt_RegistroVentaDaotRes();
                        oRpt1.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt1;
                        FnReportW = xPrmR;
                        oRpt1 = null;
                        break;
                    case "2":
                        xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = 2 });
                        rpt_RegistroVentaDaotDet oRpt2 = new rpt_RegistroVentaDaotDet();
                        oRpt2.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt2;
                        FnReportW = xPrmR;
                        oRpt2 = null;
                        break;
                    case "3":
                        xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = 1 });
                        rpt_RegistroCompraDaotRes oRpt3 = new rpt_RegistroCompraDaotRes();
                        oRpt3.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt3;
                        FnReportW = xPrmR;
                        oRpt3 = null;
                        break;
                    case "4":
                        xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = 2 });
                        rpt_RegistroCompraDaotDet oRpt4 = new rpt_RegistroCompraDaotDet();
                        oRpt4.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt4;
                        FnReportW = xPrmR;
                        oRpt4 = null;
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
            String sFlgSup = "",sTRep = "", sFil = "", sRut = "";
            
            if (uf_validarBuscar()) {
                try{

                    //Validación Antes
                    sFlgSup = cmbSuperaLimite.EditValue.ToString();
                    sTRep = cmbConsulta.EditValue.ToString();
                    if (!sFlgSup.Equals("S")) {
                        fnMensaje.MensajeInfo("Solo puede seleccionar registros que superan Limite.");
                        return;
                    }

                    if (!(sTRep.Equals("1") || sTRep.Equals("3"))) {
                        fnMensaje.MensajeInfo("Consulta no valida para generacion de Archivo.");
                        return;
                    }

                    OpenFormEspere(this);
                    ue_Buscar();

                    //Tipo Reporte - Nombre File
                    if (sTRep.Equals("1")) { sFil = "Ingresos"; }
                    if (sTRep.Equals("3")) { sFil = "Costos"; }

                    sRut = GlobalVar.DirDAOT + sFil + ".txt";
                    if (!fnFile.ExisteDirectorio(GlobalVar.DirDAOT)) {
                        fnMensaje.MensajeInfo("No existe Directorio donde exportar");
                        CloseFormEspere();
                        return;
                    }

                    //Exportar Informacion
                    FnReportW.SetValue("TipoReporte", 3);
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

    }
}
