using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FiltroLys.ZLys.Funciones;
using System.Collections.Generic;

namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Estadistico
{
    public partial class rpt_BalMensual : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_BalMensual()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlDataSource1.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
           
           
            prmCompania.Value = EReportW.GetObject("prmCompania").Valor;
            prmMoneda.Value = EReportW.GetObject("prmMoneda").Valor;
            prmPeriodo.Value = EReportW.GetObject("prmPeriodo").Valor; 
          
        
            oPrm = null;

          
            EReportW.NombreStoreProc = sqlDataSource1.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

    }
}
