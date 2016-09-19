namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.Varios
{
    partial class rpt_ReporteGastoConsolcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_ReporteGastoConsolcs));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrVarSoles = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCuenta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripcion = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExt = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocD = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtD = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GrupoClasificacion = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrMontoLocGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocDGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtDGR = new DevExpress.XtraReports.UI.XRLabel();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrMontoLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoLocDTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMontoExtDTot = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitConsulta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitCompania = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitulo = new DevExpress.XtraReports.UI.XRLabel();
            this.titFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.titConsulta = new DevExpress.XtraReports.UI.CalculatedField();
            this.titPieClasificacion = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrTitPie = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.PieClasificacion = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrVarSolesGr = new DevExpress.XtraReports.UI.XRLabel();
            this.varSoles = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrVarSoles,
            this.xrCuenta,
            this.xrDescripcion,
            this.xrMontoLoc,
            this.xrMontoExt,
            this.xrMontoLocD,
            this.xrMontoExtD});
            this.Detail.Font = new System.Drawing.Font("Arial", 7F);
            this.Detail.HeightF = 17.04162F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrVarSoles
            // 
            this.xrVarSoles.CanGrow = false;
            this.xrVarSoles.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.varSoles", "{0:n2}")});
            this.xrVarSoles.LocationFloat = new DevExpress.Utils.PointFloat(646.9999F, 0.9999593F);
            this.xrVarSoles.Name = "xrVarSoles";
            this.xrVarSoles.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrVarSoles.SizeF = new System.Drawing.SizeF(62.67F, 15F);
            this.xrVarSoles.StylePriority.UseTextAlignment = false;
            this.xrVarSoles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrCuenta
            // 
            this.xrCuenta.CanGrow = false;
            this.xrCuenta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.c_cuenta")});
            this.xrCuenta.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 0.9999593F);
            this.xrCuenta.Name = "xrCuenta";
            this.xrCuenta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCuenta.SizeF = new System.Drawing.SizeF(62F, 15F);
            this.xrCuenta.Text = "xrCuenta";
            // 
            // xrDescripcion
            // 
            this.xrDescripcion.CanGrow = false;
            this.xrDescripcion.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.c_descripcion")});
            this.xrDescripcion.LocationFloat = new DevExpress.Utils.PointFloat(68F, 0.9999593F);
            this.xrDescripcion.Name = "xrDescripcion";
            this.xrDescripcion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripcion.SizeF = new System.Drawing.SizeF(267F, 15F);
            this.xrDescripcion.Text = "xrDescripcion";
            // 
            // xrMontoLoc
            // 
            this.xrMontoLoc.CanGrow = false;
            this.xrMontoLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.a_montolocal", "{0:n2}")});
            this.xrMontoLoc.LocationFloat = new DevExpress.Utils.PointFloat(335F, 0.9999593F);
            this.xrMontoLoc.Name = "xrMontoLoc";
            this.xrMontoLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLoc.SizeF = new System.Drawing.SizeF(78F, 15F);
            this.xrMontoLoc.StylePriority.UseTextAlignment = false;
            this.xrMontoLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExt
            // 
            this.xrMontoExt.CanGrow = false;
            this.xrMontoExt.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.a_montoext", "{0:n2}")});
            this.xrMontoExt.LocationFloat = new DevExpress.Utils.PointFloat(413F, 0.9999593F);
            this.xrMontoExt.Name = "xrMontoExt";
            this.xrMontoExt.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExt.SizeF = new System.Drawing.SizeF(78F, 15F);
            this.xrMontoExt.StylePriority.UseTextAlignment = false;
            this.xrMontoExt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocD
            // 
            this.xrMontoLocD.CanGrow = false;
            this.xrMontoLocD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.d_montolocal", "{0:n2}")});
            this.xrMontoLocD.LocationFloat = new DevExpress.Utils.PointFloat(491F, 0.9999593F);
            this.xrMontoLocD.Name = "xrMontoLocD";
            this.xrMontoLocD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocD.SizeF = new System.Drawing.SizeF(78F, 15F);
            this.xrMontoLocD.StylePriority.UseTextAlignment = false;
            this.xrMontoLocD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtD
            // 
            this.xrMontoExtD.CanGrow = false;
            this.xrMontoExtD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.d_montoext", "{0:n2}")});
            this.xrMontoExtD.LocationFloat = new DevExpress.Utils.PointFloat(568.9999F, 0.9999593F);
            this.xrMontoExtD.Name = "xrMontoExtD";
            this.xrMontoExtD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtD.SizeF = new System.Drawing.SizeF(78F, 15F);
            this.xrMontoExtD.StylePriority.UseTextAlignment = false;
            this.xrMontoExtD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 25.58333F;
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
            storedProcQuery1.Name = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            queryParameter1.Name = "@Compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@Periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@Consulta";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmConsulta]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GrupoClasificacion
            // 
            this.GrupoClasificacion.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.GrupoClasificacion.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.GrupoClasificacion.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("c_clasificacion", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoClasificacion.HeightF = 20.375F;
            this.GrupoClasificacion.Name = "GrupoClasificacion";
            this.GrupoClasificacion.StylePriority.UseFont = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.c_clasificacion")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(4.705945F, 1F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(441.6989F, 18F);
            this.xrLabel2.StyleName = "DataField";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 80F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(62F, 14.54F);
            this.xrLabel1.StyleName = "FieldCaption";
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Cuenta";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            // xrMontoLocGR
            // 
            this.xrMontoLocGR.CanGrow = false;
            this.xrMontoLocGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.a_montolocal", "{0:C2}")});
            this.xrMontoLocGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoLocGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoLocGR.LocationFloat = new DevExpress.Utils.PointFloat(335.0016F, 3.999933F);
            this.xrMontoLocGR.Name = "xrMontoLocGR";
            this.xrMontoLocGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocGR.SizeF = new System.Drawing.SizeF(77.99835F, 15.00001F);
            this.xrMontoLocGR.StyleName = "FieldCaption";
            this.xrMontoLocGR.StylePriority.UseFont = false;
            this.xrMontoLocGR.StylePriority.UseForeColor = false;
            this.xrMontoLocGR.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoLocGR.Summary = xrSummary1;
            this.xrMontoLocGR.Text = "xrMontoLocGR";
            this.xrMontoLocGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtGR
            // 
            this.xrMontoExtGR.CanGrow = false;
            this.xrMontoExtGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.a_montoext", "{0:C2}")});
            this.xrMontoExtGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoExtGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoExtGR.LocationFloat = new DevExpress.Utils.PointFloat(412.9999F, 3.999933F);
            this.xrMontoExtGR.Name = "xrMontoExtGR";
            this.xrMontoExtGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtGR.SizeF = new System.Drawing.SizeF(78.00006F, 15.00001F);
            this.xrMontoExtGR.StyleName = "FieldCaption";
            this.xrMontoExtGR.StylePriority.UseFont = false;
            this.xrMontoExtGR.StylePriority.UseForeColor = false;
            this.xrMontoExtGR.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoExtGR.Summary = xrSummary2;
            this.xrMontoExtGR.Text = "xrMontoExtGR";
            this.xrMontoExtGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocDGR
            // 
            this.xrMontoLocDGR.CanGrow = false;
            this.xrMontoLocDGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.d_montolocal", "{0:C2}")});
            this.xrMontoLocDGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoLocDGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoLocDGR.LocationFloat = new DevExpress.Utils.PointFloat(491F, 3.999933F);
            this.xrMontoLocDGR.Name = "xrMontoLocDGR";
            this.xrMontoLocDGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocDGR.SizeF = new System.Drawing.SizeF(78.00003F, 15.00001F);
            this.xrMontoLocDGR.StyleName = "FieldCaption";
            this.xrMontoLocDGR.StylePriority.UseFont = false;
            this.xrMontoLocDGR.StylePriority.UseForeColor = false;
            this.xrMontoLocDGR.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoLocDGR.Summary = xrSummary3;
            this.xrMontoLocDGR.Text = "xrMontoLocDGR";
            this.xrMontoLocDGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtDGR
            // 
            this.xrMontoExtDGR.CanGrow = false;
            this.xrMontoExtDGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.d_montoext", "{0:C2}")});
            this.xrMontoExtDGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoExtDGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoExtDGR.LocationFloat = new DevExpress.Utils.PointFloat(569F, 3.999933F);
            this.xrMontoExtDGR.Name = "xrMontoExtDGR";
            this.xrMontoExtDGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtDGR.SizeF = new System.Drawing.SizeF(78F, 15.00001F);
            this.xrMontoExtDGR.StyleName = "FieldCaption";
            this.xrMontoExtDGR.StylePriority.UseFont = false;
            this.xrMontoExtDGR.StylePriority.UseForeColor = false;
            this.xrMontoExtDGR.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0:n2}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrMontoExtDGR.Summary = xrSummary4;
            this.xrMontoExtDGR.Text = "xrMontoExtDGR";
            this.xrMontoExtDGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.reportFooterBand1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.reportFooterBand1.HeightF = 44.37501F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            this.reportFooterBand1.StylePriority.UseFont = false;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrMontoLocTot,
            this.xrMontoExtTot,
            this.xrMontoLocDTot,
            this.xrMontoExtDTot});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(168.0833F, 10.00001F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(556F, 30.21167F);
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrMontoLocTot
            // 
            this.xrMontoLocTot.CanGrow = false;
            this.xrMontoLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.a_montolocal", "{0:C2}")});
            this.xrMontoLocTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoLocTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoLocTot.LocationFloat = new DevExpress.Utils.PointFloat(166.9182F, 8.000007F);
            this.xrMontoLocTot.Name = "xrMontoLocTot";
            this.xrMontoLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocTot.SizeF = new System.Drawing.SizeF(77.99835F, 15.00001F);
            this.xrMontoLocTot.StyleName = "FieldCaption";
            this.xrMontoLocTot.StylePriority.UseFont = false;
            this.xrMontoLocTot.StylePriority.UseForeColor = false;
            this.xrMontoLocTot.StylePriority.UseTextAlignment = false;
            xrSummary5.FormatString = "{0:n2}";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrMontoLocTot.Summary = xrSummary5;
            this.xrMontoLocTot.Text = "xrLabel16";
            this.xrMontoLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtTot
            // 
            this.xrMontoExtTot.CanGrow = false;
            this.xrMontoExtTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.a_montoext", "{0:C2}")});
            this.xrMontoExtTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoExtTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoExtTot.LocationFloat = new DevExpress.Utils.PointFloat(244.9166F, 8.000007F);
            this.xrMontoExtTot.Name = "xrMontoExtTot";
            this.xrMontoExtTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtTot.SizeF = new System.Drawing.SizeF(78.00006F, 15.00001F);
            this.xrMontoExtTot.StyleName = "FieldCaption";
            this.xrMontoExtTot.StylePriority.UseFont = false;
            this.xrMontoExtTot.StylePriority.UseForeColor = false;
            this.xrMontoExtTot.StylePriority.UseTextAlignment = false;
            xrSummary6.FormatString = "{0:n2}";
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrMontoExtTot.Summary = xrSummary6;
            this.xrMontoExtTot.Text = "xrLabel17";
            this.xrMontoExtTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoLocDTot
            // 
            this.xrMontoLocDTot.CanGrow = false;
            this.xrMontoLocDTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.d_montolocal", "{0:C2}")});
            this.xrMontoLocDTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoLocDTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoLocDTot.LocationFloat = new DevExpress.Utils.PointFloat(322.9167F, 8.000007F);
            this.xrMontoLocDTot.Name = "xrMontoLocDTot";
            this.xrMontoLocDTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoLocDTot.SizeF = new System.Drawing.SizeF(78.00003F, 15.00001F);
            this.xrMontoLocDTot.StyleName = "FieldCaption";
            this.xrMontoLocDTot.StylePriority.UseFont = false;
            this.xrMontoLocDTot.StylePriority.UseForeColor = false;
            this.xrMontoLocDTot.StylePriority.UseTextAlignment = false;
            xrSummary7.FormatString = "{0:n2}";
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrMontoLocDTot.Summary = xrSummary7;
            this.xrMontoLocDTot.Text = "xrLabel18";
            this.xrMontoLocDTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrMontoExtDTot
            // 
            this.xrMontoExtDTot.CanGrow = false;
            this.xrMontoExtDTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.d_montoext", "{0:C2}")});
            this.xrMontoExtDTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrMontoExtDTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrMontoExtDTot.LocationFloat = new DevExpress.Utils.PointFloat(400.9167F, 7.999991F);
            this.xrMontoExtDTot.Name = "xrMontoExtDTot";
            this.xrMontoExtDTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMontoExtDTot.SizeF = new System.Drawing.SizeF(78F, 15.00001F);
            this.xrMontoExtDTot.StyleName = "FieldCaption";
            this.xrMontoExtDTot.StylePriority.UseFont = false;
            this.xrMontoExtDTot.StylePriority.UseForeColor = false;
            this.xrMontoExtDTot.StylePriority.UseTextAlignment = false;
            xrSummary8.FormatString = "{0:n2}";
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrMontoExtDTot.Summary = xrSummary8;
            this.xrMontoExtDTot.Text = "xrLabel19";
            this.xrMontoExtDTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            // prmConsulta
            // 
            this.prmConsulta.Name = "prmConsulta";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel33,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel15,
            this.xrTitConsulta,
            this.xrLabel26,
            this.xrTitFecha,
            this.xrPageInfo3,
            this.xrLabel61,
            this.xrTitCompania,
            this.xrTitulo,
            this.xrLabel1});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 96.83336F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel33.CanGrow = false;
            this.xrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriodo, "Text", "")});
            this.xrLabel33.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(491F, 64.99999F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(155.9999F, 15F);
            this.xrLabel33.StylePriority.UseBorders = false;
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "xrLabel33";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel32.CanGrow = false;
            this.xrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.c_periodoIni")});
            this.xrLabel32.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(335.0016F, 64.99999F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(155.9984F, 15F);
            this.xrLabel32.StylePriority.UseBorders = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "xrLabel32";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel31.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(647.2983F, 80F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(62.375F, 14.54F);
            this.xrLabel31.StyleName = "FieldCaption";
            this.xrLabel31.StylePriority.UseBorders = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseForeColor = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Var.Soles";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel29.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(491F, 80F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel29.StyleName = "FieldCaption";
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseForeColor = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Imp.Soles";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel30.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(568.9999F, 80F);
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
            // xrLabel28
            // 
            this.xrLabel28.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel28.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(413F, 80F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel28.StyleName = "FieldCaption";
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Imp.Ext.";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(335F, 80F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(78F, 14.54F);
            this.xrLabel27.StyleName = "FieldCaption";
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Imp.Soles";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 7F);
            this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(68F, 80F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(267F, 14.54F);
            this.xrLabel15.StyleName = "FieldCaption";
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Descripcion";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitConsulta
            // 
            this.xrTitConsulta.CanGrow = false;
            this.xrTitConsulta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.titConsulta")});
            this.xrTitConsulta.LocationFloat = new DevExpress.Utils.PointFloat(62.35233F, 37.79166F);
            this.xrTitConsulta.Name = "xrTitConsulta";
            this.xrTitConsulta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitConsulta.SizeF = new System.Drawing.SizeF(512.6478F, 18.83333F);
            this.xrTitConsulta.StylePriority.UseTextAlignment = false;
            this.xrTitConsulta.Text = "xrTitConsulta";
            this.xrTitConsulta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Arial", 8F);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(606.3748F, 1.999982F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(40.62503F, 15F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "Fecha:";
            // 
            // xrTitFecha
            // 
            this.xrTitFecha.CanGrow = false;
            this.xrTitFecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.titFecHoy", "{0:dd/MM/yyyy}")});
            this.xrTitFecha.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTitFecha.LocationFloat = new DevExpress.Utils.PointFloat(646.9999F, 1.999982F);
            this.xrTitFecha.Name = "xrTitFecha";
            this.xrTitFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitFecha.SizeF = new System.Drawing.SizeF(62.67358F, 15F);
            this.xrTitFecha.StylePriority.UseFont = false;
            this.xrTitFecha.StylePriority.UseTextAlignment = false;
            this.xrTitFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(575.0001F, 19.79167F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(134.6683F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel61
            // 
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(4.705948F, 3.041663F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(81.25F, 16.75F);
            this.xrLabel61.Text = "EMPRESA :";
            // 
            // xrTitCompania
            // 
            this.xrTitCompania.CanGrow = false;
            this.xrTitCompania.LocationFloat = new DevExpress.Utils.PointFloat(88.95596F, 3.041663F);
            this.xrTitCompania.Name = "xrTitCompania";
            this.xrTitCompania.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitCompania.SizeF = new System.Drawing.SizeF(275F, 16.75F);
            this.xrTitCompania.Text = "---";
            // 
            // xrTitulo
            // 
            this.xrTitulo.LocationFloat = new DevExpress.Utils.PointFloat(62.35233F, 19.79167F);
            this.xrTitulo.Name = "xrTitulo";
            this.xrTitulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitulo.SizeF = new System.Drawing.SizeF(512.6478F, 18F);
            this.xrTitulo.StylePriority.UseTextAlignment = false;
            this.xrTitulo.Text = "REPORTE DE CUENTAS DE GASTOS";
            this.xrTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // titFecHoy
            // 
            this.titFecHoy.DataMember = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            this.titFecHoy.Expression = "today()";
            this.titFecHoy.Name = "titFecHoy";
            // 
            // titConsulta
            // 
            this.titConsulta.DataMember = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            this.titConsulta.Expression = "iif ([Parameters.prmConsulta] =\'C\', \'CONSOLIDADO\', \'MENSUAL\')";
            this.titConsulta.Name = "titConsulta";
            // 
            // titPieClasificacion
            // 
            this.titPieClasificacion.DataMember = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            this.titPieClasificacion.Expression = "\'Total \'+ [c_clasificacion]";
            this.titPieClasificacion.Name = "titPieClasificacion";
            // 
            // xrTitPie
            // 
            this.xrTitPie.CanGrow = false;
            this.xrTitPie.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REPORTE_GASTOS_CLASIFICACION.titPieClasificacion")});
            this.xrTitPie.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrTitPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrTitPie.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 3.999933F);
            this.xrTitPie.Name = "xrTitPie";
            this.xrTitPie.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitPie.SizeF = new System.Drawing.SizeF(318.5833F, 15.00001F);
            this.xrTitPie.StylePriority.UseFont = false;
            this.xrTitPie.StylePriority.UseForeColor = false;
            this.xrTitPie.StylePriority.UseTextAlignment = false;
            this.xrTitPie.Text = "xrTitPie";
            this.xrTitPie.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6.000002F, 1F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(710F, 2F);
            // 
            // PieClasificacion
            // 
            this.PieClasificacion.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrMontoExtGR,
            this.xrMontoLocDGR,
            this.xrMontoLocGR,
            this.xrTitPie,
            this.xrMontoExtDGR,
            this.xrVarSolesGr});
            this.PieClasificacion.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.PieClasificacion.HeightF = 20.83333F;
            this.PieClasificacion.Name = "PieClasificacion";
            this.PieClasificacion.StylePriority.UseFont = false;
            // 
            // xrVarSolesGr
            // 
            this.xrVarSolesGr.CanGrow = false;
            this.xrVarSolesGr.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrVarSolesGr.LocationFloat = new DevExpress.Utils.PointFloat(647.2983F, 3.999933F);
            this.xrVarSolesGr.Name = "xrVarSolesGr";
            this.xrVarSolesGr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrVarSolesGr.SizeF = new System.Drawing.SizeF(62.37012F, 14.66667F);
            this.xrVarSolesGr.StylePriority.UseFont = false;
            this.xrVarSolesGr.StylePriority.UseTextAlignment = false;
            this.xrVarSolesGr.Text = "xrVarSolesGr";
            this.xrVarSolesGr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // varSoles
            // 
            this.varSoles.DataMember = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            this.varSoles.Expression = "iif ([a_montolocal]<> 100 ,  [d_montolocal] / [a_montolocal] , 0)";
            this.varSoles.Name = "varSoles";
            // 
            // rpt_ReporteGastoConsolcs
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GrupoClasificacion,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.PageHeader,
            this.PieClasificacion});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.titFecHoy,
            this.titConsulta,
            this.titPieClasificacion,
            this.varSoles});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REPORTE_GASTOS_CLASIFICACION";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(36, 60, 26, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
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
        private DevExpress.XtraReports.UI.XRLabel xrCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrDescripcion;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLoc;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExt;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocD;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExtD;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoClasificacion;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
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
        private DevExpress.XtraReports.Parameters.Parameter prmConsulta;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRLabel xrTitCompania;
        private DevExpress.XtraReports.UI.XRLabel xrTitulo;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrTitFecha;
        private DevExpress.XtraReports.UI.CalculatedField titFecHoy;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrTitConsulta;
        private DevExpress.XtraReports.UI.CalculatedField titConsulta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrTitPie;
        private DevExpress.XtraReports.UI.CalculatedField titPieClasificacion;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.GroupFooterBand PieClasificacion;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocTot;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExtTot;
        private DevExpress.XtraReports.UI.XRLabel xrMontoLocDTot;
        private DevExpress.XtraReports.UI.XRLabel xrMontoExtDTot;
        private DevExpress.XtraReports.UI.XRLabel xrVarSoles;
        private DevExpress.XtraReports.UI.CalculatedField varSoles;
        private DevExpress.XtraReports.UI.XRLabel xrVarSolesGr;
    }
}
