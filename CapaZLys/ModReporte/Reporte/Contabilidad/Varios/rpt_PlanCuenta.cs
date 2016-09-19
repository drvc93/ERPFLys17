using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Varios
{
    public partial class rpt_PlanCuenta : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_PlanCuenta()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
            String sCiaN = EReportW.GetObject("CompaniaNombre").Valor.ToString();

            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmPeriodo.Value = EReportW.GetObject("Periodo").Valor;
            prmTipoPlan.Value = EReportW.GetObject("TipoCuenta").Valor;
            prmFlagCuenta.Value = EReportW.GetObject("FlagMayor").Valor;
            prmMayor02.Value = EReportW.GetObject("Mayor02").Valor;
            prmMayor03.Value = EReportW.GetObject("Mayor03").Valor;
            prmMayor04.Value = EReportW.GetObject("Mayor04").Valor;
            prmMayor05.Value = EReportW.GetObject("Mayor05").Valor;
            prmFlagEstado.Value = EReportW.GetObject("FlagEstado").Valor;
            prmEstado.Value = EReportW.GetObject("Estado").Valor;
            prmTipoReporte.Value = EReportW.GetObject("TipoReporte").Valor;
            xrTitCompania.Text = sCiaN;
            oPrm = null;

            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

    }
}
