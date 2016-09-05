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
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad
{
    public partial class frmRptCuentaCCosto : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptCuentaCCosto()
        {
            InitializeComponent();
        }

        private void frmRptCuentaCCosto_Load(object sender, EventArgs e)
        {
            fxQuitEvent();
            fxCargarCombos();
            fxCargarCombosXCia();
            fxSetearInicio();
            fxAddEvent();
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
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;                    
        }

        private void fxQuitEvent()
        {
            this.txtMayorDesde.EditValueChanged -= new EventHandler(txtMayorDesde_EditValueChanged);
            this.txtMayorHasta.EditValueChanged -= new EventHandler(txtMayorHasta_EditValueChanged);
        }

        private void fxAddEvent()
        {
            this.txtMayorDesde.EditValueChanged += new EventHandler(txtMayorDesde_EditValueChanged);
            this.txtMayorHasta.EditValueChanged += new EventHandler(txtMayorHasta_EditValueChanged);
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text;
            String sCCosto = txtCCosto.Text.Trim();
            String sMayDesde = txtMayorDesde.Text.Trim();
            String sMayHasta = txtMayorHasta.Text.Trim();

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)) {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return false;
            }

            if (!chkCCosto.Checked && sCCosto.Equals(String.Empty)) { 
                fnMensaje.MensajeInfo("Ingresar CCosto por favor.");
                return false;
            }

            if (sMayDesde.Equals(String.Empty)) {
                fnMensaje.MensajeInfo("Ingresar Mayor Desde por favor.");
                return false;
            }

            if (sMayHasta.Equals(String.Empty)){
                fnMensaje.MensajeInfo("Ingresar Mayor Desde por favor.");
                return false;
            }

            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim();
            String sCCosto = txtCCosto.Text.Trim();
            String sMayDesde = txtMayorDesde.Text.Trim();
            String sMayHasta = txtMayorHasta.Text.Trim();
            
            /*try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Moneda", Valor = sMon });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaIni", Valor = sCtI });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaFin", Valor = sCtF });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoCuenta", Valor = sTip });

                rpt_LibroBanco oRpt = new rpt_LibroBanco();
                oRpt.GenerarReport(ref xPrmR);
                dvReport.DocumentSource = oRpt;
                FnReportW = xPrmR;
                oRpt = null;
               
            }catch(Exception ex){
                fnMensaje.MensajeInfo(ex.Message);            
            }*/
        }

        #endregion

        #region "==EventObject=="

        private void btnCCosto_Click(object sender, EventArgs e)
        {
            if (chkCCosto.Checked) { return; }
            String sCia = cmbCompania.EditValue.ToString();

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)){
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return;
            }

            frmBusqCentroCosto frm = new frmBusqCentroCosto();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.EstructuraForm.StrX.Insert(0, sCia);
            if (frm.ShowDialog() == DialogResult.OK){
                entCentroCosto objE = fnConvert.ObjectToEntity<entCentroCosto>(frm.EstructuraForm.ObjX)[0];
                txtCCosto.Text = objE.CentroCosto;
                txtCCostoNom.Text = objE.Nombres;
                objE = null;
            }
            frm = null;
        }

        private void btnMayorDesde_Click(object sender, EventArgs e)
        {
            frmBusqCuentaMayor frm = new frmBusqCuentaMayor();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaMayor objE = fnConvert.ObjectToEntity<entCuentaMayor>(frm.EstructuraForm.ObjX)[0];
                txtMayorDesde.Text = objE.CuentaMayor;
                txtMayorDesdeNom.Text = objE.Descripcion;
                objE = null;
            }
            frm = null;
        }

        private void btnMayorHasta_Click(object sender, EventArgs e)
        {
            frmBusqCuentaMayor frm = new frmBusqCuentaMayor();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK){
                entCuentaMayor objE = fnConvert.ObjectToEntity<entCuentaMayor>(frm.EstructuraForm.ObjX)[0];
                txtMayorDesde.Text = objE.CuentaMayor;
                txtMayorDesdeNom.Text = objE.Descripcion;
                objE = null;
            }
            frm = null;
        }

        private void chkCCosto_CheckedChanged(object sender, EventArgs e)
        {
            txtCCosto.ReadOnly = chkCCosto.Checked;
            txtCCosto.Text = String.Empty;
            txtCCostoNom.Text = String.Empty;
        }

        private void txtCCosto_EditValueChanged(object sender, EventArgs e)
        {
            String sCia = cmbCompania.EditValue.ToString();
            String SCCosto = txtCCosto.Text.Trim();

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)){
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return;
            }

            String sCCosto = txtCCosto.Text.Trim();
            entCentroCosto oEnt = negCentroCosto.GetFormID(sCia, SCCosto);

            if (oEnt.ResultadoBusqueda) {
                txtCCostoNom.Text = oEnt.Nombres;
            }
            oEnt = null;
        }

        private void txtMayorDesde_EditValueChanged(object sender, EventArgs e)
        {
            String SMayor = txtMayorDesde.Text.Trim();
            entCuentaMayor oEnt = negCuentaMayor.GetFormID(SMayor);
            if (oEnt.ResultadoBusqueda){
                txtMayorDesdeNom.Text = oEnt.Descripcion;
            }
            oEnt = null;
        }

        private void txtMayorHasta_EditValueChanged(object sender, EventArgs e)
        {
            String SMayor = txtMayorHasta.Text.Trim();
            entCuentaMayor oEnt = negCuentaMayor.GetFormID(SMayor);
            if (oEnt.ResultadoBusqueda){
                txtMayorHastaNom.Text = oEnt.Descripcion;
            }
            oEnt = null;
        }

        #endregion

    }
}
