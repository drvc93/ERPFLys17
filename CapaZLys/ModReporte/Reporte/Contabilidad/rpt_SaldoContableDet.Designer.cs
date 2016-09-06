namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_SaldoContableDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_SaldoContableDet));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrMeses = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoDolar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSaldoDolar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSaldoLocal = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCuenta = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTitCompania = new DevExpress.XtraReports.UI.XRLabel();
            this.titPeriodo = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.titCuenta = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.GrTot = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotDolar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotLocal = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrMeses,
            this.xrMontoDolar,
            this.xrSaldoDolar,
            this.xrMontoLocal,
            this.xrSaldoLocal});
            this.Detail.Font = new System.Drawing.Font("Arial", 8F);
            this.Detail.HeightF = 16.75003F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrMeses
            // 
            this.xrMeses.BackColor = System.Drawing.Color.Transparent;
            this.xrMeses.BorderColor = System.Drawing.Color.Black;
            this.xrMeses.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMeses.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMeses.BorderWidth = 1F;
            this.xrMeses.CanGrow = false;
            this.xrMeses.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.c_mesesdes")});
            this.xrMeses.Font = new System.Drawing.Font("Arial", 8F);
            this.xrMeses.ForeColor = System.Drawing.Color.Black;
            this.xrMeses.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 0F);
            this.xrMeses.Name = "xrMeses";
            this.xrMeses.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMeses.SizeF = new System.Drawing.SizeF(92.00001F, 16F);
            this.xrMeses.StylePriority.UseBackColor = false;
            this.xrMeses.StylePriority.UseBorderColor = false;
            this.xrMeses.StylePriority.UseBorderDashStyle = false;
            this.xrMeses.StylePriority.UseBorders = false;
            this.xrMeses.StylePriority.UseBorderWidth = false;
            this.xrMeses.StylePriority.UseFont = false;
            this.xrMeses.StylePriority.UseForeColor = false;
            this.xrMeses.StylePriority.UsePadding = false;
            this.xrMeses.StylePriority.UseTextAlignment = false;
            this.xrMeses.Text = "xrTableCell8";
            this.xrMeses.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrMontoDolar
            // 
            this.xrMontoDolar.BackColor = System.Drawing.Color.Transparent;
            this.xrMontoDolar.BorderColor = System.Drawing.Color.Black;
            this.xrMontoDolar.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMontoDolar.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMontoDolar.BorderWidth = 1F;
            this.xrMontoDolar.CanGrow = false;
            this.xrMontoDolar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.n_monDolar", "{0:#,#.00 ;(#,#.00);}")});
            this.xrMontoDolar.Font = new System.Drawing.Font("Arial", 8F);
            this.xrMontoDolar.ForeColor = System.Drawing.Color.Black;
            this.xrMontoDolar.LocationFloat = new DevExpress.Utils.PointFloat(99.08556F, 0.7500331F);
            this.xrMontoDolar.Name = "xrMontoDolar";
            this.xrMontoDolar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoDolar.SizeF = new System.Drawing.SizeF(99.79559F, 16F);
            this.xrMontoDolar.StylePriority.UseBackColor = false;
            this.xrMontoDolar.StylePriority.UseBorderColor = false;
            this.xrMontoDolar.StylePriority.UseBorderDashStyle = false;
            this.xrMontoDolar.StylePriority.UseBorders = false;
            this.xrMontoDolar.StylePriority.UseBorderWidth = false;
            this.xrMontoDolar.StylePriority.UseFont = false;
            this.xrMontoDolar.StylePriority.UseForeColor = false;
            this.xrMontoDolar.StylePriority.UsePadding = false;
            this.xrMontoDolar.StylePriority.UseTextAlignment = false;
            this.xrMontoDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrSaldoDolar
            // 
            this.xrSaldoDolar.BackColor = System.Drawing.Color.Transparent;
            this.xrSaldoDolar.BorderColor = System.Drawing.Color.Black;
            this.xrSaldoDolar.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrSaldoDolar.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrSaldoDolar.BorderWidth = 1F;
            this.xrSaldoDolar.CanGrow = false;
            this.xrSaldoDolar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.n_salDolar", "{0:#,#.00 ;(#,#.00);}")});
            this.xrSaldoDolar.Font = new System.Drawing.Font("Arial", 8F);
            this.xrSaldoDolar.ForeColor = System.Drawing.Color.Black;
            this.xrSaldoDolar.LocationFloat = new DevExpress.Utils.PointFloat(198.8811F, 0F);
            this.xrSaldoDolar.Name = "xrSaldoDolar";
            this.xrSaldoDolar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrSaldoDolar.SizeF = new System.Drawing.SizeF(108.3334F, 16F);
            this.xrSaldoDolar.StylePriority.UseBackColor = false;
            this.xrSaldoDolar.StylePriority.UseBorderColor = false;
            this.xrSaldoDolar.StylePriority.UseBorderDashStyle = false;
            this.xrSaldoDolar.StylePriority.UseBorders = false;
            this.xrSaldoDolar.StylePriority.UseBorderWidth = false;
            this.xrSaldoDolar.StylePriority.UseFont = false;
            this.xrSaldoDolar.StylePriority.UseForeColor = false;
            this.xrSaldoDolar.StylePriority.UsePadding = false;
            this.xrSaldoDolar.StylePriority.UseTextAlignment = false;
            this.xrSaldoDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocal
            // 
            this.xrMontoLocal.BackColor = System.Drawing.Color.Transparent;
            this.xrMontoLocal.BorderColor = System.Drawing.Color.Black;
            this.xrMontoLocal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrMontoLocal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrMontoLocal.BorderWidth = 1F;
            this.xrMontoLocal.CanGrow = false;
            this.xrMontoLocal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.n_monLocal", "{0:#,#.00 ;(#,#.00);}")});
            this.xrMontoLocal.Font = new System.Drawing.Font("Arial", 8F);
            this.xrMontoLocal.ForeColor = System.Drawing.Color.Black;
            this.xrMontoLocal.LocationFloat = new DevExpress.Utils.PointFloat(307.2145F, 0F);
            this.xrMontoLocal.Name = "xrMontoLocal";
            this.xrMontoLocal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocal.SizeF = new System.Drawing.SizeF(99.41833F, 16F);
            this.xrMontoLocal.StylePriority.UseBackColor = false;
            this.xrMontoLocal.StylePriority.UseBorderColor = false;
            this.xrMontoLocal.StylePriority.UseBorderDashStyle = false;
            this.xrMontoLocal.StylePriority.UseBorders = false;
            this.xrMontoLocal.StylePriority.UseBorderWidth = false;
            this.xrMontoLocal.StylePriority.UseFont = false;
            this.xrMontoLocal.StylePriority.UseForeColor = false;
            this.xrMontoLocal.StylePriority.UsePadding = false;
            this.xrMontoLocal.StylePriority.UseTextAlignment = false;
            this.xrMontoLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrSaldoLocal
            // 
            this.xrSaldoLocal.BackColor = System.Drawing.Color.Transparent;
            this.xrSaldoLocal.BorderColor = System.Drawing.Color.Black;
            this.xrSaldoLocal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrSaldoLocal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrSaldoLocal.BorderWidth = 1F;
            this.xrSaldoLocal.CanGrow = false;
            this.xrSaldoLocal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.n_salLocal", "{0:#,#.00 ;(#,#.00);}")});
            this.xrSaldoLocal.Font = new System.Drawing.Font("Arial", 8F);
            this.xrSaldoLocal.ForeColor = System.Drawing.Color.Black;
            this.xrSaldoLocal.LocationFloat = new DevExpress.Utils.PointFloat(406.6329F, 0.7500331F);
            this.xrSaldoLocal.Name = "xrSaldoLocal";
            this.xrSaldoLocal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrSaldoLocal.SizeF = new System.Drawing.SizeF(107.29F, 16F);
            this.xrSaldoLocal.StylePriority.UseBackColor = false;
            this.xrSaldoLocal.StylePriority.UseBorderColor = false;
            this.xrSaldoLocal.StylePriority.UseBorderDashStyle = false;
            this.xrSaldoLocal.StylePriority.UseBorders = false;
            this.xrSaldoLocal.StylePriority.UseBorderWidth = false;
            this.xrSaldoLocal.StylePriority.UseFont = false;
            this.xrSaldoLocal.StylePriority.UseForeColor = false;
            this.xrSaldoLocal.StylePriority.UsePadding = false;
            this.xrSaldoLocal.StylePriority.UseTextAlignment = false;
            this.xrSaldoLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 33F;
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
            storedProcQuery1.Name = "sp_saldo_contable_cuenta_det";
            queryParameter1.Name = "@c_compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@c_periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@c_cuenta";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCuenta]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "sp_saldo_contable_cuenta_det";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel17,
            this.xrLabel18,
            this.xrTitCompania,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3});
            this.pageHeaderBand1.Font = new System.Drawing.Font("Arial", 8F);
            this.pageHeaderBand1.HeightF = 103.4583F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StylePriority.UseFont = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(419.7917F, 10.00001F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(58.33334F, 17.79167F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Periodo:";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 30.79168F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(98.95834F, 17.79167F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "Cuenta Contable:";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 10.00001F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(66.66667F, 17.79167F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "Compañia:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.BorderWidth = 1F;
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(406.6329F, 86.625F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(107.29F, 15.16666F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorderDashStyle = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseBorderWidth = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Saldo";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(307.2145F, 86.625F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(99.41833F, 15.16666F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorderDashStyle = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Actividad";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(307.2145F, 71.45834F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(206.7083F, 15.16667F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorderDashStyle = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Moneda Local";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.Black;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(99.08556F, 71.45834F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(208.129F, 15.16666F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorderDashStyle = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UsePadding = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Moneda Dolares";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 71.45834F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(92F, 30.33F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorderDashStyle = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.BorderWidth = 1F;
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(99.08556F, 86.62497F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(99.79559F, 15.16669F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseBorderWidth = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Actividad";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.BorderWidth = 1F;
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(198.8811F, 86.62497F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(108.3334F, 15.16666F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorderDashStyle = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Saldo";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 1D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.Weight = 1D;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.HeightF = 29.00001F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.HeightF = 0F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
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
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
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
            // prmCuenta
            // 
            this.prmCuenta.Name = "prmCuenta";
            // 
            // xrTitCompania
            // 
            this.xrTitCompania.CanGrow = false;
            this.xrTitCompania.LocationFloat = new DevExpress.Utils.PointFloat(72.66668F, 10.00001F);
            this.xrTitCompania.Name = "xrTitCompania";
            this.xrTitCompania.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTitCompania.SizeF = new System.Drawing.SizeF(287.0872F, 17.79167F);
            this.xrTitCompania.Text = "xrTitCompania";
            // 
            // titPeriodo
            // 
            this.titPeriodo.DataMember = "sp_saldo_contable_cuenta_det";
            this.titPeriodo.Expression = "Substring([Parameters.prmPeriodo], 0 ,4 )";
            this.titPeriodo.Name = "titPeriodo";
            // 
            // xrLabel18
            // 
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.titPeriodo")});
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(478.125F, 10.00001F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(47.87494F, 17.79167F);
            this.xrLabel18.Text = "xrLabel18";
            // 
            // titCuenta
            // 
            this.titCuenta.DataMember = "sp_saldo_contable_cuenta_det";
            this.titCuenta.Expression = "[c_cuenta]+ \' - \' + [c_cuentades]";
            this.titCuenta.Name = "titCuenta";
            // 
            // xrLabel17
            // 
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.titCuenta")});
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(104.9583F, 30.79168F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(421.0415F, 17.79166F);
            this.xrLabel17.Text = "xrLabel17";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 48.58335F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(519.9999F, 12.58333F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(6.000042F, 3F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(519.9999F, 2.166662F);
            // 
            // GrTot
            // 
            this.GrTot.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTotDolar,
            this.xrTotLocal,
            this.xrLabel16,
            this.xrLine2});
            this.GrTot.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrTot.HeightF = 29.16667F;
            this.GrTot.Name = "GrTot";
            this.GrTot.StylePriority.UseFont = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(4.958344F, 6.916675F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(93.04166F, 18F);
            this.xrLabel16.Text = "Total Actividad";
            // 
            // xrTotDolar
            // 
            this.xrTotDolar.BackColor = System.Drawing.Color.Transparent;
            this.xrTotDolar.BorderColor = System.Drawing.Color.Black;
            this.xrTotDolar.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTotDolar.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTotDolar.BorderWidth = 1F;
            this.xrTotDolar.CanGrow = false;
            this.xrTotDolar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.n_monDolar", "{0:#,#.00 ;(#,#.00);}")});
            this.xrTotDolar.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTotDolar.ForeColor = System.Drawing.Color.Black;
            this.xrTotDolar.LocationFloat = new DevExpress.Utils.PointFloat(99.08556F, 6.916675F);
            this.xrTotDolar.Name = "xrTotDolar";
            this.xrTotDolar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotDolar.SizeF = new System.Drawing.SizeF(99.79559F, 18F);
            this.xrTotDolar.StylePriority.UseBackColor = false;
            this.xrTotDolar.StylePriority.UseBorderColor = false;
            this.xrTotDolar.StylePriority.UseBorderDashStyle = false;
            this.xrTotDolar.StylePriority.UseBorders = false;
            this.xrTotDolar.StylePriority.UseBorderWidth = false;
            this.xrTotDolar.StylePriority.UseFont = false;
            this.xrTotDolar.StylePriority.UseForeColor = false;
            this.xrTotDolar.StylePriority.UsePadding = false;
            this.xrTotDolar.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTotDolar.Summary = xrSummary1;
            this.xrTotDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotLocal
            // 
            this.xrTotLocal.BackColor = System.Drawing.Color.Transparent;
            this.xrTotLocal.BorderColor = System.Drawing.Color.Black;
            this.xrTotLocal.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTotLocal.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTotLocal.BorderWidth = 1F;
            this.xrTotLocal.CanGrow = false;
            this.xrTotLocal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_saldo_contable_cuenta_det.n_monLocal", "{0:#,#.00 ;(#,#.00);}")});
            this.xrTotLocal.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTotLocal.ForeColor = System.Drawing.Color.Black;
            this.xrTotLocal.LocationFloat = new DevExpress.Utils.PointFloat(307.2145F, 6.916675F);
            this.xrTotLocal.Name = "xrTotLocal";
            this.xrTotLocal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotLocal.SizeF = new System.Drawing.SizeF(99.41833F, 17.25F);
            this.xrTotLocal.StylePriority.UseBackColor = false;
            this.xrTotLocal.StylePriority.UseBorderColor = false;
            this.xrTotLocal.StylePriority.UseBorderDashStyle = false;
            this.xrTotLocal.StylePriority.UseBorders = false;
            this.xrTotLocal.StylePriority.UseBorderWidth = false;
            this.xrTotLocal.StylePriority.UseFont = false;
            this.xrTotLocal.StylePriority.UseForeColor = false;
            this.xrTotLocal.StylePriority.UsePadding = false;
            this.xrTotLocal.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTotLocal.Summary = xrSummary2;
            this.xrTotLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // rpt_SaldoContableDet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageHeaderBand1,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.GrTot});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.titPeriodo,
            this.titCuenta});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "sp_saldo_contable_cuenta_det";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(21, 33, 33, 59);
            this.PageHeight = 827;
            this.PageWidth = 583;
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmCuenta});
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
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.PageHeaderBand pageHeaderBand1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter prmCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrMeses;
        private DevExpress.XtraReports.UI.XRLabel xrMontoDolar;
        private DevExpress.XtraReports.UI.XRLabel xrSaldoDolar;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocal;
        private DevExpress.XtraReports.UI.XRLabel xrSaldoLocal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrTitCompania;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.CalculatedField titPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.CalculatedField titCuenta;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.GroupFooterBand GrTot;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrTotDolar;
        private DevExpress.XtraReports.UI.XRLabel xrTotLocal;
    }
}
