using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Domain.Sistema;


namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    public partial class rpt_RegistroVentaV409 : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_RegistroVentaV409()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
            String sPeriodo = EReportW.GetObject("Periodo").Valor.ToString();

            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmPeriodo.Value = EReportW.GetObject("Periodo").Valor;            
            oPrm = null;

            xrFechaFinMes.Text = fnGeneral.FechaFinDeMesText(sPeriodo.Substring(0,6));
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }
    }
}
