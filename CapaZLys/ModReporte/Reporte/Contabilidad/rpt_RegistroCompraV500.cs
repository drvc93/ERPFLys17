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
    public partial class rpt_RegistroCompraV500 : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_RegistroCompraV500()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
            String sPeriodo = EReportW.GetObject("PerIni").Valor.ToString();

            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmPerIni.Value = EReportW.GetObject("PerIni").Valor;
            prmPerFin.Value = EReportW.GetObject("PerFin").Valor;
            prmRegOB.Value = EReportW.GetObject("RegOB").Valor;
            prmRegCH.Value = EReportW.GetObject("RegCH").Valor;
            prmRegRG.Value = EReportW.GetObject("RegRG").Valor;
            prmFlagProv.Value = EReportW.GetObject("FlagProv").Valor;
            prmProveedor.Value = EReportW.GetObject("Proveedor").Valor;
            prmFlagDProv.Value = EReportW.GetObject("FlagDatProv").Valor;
            prmDatoProv.Value = EReportW.GetObject("DatProv").Valor;
            prmTipoReporte.Value = EReportW.GetObject("TipoReporte").Valor;
            oPrm = null;

            xrFechaFinMes.Text = fnGeneral.FechaFinDeMesText(sPeriodo);
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            String sFlgRet = "N";
            xrFlgRet.Checked = false;

            if (GetCurrentColumnValue("c_flagretencion") != null){
                sFlgRet = GetCurrentColumnValue("c_flagretencion").ToString();
                if (sFlgRet.Equals("S")) { xrFlgRet.Checked = true; }           
            }    
        }
    }
}
