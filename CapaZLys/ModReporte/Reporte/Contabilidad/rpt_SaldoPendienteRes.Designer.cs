namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_SaldoPendienteRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_SaldoPendienteRes));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPeriod = new DevExpress.XtraReports.UI.XRLabel();
            this.xrVoucherNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDolar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLocal = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine7 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTotDol = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoReporte = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCuenta = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCompaniaNom = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.titFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.titPeriodo = new DevExpress.XtraReports.UI.CalculatedField();
            this.titCuenta = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrFecha,
            this.xrPeriod,
            this.xrVoucherNo,
            this.xrDolar,
            this.xrLocal,
            this.xrLabel1,
            this.xrLabel4});
            this.Detail.Font = new System.Drawing.Font("Arial", 8F);
            this.Detail.HeightF = 19.625F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrFecha
            // 
            this.xrFecha.CanGrow = false;
            this.xrFecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.exchangerateperiod")});
            this.xrFecha.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.624997F);
            this.xrFecha.Name = "xrFecha";
            this.xrFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFecha.SizeF = new System.Drawing.SizeF(66.54F, 15F);
            this.xrFecha.Text = "xrFecha";
            // 
            // xrPeriod
            // 
            this.xrPeriod.CanGrow = false;
            this.xrPeriod.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.period")});
            this.xrPeriod.LocationFloat = new DevExpress.Utils.PointFloat(66.53996F, 1.624997F);
            this.xrPeriod.Name = "xrPeriod";
            this.xrPeriod.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPeriod.SizeF = new System.Drawing.SizeF(62.30999F, 15F);
            this.xrPeriod.Text = "xrPeriod";
            // 
            // xrVoucherNo
            // 
            this.xrVoucherNo.CanGrow = false;
            this.xrVoucherNo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.voucherno")});
            this.xrVoucherNo.LocationFloat = new DevExpress.Utils.PointFloat(128.8499F, 1.624997F);
            this.xrVoucherNo.Name = "xrVoucherNo";
            this.xrVoucherNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrVoucherNo.SizeF = new System.Drawing.SizeF(74.43004F, 15F);
            this.xrVoucherNo.Text = "xrVoucherNo";
            // 
            // xrDolar
            // 
            this.xrDolar.CanGrow = false;
            this.xrDolar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.dollaramount", "{0:n2}")});
            this.xrDolar.LocationFloat = new DevExpress.Utils.PointFloat(576.9133F, 1.624997F);
            this.xrDolar.Name = "xrDolar";
            this.xrDolar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDolar.SizeF = new System.Drawing.SizeF(91.75671F, 15F);
            this.xrDolar.StylePriority.UseTextAlignment = false;
            this.xrDolar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLocal
            // 
            this.xrLocal.CanGrow = false;
            this.xrLocal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.localamount", "{0:n2}")});
            this.xrLocal.LocationFloat = new DevExpress.Utils.PointFloat(668.67F, 1.624997F);
            this.xrLocal.Name = "xrLocal";
            this.xrLocal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLocal.SizeF = new System.Drawing.SizeF(81.71655F, 15F);
            this.xrLocal.StylePriority.UseTextAlignment = false;
            this.xrLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 30F;
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
            storedProcQuery1.Name = "sp_cb_inv_documento_pendiente";
            queryParameter1.Name = "@Compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@Periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@Cuenta";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCuenta]", typeof(string));
            queryParameter4.Name = "@TipoRep";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoReporte]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.StoredProcName = "sp_cb_inv_documento_pendiente";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
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
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLine7,
            this.xrTotDol,
            this.xrTotLoc});
            this.reportFooterBand1.HeightF = 28.95832F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            // 
            // xrLabel23
            // 
            this.xrLabel23.CanGrow = false;
            this.xrLabel23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(443.714F, 6.00001F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(124.6517F, 15.17F);
            this.xrLabel23.StyleName = "FieldCaption";
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Totales:";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine7
            // 
            this.xrLine7.LocationFloat = new DevExpress.Utils.PointFloat(576.9133F, 1.746651F);
            this.xrLine7.Name = "xrLine7";
            this.xrLine7.SizeF = new System.Drawing.SizeF(173.4732F, 2F);
            // 
            // xrTotDol
            // 
            this.xrTotDol.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.dollaramount", "{0:C2}")});
            this.xrTotDol.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTotDol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrTotDol.LocationFloat = new DevExpress.Utils.PointFloat(576.9133F, 6.000007F);
            this.xrTotDol.Name = "xrTotDol";
            this.xrTotDol.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotDol.SizeF = new System.Drawing.SizeF(77.17227F, 18F);
            this.xrTotDol.StyleName = "FieldCaption";
            this.xrTotDol.StylePriority.UseFont = false;
            this.xrTotDol.StylePriority.UseForeColor = false;
            this.xrTotDol.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTotDol.Summary = xrSummary1;
            this.xrTotDol.Text = "xrTotDol";
            this.xrTotDol.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotLoc
            // 
            this.xrTotLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.localamount", "{0:C2}")});
            this.xrTotLoc.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTotLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrTotLoc.LocationFloat = new DevExpress.Utils.PointFloat(654.0858F, 6.000007F);
            this.xrTotLoc.Name = "xrTotLoc";
            this.xrTotLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotLoc.SizeF = new System.Drawing.SizeF(96.30084F, 18F);
            this.xrTotLoc.StyleName = "FieldCaption";
            this.xrTotLoc.StylePriority.UseFont = false;
            this.xrTotLoc.StylePriority.UseForeColor = false;
            this.xrTotLoc.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTotLoc.Summary = xrSummary2;
            this.xrTotLoc.Text = "xrTotLoc";
            this.xrTotLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            // prmTipoReporte
            // 
            this.prmTipoReporte.Name = "prmTipoReporte";
            // 
            // prmCuenta
            // 
            this.prmCuenta.Name = "prmCuenta";
            // 
            // prmPeriodo
            // 
            this.prmPeriodo.Name = "prmPeriodo";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel5,
            this.xrLine1,
            this.xrLabel3,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLine3,
            this.xrLabel30,
            this.xrLabel29,
            this.xrCompaniaNom,
            this.xrPageInfo3,
            this.xrLabel17,
            this.xrLabel27,
            this.xrLabel28});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F);
            this.PageHeader.HeightF = 71.16667F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 67.91667F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(748F, 2F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(668.67F, 52.91667F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(81.71655F, 15F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Importe S/.";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(576.9133F, 52.91667F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(91.75668F, 15F);
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Importe USD";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(128.85F, 52.91667F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(74.43F, 15F);
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Voucher";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(66.53996F, 52.91667F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(62.31F, 15F);
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Periodo";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 52.91667F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(66.54F, 15F);
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Fecha";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.91666F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(748F, 2F);
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.titCuenta")});
            this.xrLabel30.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(152.71F, 27.00001F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(433.7885F, 18F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "xrLabel30";
            // 
            // xrLabel29
            // 
            this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.titPeriodo")});
            this.xrLabel29.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(7.999992F, 27.00001F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(120.85F, 18F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "xrLabel29";
            // 
            // xrCompaniaNom
            // 
            this.xrCompaniaNom.CanGrow = false;
            this.xrCompaniaNom.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrCompaniaNom.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 0F);
            this.xrCompaniaNom.Name = "xrCompaniaNom";
            this.xrCompaniaNom.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCompaniaNom.SizeF = new System.Drawing.SizeF(160.4167F, 21.00001F);
            this.xrCompaniaNom.StylePriority.UseFont = false;
            this.xrCompaniaNom.Text = "xrCompaniaNom";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(609.7899F, 15.29169F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(145.0851F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.titFecHoy", "{0:dd/MM/yyyy}")});
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(697.3315F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(59.66846F, 12.99999F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(642.1649F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(54.16669F, 13F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Fecha:";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(179.2084F, 3.000005F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(407.29F, 18F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "INVENTARIO DE DOCUMENTOS PENDIENTES";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // titFecHoy
            // 
            this.titFecHoy.DataMember = "sp_cb_inv_documento_pendiente";
            this.titFecHoy.Expression = "LocalDateTimeToday()";
            this.titFecHoy.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime;
            this.titFecHoy.Name = "titFecHoy";
            // 
            // titPeriodo
            // 
            this.titPeriodo.DataMember = "sp_cb_inv_documento_pendiente";
            this.titPeriodo.Expression = "\'PERIODO : \' + Substring([Parameters.prmPeriodo],0,4) + \'-\'+ Substring([Parameter" +
    "s.prmPeriodo],4, 2 )";
            this.titPeriodo.Name = "titPeriodo";
            // 
            // titCuenta
            // 
            this.titCuenta.DataMember = "sp_cb_inv_documento_pendiente";
            this.titCuenta.Expression = "\'CUENTA : \' +  [Parameters.prmCuenta] + \' \'  + [nombrecuenta]";
            this.titCuenta.Name = "titCuenta";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.proveedor")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(203.28F, 1.624997F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(63.54163F, 15F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_inv_documento_pendiente.c_NombreCompleto")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(266.8217F, 1.624997F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(296.544F, 15F);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(266.8217F, 52.91667F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(296.544F, 15F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Nombre Proveedor";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(203.28F, 52.91667F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(63.54166F, 15F);
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Proveedor";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // rpt_SaldoPendienteRes
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.titFecHoy,
            this.titPeriodo,
            this.titCuenta});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "sp_cb_inv_documento_pendiente";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(34, 35, 30, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmCuenta,
            this.prmTipoReporte});
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
        private DevExpress.XtraReports.UI.XRLabel xrFecha;
        private DevExpress.XtraReports.UI.XRLabel xrPeriod;
        private DevExpress.XtraReports.UI.XRLabel xrVoucherNo;
        private DevExpress.XtraReports.UI.XRLabel xrDolar;
        private DevExpress.XtraReports.UI.XRLabel xrLocal;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRLabel xrTotDol;
        private DevExpress.XtraReports.UI.XRLabel xrTotLoc;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoReporte;
        private DevExpress.XtraReports.Parameters.Parameter prmCuenta;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.CalculatedField titFecHoy;
        private DevExpress.XtraReports.UI.XRLabel xrCompaniaNom;
        private DevExpress.XtraReports.UI.CalculatedField titPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.CalculatedField titCuenta;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLine xrLine7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    }
}
