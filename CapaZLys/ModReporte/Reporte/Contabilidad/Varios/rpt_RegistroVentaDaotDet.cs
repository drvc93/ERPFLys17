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
    public partial class rpt_RegistroVentaDaotDet : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_RegistroVentaDaotDet()
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
            prmFlagSupera.Value = EReportW.GetObject("FlagSupera").Valor;
            prmTipoConsulta.Value = EReportW.GetObject("TipoReporte").Valor;
            oPrm = null;

            xrTitCompania.Text = sCiaNombre;
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

        private void GrupoGeneral_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            String sFlgPaso = "N";
            xrFlagPaso.Checked = false;

            if (GetCurrentColumnValue("c_flagpaso") != null){
                sFlgPaso = GetCurrentColumnValue("c_flagpaso").ToString();
                if (sFlgPaso.Equals("S")) { xrFlagPaso.Checked = true; }
            }
        }

    }
}
