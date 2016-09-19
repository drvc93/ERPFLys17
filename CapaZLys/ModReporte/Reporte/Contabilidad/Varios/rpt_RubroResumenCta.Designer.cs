namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Varios
{
    partial class rpt_RubroResumenCta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_RubroResumenCta));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrRubro = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExt = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocD = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtD = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GrupoClasificación = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTitClasificacion = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.PieClasificacion = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrMontoExtDGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocDGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitClasificacionGR = new DevExpress.XtraReports.UI.XRLabel();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitFecHoy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitCompania = new DevExpress.XtraReports.UI.XRLabel();
            this.TitFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.titTipoConsulta = new DevExpress.XtraReports.UI.CalculatedField();
            this.titConsulta = new DevExpress.XtraReports.UI.CalculatedField();
            this.titGrClasificacion = new DevExpress.XtraReports.UI.CalculatedField();
            this.titGrRubro = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRubro,
            this.xrMontoLoc,
            this.xrMontoExt,
            this.xrMontoLocD,
            this.xrMontoExtD});
            this.Detail.Font = new System.Drawing.Font("Arial", 8F);
            this.Detail.HeightF = 17.83333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrRubro
            // 
            this.xrRubro.CanGrow = false;
            this.xrRubro.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.c_rubro")});
            this.xrRubro.LocationFloat = new DevExpress.Utils.PointFloat(29.57996F, 0F);
            this.xrRubro.Name = "xrRubro";
            this.xrRubro.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRubro.SizeF = new System.Drawing.SizeF(319.6283F, 17.83333F);
            this.xrRubro.Text = "xrRubro";
            // 
            // xrMontoLoc
            // 
            this.xrMontoLoc.CanGrow = false;
            this.xrMontoLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.a_montolocal", "{0:#,#}")});
            this.xrMontoLoc.LocationFloat = new DevExpress.Utils.PointFloat(349.2083F, 0F);
            this.xrMontoLoc.Name = "xrMontoLoc";
            this.xrMontoLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLoc.SizeF = new System.Drawing.SizeF(78.00006F, 17.83333F);
            this.xrMontoLoc.StylePriority.UseTextAlignment = false;
            this.xrMontoLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExt
            // 
            this.xrMontoExt.CanGrow = false;
            this.xrMontoExt.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.a_montoext", "{0:#,#}")});
            this.xrMontoExt.LocationFloat = new DevExpress.Utils.PointFloat(427.2083F, 0F);
            this.xrMontoExt.Name = "xrMontoExt";
            this.xrMontoExt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExt.SizeF = new System.Drawing.SizeF(77.99994F, 17.83333F);
            this.xrMontoExt.StylePriority.UseTextAlignment = false;
            this.xrMontoExt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocD
            // 
            this.xrMontoLocD.CanGrow = false;
            this.xrMontoLocD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.d_montolocal", "{0:#,#}")});
            this.xrMontoLocD.LocationFloat = new DevExpress.Utils.PointFloat(505.2083F, 0F);
            this.xrMontoLocD.Name = "xrMontoLocD";
            this.xrMontoLocD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocD.SizeF = new System.Drawing.SizeF(77.99997F, 17.83333F);
            this.xrMontoLocD.StylePriority.UseTextAlignment = false;
            this.xrMontoLocD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtD
            // 
            this.xrMontoExtD.CanGrow = false;
            this.xrMontoExtD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.d_montoext", "{0:#,#}")});
            this.xrMontoExtD.LocationFloat = new DevExpress.Utils.PointFloat(583.2083F, 0F);
            this.xrMontoExtD.Name = "xrMontoExtD";
            this.xrMontoExtD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtD.SizeF = new System.Drawing.SizeF(78.00012F, 17.83333F);
            this.xrMontoExtD.StylePriority.UseTextAlignment = false;
            this.xrMontoExtD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 34F;
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
            storedProcQuery1.Name = "SP_CB_REPORTE_GASTOS_RUBROS";
            queryParameter1.Name = "@Compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@Periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@TipoConsulta";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoConsulta]", typeof(string));
            queryParameter4.Name = "@Consulta";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmConsulta]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.StoredProcName = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GrupoClasificación
            // 
            this.GrupoClasificación.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTitClasificacion});
            this.GrupoClasificación.Font = new System.Drawing.Font("Arial", 12F);
            this.GrupoClasificación.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("c_clasificacion", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoClasificación.HeightF = 22.45833F;
            this.GrupoClasificación.Name = "GrupoClasificación";
            this.GrupoClasificación.StylePriority.UseFont = false;
            // 
            // xrTitClasificacion
            // 
            this.xrTitClasificacion.CanGrow = false;
            this.xrTitClasificacion.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.c_clasificacion")});
            this.xrTitClasificacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.xrTitClasificacion.LocationFloat = new DevExpress.Utils.PointFloat(9.999998F, 1.000023F);
            this.xrTitClasificacion.Name = "xrTitClasificacion";
            this.xrTitClasificacion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitClasificacion.SizeF = new System.Drawing.SizeF(621F, 19F);
            this.xrTitClasificacion.StyleName = "DataField";
            this.xrTitClasificacion.StylePriority.UseFont = false;
            this.xrTitClasificacion.Text = "xrTitClasificacion";
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
            // PieClasificacion
            // 
            this.PieClasificacion.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.PieClasificacion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PieClasificacion.HeightF = 35.45834F;
            this.PieClasificacion.Name = "PieClasificacion";
            this.PieClasificacion.StylePriority.UseFont = false;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrMontoExtDGR,
            this.xrMontoLocDGR,
            this.xrMontoExtGR,
            this.xrMontoLocGR,
            this.xrTitClasificacionGR});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(92.99997F, 4.000019F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(578.33F, 28F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrMontoExtDGR
            // 
            this.xrMontoExtDGR.CanGrow = false;
            this.xrMontoExtDGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.d_montoext", "{0:C2}")});
            this.xrMontoExtDGR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrMontoExtDGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoExtDGR.LocationFloat = new DevExpress.Utils.PointFloat(490.3332F, 6.000007F);
            this.xrMontoExtDGR.Name = "xrMontoExtDGR";
            this.xrMontoExtDGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtDGR.SizeF = new System.Drawing.SizeF(78.00012F, 18F);
            this.xrMontoExtDGR.StyleName = "FieldCaption";
            this.xrMontoExtDGR.StylePriority.UseFont = false;
            this.xrMontoExtDGR.StylePriority.UseForeColor = false;
            this.xrMontoExtDGR.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,#}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoExtDGR.Summary = xrSummary1;
            this.xrMontoExtDGR.Text = "xrMontoExtDGR";
            this.xrMontoExtDGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocDGR
            // 
            this.xrMontoLocDGR.CanGrow = false;
            this.xrMontoLocDGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.d_montolocal", "{0:C2}")});
            this.xrMontoLocDGR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrMontoLocDGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoLocDGR.LocationFloat = new DevExpress.Utils.PointFloat(412.3332F, 6.000007F);
            this.xrMontoLocDGR.Name = "xrMontoLocDGR";
            this.xrMontoLocDGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocDGR.SizeF = new System.Drawing.SizeF(77.99991F, 18F);
            this.xrMontoLocDGR.StyleName = "FieldCaption";
            this.xrMontoLocDGR.StylePriority.UseFont = false;
            this.xrMontoLocDGR.StylePriority.UseForeColor = false;
            this.xrMontoLocDGR.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:#,#}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoLocDGR.Summary = xrSummary2;
            this.xrMontoLocDGR.Text = "xrMontoLocDGR";
            this.xrMontoLocDGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtGR
            // 
            this.xrMontoExtGR.CanGrow = false;
            this.xrMontoExtGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.a_montoext", "{0:C2}")});
            this.xrMontoExtGR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrMontoExtGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoExtGR.LocationFloat = new DevExpress.Utils.PointFloat(334.3332F, 6.000007F);
            this.xrMontoExtGR.Name = "xrMontoExtGR";
            this.xrMontoExtGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtGR.SizeF = new System.Drawing.SizeF(78.00006F, 18F);
            this.xrMontoExtGR.StyleName = "FieldCaption";
            this.xrMontoExtGR.StylePriority.UseFont = false;
            this.xrMontoExtGR.StylePriority.UseForeColor = false;
            this.xrMontoExtGR.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:#,#}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoExtGR.Summary = xrSummary3;
            this.xrMontoExtGR.Text = "xrMontoExtGR";
            this.xrMontoExtGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocGR
            // 
            this.xrMontoLocGR.CanGrow = false;
            this.xrMontoLocGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.a_montolocal", "{0:C2}")});
            this.xrMontoLocGR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrMontoLocGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoLocGR.LocationFloat = new DevExpress.Utils.PointFloat(256.3332F, 6.000007F);
            this.xrMontoLocGR.Name = "xrMontoLocGR";
            this.xrMontoLocGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocGR.SizeF = new System.Drawing.SizeF(78.00009F, 18F);
            this.xrMontoLocGR.StyleName = "FieldCaption";
            this.xrMontoLocGR.StylePriority.UseFont = false;
            this.xrMontoLocGR.StylePriority.UseForeColor = false;
            this.xrMontoLocGR.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0:#,#}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoLocGR.Summary = xrSummary4;
            this.xrMontoLocGR.Text = "xrMontoLocGR";
            this.xrMontoLocGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTitClasificacionGR
            // 
            this.xrTitClasificacionGR.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTitClasificacionGR.CanGrow = false;
            this.xrTitClasificacionGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.titGrClasificacion")});
            this.xrTitClasificacionGR.LocationFloat = new DevExpress.Utils.PointFloat(12.00002F, 5.99999F);
            this.xrTitClasificacionGR.Name = "xrTitClasificacionGR";
            this.xrTitClasificacionGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitClasificacionGR.SizeF = new System.Drawing.SizeF(231.8331F, 18F);
            this.xrTitClasificacionGR.StylePriority.UseBorders = false;
            this.xrTitClasificacionGR.Text = "xrTitClasificacionGR";
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
            // prmTipoConsulta
            // 
            this.prmTipoConsulta.Name = "prmTipoConsulta";
            // 
            // prmConsulta
            // 
            this.prmConsulta.Name = "prmConsulta";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel32,
            this.xrLabel25,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel24,
            this.xrLabel13,
            this.xrTitFecHoy,
            this.xrPageInfo3,
            this.xrLabel26,
            this.xrLabel61,
            this.xrTitCompania});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 95.83334F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel32.CanGrow = false;
            this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriodo, "Text", "")});
            this.xrLabel32.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(505.2083F, 64.18835F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(156F, 14.99999F);
            this.xrLabel32.StylePriority.UseBorders = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "xrLabel32";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel25.CanGrow = false;
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.c_periodoini")});
            this.xrLabel25.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(349.2083F, 64.18835F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(156F, 15F);
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "xrLabel25";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(29.58002F, 79.18835F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(319.6284F, 14.54F);
            this.xrLabel27.StyleName = "FieldCaption";
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Rubro";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel28.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(349.2083F, 79.18835F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel28.StyleName = "FieldCaption";
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Imp.Soles";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel29.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(427.2084F, 79.18835F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel29.StyleName = "FieldCaption";
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseForeColor = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Imp.Ext.";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel30.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(583.2083F, 79.18835F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel30.StyleName = "FieldCaption";
            this.xrLabel30.StylePriority.UseBorders = false;
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseForeColor = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Imp.Ext.";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel31.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(505.2083F, 79.18835F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel31.StyleName = "FieldCaption";
            this.xrLabel31.StylePriority.UseBorders = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseForeColor = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Imp.Soles";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel24
            // 
            this.xrLabel24.CanGrow = false;
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.titConsulta")});
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(104F, 35.75001F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(490.4834F, 19.875F);
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "xrLabel24";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.titTipoConsulta")});
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(105F, 18.75F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(489.4834F, 17F);
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel13";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitFecHoy
            // 
            this.xrTitFecHoy.CanGrow = false;
            this.xrTitFecHoy.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_RUBROS.TitFecHoy", "{0:dd/MM/yyyy}")});
            this.xrTitFecHoy.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTitFecHoy.LocationFloat = new DevExpress.Utils.PointFloat(667.397F, 0F);
            this.xrTitFecHoy.Name = "xrTitFecHoy";
            this.xrTitFecHoy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitFecHoy.SizeF = new System.Drawing.SizeF(75.60297F, 16.74999F);
            this.xrTitFecHoy.StylePriority.UseFont = false;
            this.xrTitFecHoy.StylePriority.UseTextAlignment = false;
            this.xrTitFecHoy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(604.897F, 16.74999F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(138.103F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(626.772F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(40.62506F, 16.74999F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "Fecha:";
            // 
            // xrLabel61
            // 
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(2.750003F, 2F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(81.25F, 16.75F);
            this.xrLabel61.Text = "EMPRESA :";
            // 
            // xrTitCompania
            // 
            this.xrTitCompania.CanGrow = false;
            this.xrTitCompania.LocationFloat = new DevExpress.Utils.PointFloat(86.99998F, 2F);
            this.xrTitCompania.Name = "xrTitCompania";
            this.xrTitCompania.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitCompania.SizeF = new System.Drawing.SizeF(275F, 16.75F);
            this.xrTitCompania.Text = "---";
            // 
            // TitFecHoy
            // 
            this.TitFecHoy.DataMember = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.TitFecHoy.Expression = "today()";
            this.TitFecHoy.Name = "TitFecHoy";
            // 
            // titTipoConsulta
            // 
            this.titTipoConsulta.DataMember = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.titTipoConsulta.Expression = "iif([Parameters.prmTipoConsulta] =\'2\' || [Parameters.prmTipoConsulta] = \'3\', \'GAS" +
    "TOS POR RUBROS\', \'GASTOS FIJOS Y VARIABLES\')";
            this.titTipoConsulta.Name = "titTipoConsulta";
            // 
            // titConsulta
            // 
            this.titConsulta.DataMember = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.titConsulta.Expression = "iif ([Parameters.prmConsulta] =\'C\', \'CONSOLIDADO\', \'MENSUAL\')";
            this.titConsulta.Name = "titConsulta";
            // 
            // titGrClasificacion
            // 
            this.titGrClasificacion.DataMember = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.titGrClasificacion.Expression = "\'TOTAL \'+   [c_clasificacion]";
            this.titGrClasificacion.Name = "titGrClasificacion";
            // 
            // titGrRubro
            // 
            this.titGrRubro.DataMember = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.titGrRubro.Expression = "\'TOTAL \'+ [c_rubro]";
            this.titGrRubro.Name = "titGrRubro";
            // 
            // rpt_RubroResumenCta
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GrupoClasificación,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.PieClasificacion,
            this.reportFooterBand1,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TitFecHoy,
            this.titTipoConsulta,
            this.titConsulta,
            this.titGrClasificacion,
            this.titGrRubro});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REPORTE_GASTOS_RUBROS";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(40, 44, 34, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmTipoConsulta,
            this.prmConsulta});
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
        private DevExpress.XtraReports.UI.XRLabel xrMontoLoc;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExt;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocD;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExtD;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoClasificación;
        private DevExpress.XtraReports.UI.XRLabel xrTitClasificacion;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand PieClasificacion;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocGR;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExtGR;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocDGR;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExtDGR;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoConsulta;
        private DevExpress.XtraReports.Parameters.Parameter prmConsulta;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRLabel xrTitCompania;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrTitFecHoy;
        private DevExpress.XtraReports.UI.CalculatedField TitFecHoy;
        private DevExpress.XtraReports.UI.CalculatedField titTipoConsulta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.CalculatedField titConsulta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrTitClasificacionGR;
        private DevExpress.XtraReports.UI.CalculatedField titGrClasificacion;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.CalculatedField titGrRubro;
        private DevExpress.XtraReports.UI.XRLabel xrRubro;
    }
}
