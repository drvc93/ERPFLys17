﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Maestro.General;
using FiltroLys.Domain.Maestro.General;
using FiltroLys.Model.Contabilidad;
using FiltroLys.Domain.Contabilidad;
using FiltroLys.Type;
using FiltroLys.ZLys.ModContabilidad;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Model.Sistema;
using FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables;
using System.Linq;

namespace FiltroLys.ZLys.ModContabilidad
{
    public partial class frmSaldoxCuenta : FiltroLys.ZLys.Controles.Formulario.frmMain
    {

        #region "==Propiedades=="

        private Boolean bIniciado = false;

        #endregion

        #region "==EventForm=="

        public frmSaldoxCuenta()
        {
            InitializeComponent();
        }

        private void frmSaldoxCuenta_Load(object sender, EventArgs e)
        {
            fxCargarCombos();
            fxSetearDatos();
            fxCargarLista();
        }

        private void frmSaldoxCuenta_Shown(object sender, EventArgs e)
        {
            cmbCompania.Focus();
        }

        #endregion

        #region "==FuncionesForm=="

        private void fxCargarCombos()
        {
            //Compania
            List<entCompania> Lst = negCompania.ListaXUsuario(fnConst.ModContabilidadCod, GlobalVar.UsuarioLogeo, fnConst.StringT, new String[] { fnConst.TextNingunoCod, fnConst.TextSeleccioneNom });
            cmbCompania.Properties.DataSource = Lst;
            cmbCompania.Properties.DisplayMember = "Nombres";
            cmbCompania.Properties.ValueMember = "Compania";
            Lst = null;
        }

        private void fxCargarLista()
        {
            if (fxValidarDatos()){
                String scia = cmbCompania.EditValue.ToString();
                String sper = txtPeriodo.Text.Replace("-", "");

                List<entCierreMesCuenta> Lst = negCierreMesCuenta.ListSaldoToMayor(scia, sper);
                grControlMayor.DataSource = Lst;
                Lst = null;                
                grControlCuenta.DataSource = null;
                grControlCuenta.Refresh();
            }
        }

        private void fxCargarListaDet()
        {
            int[] regs = gvDatosMayor.GetSelectedRows();
            if (regs.Length == 0) { return; }

            entCierreMesCuenta objE = (entCierreMesCuenta)gvDatosMayor.GetRow(regs[0]);
            List<entCierreMesCuenta> Lst = negCierreMesCuenta.ListSaldoToCuenta(objE.Compania, objE.Periodo, objE.Cuenta);

            grControlCuenta.DataSource = Lst;
            Lst = null;
            objE = null;
        }

        private void fxSetearDatos()
        {
            int nCont = ((List<entCompania>)cmbCompania.Properties.DataSource).Count(x => x.Compania == GlobalVar.Compania);
            cmbCompania.EditValue = (nCont > 0) ? GlobalVar.Compania : "";
            txtPeriodo.Text = negPeriodoCia.GetPeriodoTrabajo(GlobalVar.Compania, fnConst.ModContabilidadCod);
        }

        private Boolean fxValidarDatos()
        {
            Boolean bval;
            String scia = cmbCompania.EditValue.ToString();
            String sper = txtPeriodo.Text.Replace("-", "");

            if (!bIniciado){
                bIniciado = true;
                if (!(String.IsNullOrEmpty(scia) || String.IsNullOrEmpty(sper))) return true;
                return false;
            }

            if (String.IsNullOrEmpty(scia)){
                fnMensaje.MensajeInfo("Seleccionar Compañía por favor.");
                cmbCompania.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(sper)){
                fnMensaje.MensajeInfo("Ingresar Periodo por favor.");
                cmbCompania.Focus();
                return false;
            }

            bval = true;
            return bval;
        }

        #endregion

        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fxCargarLista();
        }

        private void btnVoucherCta_Click(object sender, EventArgs e)
        {
            int cont = 0, row = 0; String tagFrm = "";
            cont = gvDatosCuenta.DataRowCount;
            if (cont == 0) { return; }
            row = gvDatosCuenta.FocusedRowHandle;
            if (row < 0) { return; }
            entCierreMesCuenta objE = (entCierreMesCuenta)gvDatosCuenta.GetRow(row);

            frmSaldoxCuentaDet frm = new frmSaldoxCuentaDet();
            frm.EstructuraForm.StrX.Insert(0, objE.Compania);
            frm.EstructuraForm.StrX.Insert(1, objE.Periodo);
            frm.EstructuraForm.StrX.Insert(2, objE.Cuenta);
            frm.EstructuraForm.StrX.Insert(3, objE.Descripcion);
            tagFrm = "VerDetalle";
            Funciones.fnAddTab.FormOpen(frm, tagFrm);

            objE = null;
        }

        private void btnDetalleCta_Click(object sender, EventArgs e)
        {
            String sCia, sPer, sCta;
            Int32 nCont = 0, nRow = 0;
          
            nCont = gvDatosCuenta.DataRowCount;
            if (nCont == 0) { return; }
            nRow = gvDatosCuenta.FocusedRowHandle;
            if (nRow < 0) { return; }

            entCierreMesCuenta objE = (entCierreMesCuenta)gvDatosCuenta.GetRow(nRow);
            sCia = objE.Compania;
            sPer = objE.Periodo;
            sCta = objE.Cuenta;
            objE = null;

            //frmrpt
            frmRptSaldoContableDet frm = new frmRptSaldoContableDet();
            frm.EstructuraForm.StrX.Insert(0, sCia);
            frm.EstructuraForm.StrX.Insert(1, sPer);
            frm.EstructuraForm.StrX.Insert(2, sCta);
            frm.ShowDialog();
            frm = null;
        }

        private void gvDatosMayor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            fxCargarListaDet();
        }

        private void gvDatosMayor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.CellValue is Decimal && (Decimal)e.CellValue < 0)
                e.Appearance.ForeColor = Color.Red;
        }

        private void gvDatosCuenta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.CellValue is Decimal && (Decimal)e.CellValue < 0)
                e.Appearance.ForeColor = Color.Red;
        }

        #endregion
    }
}
