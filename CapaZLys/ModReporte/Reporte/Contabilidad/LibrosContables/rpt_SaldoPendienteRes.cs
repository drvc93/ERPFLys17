﻿using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using FiltroLys.ZLys.Funciones;
using FiltroLys.Domain.Sistema;

namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables
{
    public partial class rpt_SaldoPendienteRes : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_SaldoPendienteRes()
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
            prmTipoReporte.Value = EReportW.GetObject("TipoRep").Valor;
            xrCompaniaNom.Text = sCiaNombre;
            oPrm = null;

            EReportW.NombreStoreProc = sqlConnRPT.Queries[0].Name;
            CreateDocument();
            EReportW.ContReg = this.RowCount;
        }
    }
}
