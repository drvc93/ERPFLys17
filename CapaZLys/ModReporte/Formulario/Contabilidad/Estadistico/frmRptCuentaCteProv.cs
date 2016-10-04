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
using FiltroLys.ZLys.Busqueda.General;
using FiltroLys.ZLys.Funciones;
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Estadistico;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.Estadistico
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
            List<entCompania> LstA = negCompania.ListaXUsuario(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringT, new String[] { fnConst.TextNingunoCod, fnConst.TextSeleccioneNom });
            cmbCompania.Properties.DataSource = LstA;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            LstA = null;
            
            //Moneda
            cmbMoneda.Properties.DataSource = fnListasDat.ListMoneda();
            cmbMoneda.Properties.DisplayMember = "Nombre";
            cmbMoneda.Properties.ValueMember = "Codigo";
            
            cmbConsulta.Properties.Items.AddRange(new string[] { "Cuenta corriente Detallada", "Cuenta corriente Consolidado", "Gastos Mensuales Detallado" });
            cmbOrdenar.Properties.Items.AddRange(new string[] { "Monto", "Fecha", "Documento" });
        }
        
        private void fxCargarCombosXCia()
        {
        }
        
        private void fxSetearInicio()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            cmbMoneda.EditValue = fnConst.MonedaLocalCod;
            cmbConsulta.SelectedIndex = 0;
            cmbOrdenar.SelectedIndex = 0;
        }
        
        #endregion
        
        #region "==EventInherit=="
        
        public override Boolean uf_validarBuscar()
        {
            String sCia = cmbCompania.EditValue.ToString();
            String sPerI = txtPerIni.Text.Trim().Replace("-", "");
            String sPerF = txtPerFin.Text.Trim().Replace("-", "");
            String sCtaI = txtCuentaIni.Text.Trim();
            String sCtaF = txtCuentaFin.Text.Trim();
            String sProv = txtProveedor.Text.Trim();
            Int32 nProv = 0;
            Int32.TryParse(sProv, out nProv);
            
            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio))
            {
                fnMensaje.MensajeInfo("Ingresar compañia por favor.");
                return false;
            }
            
            if (String.IsNullOrWhiteSpace(sPerI))
            {
                fnMensaje.MensajeInfo("Debe ingresar un periodo Inicial.");
                return false;
            }
            
            if (String.IsNullOrWhiteSpace(sPerF))
            {
                fnMensaje.MensajeInfo("Debe ingresar un periodo Final.");
                return false;
            }
            
            if (String.IsNullOrWhiteSpace(sCtaI))
            {
                fnMensaje.MensajeInfo("Debe ingresar Cuenta Inicial.");
                return false;
            }
            
            if (String.IsNullOrWhiteSpace(sCtaF))
            {
                fnMensaje.MensajeInfo("Debe ingresar Cuenta Final.");
                return false;
            }
            
            if (!chkProv.Checked && (sProv.Length == 0 || nProv == 0))
            {
                fnMensaje.MensajeInfo("Debe ingresar proveedor.");
                return false;
            }
            
            return true;
        }
        
        public override void ue_Buscar()
        {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPerI = txtPerIni.Text.Trim().Replace("-", "");
            String sPerF = txtPerFin.Text.Trim().Replace("-", "");
            String sCtI = txtCuentaIni.Text.Trim();
            String sCtF = txtCuentaFin.Text.Trim();
            String sChkProv = (chkProv.Checked) ? "S" : "N";
            String sProv = txtProveedor.Text.Trim();
            Int32 nProv = 0;
            Int32.TryParse(sProv, out nProv);
            String sCCos = txtCCosto.Text.Trim();
            sCCos = (sCCos.Length > 0) ? sCCos : "%";
            String sMon = cmbMoneda.EditValue.ToString();
            String sCtaDest = txtCtaDestino.Text;
            sCtaDest = (sCtaDest.Length > 0) ? sCtaDest : "%";
            String sChkPend = (chkDocPendiente.Checked) ? "S" : "N";
            String sOrdenar = cmbOrdenar.EditValue.ToString().Substring(0, 1);
            String sConsulta = (cmbConsulta.SelectedIndex + 1).ToString("00");
            
            try
            {
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "PerIni", Valor = sPerI });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "PerFin", Valor = sPerF });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaIni", Valor = sCtI });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CuentaFin", Valor = sCtF });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagProv", Valor = sChkProv });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Proveedor", Valor = nProv.ToString() });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CCosto", Valor = sCCos });              
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Moneda", Valor = sMon });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CtaDestino", Valor = sCtaDest });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Pendiente", Valor = sChkPend });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Ordenar", Valor = sOrdenar });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Consulta", Valor = sConsulta });
                
                //  Consulta :00 > reporte de cuenta corriente prov detallado
                // Consulta :01 > reporte de cuenta corriente prov consolidado
                // Consulta :02 > reporte de gastos mensuales
                
                if (sConsulta == "01")
                {
                    rpt_CtaCteProveedor oRpt = new rpt_CtaCteProveedor();
                    
                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;
                }
                
                else if (sConsulta == "02")
                {

                    rpt_CtaCteProveedorCons oRpt = new rpt_CtaCteProveedorCons();

                    oRpt.GenerarReport(ref xPrmR);
                    dvReport.DocumentSource = oRpt;
                    FnReportW = xPrmR;
                    oRpt = null;
                }
                else if (sConsulta == "03")
                {

                    rpt_GastosMensualDet oRpt = new rpt_GastosMensualDet();

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
        
        private void chkProveedor_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void chkProv_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProv.Checked)
            {
                txtProveedor.ReadOnly = true;
                txtProveedorNom.Text = String.Empty;
                txtProveedor.Text = String.Empty;
            }
            else
            {
                txtProveedor.ReadOnly = false;
            }
        }
        
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            if (chkProv.Checked)
            {
                return;
            }
            String sCia = cmbCompania.EditValue.ToString();
            
            if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio))
            {
                fnMensaje.MensajeInfo("Compañia no seleccionada.");
                return;
            }
            
            frmBusqPersona frm = new frmBusqPersona();
            frm.MultipleSelect = false;
            frm.SoloActivo = true;
            frm.Compania = sCia;
            frm.VerEmpleado = false;
            frm.VerCliente = false;
            frm.VerProveedor = true;
            frm.SoloActivo = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                entPersona oEnt = fnConvert.ObjectToEntity<entPersona>(frm.EstructuraForm.ObjX)[0];
                txtProveedor.Text = oEnt.Persona.ToString();
                entProveedor OProv = negProveedor.GetFormID(sCia, oEnt.Persona);
                if (OProv.ResultadoBusqueda)
                {
                    txtProveedorNom.Text = OProv.Nombres.Trim();
                }
                txtProveedorNom.Text = oEnt.NombreCompleto.Trim();
                oEnt = null;
                OProv = null;
            }
            frm = null;
        }
        
        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        
        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
        }
        
        private void txtProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProveedor.Text.Length > 0)
            {
                String sCia = cmbCompania.EditValue.ToString();
                String sProv = txtProveedor.Text.Trim();
                String sNombre = String.Empty;
                Int32 nProv = 0;
                Int32.TryParse(sProv, out nProv);
                
                if (String.IsNullOrEmpty(sCia) || sCia.Equals(fnConst.TextVacio))
                {
                    fnMensaje.MensajeInfo("Proveedor no seleccionado.");
                    return;
                }
                
                txtProveedorNom.Text = String.Empty;
                if (nProv > 0)
                {
                    entProveedor oEnt = negProveedor.GetFormID(sCia, nProv);
                    if (!oEnt.ResultadoBusqueda)
                    {
                        fnMensaje.MensajeInfo("El código del proveedor es invalido");
                        return;
                    }
                    sProv = oEnt.RazonSocial.Trim();
                    txtProveedorNom.Text = sProv;
                }
            }
        }
    }
}