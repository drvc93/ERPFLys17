namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables
{
    partial class rpt_GastosMensualDet
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_GastosMensualDet));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
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
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldcperiodo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldcmoneda = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldccuenta = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldcrazonsocial = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldnimportedollar = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldccentrocosto = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldnimportelocal = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldctipoccostonombre = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldcnombrecta = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldnproveedor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldctipogastonombre = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPerInicial = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPerFinal = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmFlagProv = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmProveedor = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCCosto = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmMoneda = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaDestino = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmDocPend = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmOrdenar = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.intervaloPeriodos = new DevExpress.XtraReports.UI.CalculatedField();
            this.nonMoneda = new DevExpress.XtraReports.UI.CalculatedField();
            this.nroPagina = new DevExpress.XtraReports.UI.CalculatedField();
            this.FechaHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.prmNomCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.nomCompania = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 210.5417F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrPageInfo3,
            this.xrLabel4});
            this.TopMargin.HeightF = 35F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.FechaHoy")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(804.3732F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(157.5851F, 14.91668F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(804.3732F, 19.29165F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(157.5851F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 15F;
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
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPerInicial]", typeof(string));
            queryParameter3.Name = "@PerFin";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPerFinal]", typeof(string));
            queryParameter4.Name = "@CtaIni";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaIni]", typeof(string));
            queryParameter5.Name = "@CtaFin";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaFin]", typeof(string));
            queryParameter6.Name = "@FlagProv";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.prmFlagProv]", typeof(string));
            queryParameter7.Name = "@Proveedor";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.prmProveedor]", typeof(int));
            queryParameter8.Name = "@CCosto";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCCosto]", typeof(string));
            queryParameter9.Name = "@Moneda";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.prmMoneda]", typeof(string));
            queryParameter10.Name = "@CtaDestino";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaDestino]", typeof(string));
            queryParameter11.Name = "@DocPend";
            queryParameter11.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter11.Value = new DevExpress.DataAccess.Expression("[Parameters.prmDocPend]", typeof(string));
            queryParameter12.Name = "@Ordenar";
            queryParameter12.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter12.Value = new DevExpress.DataAccess.Expression("[Parameters.prmOrdenar]", typeof(string));
            queryParameter13.Name = "@Consulta";
            queryParameter13.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter13.Value = new DevExpress.DataAccess.Expression("[Parameters.prmConsulta]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.Parameters.Add(queryParameter8);
            storedProcQuery1.Parameters.Add(queryParameter9);
            storedProcQuery1.Parameters.Add(queryParameter10);
            storedProcQuery1.Parameters.Add(queryParameter11);
            storedProcQuery1.Parameters.Add(queryParameter12);
            storedProcQuery1.Parameters.Add(queryParameter13);
            storedProcQuery1.StoredProcName = "sp_cb_ccte_prov";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Expanded = false;
            this.pageHeaderBand1.HeightF = 219.9167F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
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
            this.pageFooterBand1.Expanded = false;
            this.pageFooterBand1.HeightF = 29F;
            this.pageFooterBand1.Name = "pageFooterBand1";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel23,
            this.xrPivotGrid1});
            this.reportHeaderBand1.HeightF = 354.3852F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nonMoneda")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(387.9807F, 51.29168F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(313.5417F, 15.70833F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Todas las monedas";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "sp_cb_ccte_prov.intervaloPeriodos")});
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(387.9807F, 31.41668F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(313.5416F, 19.875F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(294.2307F, 10.00001F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(407.2917F, 21.41667F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "GASTOS MENSUALES DETALLADO";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.xrPivotGrid1.DataMember = "sp_cb_ccte_prov";
            this.xrPivotGrid1.DataSource = this.sqlConnRPT;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldcperiodo,
            this.fieldcmoneda,
            this.fieldccuenta,
            this.fieldcrazonsocial,
            this.fieldnimportedollar,
            this.fieldccentrocosto,
            this.fieldnimportelocal,
            this.fieldctipoccostonombre,
            this.fieldcnombrecta,
            this.fieldnproveedor,
            this.fieldctipogastonombre});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 77.20833F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.OptionsView.ShowColumnHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowDataHeaders = false;
            this.xrPivotGrid1.OptionsView.ShowFilterHeaders = false;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1073F, 277.1769F);
            // 
            // fieldcperiodo
            // 
            this.fieldcperiodo.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldcperiodo.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldcperiodo.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.fieldcperiodo.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldcperiodo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldcperiodo.AreaIndex = 0;
            this.fieldcperiodo.Caption = "Perido";
            this.fieldcperiodo.FieldName = "c_periodo";
            this.fieldcperiodo.Name = "fieldcperiodo";
            this.fieldcperiodo.TotalValueFormat.FormatString = "n2";
            this.fieldcperiodo.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldcmoneda
            // 
            this.fieldcmoneda.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fieldcmoneda.Appearance.FieldValue.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldcmoneda.AreaIndex = 0;
            this.fieldcmoneda.FieldName = "c_moneda";
            this.fieldcmoneda.Name = "fieldcmoneda";
            this.fieldcmoneda.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldccuenta
            // 
            this.fieldccuenta.Appearance.Cell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.fieldccuenta.Appearance.FieldHeader.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldccuenta.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldccuenta.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldccuenta.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldccuenta.AreaIndex = 0;
            this.fieldccuenta.Caption = "Cuenta";
            this.fieldccuenta.FieldName = "c_cuenta";
            this.fieldccuenta.Name = "fieldccuenta";
            this.fieldccuenta.TotalValueFormat.FormatString = "n2";
            this.fieldccuenta.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldccuenta.Width = 50;
            // 
            // fieldcrazonsocial
            // 
            this.fieldcrazonsocial.Appearance.FieldHeader.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldcrazonsocial.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldcrazonsocial.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldcrazonsocial.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldcrazonsocial.AreaIndex = 2;
            this.fieldcrazonsocial.Caption = "Raz.Social";
            this.fieldcrazonsocial.FieldName = "c_razonsocial";
            this.fieldcrazonsocial.Name = "fieldcrazonsocial";
            this.fieldcrazonsocial.Width = 91;
            // 
            // fieldnimportedollar
            // 
            this.fieldnimportedollar.Appearance.Cell.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldnimportedollar.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldnimportedollar.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldnimportedollar.Appearance.TotalCell.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold);
            this.fieldnimportedollar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldnimportedollar.AreaIndex = 1;
            this.fieldnimportedollar.Caption = "Dolares";
            this.fieldnimportedollar.CellFormat.FormatString = "n2";
            this.fieldnimportedollar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldnimportedollar.FieldName = "n_importedollar";
            this.fieldnimportedollar.Name = "fieldnimportedollar";
            this.fieldnimportedollar.ValueFormat.FormatString = "\"{0:#,#.00}\"";
            this.fieldnimportedollar.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldnimportedollar.Width = 50;
            // 
            // fieldccentrocosto
            // 
            this.fieldccentrocosto.Appearance.FieldHeader.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldccentrocosto.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldccentrocosto.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldccentrocosto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldccentrocosto.AreaIndex = 3;
            this.fieldccentrocosto.Caption = "C.Costo";
            this.fieldccentrocosto.FieldName = "c_centrocosto";
            this.fieldccentrocosto.Name = "fieldccentrocosto";
            this.fieldccentrocosto.Width = 40;
            // 
            // fieldnimportelocal
            // 
            this.fieldnimportelocal.Appearance.Cell.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldnimportelocal.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldnimportelocal.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldnimportelocal.Appearance.TotalCell.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold);
            this.fieldnimportelocal.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldnimportelocal.AreaIndex = 0;
            this.fieldnimportelocal.Caption = "Soles";
            this.fieldnimportelocal.CellFormat.FormatString = "n2";
            this.fieldnimportelocal.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldnimportelocal.FieldName = "n_importelocal";
            this.fieldnimportelocal.Name = "fieldnimportelocal";
            this.fieldnimportelocal.ValueFormat.FormatString = "\"{0:#,#.00}\"";
            this.fieldnimportelocal.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldnimportelocal.Width = 50;
            // 
            // fieldctipoccostonombre
            // 
            this.fieldctipoccostonombre.Appearance.FieldHeader.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldctipoccostonombre.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldctipoccostonombre.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldctipoccostonombre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldctipoccostonombre.AreaIndex = 4;
            this.fieldctipoccostonombre.Caption = "T.CCosto";
            this.fieldctipoccostonombre.FieldName = "c_tipoccostonombre";
            this.fieldctipoccostonombre.Name = "fieldctipoccostonombre";
            this.fieldctipoccostonombre.Width = 59;
            // 
            // fieldcnombrecta
            // 
            this.fieldcnombrecta.Appearance.Cell.Font = new System.Drawing.Font("Arial Narrow", 6.75F);
            this.fieldcnombrecta.AreaIndex = 1;
            this.fieldcnombrecta.FieldName = "c_nombrecta";
            this.fieldcnombrecta.Name = "fieldcnombrecta";
            // 
            // fieldnproveedor
            // 
            this.fieldnproveedor.Appearance.FieldHeader.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldnproveedor.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldnproveedor.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldnproveedor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnproveedor.AreaIndex = 1;
            this.fieldnproveedor.Caption = "Prov.";
            this.fieldnproveedor.FieldName = "n_proveedor";
            this.fieldnproveedor.Name = "fieldnproveedor";
            this.fieldnproveedor.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldnproveedor.Width = 45;
            // 
            // fieldctipogastonombre
            // 
            this.fieldctipogastonombre.Appearance.FieldHeader.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldctipogastonombre.Appearance.FieldHeader.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldctipogastonombre.Appearance.FieldValue.Font = new System.Drawing.Font("Arial", 6.75F);
            this.fieldctipogastonombre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldctipogastonombre.AreaIndex = 5;
            this.fieldctipogastonombre.Caption = "T.Gasto";
            this.fieldctipogastonombre.FieldName = "c_tipogastonombre";
            this.fieldctipogastonombre.Name = "fieldctipogastonombre";
            this.fieldctipogastonombre.Width = 42;
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
            this.prmCompania.ValueInfo = "00400000";
            // 
            // prmPerInicial
            // 
            this.prmPerInicial.Name = "prmPerInicial";
            this.prmPerInicial.ValueInfo = "201501";
            // 
            // prmPerFinal
            // 
            this.prmPerFinal.Name = "prmPerFinal";
            this.prmPerFinal.ValueInfo = "201504";
            // 
            // prmCtaIni
            // 
            this.prmCtaIni.Name = "prmCtaIni";
            this.prmCtaIni.ValueInfo = "0";
            // 
            // prmCtaFin
            // 
            this.prmCtaFin.Name = "prmCtaFin";
            this.prmCtaFin.ValueInfo = "999999999";
            // 
            // prmFlagProv
            // 
            this.prmFlagProv.Name = "prmFlagProv";
            this.prmFlagProv.ValueInfo = "S";
            // 
            // prmProveedor
            // 
            this.prmProveedor.Name = "prmProveedor";
            this.prmProveedor.Type = typeof(int);
            this.prmProveedor.ValueInfo = "0";
            // 
            // prmCCosto
            // 
            this.prmCCosto.Name = "prmCCosto";
            this.prmCCosto.ValueInfo = "%";
            // 
            // prmMoneda
            // 
            this.prmMoneda.Name = "prmMoneda";
            this.prmMoneda.ValueInfo = "%";
            // 
            // prmCtaDestino
            // 
            this.prmCtaDestino.Name = "prmCtaDestino";
            this.prmCtaDestino.ValueInfo = "%";
            // 
            // prmDocPend
            // 
            this.prmDocPend.Name = "prmDocPend";
            this.prmDocPend.ValueInfo = "S";
            // 
            // prmOrdenar
            // 
            this.prmOrdenar.Name = "prmOrdenar";
            this.prmOrdenar.ValueInfo = "M";
            // 
            // prmConsulta
            // 
            this.prmConsulta.Name = "prmConsulta";
            this.prmConsulta.ValueInfo = "03";
            // 
            // intervaloPeriodos
            // 
            this.intervaloPeriodos.DataMember = "sp_cb_ccte_prov";
            this.intervaloPeriodos.Expression = "\'Periodo: del \' +[Parameters.prmPerInicial] + \' al \' +[Parameters.prmPerFinal]";
            this.intervaloPeriodos.Name = "intervaloPeriodos";
            // 
            // nonMoneda
            // 
            this.nonMoneda.Expression = "Iif([Parameters.prmMoneda]==\'L\', \'Moneda:Soles\' ,Iif([Parameters.prmMoneda]=\'E\', " +
    "\'Moneda:Dolares\' ,Iif([Parameters.prmMoneda]=\'%\', \'Todas las monedas\',\'\' )))";
            this.nonMoneda.Name = "nonMoneda";
            // 
            // nroPagina
            // 
            this.nroPagina.DataMember = "sp_cb_ccte_prov";
            this.nroPagina.Name = "nroPagina";
            // 
            // FechaHoy
            // 
            this.FechaHoy.DataMember = "sp_cb_ccte_prov";
            this.FechaHoy.Expression = "Today()";
            this.FechaHoy.Name = "FechaHoy";
            // 
            // prmNomCompania
            // 
            this.prmNomCompania.Description = "Parameter1";
            this.prmNomCompania.Name = "prmNomCompania";
            // 
            // nomCompania
            // 
            this.nomCompania.Expression = "Upper([Parameters.prmNomCompania])";
            this.nomCompania.Name = "nomCompania";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nomCompania")});
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10F, 20F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(246.875F, 15F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // rpt_GastosMensualDet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageHeaderBand1,
            this.pageFooterBand1,
            this.reportHeaderBand1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.intervaloPeriodos,
            this.nonMoneda,
            this.nroPagina,
            this.FechaHoy,
            this.nomCompania});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "sp_cb_ccte_prov";
            this.DataSource = this.sqlConnRPT;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(14, 10, 35, 15);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPerInicial,
            this.prmPerFinal,
            this.prmCtaIni,
            this.prmCtaFin,
            this.prmFlagProv,
            this.prmProveedor,
            this.prmCCosto,
            this.prmMoneda,
            this.prmCtaDestino,
            this.prmDocPend,
            this.prmOrdenar,
            this.prmConsulta,
            this.prmNomCompania});
            this.Scripts.OnFillEmptySpace = "rpt_GastosMensualDet_FillEmptySpace";
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
        private DevExpress.XtraReports.Parameters.Parameter prmPerFinal;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaIni;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaFin;
        private DevExpress.XtraReports.Parameters.Parameter prmFlagProv;
        private DevExpress.XtraReports.Parameters.Parameter prmProveedor;
        private DevExpress.XtraReports.Parameters.Parameter prmCCosto;
        private DevExpress.XtraReports.Parameters.Parameter prmMoneda;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaDestino;
        private DevExpress.XtraReports.Parameters.Parameter prmDocPend;
        private DevExpress.XtraReports.Parameters.Parameter prmOrdenar;
        private DevExpress.XtraReports.Parameters.Parameter prmConsulta;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldcmoneda;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldcperiodo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldccuenta;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldcrazonsocial;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldcnombrecta;
        private DevExpress.XtraReports.Parameters.Parameter prmPerInicial;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldccentrocosto;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField intervaloPeriodos;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.CalculatedField nonMoneda;
        private DevExpress.XtraReports.UI.CalculatedField nroPagina;
        private DevExpress.XtraReports.UI.CalculatedField FechaHoy;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldnimportedollar;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldnimportelocal;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldnproveedor;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldctipoccostonombre;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldctipogastonombre;
        private DevExpress.XtraReports.Parameters.Parameter prmNomCompania;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.CalculatedField nomCompania;
    }
}
