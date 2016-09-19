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
    public partial class rpt_BalComprobCtaF2 : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_BalComprobCtaF2()
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
            prmTipoBC.Value = EReportW.GetObject("TipoBC").Valor;
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

            xrSalIniDebe.ForeColor = Color.Black;
            xrSalIniHaber.ForeColor = Color.Black;
            xrMovDebe.ForeColor = Color.Black;
            xrMovHaber.ForeColor = Color.Black;
            xrSalFinDebe.ForeColor = Color.Black;
            xrSalFinHaber.ForeColor = Color.Black;
            xrInvDebe.ForeColor = Color.Black;
            xrInvHaber.ForeColor = Color.Black;
            xrFunDebe.ForeColor = Color.Black;
            xrFunHaber.ForeColor = Color.Black;
            xrNatDebe.ForeColor = Color.Black;
            xrNatHaber.ForeColor = Color.Black;

            if (GetCurrentColumnValue("n_saldoini_debe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_saldoini_debe").ToString(), out nValor);
                if (nValor == 0) { xrSalIniDebe.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_saldoini_haber") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_saldoini_haber").ToString(), out nValor);
                if (nValor == 0) { xrSalIniHaber.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_movim_debe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_movim_debe").ToString(), out nValor);
                if (nValor == 0) { xrMovDebe.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_movim_haber") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_movim_haber").ToString(), out nValor);
                if (nValor == 0) { xrMovHaber.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_saldofin_debe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_saldofin_debe").ToString(), out nValor);
                if (nValor == 0) { xrSalFinDebe.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_saldofin_haber") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_saldofin_haber").ToString(), out nValor);
                if (nValor == 0) { xrSalFinHaber.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_inventario_debe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_inventario_debe").ToString(), out nValor);
                if (nValor == 0) { xrInvDebe.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_inventario_haber") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_inventario_haber").ToString(), out nValor);
                if (nValor == 0) { xrInvHaber.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_funcion_debe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_funcion_debe").ToString(), out nValor);
                if (nValor == 0) { xrFunDebe.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_funcion_haber") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_funcion_haber").ToString(), out nValor);
                if (nValor == 0) { xrFunHaber.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_natural_debe") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_natural_debe").ToString(), out nValor);
                if (nValor == 0) { xrNatDebe.ForeColor = Color.Transparent; }
            }

            if (GetCurrentColumnValue("n_natural_haber") != null){
                nValor = 0; Decimal.TryParse(GetCurrentColumnValue("n_natural_haber").ToString(), out nValor);
                if (nValor == 0) { xrNatHaber.ForeColor = Color.Transparent; }
            }
        }

    }
}
