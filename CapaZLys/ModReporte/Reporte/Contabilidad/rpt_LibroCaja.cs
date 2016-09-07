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
    public partial class rpt_LibroCaja : DevExpress.XtraReports.UI.XtraReport
    {
        private Decimal nValor = 0, nDebeGR = 0, nHaberGR = 0;

        public rpt_LibroCaja()
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
            prmMoneda.Value = EReportW.GetObject("Moneda").Valor;
            prmCuentaIni.Value = EReportW.GetObject("CuentaIni").Valor;
            prmCuentaFin.Value = EReportW.GetObject("CuentaFin").Valor;
            prmTipoCuenta.Value = EReportW.GetObject("TipoCuenta").Valor;            
            oPrm = null;

            xrFechaFinMes.Text = fnGeneral.FechaFinDeMesText(sPeriodo);
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Decimal nValor = 0;
            xrDebe.ForeColor = Color.Black;
            xrHaber.ForeColor = Color.Black;

            if (GetCurrentColumnValue("n_importe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_importe").ToString(), out nValor);
                if (nValor == 0) { xrDebe.ForeColor = Color.Transparent; }
                if (nValor == 0) { xrHaber.ForeColor = Color.Transparent; }
            }
        }

        private void xrDebeGR_SummaryReset(object sender, EventArgs e)
        {
            nDebeGR = 0;
        }

        private void xrDebeGR_SummaryRowChanged(object sender, EventArgs e)
        {
            Int32 nLinea = 0;
            nLinea = Convert.ToInt32(GetCurrentColumnValue("linea"));
            nValor = Convert.ToDecimal(GetCurrentColumnValue("n_importe"));
            if (nLinea != 0 && nValor > 0){
                nDebeGR += nValor;
            }
        }

        private void xrDebeGR_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = nDebeGR;
            e.Handled = true;
        }

        private void xrHaberGR_SummaryReset(object sender, EventArgs e)
        {
            nHaberGR = 0;
        }

        private void xrHaberGR_SummaryRowChanged(object sender, EventArgs e)
        {
            Int32 nLinea = 0;
            nLinea = Convert.ToInt32(GetCurrentColumnValue("linea"));
            nValor = Convert.ToDecimal(GetCurrentColumnValue("n_importe"));
            if (nLinea != 0 && nValor < 0){
                nHaberGR += nValor;
            }
        }

        private void xrHaberGR_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = nHaberGR;
            e.Handled = true;
        }

    }
}
