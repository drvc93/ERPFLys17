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
    public partial class rpt_LibroMayor : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_LibroMayor()
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
            prmCuentaIni.Value = EReportW.GetObject("CuentaIni").Valor;
            prmCuentaFin.Value = EReportW.GetObject("CuentaFin").Valor;
            prmMoneda.Value = EReportW.GetObject("Moneda").Valor;
            prmTipoCuenta.Value = EReportW.GetObject("TipoCuenta").Valor;
            prmIncPerRel.Value = EReportW.GetObject("IncPeriodo").Valor;
            prmTipoRep.Value = EReportW.GetObject("TipoReporte").Valor;
            prmTCCosto.Value = EReportW.GetObject("TCCosto").Valor;
            oPrm = null;

            xrFechaFinMes.Text = fnGeneral.FechaFinDeMesText(sPeriodo);
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

        private void xrDebe_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Decimal nDebe = 0;
            Decimal.TryParse(GetCurrentColumnValue("debe").ToString(), out nDebe);
            xrDebe.ForeColor = Color.Black;
            if (nDebe == 0) { xrDebe.ForeColor = Color.Transparent; }
        }

        private void xrHaber_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Decimal nHaber = 0;
            Decimal.TryParse(GetCurrentColumnValue("haber").ToString(), out nHaber);
            xrHaber.ForeColor = Color.Black;
            if (nHaber == 0) { xrHaber.ForeColor = Color.Transparent; }
        }

    }
}
