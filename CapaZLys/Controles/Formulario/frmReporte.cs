using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Domain.Sistema;
using System.IO;

namespace FiltroLys.ZLys.Controles.Formulario
{
    public partial class frmReporte : FiltroLys.ZLys.Controles.Formulario.frmMain
    {
        #region "==Propiedades=="

        protected Boolean bValidoExportar = true;
        protected fnReport fnReportW = new fnReport();

        public fnReport FnReportW{
            get { return fnReportW; }
            set { fnReportW = value; }
        } 

        #endregion

        #region "==EventForm=="

        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e) { }

        #endregion
        
        #region "==EventObject=="

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GenerarBuscar();
        }

        private void ppbiExpExcelDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GenerarExport();
        }

        private void dvReport_DocumentChanged(object sender, EventArgs e)
        {
            ue_DocumentChanged();
        }

        #endregion

        #region "FuncionesForm"

        public static void OpenFormEspere(Form oFrm)
        {
            SplashScreenManager.ShowForm(oFrm, typeof(FiltroLys.ZLys.Inicio.frmEspere), true, true, false);
        }

        public static void CloseFormEspere()
        {
            SplashScreenManager.CloseForm(false);
        }

        public void GenerarBuscar()
        {
            if (uf_validarBuscar()){
                try{
                    SplashScreenManager.ShowForm(this, typeof(FiltroLys.ZLys.Inicio.frmEspere), true, true, false);
                    ue_Buscar();
                }finally{
                    SplashScreenManager.CloseForm(false);
                }
            }
        }

        public void GenerarExport()
        {
            if (uf_validarExpExcel()){
                try{
                    SplashScreenManager.ShowForm(this, typeof(FiltroLys.ZLys.Inicio.frmEspere), true, true, false);
                    ue_ExportarDat();
                }finally{
                    SplashScreenManager.CloseForm(false);
                }
            }
        }

        #endregion

        #region "==EventInherit=="

        public virtual Boolean uf_validarBuscar() {
            return false;
        }
        public virtual Boolean uf_validarExpExcel(){
            if (!fnReportW.TieneParametros) { return false; }
            if (fnReportW.ContReg == 0) { return false; }
            return true;
        }
        public virtual void ue_Buscar() {
            
        }
        public virtual void ue_ExportarDat() {
            DataTable oDt = negBaseDatos.ListaDatosOfStoreProc(FnReportW.GetQueryProcPK());
            if (oDt == null) { fnMensaje.MensajeInfo("No Existe Información(DT)"); return; }

            SaveFileDialog sDialog = new SaveFileDialog();
            sDialog.Filter = "Excel Files (*.xls)|*.xls";
            sDialog.FilterIndex = 0;
            sDialog.RestoreDirectory = true;
            sDialog.Title = "Exportar Data en ruta..";
            if (sDialog.ShowDialog() == DialogResult.OK) {
                Int32 nReturn = fnExportar.CreateXLSFile(oDt, sDialog.FileName);
                fnMensaje.MensajeInfo("Se ha exportado la información correctamente");
            }
            
        }
        public virtual void ue_DocumentChanged() {
            ppbiExpExcelDat.Enabled = true;
        }
        
        #endregion

    }
}
