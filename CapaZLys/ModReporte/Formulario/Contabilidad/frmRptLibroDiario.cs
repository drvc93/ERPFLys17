using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Objeto;
using FiltroLys.Type;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.ModReporte.Reporte;

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
            rptPrueba oRpt = new rptPrueba();
            fnReport xPrmR = new fnReport();

            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sMon = cmbMoneda.EditValue.ToString();
            String sTip = cmbTipoCuenta.EditValue.ToString();
            String sInc = (chkIncluirPeriodoRelacionado.Checked) ? "S" : "N";
            String sTRp = "1";
            String sTcc = cmbTCCosto.EditValue.ToString();

            xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "Moneda", Valor = sMon });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoCuenta", Valor = sTip });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "IncPeriodo", Valor = sInc });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = sTRp });
            xPrmR.AddParametro(new entRepParam() { Propiedad = "TCCosto", Valor = sTcc });

            oRpt.GenerarReport(ref xPrmR);
            dvReport.DocumentSource = oRpt;
            FnReportW = xPrmR;
            
            oRpt = null;
        }

        #endregion
        
    }
}
