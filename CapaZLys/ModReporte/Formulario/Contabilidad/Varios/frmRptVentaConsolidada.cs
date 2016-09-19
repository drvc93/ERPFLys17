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
    public partial class frmRptVentaConsolidada : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptVentaConsolidada()
        {
            InitializeComponent();
        }

        private void frmRptVentaConsolidada_Load(object sender, EventArgs e)
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

            //Consultas
            List<entComboList> LstB = new List<entComboList>();
            LstB.Add(new entComboList() { Codigo = "1", Nombre = "Detalle Venta consolidada" });
            LstB.Add(new entComboList() { Codigo = "2", Nombre = "Resumen Venta consolidada" });
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
            cmbMoneda.EditValue = fnConst.MonedaLocalCod;
            cmbConsulta.EditValue = "1";
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
            String sTRp = cmbConsulta.EditValue.ToString();            
            String sMon = cmbMoneda.EditValue.ToString();
            
            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Consulta", Valor = sTRp });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Moneda", Valor = sMon });
                switch(sTRp){
                    case "1":
                        rpt_AnalisisVentaCostoDet oRpt = new rpt_AnalisisVentaCostoDet();
                        oRpt.GenerarReport(ref xPrmR);
                        dvReport.DocumentSource = oRpt;
                        FnReportW = xPrmR;
                        oRpt = null;
                        break;
                    case "2":
                        rpt_AnalisisVentaCostoRes oRptV = new rpt_AnalisisVentaCostoRes();
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
               
    }
}
