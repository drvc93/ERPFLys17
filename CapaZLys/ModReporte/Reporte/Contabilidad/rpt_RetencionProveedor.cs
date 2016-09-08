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
    public partial class rpt_RetencionProveedor : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_RetencionProveedor()
        {
            InitializeComponent();
        }

        public void GenerarReport(ref fnReport EReportW)
        {
            sqlConnRPT.Connection.ConnectionString = EReportW.ConnString;
            List<entRepParam> oPrm = EReportW.GetParametrosPK();

            prmCompania.Value = EReportW.GetObject("Compania").Valor;
            prmFlagPeriodo.Value = EReportW.GetObject("FlagPeriodo").Valor;
            prmPeriodo.Value = EReportW.GetObject("Periodo").Valor;
            prmFlagProv.Value = EReportW.GetObject("FlagProveedor").Valor;
            prmProveedor.Value = EReportW.GetObject("Proveedor").Valor;
            prmFlagFecha.Value = EReportW.GetObject("FlagFecha").Valor;
            prmFecPagIni.Value = EReportW.GetObject("FechaPagoIni").Valor;
            prmFecPagFin.Value = EReportW.GetObject("FechaPagoFin").Valor;
            prmFecRet.Value = EReportW.GetObject("FechaRetencion").Valor;

            if (Convert.ToDateTime(EReportW.GetObject("FechaPagoIni").Valor) == DateTime.MinValue) {
                prmFecPagIni.Value = fnGeneral.FechaRepNULL();
            }

            if (Convert.ToDateTime(EReportW.GetObject("FechaPagoFin").Valor) == DateTime.MinValue){
                prmFecPagFin.Value = fnGeneral.FechaRepNULL();
            }

            if (Convert.ToDateTime(EReportW.GetObject("FechaRetencion").Valor) == DateTime.MinValue){
                prmFecRet.Value = fnGeneral.FechaRepNULL();
            }
            
            prmFlagTipo.Value = EReportW.GetObject("FlagTipo").Valor;
            prmTipo.Value = EReportW.GetObject("Tipo").Valor;
            prmRetNum.Value = EReportW.GetObject("RetencionNum").Valor;
            prmFlagEstado.Value = EReportW.GetObject("FlagEstado").Valor;
            prmEstado.Value = EReportW.GetObject("Estado").Valor;
            prmExcAN.Value = EReportW.GetObject("ExcAnulado").Valor;
            prmFlagOrigen.Value = EReportW.GetObject("FlagOrigen").Valor;
            prmOrigen.Value = EReportW.GetObject("Origen").Valor;
            prmTipoExp.Value = EReportW.GetObject("TipoExp").Valor;            
            oPrm = null;

            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }

    }
}
