using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables
{
    public partial class rpt_CuentaCCosto : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_CuentaCCosto()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
            String sCiaNombre = EReportW.GetObject("CompaniaNombre").Valor.ToString();

            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmPeriodo.Value = EReportW.GetObject("Periodo").Valor;
            prmCuentaIni.Value = EReportW.GetObject("CuentaIni").Valor;
            prmCuentaFin.Value = EReportW.GetObject("CuentaFin").Valor;
            prmCCosto.Value = EReportW.GetObject("CentroCosto").Valor;
            oPrm = null;

            xrTitCompania.Text = "COMPAÑIA: " + sCiaNombre;
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

    }
}
