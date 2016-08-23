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
        public rptPrueba()
        {
            InitializeComponent();
        }

        public void GenerarReport(fnReport xParametro) {
            sqlConnRPT.Connection.ConnectionString = xParametro.ConnString;
            for (int nI = 0; nI < xParametro.Parametros.Count; nI++){
                sqlConnRPT.Queries[0].Parameters[nI].Value = xParametro.Parametros[nI].Valor;                
            }
            //xrPeriodo.Text = xParametro.Parametros[4].Valor.ToString();
            CreateDocument();
        }

    }
}
