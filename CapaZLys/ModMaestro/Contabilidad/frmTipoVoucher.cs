﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Maestro.Contabilidad;
using FiltroLys.Domain.Maestro.Contabilidad;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.ModMaestro.Contabilidad
{
    public partial class frmTipoVoucher : FiltroLys.ZLys.Controles.Formulario.frmMaestro
    {
        #region "==Propiedades=="
        
        private entTipoVoucher entMain = new entTipoVoucher();
        private String xOperacion = "";
        private String xTipoVoucher = "";
        private entEstructForm xestruct = new entEstructForm();

        public entEstructForm EstructuraForm
        {
            get { return xestruct; }
            set { xestruct = value; }
        }

        #endregion

        #region "==EventForm=="

        public frmTipoVoucher()
        {
            InitializeComponent();
        }

        private void frmTipoVoucher_Load(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelList){
                fxCargarComboListaDet();
                fxCargarLista();
            }

            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxSetearIni();
                fxQuitEvent();
                fxCargarCombos();
                fxCargarCombosDetalle();
                fxCargarCombosXCia();
                fxPreOpen();
                fxPostOpen();
                fxAddEvent();
            }
        }

        private void frmTipoVoucher_Shown(object sender, EventArgs e)
        {
            if (this.PanelForm == fnEnum.PanelFormMaestros.PanelMant){
                fxFocusInicial();
            }
        }

        #endregion

        #region "==FuncionesList=="

        private void fxCargarLista()
        {
            if (!fnAcceso.ExisteAcceso(GlobalVar.UsuarioLogeo, Modulo, Niveles, fnEnum.AccesoOpcion.Acceso)) { return; }
            List<entTipoVoucher> Lst = negTipoVoucher.ListaFormID();
            grControl.DataSource = Lst;
        }

        private void fxCargarComboListaDet()
        {
            //Estado
            rilueEstado.DataSource = fnListasDat.ListEstadoF1();
            rilueEstado.DisplayMember = "Nombre";
            rilueEstado.ValueMember = "Codigo";

            //SINO
            rilueSiNo.DataSource = fnListasDat.ListEstadoSiNoRaya();
            rilueSiNo.DisplayMember = "Nombre";
            rilueSiNo.ValueMember = "Codigo";
        }

        #endregion

        #region "==FuncionesMant=="

        private void fxQuitEvent() {
            
        }

        private void fxAddEvent() {
            
        }

        private void fxCargarCombos()
        {
            //Flag Correlativo
            cmbFlagCorrelativo.Properties.DataSource = fnListasDat.ListEstadoSiNoRaya();
            cmbFlagCorrelativo.Properties.DisplayMember = "Nombre";
            cmbFlagCorrelativo.Properties.ValueMember = "Codigo";

            //Flag Sistema
            cmbFlagSistema.Properties.DataSource = fnListasDat.ListEstadoSiNoRaya();
            cmbFlagSistema.Properties.DisplayMember = "Nombre";
            cmbFlagSistema.Properties.ValueMember = "Codigo";

            //Estado
            cmbEstado.Properties.DataSource = fnListasDat.ListEstadoF1();
            cmbEstado.Properties.DisplayMember = "Nombre";
            cmbEstado.Properties.ValueMember = "Codigo";
        }

        private void fxCargarCombosXCia() {             

        }

        private void fxCargarCombosDetalle() { }

        private void fxSetearIni()
        {
            xOperacion = this.EstructuraForm.OperacionX;
            if (!(xOperacion.Equals("A"))){
                xTipoVoucher = this.EstructuraForm.StrX[0];
            }
        }

        private void fxPreOpen()
        {
            String sTitle = "Actualizar";
            switch (xOperacion){
                case "A":
                    sTitle = " - Nuevo";
                    fxNuevoReg();
                    fxHabilitarOCX();
                    break;
                case "M":
                    sTitle = " - Modificar";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
                case "V":
                    sTitle = " - Ver";
                    fxCargarReg();
                    fxHabilitarOCX();
                    break;
            }
            this.Text = this.Text + sTitle;
            this.lblTitulo.Text = "TIPO VOUCHER";
        }

        private void fxPostOpen() { }

        private void fxNuevoReg()
        {
            entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
            cmbFlagCorrelativo.EditValue = fnConst.TextNingunoCod;
            cmbFlagSistema.EditValue = fnConst.TextNingunoCod;            
            cmbEstado.EditValue = fnConst.EstadoActivoCod;
            txtUltimoUsuario.Text = GlobalVar.UsuarioLogeo;
            txtUltimaFecha.Text = fnGeneral.FormatoDateTime(DateTime.Now);
            txtCodigo.Focus();
        }

        private void fxCargarReg()
        {
            entMain = negTipoVoucher.GetFormID(xTipoVoucher);
            entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
            if (entMain.ResultadoBusqueda){
                txtCodigo.Text = entMain.TipoVoucher.Trim();
                txtDescripcion.Text = entMain.Descripcion.Trim();
                cmbFlagCorrelativo.EditValue = entMain.CorrelativoManual.Trim();
                cmbFlagSistema.EditValue = entMain.FlagSistema.Trim();
                cmbEstado.EditValue = entMain.Estado.Trim();
                txtUltimoUsuario.Text = entMain.UltimoUsuarioMod;
                txtUltimoUsuarioNombre.Text = entMain.UserNombreForm;
                txtUltimaFecha.Text = fnGeneral.FormatoDateTime(entMain.UltimaFechaMod);
                txtDescripcion.Focus();
            }
        }

        private void fxHabilitarOCX()
        {
            Boolean sHabilitado = false;
            if (xOperacion.Equals("A") || xOperacion.Equals("M")){
                sHabilitado = true;
            }

            txtCodigo.ReadOnly = !sHabilitado;
            txtDescripcion.ReadOnly = !sHabilitado;
            cmbFlagCorrelativo.ReadOnly = !sHabilitado;
            cmbFlagSistema.ReadOnly = !sHabilitado;            
            cmbEstado.ReadOnly = !sHabilitado;
            btnGuardar.Enabled = true;
            txtUltimoUsuario.ReadOnly = true;
            txtUltimoUsuarioNombre.ReadOnly = true;
            txtUltimaFecha.ReadOnly = true;

            if (xOperacion.Equals("M")){
                txtCodigo.ReadOnly = true;
            }

            if (xOperacion.Equals("V")) { btnGuardar.Enabled = false; }
        }

        private void fxFocusInicial()
        {
            if (xOperacion.Equals("A")) { txtCodigo.Focus(); }
            if (xOperacion.Equals("M")) { txtDescripcion.Focus(); }
        }

        private Boolean fxValidar()
        {
            Boolean bOk = false;
            String sTVouc = txtCodigo.Text.Trim();
            String sDescripcion = txtDescripcion.Text.Trim();
            String sFlagCorr = cmbFlagCorrelativo.EditValue.ToString();
            String sFlagSist = cmbFlagSistema.EditValue.ToString();
            String sEst = cmbEstado.EditValue.ToString();

            if (String.IsNullOrEmpty(sTVouc)){
                fnMensaje.MensajeInfo("Debe ingresar Código por favor.");
                txtCodigo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sDescripcion)){
                fnMensaje.MensajeInfo("Debe ingresar Descripción por favor.");
                txtDescripcion.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sFlagCorr) || sFlagCorr.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Seleccionar Flag Correlativo Manual(Si/No) por favor.");
                cmbFlagCorrelativo.Focus();
                return bOk;
            }

            if (String.IsNullOrEmpty(sFlagSist) || sFlagSist.Equals(fnConst.TextRaya3)){
                fnMensaje.MensajeInfo("Seleccionar Flag Sistema(Si/No) por favor.");
                cmbFlagSistema.Focus();
                return bOk;
            }

            //Actualizando Datos Entidad
            entMain.TipoVoucher = sTVouc;
            entMain.Descripcion = sDescripcion;
            entMain.CorrelativoManual = sFlagCorr;
            entMain.FlagSistema = sFlagSist;
            entMain.Estado = sEst;
            entMain.UsuarioSys = GlobalVar.UsuarioLogeo;
            entMain.EstacionSys = GlobalVar.EstacionLogeo;
            entMain.FechaSys = DateTime.Now;

            xTipoVoucher = sTVouc;
            
            bOk = true;
            return bOk;
        }

        private Boolean fxPreUpdate()
        {
            entErrores oErr = new entErrores();
            Boolean bOK = true;

            switch (xOperacion){
                case "A":
                    entMain.OperMantenimiento = fnEnum.OperacionMant.Insertar;
                    break;
                case "M":
                    entMain.OperMantenimiento = fnEnum.OperacionMant.Modificar;
                    break;
            }

            oErr = negTipoVoucher.MantFormID(entMain);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
                bOK = false;
            }
            oErr = null;
            return bOK;
        }

        private void fxPostUpdate()
        {
            fxCargarLista();
        }

        #endregion

        #region "==EventInherit=="

        public override void ue_nuevo()
        {
            Contabilidad.frmTipoVoucher frm = new Contabilidad.frmTipoVoucher();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "A";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            frm = null;
        }

        public override void ue_modificar()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entTipoVoucher oEnt = (entTipoVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            
            Contabilidad.frmTipoVoucher frm = new Contabilidad.frmTipoVoucher();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "M";
            frm.EstructuraForm.StrX.Insert(0, oEnt.TipoVoucher);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                fxCargarLista();
            }
            oEnt = null;
            frm = null;
        }

        public override void ue_eliminar()
        {
            if (MessageBox.Show(fnConst.MensajeDeleteMaestro, fnConst.MessageTitleAviso, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entTipoVoucher oEnt = (entTipoVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);
            oEnt.UsuarioSys = GlobalVar.UsuarioLogeo;
            oEnt.EstacionSys = GlobalVar.EstacionLogeo;
            oEnt.FechaSys = DateTime.Now;

            oEnt.OperMantenimiento = fnEnum.OperacionMant.Eliminar;
            entErrores oErr = new entErrores();
            oErr = negTipoVoucher.MantFormID(oEnt);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);
            }
            else { fxCargarLista(); }
            oErr = null;
            oEnt = null;
        }

        public override void ue_ver()
        {
            if (gvDatos.DataRowCount == 0) { return; }
            if (gvDatos.SelectedRowsCount == 0) { return; }
            entTipoVoucher oEnt = (entTipoVoucher)gvDatos.GetRow(gvDatos.FocusedRowHandle);

            Contabilidad.frmTipoVoucher frm = new Contabilidad.frmTipoVoucher();
            frm.PanelForm = fnEnum.PanelFormMaestros.PanelMant;
            frm.EstructuraForm.OperacionX = "V";
            frm.EstructuraForm.StrX.Insert(0, oEnt.TipoVoucher);
            frm.ShowDialog();
            oEnt = null;
            frm = null;
        }

        public override void ue_guardar()
        {
            if (!fxValidar()) { return; };
            if (!fxPreUpdate()) { return; };
            fxPostUpdate();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public override void ue_cancelar()
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        #endregion

    }
}
