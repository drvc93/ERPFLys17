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
    public partial class frmRptCuentaCteProv : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptCuentaCteProv()
        {
            InitializeComponent();
        }

        private void frmRptCuentaCteProv_Load(object sender, EventArgs e)
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
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            cmbMoneda.EditValue = fnConst.MonedaLocalCod;
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sCia = cmbCompania.EditValue.ToString();
            String sPerI = txtPerIni.Text.Trim().Replace("-", "");
            String sPerF = txtPerFin.Text.Trim().Replace("-", "");
            String sCtaI = txtCuentaIni.Text.Trim();
            String sCtaF = txtCuentaFin.Text.Trim();
            String sProv = txtProveedor.Text.Trim();
            Int32 nProv = 0;
            Int32.TryParse(sProv, out nProv);

            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio)) {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPerI)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo Inicial.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sPerF)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo Final.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sCtaI)){
                fnMensaje.MensajeInfo("Debe ingresar Cuenta Inicial.");
                return false;
            }

            if (String.IsNullOrWhiteSpace(sCtaF)){
                fnMensaje.MensajeInfo("Debe ingresar Cuenta Final.");
                return false;
            }

            if (!chkProveedor.Checked && (sProv.Length == 0 || nProv == 0)) {
                fnMensaje.MensajeInfo("Debe ingresar proveedor.");
                return false;
            }

            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPerI = txtPerIni.Text.Trim().Replace("-", "");
            String sPerF = txtPerFin.Text.Trim().Replace("-", "");
            String sCtI = txtCuentaIni.Text.Trim();
            String sCtF = txtCuentaFin.Text.Trim();
            String sMon = cmbMoneda.EditValue.ToString();
            String sProv = txtProveedor.Text.Trim();
            String sCCos = txtCCosto.Text.Trim();
            String sChkProv = (chkProveedor.Checked) ? "S" : "N";
            String sChkPend = (chkDocPendiente.Checked)?"S":"N";
            Int32 nProv = 0;
            Int32.TryParse(sProv, out nProv);
            sCCos = (sCCos.Length>0)?sCCos:"T";

            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "PerIni", Valor = sPerI });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "PerFin", Valor = sPerF });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaIni", Valor = sCtI });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaFin", Valor = sCtF });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Moneda", Valor = sMon });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Proveedor", Valor = nProv.ToString()});
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CCosto", Valor = sCCos });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Pendiente", Valor = sChkPend });

                rpt_CuentaCCteProv oRpt = new rpt_CuentaCCteProv();
                oRpt.GenerarReport(ref xPrmR);
                dvReport.DocumentSource = oRpt;
                FnReportW = xPrmR;
                oRpt = null;
               
            }catch(Exception ex){
                fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

    }
}
