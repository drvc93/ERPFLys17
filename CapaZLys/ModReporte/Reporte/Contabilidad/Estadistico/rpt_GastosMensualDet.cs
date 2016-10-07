using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FiltroLys.ZLys.Funciones;
using System.Collections.Generic;

namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Estadistico
{
    public partial class rpt_GastosMensualDet : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_GastosMensualDet()
        {
            InitializeComponent();
        }


        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();


            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmPerInicial.Value = EReportW.GetObject("PerIni").Valor;
            prmPerFinal.Value = EReportW.GetObject("PerFin").Valor;
            prmCtaIni.Value = EReportW.GetObject("CuentaIni").Valor;
            prmCtaFin.Value = EReportW.GetObject("CuentaFin").Valor;
            prmFlagProv.Value = EReportW.GetObject("FlagProv").Valor;
            prmProveedor.Value = EReportW.GetObject("Proveedor").Valor;
            prmCCosto.Value = EReportW.GetObject("CCosto").Valor;
            prmMoneda.Value = EReportW.GetObject("Moneda").Valor;
            prmCtaDestino.Value = EReportW.GetObject("CtaDestino").Valor;
            prmDocPend.Value = EReportW.GetObject("Pendiente").Valor;
            prmOrdenar.Value = EReportW.GetObject("Ordenar").Valor;
            prmConsulta.Value = EReportW.GetObject("Consulta").Valor;




            oPrm = null;


            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }
    }
}
