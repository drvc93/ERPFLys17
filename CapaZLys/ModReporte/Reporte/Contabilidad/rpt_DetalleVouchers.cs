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
    public partial class rpt_DetalleVouchers : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_DetalleVouchers()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();
            
            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmProveedor.Value = EReportW.GetObject("Proveedor").Valor;
            prmCtaIni.Value = EReportW.GetObject("CuentaIni").Valor;
            prmCtaFin.Value = EReportW.GetObject("CuentaFin").Valor;
            prmPerIni.Value = EReportW.GetObject("PerIni").Valor;
            prmPerFin.Value = EReportW.GetObject("PerFin").Valor;
            prmOrdenar.Value = EReportW.GetObject("Ordenar").Valor;
            prmDocPend.Value = EReportW.GetObject("Pendiente").Valor;
            prmMoneda.Value = EReportW.GetObject("Moneda").Valor;
            prmCCosto.Value = EReportW.GetObject("CCosto").Valor;
            prmCtaDestino.Value = EReportW.GetObject("CuentaDestino").Valor;            
            oPrm = null;
            
            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

    }
}
