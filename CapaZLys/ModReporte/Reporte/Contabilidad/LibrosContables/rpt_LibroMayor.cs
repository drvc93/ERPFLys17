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
    public partial class rpt_LibroMayor : DevExpress.XtraReports.UI.XtraReport
    {
        Decimal nDebeGR = 0, nHaberGR = 0, nDebeSal = 0, nHaberSal = 0,nDebeMv = 0, nHaberMv = 0;
        Decimal nDebeGR2 = 0, nHaberGR2 = 0;

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
            if (GetCurrentColumnValue("debe") == null) { return; }
            Decimal.TryParse(GetCurrentColumnValue("debe").ToString(), out nDebe);
            xrDebe.ForeColor = Color.Black;
            if (nDebe == 0) { xrDebe.ForeColor = Color.Transparent; }
        }

        private void xrHaber_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Decimal nHaber = 0;
            if (GetCurrentColumnValue("haber") == null) { return; }
            Decimal.TryParse(GetCurrentColumnValue("haber").ToString(), out nHaber);
            xrHaber.ForeColor = Color.Black;
            if (nHaber == 0) { xrHaber.ForeColor = Color.Transparent; }
        }

        private void xrGRVoucherDebe_SummaryReset(object sender, EventArgs e)
        {
            nDebeGR = 0;
        }

        private void xrGRVoucherDebe_SummaryRowChanged(object sender, EventArgs e)
        {
            String sVouch = "";
            sVouch = GetCurrentColumnValue("voucher").ToString();
            if (sVouch.Length > 0){
                nDebeGR += Convert.ToDecimal(GetCurrentColumnValue("debe"));
            }
        }

        private void xrGRVoucherDebe_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = nDebeGR;
            e.Handled = true;
        }

        private void xrGRVoucherHaber_SummaryReset(object sender, EventArgs e)
        {
            nHaberGR = 0;
        }

        private void xrGRVoucherHaber_SummaryRowChanged(object sender, EventArgs e)
        {
            String sVouch = "";
            sVouch = GetCurrentColumnValue("voucher").ToString();
            if(sVouch.Length>0){
                nHaberGR += Convert.ToDecimal(GetCurrentColumnValue("haber"));
            }
        }

        private void xrGRVoucherHaber_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = -1 * nHaberGR;
            e.Handled = true;
        }

        private void xrGRSaldoActual_SummaryReset(object sender, EventArgs e)
        {
            nDebeSal = 0;
            nHaberSal = 0;
        }

        private void xrGRSaldoActual_SummaryRowChanged(object sender, EventArgs e)
        {
            nDebeSal += Convert.ToDecimal(GetCurrentColumnValue("debe"));
            nHaberSal += Convert.ToDecimal(GetCurrentColumnValue("haber"));
        }

        private void xrGRSaldoActual_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = nDebeSal - nHaberSal;
            e.Handled = true;
        }

        private void xrGRMovimientoMes_SummaryReset(object sender, EventArgs e)
        {
            nDebeMv = 0;
            nHaberMv = 0;
        }

        private void xrGRMovimientoMes_SummaryRowChanged(object sender, EventArgs e)
        {
            String sVouch = "";
            sVouch = GetCurrentColumnValue("voucher").ToString();
            if (sVouch.Length > 0){
                nDebeMv += Convert.ToDecimal(GetCurrentColumnValue("debe"));
                nHaberMv += Convert.ToDecimal(GetCurrentColumnValue("haber"));
            }
        }

        private void xrGRMovimientoMes_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = nDebeMv + nHaberMv;
            e.Handled = true;
        }

        private void xrGR2Saldo_SummaryReset(object sender, EventArgs e)
        {
            nDebeGR2 = 0;
            nHaberGR2 = 0;
        }

        private void xrGR2Saldo_SummaryRowChanged(object sender, EventArgs e)
        {
            nDebeGR2 += Convert.ToDecimal(GetCurrentColumnValue("debe"));
            nHaberGR2 += Convert.ToDecimal(GetCurrentColumnValue("haber"));
        }

        private void xrGR2Saldo_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            e.Result = nDebeGR2 - nHaberGR2;
            e.Handled = true;
        }
                
    }
}
