namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables
{
    partial class rpt_LibroBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_LibroBanco));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrImpHaber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpDebe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrVoucher = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCodSunatFTP = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTipoPago = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripV = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPagado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripD = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCuentaAsoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescCtaAsoc = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GrupoCuenta = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrCuentaCTE = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTipoCuentaT = new DevExpress.XtraReports.UI.XRLabel();
            this.xrEntFinanciera = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.PieCuenta = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHaberGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDebeGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotalGR = new DevExpress.XtraReports.UI.XRLabel();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmMoneda = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCuentaIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCuentaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoCuenta = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrFechaFinMes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.MonedaExp = new DevExpress.XtraReports.UI.CalculatedField();
            this.TitCuenta = new DevExpress.XtraReports.UI.CalculatedField();
            this.EntFinanciera = new DevExpress.XtraReports.UI.CalculatedField();
            this.CuentaCTE = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.ImpDebe = new DevExpress.XtraReports.UI.CalculatedField();
            this.ImpHaber = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrImpHaber,
            this.xrImpDebe,
            this.xrVoucher,
            this.xrFecha,
            this.xrCodSunatFTP,
            this.xrTipoPago,
            this.xrDescripV,
            this.xrPagado,
            this.xrDescripD,
            this.xrCuentaAsoc,
            this.xrDescCtaAsoc});
            this.Detail.Font = new System.Drawing.Font("Arial", 6F);
            this.Detail.HeightF = 19F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrImpHaber
            // 
            this.xrImpHaber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.ImpHaber", "{0:n2}")});
            this.xrImpHaber.LocationFloat = new DevExpress.Utils.PointFloat(696.9999F, 0F);
            this.xrImpHaber.Name = "xrImpHaber";
            this.xrImpHaber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpHaber.SizeF = new System.Drawing.SizeF(65F, 13F);
            this.xrImpHaber.StylePriority.UseTextAlignment = false;
            this.xrImpHaber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpDebe
            // 
            this.xrImpDebe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.ImpDebe", "{0:n2}")});
            this.xrImpDebe.LocationFloat = new DevExpress.Utils.PointFloat(636.5717F, 0F);
            this.xrImpDebe.Name = "xrImpDebe";
            this.xrImpDebe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpDebe.SizeF = new System.Drawing.SizeF(60.42828F, 13F);
            this.xrImpDebe.StylePriority.UseTextAlignment = false;
            this.xrImpDebe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrVoucher
            // 
            this.xrVoucher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.voucher")});
            this.xrVoucher.LocationFloat = new DevExpress.Utils.PointFloat(2.916654F, 0F);
            this.xrVoucher.Name = "xrVoucher";
            this.xrVoucher.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrVoucher.SizeF = new System.Drawing.SizeF(38.37503F, 12F);
            this.xrVoucher.Text = "xrVoucher";
            // 
            // xrFecha
            // 
            this.xrFecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.fecha", "{0:dd/MM/yyyy}")});
            this.xrFecha.LocationFloat = new DevExpress.Utils.PointFloat(41.29168F, 0F);
            this.xrFecha.Name = "xrFecha";
            this.xrFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFecha.SizeF = new System.Drawing.SizeF(47.91667F, 12F);
            // 
            // xrCodSunatFTP
            // 
            this.xrCodSunatFTP.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.C_CODIGOSUNATFP")});
            this.xrCodSunatFTP.LocationFloat = new DevExpress.Utils.PointFloat(89.20835F, 0F);
            this.xrCodSunatFTP.Name = "xrCodSunatFTP";
            this.xrCodSunatFTP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCodSunatFTP.SizeF = new System.Drawing.SizeF(18F, 12F);
            this.xrCodSunatFTP.Text = "xrCodSunatFTP";
            // 
            // xrTipoPago
            // 
            this.xrTipoPago.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.tipopago")});
            this.xrTipoPago.LocationFloat = new DevExpress.Utils.PointFloat(108.375F, 0.9999911F);
            this.xrTipoPago.Name = "xrTipoPago";
            this.xrTipoPago.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTipoPago.SizeF = new System.Drawing.SizeF(58F, 12F);
            this.xrTipoPago.Text = "xrTipoPago";
            // 
            // xrDescripV
            // 
            this.xrDescripV.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.v_descrip")});
            this.xrDescripV.Font = new System.Drawing.Font("Arial", 5F);
            this.xrDescripV.LocationFloat = new DevExpress.Utils.PointFloat(166.375F, 0F);
            this.xrDescripV.Name = "xrDescripV";
            this.xrDescripV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripV.SizeF = new System.Drawing.SizeF(126.1901F, 19F);
            this.xrDescripV.StylePriority.UseFont = false;
            this.xrDescripV.Text = "xrDescripV";
            // 
            // xrPagado
            // 
            this.xrPagado.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.pagado")});
            this.xrPagado.Font = new System.Drawing.Font("Arial", 5F);
            this.xrPagado.LocationFloat = new DevExpress.Utils.PointFloat(292.5651F, 0F);
            this.xrPagado.Name = "xrPagado";
            this.xrPagado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPagado.SizeF = new System.Drawing.SizeF(129.0166F, 19F);
            this.xrPagado.StylePriority.UseFont = false;
            this.xrPagado.Text = "xrPagado";
            // 
            // xrDescripD
            // 
            this.xrDescripD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.d_descrip")});
            this.xrDescripD.LocationFloat = new DevExpress.Utils.PointFloat(421.5817F, 0F);
            this.xrDescripD.Name = "xrDescripD";
            this.xrDescripD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripD.SizeF = new System.Drawing.SizeF(86.40671F, 12F);
            this.xrDescripD.Text = "xrDescripD";
            // 
            // xrCuentaAsoc
            // 
            this.xrCuentaAsoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.c_cuentaasociada")});
            this.xrCuentaAsoc.LocationFloat = new DevExpress.Utils.PointFloat(507.9884F, 0F);
            this.xrCuentaAsoc.Name = "xrCuentaAsoc";
            this.xrCuentaAsoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCuentaAsoc.SizeF = new System.Drawing.SizeF(39F, 12F);
            this.xrCuentaAsoc.Text = "xrCuentaAsoc";
            // 
            // xrDescCtaAsoc
            // 
            this.xrDescCtaAsoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.descrip_cta_asoc")});
            this.xrDescCtaAsoc.Font = new System.Drawing.Font("Arial", 5F);
            this.xrDescCtaAsoc.LocationFloat = new DevExpress.Utils.PointFloat(546.9884F, 0F);
            this.xrDescCtaAsoc.Name = "xrDescCtaAsoc";
            this.xrDescCtaAsoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescCtaAsoc.SizeF = new System.Drawing.SizeF(89.58331F, 19F);
            this.xrDescCtaAsoc.StylePriority.UseFont = false;
            this.xrDescCtaAsoc.Text = "xrDescCtaAsoc";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 35F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 59F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlConnRPT
            // 
            this.sqlConnRPT.ConnectionName = "ibserver_29_lys_Connection";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer;
            msSqlConnectionParameters1.DatabaseName = "lys";
            msSqlConnectionParameters1.ServerName = "ibserver_29";
            this.sqlConnRPT.ConnectionParameters = msSqlConnectionParameters1;
            this.sqlConnRPT.Name = "sqlConnRPT";
            storedProcQuery1.Name = "SP_CB_REP_LIBROBANCOS";
            queryParameter1.Name = "@compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@moneda";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmMoneda]", typeof(string));
            queryParameter4.Name = "@cuentaini";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCuentaIni]", typeof(string));
            queryParameter5.Name = "@cuentafin";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCuentaFin]", typeof(string));
            queryParameter6.Name = "@tipoplan";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoCuenta]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.StoredProcName = "SP_CB_REP_LIBROBANCOS";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GrupoCuenta
            // 
            this.GrupoCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCuentaCTE,
            this.xrTipoCuentaT,
            this.xrEntFinanciera,
            this.xrLabel33,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel65,
            this.xrLabel49,
            this.xrLabel48,
            this.xrLabel47,
            this.xrLabel50,
            this.xrLabel61});
            this.GrupoCuenta.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.GrupoCuenta.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cuenta", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoCuenta.HeightF = 55.79166F;
            this.GrupoCuenta.Name = "GrupoCuenta";
            this.GrupoCuenta.StylePriority.UseFont = false;
            // 
            // xrCuentaCTE
            // 
            this.xrCuentaCTE.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.CuentaCTE")});
            this.xrCuentaCTE.LocationFloat = new DevExpress.Utils.PointFloat(486.0383F, 7.000001F);
            this.xrCuentaCTE.Name = "xrCuentaCTE";
            this.xrCuentaCTE.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCuentaCTE.SizeF = new System.Drawing.SizeF(250.9616F, 13F);
            this.xrCuentaCTE.Text = "xrCuentaCTE";
            // 
            // xrTipoCuentaT
            // 
            this.xrTipoCuentaT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.TitCuenta")});
            this.xrTipoCuentaT.LocationFloat = new DevExpress.Utils.PointFloat(4.000028F, 24.41669F);
            this.xrTipoCuentaT.Name = "xrTipoCuentaT";
            this.xrTipoCuentaT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTipoCuentaT.SizeF = new System.Drawing.SizeF(448.9166F, 13F);
            this.xrTipoCuentaT.Text = "xrTipoCuentaT";
            // 
            // xrEntFinanciera
            // 
            this.xrEntFinanciera.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.EntFinanciera")});
            this.xrEntFinanciera.LocationFloat = new DevExpress.Utils.PointFloat(2.916654F, 7.000001F);
            this.xrEntFinanciera.Name = "xrEntFinanciera";
            this.xrEntFinanciera.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrEntFinanciera.SizeF = new System.Drawing.SizeF(450F, 13F);
            this.xrEntFinanciera.Text = "xrEntFinanciera";
            // 
            // xrLabel33
            // 
            this.xrLabel33.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel33.BorderColor = System.Drawing.Color.Black;
            this.xrLabel33.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel33.BorderWidth = 1F;
            this.xrLabel33.CanGrow = false;
            this.xrLabel33.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel33.ForeColor = System.Drawing.Color.Black;
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(421.5818F, 41.12501F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(86.40665F, 13F);
            this.xrLabel33.StylePriority.UseBackColor = false;
            this.xrLabel33.StylePriority.UseBorderColor = false;
            this.xrLabel33.StylePriority.UseBorders = false;
            this.xrLabel33.StylePriority.UseBorderWidth = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseForeColor = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "Documento";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(292.5651F, 41.12501F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(129.0167F, 13F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Apellidos y Nombres / Razon Social";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(92.70834F, 41.12501F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(73.66666F, 13F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "F.Pago";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel65
            // 
            this.xrLabel65.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel65.BorderColor = System.Drawing.Color.Black;
            this.xrLabel65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel65.BorderWidth = 1F;
            this.xrLabel65.CanGrow = false;
            this.xrLabel65.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.ForeColor = System.Drawing.Color.Black;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(0F, 41.12501F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(43F, 13F);
            this.xrLabel65.StylePriority.UseBackColor = false;
            this.xrLabel65.StylePriority.UseBorderColor = false;
            this.xrLabel65.StylePriority.UseBorders = false;
            this.xrLabel65.StylePriority.UseBorderWidth = false;
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseForeColor = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            this.xrLabel65.Text = "Voucher";
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel49
            // 
            this.xrLabel49.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel49.BorderColor = System.Drawing.Color.Black;
            this.xrLabel49.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel49.BorderWidth = 1F;
            this.xrLabel49.CanGrow = false;
            this.xrLabel49.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel49.ForeColor = System.Drawing.Color.Black;
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(636.5717F, 41.12501F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(60.42828F, 13F);
            this.xrLabel49.StylePriority.UseBackColor = false;
            this.xrLabel49.StylePriority.UseBorderColor = false;
            this.xrLabel49.StylePriority.UseBorders = false;
            this.xrLabel49.StylePriority.UseBorderWidth = false;
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseForeColor = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "Debe";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel48
            // 
            this.xrLabel48.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel48.BorderColor = System.Drawing.Color.Black;
            this.xrLabel48.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel48.BorderWidth = 1F;
            this.xrLabel48.CanGrow = false;
            this.xrLabel48.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel48.ForeColor = System.Drawing.Color.Black;
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(507.9884F, 41.12501F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(128.5833F, 13F);
            this.xrLabel48.StylePriority.UseBackColor = false;
            this.xrLabel48.StylePriority.UseBorderColor = false;
            this.xrLabel48.StylePriority.UseBorders = false;
            this.xrLabel48.StylePriority.UseBorderWidth = false;
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseForeColor = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "Cuenta asociada";
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel47
            // 
            this.xrLabel47.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel47.BorderColor = System.Drawing.Color.Black;
            this.xrLabel47.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel47.BorderWidth = 1F;
            this.xrLabel47.CanGrow = false;
            this.xrLabel47.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel47.ForeColor = System.Drawing.Color.Black;
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(166.375F, 41.12501F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(126.1901F, 13F);
            this.xrLabel47.StylePriority.UseBackColor = false;
            this.xrLabel47.StylePriority.UseBorderColor = false;
            this.xrLabel47.StylePriority.UseBorders = false;
            this.xrLabel47.StylePriority.UseBorderWidth = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseForeColor = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.Text = "Descripción";
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel50
            // 
            this.xrLabel50.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel50.BorderColor = System.Drawing.Color.Black;
            this.xrLabel50.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel50.BorderWidth = 1F;
            this.xrLabel50.CanGrow = false;
            this.xrLabel50.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel50.ForeColor = System.Drawing.Color.Black;
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(697F, 41.12501F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(65F, 13F);
            this.xrLabel50.StylePriority.UseBackColor = false;
            this.xrLabel50.StylePriority.UseBorderColor = false;
            this.xrLabel50.StylePriority.UseBorders = false;
            this.xrLabel50.StylePriority.UseBorderWidth = false;
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseForeColor = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.Text = "Haber";
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel61
            // 
            this.xrLabel61.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel61.BorderColor = System.Drawing.Color.Black;
            this.xrLabel61.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel61.BorderWidth = 1F;
            this.xrLabel61.CanGrow = false;
            this.xrLabel61.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel61.ForeColor = System.Drawing.Color.Black;
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(43F, 41.12501F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(49.70833F, 13F);
            this.xrLabel61.StylePriority.UseBackColor = false;
            this.xrLabel61.StylePriority.UseBorderColor = false;
            this.xrLabel61.StylePriority.UseBorders = false;
            this.xrLabel61.StylePriority.UseBorderWidth = false;
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.StylePriority.UseForeColor = false;
            this.xrLabel61.StylePriority.UseTextAlignment = false;
            this.xrLabel61.Text = "Fecha";
            this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.HeightF = 29F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.HeightF = 0.9999911F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.HeightF = 1F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            // 
            // PieCuenta
            // 
            this.PieCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrHaberGR,
            this.xrDebeGR,
            this.xrLine1,
            this.xrLabel4,
            this.xrTotalGR});
            this.PieCuenta.HeightF = 40.41665F;
            this.PieCuenta.Name = "PieCuenta";
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(464F, 9.208312F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(143.13F, 11F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Total Movimiento del Mes  ---> ";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrHaberGR
            // 
            this.xrHaberGR.CanGrow = false;
            this.xrHaberGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.haber")});
            this.xrHaberGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrHaberGR.LocationFloat = new DevExpress.Utils.PointFloat(687.3201F, 9.208312F);
            this.xrHaberGR.Name = "xrHaberGR";
            this.xrHaberGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHaberGR.SizeF = new System.Drawing.SizeF(73.97F, 11F);
            this.xrHaberGR.StylePriority.UseFont = false;
            this.xrHaberGR.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrHaberGR.Summary = xrSummary1;
            this.xrHaberGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrHaberGR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrHaberGR_SummaryGetResult);
            this.xrHaberGR.SummaryReset += new System.EventHandler(this.xrHaberGR_SummaryReset);
            this.xrHaberGR.SummaryRowChanged += new System.EventHandler(this.xrHaberGR_SummaryRowChanged);
            // 
            // xrDebeGR
            // 
            this.xrDebeGR.CanGrow = false;
            this.xrDebeGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.debe", "{0:n2}")});
            this.xrDebeGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrDebeGR.LocationFloat = new DevExpress.Utils.PointFloat(612.3085F, 9.208312F);
            this.xrDebeGR.Name = "xrDebeGR";
            this.xrDebeGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDebeGR.SizeF = new System.Drawing.SizeF(75.01147F, 11F);
            this.xrDebeGR.StylePriority.UseFont = false;
            this.xrDebeGR.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrDebeGR.Summary = xrSummary2;
            this.xrDebeGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebeGR.XlsxFormatString = "";
            this.xrDebeGR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrDebeGR_SummaryGetResult);
            this.xrDebeGR.SummaryReset += new System.EventHandler(this.xrDebeGR_SummaryReset);
            this.xrDebeGR.SummaryRowChanged += new System.EventHandler(this.xrDebeGR_SummaryRowChanged);
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 1F;
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(468F, 2.208342F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(290F, 5F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(464F, 23.20831F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(143.13F, 11F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "SALDO FINAL  --->";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotalGR
            // 
            this.xrTotalGR.CanGrow = false;
            this.xrTotalGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.n_importe", "{0:n2}")});
            this.xrTotalGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrTotalGR.LocationFloat = new DevExpress.Utils.PointFloat(612.3087F, 22.20832F);
            this.xrTotalGR.Name = "xrTotalGR";
            this.xrTotalGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotalGR.SizeF = new System.Drawing.SizeF(145.6913F, 11F);
            this.xrTotalGR.StylePriority.UseFont = false;
            this.xrTotalGR.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTotalGR.Summary = xrSummary3;
            this.xrTotalGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTotalGR.XlsxFormatString = "";
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.HeightF = 0.8333206F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // prmCompania
            // 
            this.prmCompania.Name = "prmCompania";
            // 
            // prmPeriodo
            // 
            this.prmPeriodo.Name = "prmPeriodo";
            // 
            // prmMoneda
            // 
            this.prmMoneda.Name = "prmMoneda";
            // 
            // prmCuentaIni
            // 
            this.prmCuentaIni.Name = "prmCuentaIni";
            // 
            // prmCuentaFin
            // 
            this.prmCuentaFin.Name = "prmCuentaFin";
            // 
            // prmTipoCuenta
            // 
            this.prmTipoCuenta.Name = "prmTipoCuenta";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel25,
            this.xrPageInfo3,
            this.xrFechaFinMes,
            this.xrLabel51,
            this.xrLabel35,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLabel46});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 101.0417F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel32
            // 
            this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.MonedaExp")});
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(89.20835F, 66.83334F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(146.875F, 16.7083F);
            this.xrLabel32.Text = "xrLabel32";
            // 
            // xrLabel31
            // 
            this.xrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.NOMBRECOMPANIA")});
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(102.9167F, 51.12498F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(419.7917F, 15.70834F);
            this.xrLabel31.Text = "xrLabel31";
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROBANCOS.RUC")});
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(41.29169F, 35.41665F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(147.9167F, 15.70833F);
            this.xrLabel30.Text = "xrLabel30";
            // 
            // xrLabel25
            // 
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriodo, "Text", "")});
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(66.45835F, 19.70833F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(122.75F, 15.70829F);
            this.xrLabel25.Text = "xrLabel25";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(526.9014F, 4.000012F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(127.5833F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrFechaFinMes
            // 
            this.xrFechaFinMes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrFechaFinMes.LocationFloat = new DevExpress.Utils.PointFloat(654.4847F, 4.000012F);
            this.xrFechaFinMes.Name = "xrFechaFinMes";
            this.xrFechaFinMes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFechaFinMes.SizeF = new System.Drawing.SizeF(82.51532F, 15.70834F);
            this.xrFechaFinMes.StylePriority.UseFont = false;
            this.xrFechaFinMes.Text = "xrFechaFinMes";
            // 
            // xrLabel51
            // 
            this.xrLabel51.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 19.70829F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(61.45833F, 15.70833F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.Text = "PERIODO:";
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 67.83331F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(79.16665F, 15.70833F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.Text = "Expresado en ";
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 51.125F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(97.91665F, 15.70833F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.Text = "RAZON SOCIAL :";
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 35.41665F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(32.29167F, 15.70833F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.Text = "RUC:";
            // 
            // xrLabel46
            // 
            this.xrLabel46.CanGrow = false;
            this.xrLabel46.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 4.000007F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(485.5673F, 15.70833F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.Text = "FORMATO 1.2: LIBRO  CAJA BANCOS - DETALLE DE LOS MOVIMIENTOS DE LA CUENTA CORRIEN" +
    "TE";
            // 
            // MonedaExp
            // 
            this.MonedaExp.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.MonedaExp.Expression = "Iif([Parameters.prmMoneda]=\'L\',\'Moneda Local\'  ,\'Moneda Extranjera\' )";
            this.MonedaExp.Name = "MonedaExp";
            // 
            // TitCuenta
            // 
            this.TitCuenta.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.TitCuenta.Expression = "\'( \'+ [cuenta] + \' ) \'+[descrip_cta]";
            this.TitCuenta.Name = "TitCuenta";
            // 
            // EntFinanciera
            // 
            this.EntFinanciera.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.EntFinanciera.Expression = "\'Entidad Financiera : \'+  [banco]";
            this.EntFinanciera.Name = "EntFinanciera";
            // 
            // CuentaCTE
            // 
            this.CuentaCTE.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.CuentaCTE.Expression = "\'Cod. de Cta.Cte : \'+ [cuentabco]";
            this.CuentaCTE.Name = "CuentaCTE";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // ImpDebe
            // 
            this.ImpDebe.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.ImpDebe.Expression = "iif([n_importe]>0,[n_importe],0)";
            this.ImpDebe.Name = "ImpDebe";
            // 
            // ImpHaber
            // 
            this.ImpHaber.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.ImpHaber.Expression = "iif([n_importe]<0,[n_importe],0)";
            this.ImpHaber.Name = "ImpHaber";
            // 
            // rpt_LibroBanco
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GrupoCuenta,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.PieCuenta,
            this.reportFooterBand1,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.MonedaExp,
            this.TitCuenta,
            this.EntFinanciera,
            this.CuentaCTE,
            this.calculatedField1,
            this.ImpDebe,
            this.ImpHaber});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_LIBROBANCOS";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(33, 32, 35, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmMoneda,
            this.prmCuentaIni,
            this.prmCuentaFin,
            this.prmTipoCuenta});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrVoucher;
        private DevExpress.XtraReports.UI.XRLabel xrFecha;
        private DevExpress.XtraReports.UI.XRLabel xrCodSunatFTP;
        private DevExpress.XtraReports.UI.XRLabel xrTipoPago;
        private DevExpress.XtraReports.UI.XRLabel xrDescripV;
        private DevExpress.XtraReports.UI.XRLabel xrPagado;
        private DevExpress.XtraReports.UI.XRLabel xrDescripD;
        private DevExpress.XtraReports.UI.XRLabel xrCuentaAsoc;
        private DevExpress.XtraReports.UI.XRLabel xrDescCtaAsoc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoCuenta;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand PieCuenta;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter prmMoneda;
        private DevExpress.XtraReports.Parameters.Parameter prmCuentaIni;
        private DevExpress.XtraReports.Parameters.Parameter prmCuentaFin;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoCuenta;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel51;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.XtraReports.UI.XRLabel xrLabel46;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrFechaFinMes;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.CalculatedField MonedaExp;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRLabel xrLabel65;
        private DevExpress.XtraReports.UI.XRLabel xrLabel47;
        private DevExpress.XtraReports.UI.XRLabel xrLabel48;
        private DevExpress.XtraReports.UI.XRLabel xrLabel49;
        private DevExpress.XtraReports.UI.XRLabel xrLabel50;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrTipoCuentaT;
        private DevExpress.XtraReports.UI.XRLabel xrEntFinanciera;
        private DevExpress.XtraReports.UI.CalculatedField TitCuenta;
        private DevExpress.XtraReports.UI.CalculatedField EntFinanciera;
        private DevExpress.XtraReports.UI.XRLabel xrCuentaCTE;
        private DevExpress.XtraReports.UI.CalculatedField CuentaCTE;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.XRLabel xrImpHaber;
        private DevExpress.XtraReports.UI.XRLabel xrImpDebe;
        private DevExpress.XtraReports.UI.CalculatedField ImpDebe;
        private DevExpress.XtraReports.UI.CalculatedField ImpHaber;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrHaberGR;
        private DevExpress.XtraReports.UI.XRLabel xrDebeGR;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrTotalGR;
    }
}
