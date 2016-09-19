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
    public partial class rpt_LibroBanco : DevExpress.XtraReports.UI.XtraReport
    {
        Decimal nDebeGR = 0, nHaberGR = 0;

        public rpt_LibroBanco()
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

        private void xrDebeGR_SummaryReset(object sender, EventArgs e)
        {
            nDebeGR = 0;
        }

        private void xrDebeGR_SummaryRowChanged(object sender, EventArgs e)
        {
            String sVouch = "";
            sVouch = GetCurrentColumnValue("voucher").ToString();
            if (sVouch.Length > 0){
                nDebeGR += Convert.ToDecimal(GetCurrentColumnValue("debe"));
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
            String sVouch = "";
            sVouch = GetCurrentColumnValue("voucher").ToString();
            if (sVouch.Length > 0){
                nHaberGR += Convert.ToDecimal(GetCurrentColumnValue("haber"));
            }
        }

        private void xrHaberGR_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            nHaberGR = nHaberGR * -1;
            e.Result = nHaberGR;
            e.Handled = true;
        }

    }
}
