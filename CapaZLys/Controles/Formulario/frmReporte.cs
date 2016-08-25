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
            if (uf_validarBuscar()){
                try{
                    SplashScreenManager.ShowForm(this, typeof(FiltroLys.ZLys.Inicio.frmEspere), true, true, false);
                    ue_Buscar();
                }finally{
                    SplashScreenManager.CloseForm(false);
                }
            }
        }

        private void ppbiExpExcelDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void dvReport_DocumentChanged(object sender, EventArgs e)
        {
            ue_DocumentChanged();
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
            DataSet oDs = negBaseDatos.ListaDatosOfStoreProc(FnReportW.GetQueryProcPK());
            if (oDs.Tables.Count > 0) {
                DataTable oDt = oDs.Tables[0];
                SaveFileDialog sDialog = new SaveFileDialog();
                sDialog.Filter = "Excel Files (*.xls)|*.xls";
                sDialog.FilterIndex = 0;
                sDialog.RestoreDirectory = true;
                sDialog.Title = "Exportar Data en ruta..";
                if (sDialog.ShowDialog() == DialogResult.OK) {
                    CreateCSVFile(oDt, sDialog.FileName);
                    fnMensaje.MensajeInfo("Se ha exportado la información correctamente");
                }
            }
        }
        public virtual void ue_DocumentChanged() {
            ppbiExpExcelDat.Enabled = true;
        }

        #endregion

        #region "==FuncionesForm=="

        public void CreateCSVFile(DataTable dt, String strFilePath)
        {
            StreamWriter sWFile = new StreamWriter(strFilePath,false,Encoding.Unicode);
            Int32 nCols = dt.Columns.Count;

            for(int i = 0; i < nCols; i++){
                sWFile.Write(dt.Columns[i]);
                if (i < nCols - 1){sWFile.Write("\t");}
            }

            sWFile.Write(sWFile.NewLine);
            
            foreach (DataRow dr in dt.Rows){
                for (int i = 0; i < nCols; i++){
                    if (!Convert.IsDBNull(dr[i])){
                        sWFile.Write(dr[i].ToString());
                    }
                    if (i < nCols - 1){sWFile.Write("\t");}
                }
                sWFile.Write(sWFile.NewLine);
            }
            sWFile.Close();
        }

        #endregion
        
    }
}
