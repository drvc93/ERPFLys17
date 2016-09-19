namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Varios
{
    partial class rpt_RegistroCompraDaotRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_RegistroCompraDaotRes));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrFlagPaso = new DevExpress.XtraReports.UI.XRCheckBox();
            this.xrCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCodSunatC = new DevExpress.XtraReports.UI.XRLabel();
            this.xrClienteRuc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrClienteNombre = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBaseLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotalLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xr2UIT = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmFlagSupera = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitLimite = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTituloGen = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitFecHoy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitCompania = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.TitFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.titPeriodo = new DevExpress.XtraReports.UI.CalculatedField();
            this.titLimite = new DevExpress.XtraReports.UI.CalculatedField();
            this.PieSummary = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTitPieNroReg = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBaseLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotalLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.titPieNroReg = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrFlagPaso,
            this.xrCliente,
            this.xrCodSunatC,
            this.xrClienteRuc,
            this.xrClienteNombre,
            this.xrBaseLoc,
            this.xrImpLoc,
            this.xrTotalLoc,
            this.xr2UIT});
            this.Detail.Font = new System.Drawing.Font("Arial", 8F);
            this.Detail.HeightF = 18F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrFlagPaso
            // 
            this.xrFlagPaso.LocationFloat = new DevExpress.Utils.PointFloat(702.022F, 0F);
            this.xrFlagPaso.Name = "xrFlagPaso";
            this.xrFlagPaso.SizeF = new System.Drawing.SizeF(16F, 18F);
            this.xrFlagPaso.StylePriority.UseTextAlignment = false;
            this.xrFlagPaso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCliente
            // 
            this.xrCliente.CanGrow = false;
            this.xrCliente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.n_cliente")});
            this.xrCliente.Font = new System.Drawing.Font("Arial", 8F);
            this.xrCliente.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 0F);
            this.xrCliente.Name = "xrCliente";
            this.xrCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCliente.SizeF = new System.Drawing.SizeF(54.99997F, 18F);
            this.xrCliente.StyleName = "DataField";
            this.xrCliente.StylePriority.UseFont = false;
            this.xrCliente.StylePriority.UseTextAlignment = false;
            this.xrCliente.Text = "xrCliente";
            this.xrCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrCodSunatC
            // 
            this.xrCodSunatC.CanGrow = false;
            this.xrCodSunatC.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.c_codigosunat_c")});
            this.xrCodSunatC.Font = new System.Drawing.Font("Arial", 8F);
            this.xrCodSunatC.LocationFloat = new DevExpress.Utils.PointFloat(61F, 0F);
            this.xrCodSunatC.Name = "xrCodSunatC";
            this.xrCodSunatC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCodSunatC.SizeF = new System.Drawing.SizeF(53F, 18F);
            this.xrCodSunatC.StyleName = "DataField";
            this.xrCodSunatC.StylePriority.UseFont = false;
            this.xrCodSunatC.StylePriority.UseTextAlignment = false;
            this.xrCodSunatC.Text = "xrCodSunatC";
            this.xrCodSunatC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrClienteRuc
            // 
            this.xrClienteRuc.CanGrow = false;
            this.xrClienteRuc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.c_clienteruc")});
            this.xrClienteRuc.Font = new System.Drawing.Font("Arial", 8F);
            this.xrClienteRuc.LocationFloat = new DevExpress.Utils.PointFloat(114F, 0F);
            this.xrClienteRuc.Name = "xrClienteRuc";
            this.xrClienteRuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrClienteRuc.SizeF = new System.Drawing.SizeF(95.00002F, 18F);
            this.xrClienteRuc.StyleName = "DataField";
            this.xrClienteRuc.StylePriority.UseFont = false;
            this.xrClienteRuc.Text = "xrClienteRuc";
            // 
            // xrClienteNombre
            // 
            this.xrClienteNombre.CanGrow = false;
            this.xrClienteNombre.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.c_clientenombre")});
            this.xrClienteNombre.Font = new System.Drawing.Font("Arial", 8F);
            this.xrClienteNombre.LocationFloat = new DevExpress.Utils.PointFloat(209.875F, 0F);
            this.xrClienteNombre.Name = "xrClienteNombre";
            this.xrClienteNombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrClienteNombre.SizeF = new System.Drawing.SizeF(148.1882F, 18F);
            this.xrClienteNombre.StyleName = "DataField";
            this.xrClienteNombre.StylePriority.UseFont = false;
            this.xrClienteNombre.Text = "xrClienteNombre";
            // 
            // xrBaseLoc
            // 
            this.xrBaseLoc.CanGrow = false;
            this.xrBaseLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.base_loc", "{0:n2}")});
            this.xrBaseLoc.Font = new System.Drawing.Font("Arial", 8F);
            this.xrBaseLoc.LocationFloat = new DevExpress.Utils.PointFloat(358.0633F, 0F);
            this.xrBaseLoc.Name = "xrBaseLoc";
            this.xrBaseLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBaseLoc.SizeF = new System.Drawing.SizeF(85.41177F, 18F);
            this.xrBaseLoc.StyleName = "DataField";
            this.xrBaseLoc.StylePriority.UseFont = false;
            this.xrBaseLoc.StylePriority.UseTextAlignment = false;
            this.xrBaseLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpLoc
            // 
            this.xrImpLoc.CanGrow = false;
            this.xrImpLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.impuestos_loc", "{0:n2}")});
            this.xrImpLoc.Font = new System.Drawing.Font("Arial", 8F);
            this.xrImpLoc.LocationFloat = new DevExpress.Utils.PointFloat(443.475F, 0F);
            this.xrImpLoc.Name = "xrImpLoc";
            this.xrImpLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpLoc.SizeF = new System.Drawing.SizeF(75.99994F, 18F);
            this.xrImpLoc.StyleName = "DataField";
            this.xrImpLoc.StylePriority.UseFont = false;
            this.xrImpLoc.StylePriority.UseTextAlignment = false;
            this.xrImpLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotalLoc
            // 
            this.xrTotalLoc.CanGrow = false;
            this.xrTotalLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.total_loc", "{0:n2}")});
            this.xrTotalLoc.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTotalLoc.LocationFloat = new DevExpress.Utils.PointFloat(519.8749F, 0F);
            this.xrTotalLoc.Name = "xrTotalLoc";
            this.xrTotalLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotalLoc.SizeF = new System.Drawing.SizeF(85.00006F, 18F);
            this.xrTotalLoc.StyleName = "DataField";
            this.xrTotalLoc.StylePriority.UseFont = false;
            this.xrTotalLoc.StylePriority.UseTextAlignment = false;
            this.xrTotalLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xr2UIT
            // 
            this.xr2UIT.CanGrow = false;
            this.xr2UIT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.n_2UIT", "{0:n2}")});
            this.xr2UIT.Font = new System.Drawing.Font("Arial", 8F);
            this.xr2UIT.LocationFloat = new DevExpress.Utils.PointFloat(604.875F, 0F);
            this.xr2UIT.Name = "xr2UIT";
            this.xr2UIT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr2UIT.SizeF = new System.Drawing.SizeF(75F, 18F);
            this.xr2UIT.StyleName = "DataField";
            this.xr2UIT.StylePriority.UseFont = false;
            this.xr2UIT.StylePriority.UseTextAlignment = false;
            this.xr2UIT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 28F;
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
            storedProcQuery1.Name = "SP_CB_REP_REGCOMPRAS_DAOT";
            queryParameter1.Name = "@Compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@Periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@FlagSupera";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmFlagSupera]", typeof(string));
            queryParameter4.Name = "@Tipo";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoConsulta]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.StoredProcName = "SP_CB_REP_REGCOMPRAS_DAOT";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 90.79167F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(723F, 2F);
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
            // prmFlagSupera
            // 
            this.prmFlagSupera.Name = "prmFlagSupera";
            // 
            // prmTipoConsulta
            // 
            this.prmTipoConsulta.Name = "prmTipoConsulta";
            this.prmTipoConsulta.Type = typeof(int);
            this.prmTipoConsulta.ValueInfo = "0";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel32,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel27,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrTitLimite,
            this.xrTitPeriodo,
            this.xrTituloGen,
            this.xrTitFecHoy,
            this.xrPageInfo3,
            this.xrLabel26,
            this.xrTitCompania,
            this.xrLabel61,
            this.xrLine1});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 111.4583F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 108.7917F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(723F, 2F);
            // 
            // xrLabel32
            // 
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(679.875F, 92.79169F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(50F, 16F);
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "> Limite";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(604.875F, 92.79169F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(75F, 16F);
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Limite";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(519.875F, 92.79169F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(85F, 16F);
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Total S/.";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(443.475F, 92.79169F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(76F, 16F);
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "IVG";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(358.0634F, 92.79169F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(85.41168F, 16F);
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Valor Venta S/.";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(209F, 92.79169F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(149.0633F, 16F);
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Razon Social";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel25
            // 
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(114F, 92.79169F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(95F, 16F);
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Documento";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel24
            // 
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(61F, 92.79169F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(53F, 16F);
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Cod Doc.";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 92.79167F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(55F, 16F);
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Cod. Cli.";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitLimite
            // 
            this.xrTitLimite.CanGrow = false;
            this.xrTitLimite.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.titLimite")});
            this.xrTitLimite.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 68.54169F);
            this.xrTitLimite.Name = "xrTitLimite";
            this.xrTitLimite.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitLimite.SizeF = new System.Drawing.SizeF(702.0001F, 15.70834F);
            this.xrTitLimite.StylePriority.UseTextAlignment = false;
            this.xrTitLimite.Text = "xrTitLimite";
            this.xrTitLimite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitPeriodo
            // 
            this.xrTitPeriodo.CanGrow = false;
            this.xrTitPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.titPeriodo")});
            this.xrTitPeriodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrTitPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 50.75F);
            this.xrTitPeriodo.Name = "xrTitPeriodo";
            this.xrTitPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitPeriodo.SizeF = new System.Drawing.SizeF(702F, 17.79167F);
            this.xrTitPeriodo.StylePriority.UseFont = false;
            this.xrTitPeriodo.StylePriority.UseTextAlignment = false;
            this.xrTitPeriodo.Text = "xrTitPeriodo";
            this.xrTitPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTituloGen
            // 
            this.xrTituloGen.CanGrow = false;
            this.xrTituloGen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrTituloGen.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 33.74999F);
            this.xrTituloGen.Name = "xrTituloGen";
            this.xrTituloGen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTituloGen.SizeF = new System.Drawing.SizeF(702F, 17F);
            this.xrTituloGen.StylePriority.UseFont = false;
            this.xrTituloGen.StylePriority.UseTextAlignment = false;
            this.xrTituloGen.Text = "REGISTRO DE COMPRAS - RESUMEN (COSTOS)";
            this.xrTituloGen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitFecHoy
            // 
            this.xrTitFecHoy.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.TitFecHoy", "{0:dd/MM/yyyy}")});
            this.xrTitFecHoy.LocationFloat = new DevExpress.Utils.PointFloat(623.022F, 16.75F);
            this.xrTitFecHoy.Name = "xrTitFecHoy";
            this.xrTitFecHoy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitFecHoy.SizeF = new System.Drawing.SizeF(84.97797F, 16.74999F);
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(582.397F, 1.041667F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(125.603F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(582.397F, 16.75F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(40.62506F, 16.74999F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "Fecha:";
            // 
            // xrTitCompania
            // 
            this.xrTitCompania.CanGrow = false;
            this.xrTitCompania.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrTitCompania.LocationFloat = new DevExpress.Utils.PointFloat(90.25001F, 0F);
            this.xrTitCompania.Name = "xrTitCompania";
            this.xrTitCompania.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitCompania.SizeF = new System.Drawing.SizeF(275F, 16.75F);
            this.xrTitCompania.StylePriority.UseFont = false;
            this.xrTitCompania.Text = "---";
            // 
            // xrLabel61
            // 
            this.xrLabel61.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 0F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(81.25F, 16.75F);
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.Text = "EMPRESA :";
            // 
            // TitFecHoy
            // 
            this.TitFecHoy.DataMember = "SP_CB_REP_REGCOMPRAS_DAOT";
            this.TitFecHoy.Expression = "today()";
            this.TitFecHoy.Name = "TitFecHoy";
            // 
            // titPeriodo
            // 
            this.titPeriodo.DataMember = "SP_CB_REP_REGCOMPRAS_DAOT";
            this.titPeriodo.Expression = "\'Periodo: \' +  [Parameters.prmPeriodo]";
            this.titPeriodo.Name = "titPeriodo";
            // 
            // titLimite
            // 
            this.titLimite.DataMember = "SP_CB_REP_REGCOMPRAS_DAOT";
            this.titLimite.Expression = "\'Paso Limite: \' + iif([Parameters.prmFlagSupera]=\'T\',\'Ambos\',iif([Parameters.prmF" +
    "lagSupera]=\'S\',\'SI\',\'NO\'))";
            this.titLimite.Name = "titLimite";
            // 
            // PieSummary
            // 
            this.PieSummary.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTitPieNroReg,
            this.xrLine4,
            this.xrLabel4,
            this.xrBaseLocTot,
            this.xrImpLocTot,
            this.xrTotalLocTot,
            this.xrLine3});
            this.PieSummary.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PieSummary.HeightF = 27.08333F;
            this.PieSummary.Name = "PieSummary";
            this.PieSummary.StylePriority.UseFont = false;
            this.PieSummary.StylePriority.UseTextAlignment = false;
            this.PieSummary.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTitPieNroReg
            // 
            this.xrTitPieNroReg.CanGrow = false;
            this.xrTitPieNroReg.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.titPieNroReg")});
            this.xrTitPieNroReg.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 3.999996F);
            this.xrTitPieNroReg.Name = "xrTitPieNroReg";
            this.xrTitPieNroReg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitPieNroReg.SizeF = new System.Drawing.SizeF(203F, 17.25002F);
            this.xrTitPieNroReg.StylePriority.UseTextAlignment = false;
            this.xrTitPieNroReg.Text = "xrTitPieNroReg";
            this.xrTitPieNroReg.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(310.1466F, 21.99999F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(292F, 2F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(310.1466F, 3.000005F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(47.91669F, 19F);
            this.xrLabel4.Text = "Totales:";
            // 
            // xrBaseLocTot
            // 
            this.xrBaseLocTot.CanGrow = false;
            this.xrBaseLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.base_loc", "{0:n2}")});
            this.xrBaseLocTot.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrBaseLocTot.LocationFloat = new DevExpress.Utils.PointFloat(358.0633F, 4.000007F);
            this.xrBaseLocTot.Name = "xrBaseLocTot";
            this.xrBaseLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBaseLocTot.SizeF = new System.Drawing.SizeF(85.41177F, 18F);
            this.xrBaseLocTot.StyleName = "DataField";
            this.xrBaseLocTot.StylePriority.UseFont = false;
            this.xrBaseLocTot.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrBaseLocTot.Summary = xrSummary1;
            this.xrBaseLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpLocTot
            // 
            this.xrImpLocTot.CanGrow = false;
            this.xrImpLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.impuestos_loc", "{0:n2}")});
            this.xrImpLocTot.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrImpLocTot.LocationFloat = new DevExpress.Utils.PointFloat(443.4751F, 4.000007F);
            this.xrImpLocTot.Name = "xrImpLocTot";
            this.xrImpLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpLocTot.SizeF = new System.Drawing.SizeF(75.99994F, 18F);
            this.xrImpLocTot.StyleName = "DataField";
            this.xrImpLocTot.StylePriority.UseFont = false;
            this.xrImpLocTot.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrImpLocTot.Summary = xrSummary2;
            this.xrImpLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotalLocTot
            // 
            this.xrTotalLocTot.CanGrow = false;
            this.xrTotalLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGCOMPRAS_DAOT.total_loc", "{0:n2}")});
            this.xrTotalLocTot.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrTotalLocTot.LocationFloat = new DevExpress.Utils.PointFloat(519.875F, 4.000007F);
            this.xrTotalLocTot.Name = "xrTotalLocTot";
            this.xrTotalLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotalLocTot.SizeF = new System.Drawing.SizeF(85.00006F, 18F);
            this.xrTotalLocTot.StyleName = "DataField";
            this.xrTotalLocTot.StylePriority.UseFont = false;
            this.xrTotalLocTot.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTotalLocTot.Summary = xrSummary3;
            this.xrTotalLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 1F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(723F, 2F);
            // 
            // titPieNroReg
            // 
            this.titPieNroReg.DataMember = "SP_CB_REP_REGCOMPRAS_DAOT";
            this.titPieNroReg.Expression = "  [].Count()+ \' registro(s).\'";
            this.titPieNroReg.Name = "titPieNroReg";
            // 
            // rpt_RegistroCompraDaotRes
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.PageHeader,
            this.PieSummary});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TitFecHoy,
            this.titPeriodo,
            this.titLimite,
            this.titPieNroReg});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_REGCOMPRAS_DAOT";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(45, 49, 28, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmFlagSupera,
            this.prmTipoConsulta});
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
        private DevExpress.XtraReports.UI.XRLabel xrCliente;
        private DevExpress.XtraReports.UI.XRLabel xrCodSunatC;
        private DevExpress.XtraReports.UI.XRLabel xrClienteRuc;
        private DevExpress.XtraReports.UI.XRLabel xrClienteNombre;
        private DevExpress.XtraReports.UI.XRLabel xrBaseLoc;
        private DevExpress.XtraReports.UI.XRLabel xrImpLoc;
        private DevExpress.XtraReports.UI.XRLabel xrTotalLoc;
        private DevExpress.XtraReports.UI.XRLabel xr2UIT;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter prmFlagSupera;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoConsulta;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrTitCompania;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrTitFecHoy;
        private DevExpress.XtraReports.UI.CalculatedField TitFecHoy;
        private DevExpress.XtraReports.UI.XRLabel xrTituloGen;
        private DevExpress.XtraReports.UI.XRLabel xrTitPeriodo;
        private DevExpress.XtraReports.UI.CalculatedField titPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrTitLimite;
        private DevExpress.XtraReports.UI.CalculatedField titLimite;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRCheckBox xrFlagPaso;
        private DevExpress.XtraReports.UI.GroupFooterBand PieSummary;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel xrBaseLocTot;
        private DevExpress.XtraReports.UI.XRLabel xrImpLocTot;
        private DevExpress.XtraReports.UI.XRLabel xrTotalLocTot;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrTitPieNroReg;
        private DevExpress.XtraReports.UI.CalculatedField titPieNroReg;
    }
}
