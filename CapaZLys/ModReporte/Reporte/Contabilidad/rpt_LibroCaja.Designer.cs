namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_LibroCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_LibroCaja));
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrHaber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDebe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCuentaAsoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCuentaDescAsoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripV = new DevExpress.XtraReports.UI.XRLabel();
            this.xrVoucher = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GrupoCuenta = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
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
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFechaFinMes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.MonedaExp = new DevExpress.XtraReports.UI.CalculatedField();
            this.TitCuenta = new DevExpress.XtraReports.UI.CalculatedField();
            this.ImpDebe = new DevExpress.XtraReports.UI.CalculatedField();
            this.ImpHaber = new DevExpress.XtraReports.UI.CalculatedField();
            this.PieCuenta = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrDebeGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHaberGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotalGR = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrHaber,
            this.xrDebe,
            this.xrCuentaAsoc,
            this.xrCuentaDescAsoc,
            this.xrFecha,
            this.xrDescripV,
            this.xrVoucher});
            this.Detail.Font = new System.Drawing.Font("Arial", 6F);
            this.Detail.HeightF = 15.70832F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrHaber
            // 
            this.xrHaber.CanGrow = false;
            this.xrHaber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.ImpHaber", "{0:n2}")});
            this.xrHaber.LocationFloat = new DevExpress.Utils.PointFloat(666.0298F, 0F);
            this.xrHaber.Name = "xrHaber";
            this.xrHaber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHaber.SizeF = new System.Drawing.SizeF(73.96997F, 13.79166F);
            this.xrHaber.StylePriority.UseTextAlignment = false;
            this.xrHaber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrDebe
            // 
            this.xrDebe.CanGrow = false;
            this.xrDebe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.ImpDebe", "{0:n2}")});
            this.xrDebe.LocationFloat = new DevExpress.Utils.PointFloat(591.0183F, 0F);
            this.xrDebe.Name = "xrDebe";
            this.xrDebe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDebe.SizeF = new System.Drawing.SizeF(75.01154F, 13.79166F);
            this.xrDebe.StylePriority.UseTextAlignment = false;
            this.xrDebe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrCuentaAsoc
            // 
            this.xrCuentaAsoc.CanGrow = false;
            this.xrCuentaAsoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.c_cuentaasociada")});
            this.xrCuentaAsoc.LocationFloat = new DevExpress.Utils.PointFloat(401.8283F, 0F);
            this.xrCuentaAsoc.Name = "xrCuentaAsoc";
            this.xrCuentaAsoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCuentaAsoc.SizeF = new System.Drawing.SizeF(40.88138F, 13.79166F);
            this.xrCuentaAsoc.Text = "xrCuentaAsoc";
            // 
            // xrCuentaDescAsoc
            // 
            this.xrCuentaDescAsoc.CanGrow = false;
            this.xrCuentaDescAsoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.descrip_cta_asoc")});
            this.xrCuentaDescAsoc.LocationFloat = new DevExpress.Utils.PointFloat(442.7097F, 0F);
            this.xrCuentaDescAsoc.Name = "xrCuentaDescAsoc";
            this.xrCuentaDescAsoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCuentaDescAsoc.SizeF = new System.Drawing.SizeF(148.3087F, 13.79166F);
            this.xrCuentaDescAsoc.Text = "xrCuentaDescAsoc";
            // 
            // xrFecha
            // 
            this.xrFecha.CanGrow = false;
            this.xrFecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.fecha", "{0:dd/MM/yyyy}")});
            this.xrFecha.LocationFloat = new DevExpress.Utils.PointFloat(66.45832F, 0F);
            this.xrFecha.Name = "xrFecha";
            this.xrFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFecha.SizeF = new System.Drawing.SizeF(59.37999F, 13.79166F);
            // 
            // xrDescripV
            // 
            this.xrDescripV.CanGrow = false;
            this.xrDescripV.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.v_descrip")});
            this.xrDescripV.LocationFloat = new DevExpress.Utils.PointFloat(125.8383F, 0F);
            this.xrDescripV.Name = "xrDescripV";
            this.xrDescripV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripV.SizeF = new System.Drawing.SizeF(275.99F, 13.79166F);
            this.xrDescripV.Text = "xrDescripV";
            // 
            // xrVoucher
            // 
            this.xrVoucher.CanGrow = false;
            this.xrVoucher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.voucher")});
            this.xrVoucher.LocationFloat = new DevExpress.Utils.PointFloat(5.000019F, 0F);
            this.xrVoucher.Name = "xrVoucher";
            this.xrVoucher.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrVoucher.SizeF = new System.Drawing.SizeF(60.45999F, 13.79166F);
            this.xrVoucher.Text = "xrVoucher";
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
            storedProcQuery1.Name = "SP_CB_REP_LIBROCAJA";
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
            storedProcQuery1.StoredProcName = "SP_CB_REP_LIBROCAJA";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GrupoCuenta
            // 
            this.GrupoCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GrupoCuenta.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.GrupoCuenta.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cuenta", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoCuenta.HeightF = 21.41666F;
            this.GrupoCuenta.Name = "GrupoCuenta";
            this.GrupoCuenta.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.TitCuenta")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(2.916654F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(525.654F, 20F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.HeightF = 29F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.HeightF = 0F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // groupFooterBand1
            // 
            this.groupFooterBand1.HeightF = 1F;
            this.groupFooterBand1.Name = "groupFooterBand1";
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.HeightF = 0F;
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
            this.xrLabel50,
            this.xrLabel49,
            this.xrLabel48,
            this.xrLabel47,
            this.xrLabel65,
            this.xrLabel43,
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel40,
            this.xrFechaFinMes,
            this.xrPageInfo3,
            this.xrLabel46,
            this.xrLabel45,
            this.xrLabel44,
            this.xrLabel35,
            this.xrLabel51,
            this.xrLabel61});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 113.5417F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel50
            // 
            this.xrLabel50.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel50.BorderColor = System.Drawing.Color.Black;
            this.xrLabel50.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel50.BorderWidth = 1F;
            this.xrLabel50.CanGrow = false;
            this.xrLabel50.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel50.ForeColor = System.Drawing.Color.Black;
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(666.03F, 98.20827F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(73.97F, 13F);
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
            // xrLabel49
            // 
            this.xrLabel49.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel49.BorderColor = System.Drawing.Color.Black;
            this.xrLabel49.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel49.BorderWidth = 1F;
            this.xrLabel49.CanGrow = false;
            this.xrLabel49.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel49.ForeColor = System.Drawing.Color.Black;
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(591.0183F, 98.20827F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(75.0116F, 13F);
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
            this.xrLabel48.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel48.ForeColor = System.Drawing.Color.Black;
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(401.8283F, 98.20827F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(189.19F, 13F);
            this.xrLabel48.StylePriority.UseBackColor = false;
            this.xrLabel48.StylePriority.UseBorderColor = false;
            this.xrLabel48.StylePriority.UseBorders = false;
            this.xrLabel48.StylePriority.UseBorderWidth = false;
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseForeColor = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "Cuenta Contable asociada";
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
            this.xrLabel47.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel47.ForeColor = System.Drawing.Color.Black;
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(125.8383F, 98.20827F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(275.99F, 13F);
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
            // xrLabel65
            // 
            this.xrLabel65.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel65.BorderColor = System.Drawing.Color.Black;
            this.xrLabel65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel65.BorderWidth = 1F;
            this.xrLabel65.CanGrow = false;
            this.xrLabel65.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.ForeColor = System.Drawing.Color.Black;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 98.20827F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(60.46F, 13F);
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
            // xrLabel43
            // 
            this.xrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.MonedaExp")});
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(84.16666F, 66.83331F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(168.75F, 15.70833F);
            this.xrLabel43.Text = "xrLabel43";
            // 
            // xrLabel42
            // 
            this.xrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.NOMBRECOMPANIA")});
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(105.6538F, 50.12503F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(422.9167F, 15.70833F);
            this.xrLabel42.Text = "xrLabel42";
            // 
            // xrLabel41
            // 
            this.xrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.RUC")});
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(41.51923F, 34.41666F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(142.6474F, 15.70835F);
            this.xrLabel41.Text = "xrLabel41";
            // 
            // xrLabel40
            // 
            this.xrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriodo, "Text", "")});
            this.xrLabel40.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(66.45832F, 18.70832F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(117.7083F, 15.70833F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.Text = "xrLabel40";
            // 
            // xrFechaFinMes
            // 
            this.xrFechaFinMes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrFechaFinMes.LocationFloat = new DevExpress.Utils.PointFloat(657.4847F, 3.000005F);
            this.xrFechaFinMes.Name = "xrFechaFinMes";
            this.xrFechaFinMes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFechaFinMes.SizeF = new System.Drawing.SizeF(82.51532F, 15.70834F);
            this.xrFechaFinMes.StylePriority.UseFont = false;
            this.xrFechaFinMes.Text = "xrFechaFinMes";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(529.9015F, 3.000005F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(127.5833F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(5.000019F, 3.000005F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(485.5673F, 15.70833F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.Text = "FORMATO 1.1: LIBRO CAJA BANCOS - DETALLE DE LOS MOVIMIENTOS EN EFECTIVO";
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 34.41668F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(32.29167F, 15.70833F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.Text = "RUC:";
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 50.12503F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(97.91665F, 15.70833F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.Text = "RAZON SOCIAL :";
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 66.83331F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(79.16665F, 15.70833F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.Text = "Expresado en ";
            // 
            // xrLabel51
            // 
            this.xrLabel51.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 18.70833F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(61.45833F, 15.70833F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.Text = "PERIODO:";
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
            this.xrLabel61.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel61.ForeColor = System.Drawing.Color.Black;
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(66.45832F, 98.20827F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(59.38F, 13F);
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
            // MonedaExp
            // 
            this.MonedaExp.DataMember = "SP_CB_REP_LIBROCAJA";
            this.MonedaExp.Expression = "Iif([Parameters.prmMoneda]=\'L\',\'Moneda Local\'  ,\'Moneda Extranjera\' )";
            this.MonedaExp.Name = "MonedaExp";
            // 
            // TitCuenta
            // 
            this.TitCuenta.DataMember = "SP_CB_REP_LIBROCAJA";
            this.TitCuenta.Expression = "[cuenta] + \' \' + [descrip_cta]";
            this.TitCuenta.Name = "TitCuenta";
            // 
            // ImpDebe
            // 
            this.ImpDebe.DataMember = "SP_CB_REP_LIBROCAJA";
            this.ImpDebe.Expression = "iif([n_importe]>0,[n_importe],0)";
            this.ImpDebe.Name = "ImpDebe";
            // 
            // ImpHaber
            // 
            this.ImpHaber.DataMember = "SP_CB_REP_LIBROCAJA";
            this.ImpHaber.Expression = "iif([n_importe]<0,[n_importe],0)";
            this.ImpHaber.Name = "ImpHaber";
            // 
            // PieCuenta
            // 
            this.PieCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTotalGR,
            this.xrLabel4,
            this.xrLine1,
            this.xrDebeGR,
            this.xrHaberGR,
            this.xrLabel20});
            this.PieCuenta.HeightF = 36.45833F;
            this.PieCuenta.Name = "PieCuenta";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(442.7097F, 23F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(143.13F, 11F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "SALDO FINAL  --->";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 1F;
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(446.7097F, 2.000014F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(290F, 5F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // xrDebeGR
            // 
            this.xrDebeGR.CanGrow = false;
            this.xrDebeGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.debe", "{0:n2}")});
            this.xrDebeGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrDebeGR.LocationFloat = new DevExpress.Utils.PointFloat(591.0183F, 8.999984F);
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
            // xrHaberGR
            // 
            this.xrHaberGR.CanGrow = false;
            this.xrHaberGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.haber")});
            this.xrHaberGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrHaberGR.LocationFloat = new DevExpress.Utils.PointFloat(666.0298F, 9F);
            this.xrHaberGR.Name = "xrHaberGR";
            this.xrHaberGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHaberGR.SizeF = new System.Drawing.SizeF(73.97F, 11F);
            this.xrHaberGR.StylePriority.UseFont = false;
            this.xrHaberGR.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrHaberGR.Summary = xrSummary3;
            this.xrHaberGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrHaberGR.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrHaberGR_SummaryGetResult);
            this.xrHaberGR.SummaryReset += new System.EventHandler(this.xrHaberGR_SummaryReset);
            this.xrHaberGR.SummaryRowChanged += new System.EventHandler(this.xrHaberGR_SummaryRowChanged);
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(442.7097F, 9F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(143.13F, 11F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Total Movimiento del Mes  ---> ";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotalGR
            // 
            this.xrTotalGR.CanGrow = false;
            this.xrTotalGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROCAJA.n_importe", "{0:n2}")});
            this.xrTotalGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrTotalGR.LocationFloat = new DevExpress.Utils.PointFloat(591.0184F, 21.99999F);
            this.xrTotalGR.Name = "xrTotalGR";
            this.xrTotalGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotalGR.SizeF = new System.Drawing.SizeF(145.6913F, 11F);
            this.xrTotalGR.StylePriority.UseFont = false;
            this.xrTotalGR.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTotalGR.Summary = xrSummary1;
            this.xrTotalGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTotalGR.XlsxFormatString = "";
            // 
            // rpt_LibroCaja
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GrupoCuenta,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.PageHeader,
            this.PieCuenta});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.MonedaExp,
            this.TitCuenta,
            this.ImpDebe,
            this.ImpHaber});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_LIBROCAJA";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(39, 48, 35, 59);
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
        private DevExpress.XtraReports.UI.XRLabel xrCuentaAsoc;
        private DevExpress.XtraReports.UI.XRLabel xrCuentaDescAsoc;
        private DevExpress.XtraReports.UI.XRLabel xrFecha;
        private DevExpress.XtraReports.UI.XRLabel xrDescripV;
        private DevExpress.XtraReports.UI.XRLabel xrVoucher;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoCuenta;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel46;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel51;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRLabel xrFechaFinMes;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel42;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel43;
        private DevExpress.XtraReports.UI.CalculatedField MonedaExp;
        private DevExpress.XtraReports.UI.XRLabel xrLabel65;
        private DevExpress.XtraReports.UI.XRLabel xrLabel50;
        private DevExpress.XtraReports.UI.XRLabel xrLabel49;
        private DevExpress.XtraReports.UI.XRLabel xrLabel48;
        private DevExpress.XtraReports.UI.XRLabel xrLabel47;
        private DevExpress.XtraReports.UI.CalculatedField TitCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrHaber;
        private DevExpress.XtraReports.UI.XRLabel xrDebe;
        private DevExpress.XtraReports.UI.CalculatedField ImpDebe;
        private DevExpress.XtraReports.UI.CalculatedField ImpHaber;
        private DevExpress.XtraReports.UI.GroupFooterBand PieCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrDebeGR;
        private DevExpress.XtraReports.UI.XRLabel xrHaberGR;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrTotalGR;
    }
}
