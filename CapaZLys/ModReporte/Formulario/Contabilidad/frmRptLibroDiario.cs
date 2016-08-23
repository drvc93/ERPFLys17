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

        public override Boolean uf_validarExpExcel() { return true; }

        public override void ue_Buscar() {
            rptPrueba orpt = new rptPrueba();
            fnReport xPrm = new fnReport();

            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");

            xPrm.Parametros.Add(new entRepParam() { Propiedad = "Compania", Tipo = fnEnum.TDatoReportParam.sStrings, Valor = sCia });
            xPrm.Parametros.Add(new entRepParam() { Propiedad = "Periodo", Tipo = fnEnum.TDatoReportParam.sStrings, Valor = sPer });
            orpt.GenerarReport(xPrm);
            dvReport.DocumentSource = orpt;       
            
        }

        public override void ue_ExportarDat() {
            DataTable dt = new DataTable();
            String sTexto = "SP_CB_REP_LIBRODIARIO '00100000','201605','L','E','N','1','A'";
            dt = FiltroLys.Domain.Sistema.negBaseDatos.ListaDatosOfStoreProc(sTexto);        
        }

        #endregion
        
    }
}
