﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FiltroLys.Model.Seguridad;
using FiltroLys.Domain.Seguridad;
using DevExpress.XtraTreeList.Nodes;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Type;

namespace FiltroLys.ZLys.ModReporte
{
    public partial class frmReportesMain : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==EventForm=="
        
        public frmReportesMain()
        {
            InitializeComponent();
        }
        
        private void frmReportesMain_Load(object sender, EventArgs e)
        {
            fxTreeViewMaestro();
        }
        
        #endregion
        
        #region "==FuncionesForm=="
        
        private void fxTreeViewMaestro()
        { 
            List<entAccesoReporte> oList = new List<entAccesoReporte>();
            oList = negAccesoReporte.ListaReportexModulo(GlobalVar.UsuarioLogeo);
            List<entAccesoReporte> LstDet = oList;
            
            tvReporte.BeginUnboundLoad();
            foreach (entAccesoReporte oEnt in LstDet){
                if (oEnt.Padre.Equals("")){
                    TreeListNode xNodePadre = null;
                    TreeListNode xNodeHijo = tvReporte.AppendNode(new object[] { oEnt.NombreReporte, oEnt.Descripcion }, xNodePadre);
                    xNodeHijo.Tag = oEnt;
                    xNodeHijo.ImageIndex = 0;
                    fxTreeViewMaestroChild(LstDet, xNodeHijo);
                }
            }
            tvReporte.EndUnboundLoad();
            tvReporte.ExpandAll();
        }
        
        private void fxTreeViewMaestroChild(List<entAccesoReporte> oList, TreeListNode xNode)
        {
            foreach (entAccesoReporte oEnt in oList){
                if (!oEnt.Padre.Equals("")){
                    entAccesoReporte oPadre = (entAccesoReporte)xNode.Tag;
                    if (oEnt.Padre.Equals(oPadre.CodReg)){
                        TreeListNode xNodeHijo = tvReporte.AppendNode(new object[] { oEnt.NombreReporte, oEnt.Descripcion }, xNode);
                        xNodeHijo.Tag = oEnt;
                        xNodeHijo.ImageIndex = 1;
                        xNodeHijo.SelectImageIndex = 1;
                        fxTreeViewMaestroChild(oList, xNodeHijo);
                    }
                }
            }
        }
        
        private void fxFiltrarLista()
        {
            String sFiltro = txtFiltrarPor.Text.Trim();
            if (sFiltro.Length == 0){ sFiltro = ""; }
            else{
                sFiltro = String.Format("Contains([NombreReporte],'" + sFiltro + "')");
            }
            tvReporte.ActiveFilterString = sFiltro;
        }
        
        private void fxCargarForm()
        {
            entAccesoReporte oEnt = (entAccesoReporte)tvReporte.FocusedNode.Tag;
            if (oEnt != null){
                if (!(String.IsNullOrEmpty(oEnt.FormNet))){
                    String sForm = "FiltroLys.ZLys.ModReporte.Formulario.";
                    switch (oEnt.Modulo)
                    {
                        case "CB":
                            sForm = sForm + "Contabilidad";
                            break;
                        case "LO":
                            sForm = sForm + "Logistica";
                            break;
                        case "CO":
                            sForm = sForm + "Comercial";
                            break;
                        case "RH":
                            sForm = sForm + "RRHH";
                            break;
                        case "TR":
                            sForm = sForm + "Tesoreria";
                            break;
                        case "MT":
                            sForm = sForm + "Mantenimiento";
                            break;
                        case "PT":
                            sForm = sForm + "Presupuesto";
                            break;
                        case "CA":
                            sForm = sForm + "Calidad";
                            break;
                        case "PC":
                            sForm = sForm + "Produccion";
                            break;
                    }

                    //Restricciones
                    if (oEnt.Modulo.Equals("CB") && oEnt.Menu == 1 && oEnt.Reporte == 10) {
                        ModContabilidad.frmSaldoxCuenta frmRestr = new ModContabilidad.frmSaldoxCuenta();
                        fnAddTab.FormOpen(frmRestr);
                        return;
                    }

                    //Fin Restricciones

                    sForm = sForm + "." + oEnt.FormNet;
                    Form frm = (Form)System.Activator.CreateInstance(System.Type.GetType(sForm));
                    Funciones.fnAddTab.FormOpen(frm, "Reporte", true);                    
                }
                else{
                    fnMensaje.MensajeInfo("No se ha definido Formulario, revisar por favor.");
                }
            }
        }
        
        #endregion
        
        #region "==EventObjects=="
        
        private void txtFiltrarPor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fxFiltrarLista();
            }
        }
        
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            fxCargarForm();
        }
        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            fxFiltrarLista();
        }
        
        private void tvReporte_DoubleClick(object sender, EventArgs e)
        {
            fxCargarForm();
        }
    
        #endregion
    }
}