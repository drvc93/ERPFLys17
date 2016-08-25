using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using FiltroLys.Domain.Sistema;
using System.Data;
using FiltroLys.ZLys.Funciones;

namespace FiltroLys.ZLys.ModReporte.Reporte
{
    public partial class rptPrueba : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPrueba(){
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW) {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
            for (int nI = 0; nI < oPrm.Count; nI++){
                sqlConnRPT.Queries[0].Parameters[nI].Value = oPrm[nI].Valor;                
            }
            oPrm = null;
            xrPeriodo.Text = EReportW.GetObject("Periodo").Valor.ToString();
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

    }
}
