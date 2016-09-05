namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_CuentaCCteProv
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_CuentaCCteProv));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMoneda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCCosto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLocal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpDollar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitulo = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GrupoProvAccount = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPerIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPerFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmMoneda = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmProveedor = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCCosto = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPendiente = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.titFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.titPeriodoRango = new DevExpress.XtraReports.UI.CalculatedField();
            this.PieProvAccount = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.titProveedor = new DevExpress.XtraReports.UI.CalculatedField();
            this.titAccount = new DevExpress.XtraReports.UI.CalculatedField();
            this.regVoucher = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrFecha,
            this.xrPeriodo,
            this.xrMoneda,
            this.xrDocumento,
            this.xrCCosto,
            this.xrImpLocal,
            this.xrImpDollar,
            this.xrTitulo});
            this.Detail.Font = new System.Drawing.Font("Arial", 8F);
            this.Detail.HeightF = 19F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.regVoucher")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(117.8684F, 0.9999911F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(72.75664F, 18.00001F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrFecha
            // 
            this.xrFecha.CanGrow = false;
            this.xrFecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.fecha", "{0:dd/MM/yyyy}")});
            this.xrFecha.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1F);
            this.xrFecha.Name = "xrFecha";
            this.xrFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFecha.SizeF = new System.Drawing.SizeF(71.99998F, 18F);
            // 
            // xrPeriodo
            // 
            this.xrPeriodo.CanGrow = false;
            this.xrPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.period")});
            this.xrPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(71.99999F, 1F);
            this.xrPeriodo.Name = "xrPeriodo";
            this.xrPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPeriodo.SizeF = new System.Drawing.SizeF(45.86838F, 18F);
            this.xrPeriodo.Text = "xrPeriodo";
            // 
            // xrMoneda
            // 
            this.xrMoneda.CanGrow = false;
            this.xrMoneda.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.moneda")});
            this.xrMoneda.LocationFloat = new DevExpress.Utils.PointFloat(190.625F, 1F);
            this.xrMoneda.Name = "xrMoneda";
            this.xrMoneda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMoneda.SizeF = new System.Drawing.SizeF(37.5F, 18F);
            this.xrMoneda.Text = "xrMoneda";
            // 
            // xrDocumento
            // 
            this.xrDocumento.CanGrow = false;
            this.xrDocumento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.documento")});
            this.xrDocumento.LocationFloat = new DevExpress.Utils.PointFloat(228.125F, 1F);
            this.xrDocumento.Name = "xrDocumento";
            this.xrDocumento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDocumento.SizeF = new System.Drawing.SizeF(95.99997F, 18F);
            this.xrDocumento.Text = "xrDocumento";
            // 
            // xrCCosto
            // 
            this.xrCCosto.CanGrow = false;
            this.xrCCosto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.c_centrocosto")});
            this.xrCCosto.LocationFloat = new DevExpress.Utils.PointFloat(324.125F, 1F);
            this.xrCCosto.Name = "xrCCosto";
            this.xrCCosto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCCosto.SizeF = new System.Drawing.SizeF(40F, 18F);
            this.xrCCosto.Text = "xrCCosto";
            // 
            // xrImpLocal
            // 
            this.xrImpLocal.CanGrow = false;
            this.xrImpLocal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.importelocal", "{0:n2}")});
            this.xrImpLocal.LocationFloat = new DevExpress.Utils.PointFloat(364.1249F, 1F);
            this.xrImpLocal.Name = "xrImpLocal";
            this.xrImpLocal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpLocal.SizeF = new System.Drawing.SizeF(88.40582F, 18F);
            this.xrImpLocal.StylePriority.UseTextAlignment = false;
            this.xrImpLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpDollar
            // 
            this.xrImpDollar.CanGrow = false;
            this.xrImpDollar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.importedollar", "{0:n2}")});
            this.xrImpDollar.LocationFloat = new DevExpress.Utils.PointFloat(452.5308F, 1F);
            this.xrImpDollar.Name = "xrImpDollar";
            this.xrImpDollar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpDollar.SizeF = new System.Drawing.SizeF(90.76083F, 18F);
            this.xrImpDollar.StylePriority.UseTextAlignment = false;
            this.xrImpDollar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTitulo
            // 
            this.xrTitulo.CanGrow = false;
            this.xrTitulo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.titulo")});
            this.xrTitulo.LocationFloat = new DevExpress.Utils.PointFloat(543.2916F, 1F);
            this.xrTitulo.Name = "xrTitulo";
            this.xrTitulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitulo.SizeF = new System.Drawing.SizeF(208.7084F, 18F);
            this.xrTitulo.Text = "xrTitulo";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 29F;
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
            storedProcQuery1.Name = "sp_cb_ccte_prov";
            queryParameter1.Name = "@Compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@PerIni";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPerIni]", typeof(string));
            queryParameter3.Name = "@PerFin";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPerFin]", typeof(string));
            queryParameter4.Name = "@CtaIni";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaIni]", typeof(string));
            queryParameter5.Name = "@CtaFin";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaFin]", typeof(string));
            queryParameter6.Name = "@Moneda";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.prmMoneda]", typeof(string));
            queryParameter7.Name = "@Proveedor";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.prmProveedor]", typeof(string));
            queryParameter8.Name = "@CenCosto";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCCosto]", typeof(string));
            queryParameter9.Name = "@Pendiente";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPendiente]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.Parameters.Add(queryParameter8);
            storedProcQuery1.Parameters.Add(queryParameter9);
            storedProcQuery1.StoredProcName = "sp_cb_ccte_prov";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GrupoProvAccount
            // 
            this.GrupoProvAccount.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel2,
            this.xrLabel1});
            this.GrupoProvAccount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.GrupoProvAccount.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("proveedor", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("Account", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoProvAccount.HeightF = 23.5F;
            this.GrupoProvAccount.Name = "GrupoProvAccount";
            this.GrupoProvAccount.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(3.000005F, 19.83334F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(746.0001F, 2F);
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.titAccount")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(479.75F, 3.000005F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(170.8334F, 16F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.proveedor")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 3.000005F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(456.6667F, 16F);
            this.xrLabel1.Text = "xrLabel1";
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
            // prmPerIni
            // 
            this.prmPerIni.Name = "prmPerIni";
            // 
            // prmPerFin
            // 
            this.prmPerFin.Name = "prmPerFin";
            // 
            // prmCtaIni
            // 
            this.prmCtaIni.Name = "prmCtaIni";
            // 
            // prmCtaFin
            // 
            this.prmCtaFin.Name = "prmCtaFin";
            // 
            // prmMoneda
            // 
            this.prmMoneda.Name = "prmMoneda";
            // 
            // prmProveedor
            // 
            this.prmProveedor.Name = "prmProveedor";
            // 
            // prmCCosto
            // 
            this.prmCCosto.Name = "prmCCosto";
            // 
            // prmPendiente
            // 
            this.prmPendiente.Name = "prmPendiente";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel35,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel30,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrPageInfo3,
            this.xrLabel23});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 89.58334F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 69.58335F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(72F, 17.79F);
            this.xrLabel35.StylePriority.UseBorders = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "Fecha";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel34
            // 
            this.xrLabel34.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(71.99999F, 69.58168F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(50.29565F, 17.79166F);
            this.xrLabel34.StylePriority.UseBorders = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "Periodo";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(123.6627F, 69.58168F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(66.96231F, 17.79166F);
            this.xrLabel33.StylePriority.UseBorders = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "Voucher";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(190.625F, 69.58335F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(37.5F, 17.79166F);
            this.xrLabel32.StylePriority.UseBorders = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Mda";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(228.125F, 69.58335F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(96F, 17.79F);
            this.xrLabel31.StylePriority.UseBorders = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Documento";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(324.125F, 69.58502F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(40F, 17.79F);
            this.xrLabel30.StylePriority.UseBorders = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "C. C.";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(364.1249F, 69.58335F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(89.58334F, 17.79166F);
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Imp. Local";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(453.7083F, 69.58168F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(89.58334F, 17.79166F);
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Imp. Dolar";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(543.2916F, 69.58335F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(208.7084F, 17.79166F);
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Titulo del Voucher";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel26
            // 
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.titPeriodoRango")});
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(182.25F, 39.41668F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(407.2917F, 17.79167F);
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "xrLabel26";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel25
            // 
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.descripcion")});
            this.xrLabel25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(190.625F, 15.70833F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.Text = "xrLabel25";
            // 
            // xrLabel24
            // 
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.titFecHoy", "{0:dd/MM/yyyy}")});
            this.xrLabel24.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(687.3315F, 1.70834F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(59.66846F, 12.99999F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(601.9149F, 17.00002F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(145.0851F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(182.25F, 18.00001F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(407.2917F, 21.41667F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "CUENTA CORRIENTE DETALLADA DE PROVEEDORES";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // titFecHoy
            // 
            this.titFecHoy.DataMember = "sp_cb_ccte_prov";
            this.titFecHoy.Expression = "Today()";
            this.titFecHoy.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime;
            this.titFecHoy.Name = "titFecHoy";
            // 
            // titPeriodoRango
            // 
            this.titPeriodoRango.DataMember = "sp_cb_ccte_prov";
            this.titPeriodoRango.Expression = "\'PERIODO DEL \' +  [Parameters.prmPerIni] + \'  AL \' + [Parameters.prmPerFin]";
            this.titPeriodoRango.Name = "titPeriodoRango";
            // 
            // PieProvAccount
            // 
            this.PieProvAccount.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7});
            this.PieProvAccount.Font = new System.Drawing.Font("Arial", 8F);
            this.PieProvAccount.HeightF = 32.29167F;
            this.PieProvAccount.Name = "PieProvAccount";
            this.PieProvAccount.StylePriority.UseFont = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(3.00001F, 22.79166F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(746.0001F, 2F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.importelocal", "{0:n2}")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(365.3025F, 3.000007F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(88.40582F, 18F);
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel5.Summary = xrSummary1;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.importedollar", "{0:n2}")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(453.7083F, 3.000007F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(90.76083F, 18F);
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(268.125F, 3.000007F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(96F, 17.79F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Saldo Final :";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // titProveedor
            // 
            this.titProveedor.DataMember = "sp_cb_ccte_prov";
            this.titProveedor.Expression = "\'PROVEEDOR : \' + [proveedor] + \' - \' +  [NombreCompleto]";
            this.titProveedor.Name = "titProveedor";
            // 
            // titAccount
            // 
            this.titAccount.DataMember = "sp_cb_ccte_prov";
            this.titAccount.Expression = "\'CUENTA :\' +  [Account]";
            this.titAccount.Name = "titAccount";
            // 
            // regVoucher
            // 
            this.regVoucher.DataMember = "sp_cb_ccte_prov";
            this.regVoucher.Expression = "[tipovoucher] + \' - \' + [voucherno]";
            this.regVoucher.Name = "regVoucher";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(633.1649F, 1.291688F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(54.16669F, 15.70833F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Fecha:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // rpt_CuentaCCteProv
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GrupoProvAccount,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.PageHeader,
            this.PieProvAccount});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.titFecHoy,
            this.titPeriodoRango,
            this.titProveedor,
            this.titAccount,
            this.regVoucher});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "sp_cb_ccte_prov";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(39, 36, 29, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPerIni,
            this.prmPerFin,
            this.prmCtaIni,
            this.prmCtaFin,
            this.prmMoneda,
            this.prmProveedor,
            this.prmCCosto,
            this.prmPendiente});
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
        private DevExpress.XtraReports.UI.XRLabel xrPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrMoneda;
        private DevExpress.XtraReports.UI.XRLabel xrDocumento;
        private DevExpress.XtraReports.UI.XRLabel xrCCosto;
        private DevExpress.XtraReports.UI.XRLabel xrImpLocal;
        private DevExpress.XtraReports.UI.XRLabel xrImpDollar;
        private DevExpress.XtraReports.UI.XRLabel xrTitulo;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoProvAccount;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPerIni;
        private DevExpress.XtraReports.Parameters.Parameter prmPerFin;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaIni;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaFin;
        private DevExpress.XtraReports.Parameters.Parameter prmMoneda;
        private DevExpress.XtraReports.Parameters.Parameter prmProveedor;
        private DevExpress.XtraReports.Parameters.Parameter prmCCosto;
        private DevExpress.XtraReports.Parameters.Parameter prmPendiente;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.CalculatedField titFecHoy;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.CalculatedField titPeriodoRango;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel34;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.GroupFooterBand PieProvAccount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField titProveedor;
        private DevExpress.XtraReports.UI.CalculatedField titAccount;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.CalculatedField regVoucher;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    }
}
