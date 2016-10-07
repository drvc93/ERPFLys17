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

using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Estadistico;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.Estadistico
{
    public partial class frmRptBalanceMensual : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptBalanceMensual()
        {
            InitializeComponent();
        }

       

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> LstA = negCompania.ListaXUsuario(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo,fnConst.StringT, new String[] { fnConst.TextNingunoCod, fnConst.TextSeleccioneNom});
            cmbCompaniab.Properties.DataSource = LstA;
            cmbCompaniab.Properties.DisplayMember = "Nombres";
            cmbCompaniab.Properties.ValueMember = "Compania";
            LstA = null;

            //Moneda
            cmbsMoneda.Properties.DataSource = fnListasDat.ListMoneda();
            cmbsMoneda.Properties.DisplayMember = "Nombre";
            cmbsMoneda.Properties.ValueMember = "Codigo";
               //Tipo Cuenta

            cmbTFormato.Properties.Items.AddRange(new string[] { "Formato general", "Formato de dos digitos" });
            

        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompaniab.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompaniab.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;

            cmbsMoneda.EditValue = fnConst.MonedaLocalCod;
          
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompaniab.EditValue.ToString();
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
            String sCia = cmbCompaniab.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim();
            String sMon = cmbsMoneda.EditValue.ToString();
            int sTipoF = cmbTFormato.SelectedIndex;
            

            try
            {
                if (sTipoF == 0)
                {
                    xPrmR.AddParametro(new entRepParam() { Propiedad = "prmCompania", Valor = sCia });
                    xPrmR.AddParametro(new entRepParam() { Propiedad = "prmPeriodo", Valor = sPer });
                    xPrmR.AddParametro(new entRepParam() { Propiedad = "prmMoneda", Valor = sMon });



                    rpt_BalMensual oRpt = new rpt_BalMensual();
                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;

                }
                else if (sTipoF==1)
                {

                    xPrmR.AddParametro(new entRepParam() { Propiedad = "prmCompania", Valor = sCia });
                    xPrmR.AddParametro(new entRepParam() { Propiedad = "prmPeriodo", Valor = sPer });
                    xPrmR.AddParametro(new entRepParam() { Propiedad = "prmMoneda", Valor = sMon });



                    rpt_BalMensual2D oRpt = new rpt_BalMensual2D();
                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;
                }
                

            }
            catch (Exception ex)
            {
                fnMensaje.MensajeInfo(ex.Message);
            }
        }

        #endregion

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void frmRptBalanceComp_Load(object sender, EventArgs e)
        {

        }

        private void frmRptBalanceMensual_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxCargarCombosXCia();
            fxSetearInicio();
        }

    }
}
