using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Domain.Sistema;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.Busqueda.General;
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    public partial class frmRptDocumentoPend : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptDocumentoPend()
        {
            InitializeComponent();
        }

        private void frmRptDocumentoPend_Load(object sender, EventArgs e)
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
            
            //Formato
            cmbFormato.Properties.DataSource = fnListasDat.ListFormatoReporte();
            cmbFormato.Properties.DisplayMember = "Nombre";
            cmbFormato.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            cmbFormato.EditValue = fnConst.FormatoResumidoCod;
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sCta = txtCuenta.Text.Trim();

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)) {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return false;
            }

            if (String.IsNullOrEmpty(sCta)){
                fnMensaje.MensajeInfo("Ingresar Cuenta por favor.");
                return false;
            }

            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sCta = txtCuenta.Text.Trim();
            String sTRe = cmbFormato.EditValue.ToString();
            String sCiaNom = cmbCompania.Text.Trim();
            String sCtaNom = txtCuentaNombre.Text.Trim();
            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Cuenta", Valor = sCta });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoRep", Valor = sTRe });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CompaniaNombre", Valor = sCiaNom, OtrosDatos = true });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaNombre", Valor = sCtaNom, OtrosDatos = true });

                if (sTRe.Equals(fnConst.FormatoDetalladoCod)) {
                    rpt_SaldoPendienteDet oRpt = new rpt_SaldoPendienteDet();
                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;
                }

                if (sTRe.Equals(fnConst.FormatoResumidoCod)) {
                    rpt_SaldoPendienteRes oRpt = new rpt_SaldoPendienteRes();
                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;
                }
            }catch(Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

        #region "==EventObject=="

        private void btnCuenta_Click(object sender, EventArgs e)
        {   
            frmBusqCtaContable frm = new frmBusqCtaContable();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaContable oEnt = fnConvert.ObjectToEntity<entCuentaContable>(frm.EstructuraForm.ObjX)[0];
                txtCuenta.Text = oEnt.Cuenta;
                txtCuentaNombre.Text = oEnt.Nombres;
                oEnt = null;
            }            
            frm = null;
        }

        private void txtCuenta_EditValueChanged(object sender, EventArgs e)
        {
            String sCta = txtCuenta.Text.Trim();
            entCuentaContable oEnt = negCuentaContable.GetFormID(sCta);
            txtCuentaNombre.Text = String.Empty;
            if (oEnt.ResultadoBusqueda) { 
                txtCuentaNombre.Text = oEnt.Nombres;
            }
        }

        #endregion

    }
}
