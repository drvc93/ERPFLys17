using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;
using FiltroLys.ZLys.Funciones;
using System.Linq;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmSelPeriodoTrabajo : FiltroLys.ZLys.Controles.Formulario.frmResponse
    {

        #region "==EventForm=="

        public frmSelPeriodoTrabajo()
        {
            InitializeComponent();
        }

        private void frmSelPeriodoTrabajo_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
        }

        private void frmSelPeriodoTrabajo_Shown(object sender, EventArgs e)
        {
            fxSetearDatos();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListaXUsuario(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringN, new String[] { fnConst.StringN, fnConst.TextNingunoNom });
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;
        }

        private void fxSetearDatos()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : "";
            txtPeriodo.Text = negPeriodoCia.GetPeriodoTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
            txtPeriodo.Focus();
        } 

        #endregion

        #region "==EventObject=="

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String sCia = cmbCompania.EditValue.ToString();
            String sPer = txtPeriodo.Text.Replace("-", "");
            Int32 nResult = 0;

            //Validación Basica
            if (String.IsNullOrEmpty(sCia)){
                fnMensaje.MensajeInfo("Debe seleccionar una compañía.");
                return;
            }

            if (String.IsNullOrWhiteSpace(sPer)){
                fnMensaje.MensajeInfo("Debe ingresar un periodo válido.");
                return;
            }

            nResult = negPeriodoCia.GetValidaPeriodoCia(sCia, sPer, fnConst.ModContabilidadCod);
            if (nResult <= 0){
                fnMensaje.MensajeInfo("Periodo no existe o se encuentra cerrado. No se puede asignar periodo de trabajo.");
                return;
            }

            //Estableciendo Flag Trabajo
            entErrores oErr = new entErrores();
            entPeriodoCia oData = new entPeriodoCia();
            oData.Compania = sCia;
            oData.Periodo = sPer;
            oData.Sistema = fnConst.ModContabilidadCod;
            oData.UltimoUsuario = GlobalVar.UsuarioLogeo;
            oData.UsuarioSys = GlobalVar.UsuarioLogeo;
            oData.EstacionSys = GlobalVar.EstacionLogeo;
            oData.FechaSys = DateTime.Now;

            oErr = negPeriodoCia.SetPeriodoTrabajo(oData);
            if (oErr.Errores.Count > 0){
                fnMensaje.MensajeInfo(oErr.Errores[0].Descripcion);                
                oData = null;
                oErr = null;
                return;
            }
            oData = null;
            oErr = null;

            fnMensaje.MensajeInfo("Se ha asignado periodo de trabajo correctamente.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
