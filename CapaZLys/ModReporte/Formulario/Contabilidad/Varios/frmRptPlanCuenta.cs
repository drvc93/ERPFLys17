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
using FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Varios;

namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.Varios
{
    public partial class frmRptPlanCuenta : FiltroLys.ZLys.Controles.Formulario.frmReporte
    {
        #region "==EventForm=="

        public frmRptPlanCuenta()
        {
            InitializeComponent();
        }

        private void frmRptPlanCuenta_Load(object sender, EventArgs e)
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

            //Tipo Cuenta
            cmbTipoCuenta.Properties.DataSource = fnListasDat.ListTipoCuentaContable();
            cmbTipoCuenta.Properties.DisplayMember = "Nombre";
            cmbTipoCuenta.Properties.ValueMember = "Codigo";

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoActInacSel();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";

            fxCargarMayor02();
            fxCargarMayor03();
            fxCargarMayor04();
            fxCargarMayor05();
        }

        private void fxCargarMayor02() {
            List<entClasificacionMayor> LstA = negClasificacionMayor.ListaCombo(fnConst.StringPorc, new String[] { fnConst.TextRaya3, fnConst.TextSeleccioneNom });
            cmbMayor02.Properties.DataSource = LstA;
            cmbMayor02.Properties.DisplayMember = "Descripcion";
            cmbMayor02.Properties.ValueMember = "Clasificacion";
            cmbMayor02.EditValue = fnConst.TextRaya3;
        }

        private void fxCargarMayor03() {
            String sMayor02 = String.Empty;
            if (cmbMayor02.EditValue != null) { sMayor02 = cmbMayor02.EditValue.ToString();}

            List<entCuentaMayor> LstA = negCuentaMayor.ListaCombo(sMayor02, fnConst.StringPorc, new String[] { fnConst.TextRaya3, fnConst.TextSeleccioneNom });
            cmbMayor03.Properties.DataSource = LstA;
            cmbMayor03.Properties.DisplayMember = "Descripcion";
            cmbMayor03.Properties.ValueMember = "CuentaMayor";
            cmbMayor03.EditValue = fnConst.TextRaya3;
        
        }

        private void fxCargarMayor04() {
            String sMayor03 = String.Empty;            
            if (cmbMayor03.EditValue != null) { sMayor03 = cmbMayor03.EditValue.ToString(); }

            List<entCuentaMayor04> LstA = negCuentaMayor04.ListaCombo(sMayor03, fnConst.StringPorc, new String[] { fnConst.TextRaya3, fnConst.TextSeleccioneNom });
            cmbMayor04.Properties.DataSource = LstA;
            cmbMayor04.Properties.DisplayMember = "Descripcion";
            cmbMayor04.Properties.ValueMember = "CuentaMayor04";
            cmbMayor04.EditValue = fnConst.TextRaya3;
        }

        private void fxCargarMayor05() {
            String sMayor04 = String.Empty;
            if (cmbMayor04.EditValue != null) { sMayor04 = cmbMayor04.EditValue.ToString(); }

            List<entCuentaMayor05> LstA = negCuentaMayor05.ListaCombo(sMayor04, fnConst.StringPorc, new String[] { fnConst.TextRaya3, fnConst.TextSeleccioneNom });
            cmbMayor05.Properties.DataSource = LstA;
            cmbMayor05.Properties.DisplayMember = "Descripcion";
            cmbMayor05.Properties.ValueMember = "CuentaMayor05";
            cmbMayor05.EditValue = fnConst.TextRaya3;
        }

        private void fxCargarCombosXCia() { }

        private void fxSetearInicio() {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : fnConst.TextVacio;
            txtPeriodo.Text = fnGeneral.PeriodoAnt(fnGeneral.PeriodoActual());
            cmbTipoCuenta.EditValue = fnConst.TipoCuentaGenCod;
            cmbEstado.EditValue = fnConst.TextRaya3;
        }

        private void fxQuitEvent()
        {
            this.chkMayor02.CheckedChanged -= new EventHandler(chkMayor02_CheckedChanged);
            this.cmbMayor02.EditValueChanged -= new EventHandler(cmbMayor02_EditValueChanged);
            this.cmbMayor03.EditValueChanged -= new EventHandler(cmbMayor03_EditValueChanged);
            this.cmbMayor04.EditValueChanged -= new EventHandler(cmbMayor04_EditValueChanged);
        }

        private void fxAddEvent()
        {
            this.chkMayor02.CheckedChanged += new EventHandler(chkMayor02_CheckedChanged);
            this.cmbMayor02.EditValueChanged += new EventHandler(cmbMayor02_EditValueChanged);
            this.cmbMayor03.EditValueChanged += new EventHandler(cmbMayor03_EditValueChanged);
            this.cmbMayor04.EditValueChanged += new EventHandler(cmbMayor04_EditValueChanged);
        }

        #endregion

        #region "==EventInherit=="

        public override Boolean uf_validarBuscar() {
            String sEstado = String.Empty;
            String sMayor02 = String.Empty;

            sEstado = cmbEstado.EditValue.ToString();
            sMayor02 = cmbMayor02.EditValue.ToString();

            if (!chkEstado.Checked && sEstado.Equals(fnConst.TextRaya3)) {
                fnMensaje.MensajeInfo("Seleccionar Estado por Favor.");
            }

            if (!chkMayor02.Checked && sMayor02.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Seleccionar Mayor por Favor.");
            }
            return true;
        }

        public override void ue_Buscar() {
            fnReport xPrmR = new fnReport();
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Trim().Replace("-", "");
            String sFlgMay2 = (chkMayor02.Checked) ? "S" : "N";
            String sFlgEsta = (chkEstado.Checked) ? "S" : "N";
            String sMay2 = cmbMayor02.EditValue.ToString();
            String sMay3 = cmbMayor03.EditValue.ToString();
            String sMay4 = cmbMayor04.EditValue.ToString();
            String sMay5 = cmbMayor05.EditValue.ToString();
            String sEsta = cmbEstado.EditValue.ToString();
            String sTip = cmbTipoCuenta.EditValue.ToString();
            String sCiaN = cmbCompania.Text;
            String sTRp = "1";
            
            try{
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Compania", Valor = sCia });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Periodo", Valor = sPer });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoCuenta", Valor = sTip });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagMayor", Valor = sFlgMay2 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Mayor02", Valor = sMay2 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Mayor03", Valor = sMay3 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Mayor04", Valor = sMay4 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Mayor05", Valor = sMay5 });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "FlagEstado", Valor = sFlgEsta });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "Estado", Valor = sEsta });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "TipoReporte", Valor = sTRp });
                xPrmR.AddParametro(new entRepParam() { Propiedad = "CompaniaNombre", Valor = sCiaN, OtrosDatos = true });

                rpt_PlanCuenta oRptV = new rpt_PlanCuenta();
                oRptV.GenerarReport(ref xPrmR);
                dvReport.DocumentSource = oRptV;
                FnReportW = xPrmR;
                oRptV = null;
                
                
            }catch(Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);            
            }
        }

        #endregion

        #region "==EventObject=="

        private void btnGenerarFileTXT_Click(object sender, EventArgs e)
        {
            String sCia = "", sPer = "", sRuc="", sFil = "", sRut = "";
            
            if (uf_validarBuscar()) {
                try{
                    OpenFormEspere(this);
                    ue_Buscar();

                    //Ruta a Guardar
                    sCia = FnReportW.GetValue("Compania").ToString();
                    sPer = FnReportW.GetValue("Periodo").ToString();
                    
                    sRuc = negCompania.GetDatosDocFiscal(sCia);
                    sFil = "LE" + sRuc + sPer + "000503" + "0000" + "11" + "1" + "1";
                    sRut = GlobalVar.DirRegSunat + sFil + ".txt";
                    if (!fnFile.ExisteDirectorio(GlobalVar.DirRegSunat)) {
                        fnMensaje.MensajeInfo("No existe Directorio donde exportar");
                        CloseFormEspere();
                        return;
                    }

                    //Exportar Informacion
                    FnReportW.SetValue("TipoReporte", "2");
                    Int32 nReturn = fnExportar.CreateTXTFile(FnReportW.GetQueryProcPK(), sRut, false);
                    CloseFormEspere();
                    if (nReturn != 1) {
                        fnMensaje.MensajeInfo(fnExportar.MensajeError(nReturn));                    
                        return;
                    }
                    FnReportW.SetValue("TipoReporte", "1");
                    fnMensaje.MensajeInfo("Archivo de TXT se generó satisfactoriamente. " + sRut);
                }catch(Exception ex){
                    fnMensaje.MensajeInfo(ex.Message);
                }
            }
        }

        private void chkMayor02_CheckedChanged(object sender, EventArgs e)
        {
            cmbMayor02.ReadOnly = chkMayor02.Checked;
            cmbMayor03.ReadOnly = chkMayor02.Checked;
            cmbMayor04.ReadOnly = chkMayor02.Checked;
            cmbMayor05.ReadOnly = chkMayor02.Checked;
            cmbMayor02.EditValue = fnConst.TextRaya3;
        }

        private void cmbMayor02_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarMayor03();
        }

        private void cmbMayor03_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarMayor04();
        }

        private void cmbMayor04_EditValueChanged(object sender, EventArgs e)
        {
            fxCargarMayor05();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            cmbEstado.ReadOnly = chkEstado.Checked;
            cmbEstado.EditValue = fnConst.TextRaya3;
        }

        #endregion

    }
}
