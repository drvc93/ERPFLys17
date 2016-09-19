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
    public partial class rpt_SaldoContableDet : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_SaldoContableDet()
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
            prmCuenta.Value = EReportW.GetObject("Cuenta").Valor;
            oPrm = null;

            xrTitCompania.Text = prmCompania.Value.ToString() + " - " + sCiaNombre;
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrMontoLocal.ForeColor = Color.Black;
            xrMontoDolar.ForeColor = Color.Black;
            xrSaldoLocal.ForeColor = Color.Black;
            xrSaldoDolar.ForeColor = Color.Black;
            Decimal nValor = 0;

            if (GetCurrentColumnValue("n_monLocal") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_monLocal").ToString(), out nValor);
                if (nValor < 0) { xrMontoLocal.ForeColor = Color.Red; }
            }

            if (GetCurrentColumnValue("n_monDolar") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_monDolar").ToString(), out nValor);
                if (nValor < 0) { xrMontoDolar.ForeColor = Color.Red; }
            }

            if (GetCurrentColumnValue("n_salLocal") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_salLocal").ToString(), out nValor);
                if (nValor < 0) { xrSaldoLocal.ForeColor = Color.Red; }
            }

            if (GetCurrentColumnValue("n_salDolar") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_salDolar").ToString(), out nValor);
                if (nValor < 0) { xrSaldoDolar.ForeColor = Color.Red; }
            }

        }

    }
}
