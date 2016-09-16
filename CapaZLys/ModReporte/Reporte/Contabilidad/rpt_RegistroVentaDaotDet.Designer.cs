namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_RegistroVentaDaotDet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_RegistroVentaDaotDet));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GrupoGeneral = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrClienteRuc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCodSunatC = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrClienteNombre = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTipoDoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSerDoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrNumDoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFecEmi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBaseLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrBaseLocGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLocGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotLocGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmFlagSupera = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoConsulta = new DevExpress.XtraReports.Parameters.Parameter();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTituloGen = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitCompania = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.TitFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrTitFecHoy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.TitPeriodo = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrTitPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.titLimite = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrTitLimite = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.PieGeneral = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.PieSummary = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xr2UIT = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBaseLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTotLocTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFlagPaso = new DevExpress.XtraReports.UI.XRCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCliente,
            this.xrClienteNombre,
            this.xrTipoDoc,
            this.xrSerDoc,
            this.xrNumDoc,
            this.xrFecEmi,
            this.xrBaseLoc,
            this.xrImpLoc,
            this.xrTotLoc});
            this.Detail.Font = new System.Drawing.Font("Arial", 7F);
            this.Detail.HeightF = 12F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            storedProcQuery1.Name = "SP_CB_REP_REGVENTAS_DAOT";
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
            storedProcQuery1.StoredProcName = "SP_CB_REP_REGVENTAS_DAOT";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GrupoGeneral
            // 
            this.GrupoGeneral.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrFlagPaso,
            this.xrLabel3,
            this.xrClienteRuc,
            this.xrCodSunatC,
            this.xrLabel1,
            this.xrLabel2});
            this.GrupoGeneral.Font = new System.Drawing.Font("Arial", 7F);
            this.GrupoGeneral.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("c_codigosunat_c", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("c_clienteruc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoGeneral.HeightF = 14.125F;
            this.GrupoGeneral.Name = "GrupoGeneral";
            this.GrupoGeneral.StylePriority.UseFont = false;
            this.GrupoGeneral.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GrupoGeneral_BeforePrint);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(55.95833F, 14.125F);
            this.xrLabel1.StyleName = "FieldCaption";
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "Cod. Doc.:";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(100.0834F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(33.07308F, 14.125F);
            this.xrLabel2.StyleName = "FieldCaption";
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "Doc.:";
            // 
            // xrClienteRuc
            // 
            this.xrClienteRuc.CanGrow = false;
            this.xrClienteRuc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.c_clienteruc")});
            this.xrClienteRuc.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrClienteRuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrClienteRuc.LocationFloat = new DevExpress.Utils.PointFloat(133.1564F, 0F);
            this.xrClienteRuc.Name = "xrClienteRuc";
            this.xrClienteRuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrClienteRuc.SizeF = new System.Drawing.SizeF(82F, 14.125F);
            this.xrClienteRuc.StyleName = "DataField";
            this.xrClienteRuc.StylePriority.UseFont = false;
            this.xrClienteRuc.StylePriority.UseForeColor = false;
            this.xrClienteRuc.Text = "xrClienteRuc";
            // 
            // xrCodSunatC
            // 
            this.xrCodSunatC.CanGrow = false;
            this.xrCodSunatC.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.c_codigosunat_c")});
            this.xrCodSunatC.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrCodSunatC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrCodSunatC.LocationFloat = new DevExpress.Utils.PointFloat(61.95834F, 0F);
            this.xrCodSunatC.Name = "xrCodSunatC";
            this.xrCodSunatC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCodSunatC.SizeF = new System.Drawing.SizeF(38.12501F, 14.125F);
            this.xrCodSunatC.StyleName = "DataField";
            this.xrCodSunatC.StylePriority.UseFont = false;
            this.xrCodSunatC.StylePriority.UseForeColor = false;
            this.xrCodSunatC.Text = "xrCodSunatC";
            // 
            // xrCliente
            // 
            this.xrCliente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.n_cliente")});
            this.xrCliente.LocationFloat = new DevExpress.Utils.PointFloat(5.000019F, 0F);
            this.xrCliente.Name = "xrCliente";
            this.xrCliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCliente.SizeF = new System.Drawing.SizeF(40F, 12F);
            this.xrCliente.StylePriority.UseTextAlignment = false;
            this.xrCliente.Text = "xrCliente";
            this.xrCliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrClienteNombre
            // 
            this.xrClienteNombre.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.c_clientenombre")});
            this.xrClienteNombre.LocationFloat = new DevExpress.Utils.PointFloat(45.09621F, 0F);
            this.xrClienteNombre.Name = "xrClienteNombre";
            this.xrClienteNombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrClienteNombre.SizeF = new System.Drawing.SizeF(283.9F, 12F);
            this.xrClienteNombre.Text = "xrClienteNombre";
            // 
            // xrTipoDoc
            // 
            this.xrTipoDoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.c_tipodocumento")});
            this.xrTipoDoc.LocationFloat = new DevExpress.Utils.PointFloat(328.9999F, 0F);
            this.xrTipoDoc.Name = "xrTipoDoc";
            this.xrTipoDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTipoDoc.SizeF = new System.Drawing.SizeF(38F, 12F);
            this.xrTipoDoc.Text = "xrTipoDoc";
            // 
            // xrSerDoc
            // 
            this.xrSerDoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.c_seriedocumento")});
            this.xrSerDoc.LocationFloat = new DevExpress.Utils.PointFloat(366.9999F, 0F);
            this.xrSerDoc.Name = "xrSerDoc";
            this.xrSerDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrSerDoc.SizeF = new System.Drawing.SizeF(35F, 12F);
            this.xrSerDoc.Text = "xrSerDoc";
            // 
            // xrNumDoc
            // 
            this.xrNumDoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.n_numerodocumento")});
            this.xrNumDoc.LocationFloat = new DevExpress.Utils.PointFloat(401.9999F, 0F);
            this.xrNumDoc.Name = "xrNumDoc";
            this.xrNumDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrNumDoc.SizeF = new System.Drawing.SizeF(55F, 12F);
            this.xrNumDoc.Text = "xrNumDoc";
            // 
            // xrFecEmi
            // 
            this.xrFecEmi.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.fechaemision")});
            this.xrFecEmi.LocationFloat = new DevExpress.Utils.PointFloat(457F, 0F);
            this.xrFecEmi.Name = "xrFecEmi";
            this.xrFecEmi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrFecEmi.SizeF = new System.Drawing.SizeF(55F, 12F);
            this.xrFecEmi.Text = "xrFecEmi";
            // 
            // xrBaseLoc
            // 
            this.xrBaseLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.base_loc", "{0:n2}")});
            this.xrBaseLoc.LocationFloat = new DevExpress.Utils.PointFloat(511.9999F, 0F);
            this.xrBaseLoc.Name = "xrBaseLoc";
            this.xrBaseLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrBaseLoc.SizeF = new System.Drawing.SizeF(75F, 12F);
            this.xrBaseLoc.StylePriority.UseTextAlignment = false;
            this.xrBaseLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpLoc
            // 
            this.xrImpLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.impuestos_loc", "{0:n2}")});
            this.xrImpLoc.LocationFloat = new DevExpress.Utils.PointFloat(586.9999F, 0F);
            this.xrImpLoc.Name = "xrImpLoc";
            this.xrImpLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrImpLoc.SizeF = new System.Drawing.SizeF(72.45F, 12F);
            this.xrImpLoc.StylePriority.UseTextAlignment = false;
            this.xrImpLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotLoc
            // 
            this.xrTotLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.total_loc", "{0:n2}")});
            this.xrTotLoc.LocationFloat = new DevExpress.Utils.PointFloat(661.9999F, 0F);
            this.xrTotLoc.Name = "xrTotLoc";
            this.xrTotLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTotLoc.SizeF = new System.Drawing.SizeF(75F, 12F);
            this.xrTotLoc.StylePriority.UseTextAlignment = false;
            this.xrTotLoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.HeightF = 29F;
            this.pageFooterBand1.Name = "pageFooterBand1";
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
            // xrBaseLocGR
            // 
            this.xrBaseLocGR.CanGrow = false;
            this.xrBaseLocGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.base_loc", "{0:C2}")});
            this.xrBaseLocGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrBaseLocGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrBaseLocGR.LocationFloat = new DevExpress.Utils.PointFloat(511.9999F, 1.999996F);
            this.xrBaseLocGR.Name = "xrBaseLocGR";
            this.xrBaseLocGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBaseLocGR.SizeF = new System.Drawing.SizeF(75.00003F, 13F);
            this.xrBaseLocGR.StyleName = "FieldCaption";
            this.xrBaseLocGR.StylePriority.UseFont = false;
            this.xrBaseLocGR.StylePriority.UseForeColor = false;
            this.xrBaseLocGR.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrBaseLocGR.Summary = xrSummary1;
            this.xrBaseLocGR.Text = "xrBaseLocGR";
            this.xrBaseLocGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpLocGR
            // 
            this.xrImpLocGR.CanGrow = false;
            this.xrImpLocGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.impuestos_loc", "{0:C2}")});
            this.xrImpLocGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrImpLocGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrImpLocGR.LocationFloat = new DevExpress.Utils.PointFloat(586.9999F, 1.999996F);
            this.xrImpLocGR.Name = "xrImpLocGR";
            this.xrImpLocGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpLocGR.SizeF = new System.Drawing.SizeF(75.02222F, 13F);
            this.xrImpLocGR.StyleName = "FieldCaption";
            this.xrImpLocGR.StylePriority.UseFont = false;
            this.xrImpLocGR.StylePriority.UseForeColor = false;
            this.xrImpLocGR.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrImpLocGR.Summary = xrSummary2;
            this.xrImpLocGR.Text = "xrImpLocGR";
            this.xrImpLocGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotLocGR
            // 
            this.xrTotLocGR.CanGrow = false;
            this.xrTotLocGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.total_loc", "{0:C2}")});
            this.xrTotLocGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrTotLocGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrTotLocGR.LocationFloat = new DevExpress.Utils.PointFloat(662.0221F, 1.999996F);
            this.xrTotLocGR.Name = "xrTotLocGR";
            this.xrTotLocGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotLocGR.SizeF = new System.Drawing.SizeF(74.98F, 13F);
            this.xrTotLocGR.StyleName = "FieldCaption";
            this.xrTotLocGR.StylePriority.UseFont = false;
            this.xrTotLocGR.StylePriority.UseForeColor = false;
            this.xrTotLocGR.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTotLocGR.Summary = xrSummary3;
            this.xrTotLocGR.Text = "xrTotLocGR";
            this.xrTotLocGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel31
            // 
            this.xrLabel31.CanGrow = false;
            this.xrLabel31.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(445.6249F, 1.999996F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(66.37497F, 13F);
            this.xrLabel31.StyleName = "FieldCaption";
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseForeColor = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Totales x C.:";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.HeightF = 0F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel46,
            this.xrLabel45,
            this.xrLine3,
            this.xrLabel36,
            this.xrLabel37,
            this.xrLabel40,
            this.xrLabel41,
            this.xrLabel42,
            this.xrLabel43,
            this.xrLabel44,
            this.xrLine4,
            this.xrTitLimite,
            this.xrTitPeriodo,
            this.xrLabel33,
            this.xrTitFecHoy,
            this.xrTituloGen,
            this.xrTitCompania,
            this.xrPageInfo3,
            this.xrLabel61});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PageHeader.HeightF = 114.5833F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrTituloGen
            // 
            this.xrTituloGen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrTituloGen.LocationFloat = new DevExpress.Utils.PointFloat(3.74999F, 33.74999F);
            this.xrTituloGen.Name = "xrTituloGen";
            this.xrTituloGen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTituloGen.SizeF = new System.Drawing.SizeF(733.2499F, 17F);
            this.xrTituloGen.StylePriority.UseFont = false;
            this.xrTituloGen.StylePriority.UseTextAlignment = false;
            this.xrTituloGen.Text = "REGISTRO DE VENTAS - DETALLE";
            this.xrTituloGen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitCompania
            // 
            this.xrTitCompania.CanGrow = false;
            this.xrTitCompania.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrTitCompania.LocationFloat = new DevExpress.Utils.PointFloat(87.99998F, 0F);
            this.xrTitCompania.Name = "xrTitCompania";
            this.xrTitCompania.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitCompania.SizeF = new System.Drawing.SizeF(231F, 16.75F);
            this.xrTitCompania.StylePriority.UseFont = false;
            this.xrTitCompania.Text = "---";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(621.397F, 1.041667F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(125.603F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel61
            // 
            this.xrLabel61.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(3.74999F, 6.67572E-06F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(81.25F, 16.75F);
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.Text = "EMPRESA :";
            // 
            // TitFecHoy
            // 
            this.TitFecHoy.DataMember = "SP_CB_REP_REGVENTAS_DAOT";
            this.TitFecHoy.Expression = "today()";
            this.TitFecHoy.Name = "TitFecHoy";
            // 
            // xrTitFecHoy
            // 
            this.xrTitFecHoy.CanGrow = false;
            this.xrTitFecHoy.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.TitFecHoy", "{0:dd/MM/yyyy}")});
            this.xrTitFecHoy.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrTitFecHoy.LocationFloat = new DevExpress.Utils.PointFloat(662.0221F, 17.00001F);
            this.xrTitFecHoy.Name = "xrTitFecHoy";
            this.xrTitFecHoy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTitFecHoy.SizeF = new System.Drawing.SizeF(84.97791F, 16.74999F);
            this.xrTitFecHoy.StylePriority.UseFont = false;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(621.397F, 17.00001F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(40.62506F, 16.74999F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.Text = "Fecha:";
            // 
            // TitPeriodo
            // 
            this.TitPeriodo.DataMember = "SP_CB_REP_REGVENTAS_DAOT";
            this.TitPeriodo.Expression = "\'Periodo: \' +  [Parameters.prmPeriodo]";
            this.TitPeriodo.Name = "TitPeriodo";
            // 
            // xrTitPeriodo
            // 
            this.xrTitPeriodo.CanGrow = false;
            this.xrTitPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.TitPeriodo")});
            this.xrTitPeriodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.xrTitPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(3.749974F, 50.75F);
            this.xrTitPeriodo.Name = "xrTitPeriodo";
            this.xrTitPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTitPeriodo.SizeF = new System.Drawing.SizeF(733.2499F, 17.79167F);
            this.xrTitPeriodo.StylePriority.UseFont = false;
            this.xrTitPeriodo.StylePriority.UseTextAlignment = false;
            this.xrTitPeriodo.Text = "xrTitPeriodo";
            this.xrTitPeriodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // titLimite
            // 
            this.titLimite.DataMember = "SP_CB_REP_REGVENTAS_DAOT";
            this.titLimite.Expression = "\'Paso Limite: \' + iif([Parameters.prmFlagSupera]=\'T\',\'Ambos\',iif([Parameters.prmF" +
    "lagSupera]=\'S\',\'SI\',\'NO\'))";
            this.titLimite.Name = "titLimite";
            // 
            // xrTitLimite
            // 
            this.xrTitLimite.CanGrow = false;
            this.xrTitLimite.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.titLimite")});
            this.xrTitLimite.LocationFloat = new DevExpress.Utils.PointFloat(3.749974F, 68.54169F);
            this.xrTitLimite.Name = "xrTitLimite";
            this.xrTitLimite.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTitLimite.SizeF = new System.Drawing.SizeF(733.2499F, 16.75F);
            this.xrTitLimite.StylePriority.UseTextAlignment = false;
            this.xrTitLimite.Text = "xrTitLimite";
            this.xrTitLimite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 95.72916F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(732F, 2F);
            // 
            // xrLabel36
            // 
            this.xrLabel36.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(5.000019F, 98.72917F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(40F, 12F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "Cliente";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel37
            // 
            this.xrLabel37.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(45.00001F, 98.72916F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(283.9999F, 11.99998F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "Razon Social";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(401.9999F, 98.72916F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(55F, 12F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "Numero";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel41
            // 
            this.xrLabel41.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(456.9999F, 98.72916F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(55F, 12F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.Text = "F.Emisión";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(511.9999F, 98.72916F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(75F, 12F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.Text = "Valor Venta S/.";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel43
            // 
            this.xrLabel43.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(586.9999F, 98.72916F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(75F, 11.99998F);
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "IVG";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(661.9999F, 98.72914F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(75F, 12F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "Total S/.";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(5.00001F, 111.7292F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(732F, 2F);
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(328.9999F, 98.72916F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(38F, 12F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.Text = "T.Doc.";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(366.9999F, 98.72913F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(35F, 12F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.Text = "Serie";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PieGeneral
            // 
            this.PieGeneral.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xr2UIT,
            this.xrLabel5,
            this.xrImpLocGR,
            this.xrTotLocGR,
            this.xrLabel31,
            this.xrBaseLocGR});
            this.PieGeneral.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.PieGeneral.HeightF = 15F;
            this.PieGeneral.Name = "PieGeneral";
            this.PieGeneral.StylePriority.UseFont = false;
            // 
            // PieSummary
            // 
            this.PieSummary.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrBaseLocTot,
            this.xrImpLocTot,
            this.xrTotLocTot,
            this.xrLine2});
            this.PieSummary.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.PieSummary.HeightF = 21.875F;
            this.PieSummary.Level = 1;
            this.PieSummary.Name = "PieSummary";
            this.PieSummary.StylePriority.UseFont = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(300.625F, 1.999996F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(66.37497F, 13F);
            this.xrLabel5.StyleName = "FieldCaption";
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Limite:";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xr2UIT
            // 
            this.xr2UIT.CanGrow = false;
            this.xr2UIT.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.n_2UIT", "{0:n2}")});
            this.xr2UIT.Font = new System.Drawing.Font("Arial", 7F);
            this.xr2UIT.LocationFloat = new DevExpress.Utils.PointFloat(366.9999F, 1.999996F);
            this.xr2UIT.Name = "xr2UIT";
            this.xr2UIT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xr2UIT.SizeF = new System.Drawing.SizeF(57.29169F, 13F);
            this.xr2UIT.StylePriority.UseFont = false;
            this.xr2UIT.StylePriority.UseTextAlignment = false;
            this.xr2UIT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(27F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(710F, 2F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(26.99988F, 1F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(710F, 2F);
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(445.625F, 5.000019F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(66.37497F, 13F);
            this.xrLabel7.StyleName = "FieldCaption";
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Totales:\r\n";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrBaseLocTot
            // 
            this.xrBaseLocTot.CanGrow = false;
            this.xrBaseLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.base_loc", "{0:C2}")});
            this.xrBaseLocTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrBaseLocTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrBaseLocTot.LocationFloat = new DevExpress.Utils.PointFloat(512F, 5.000019F);
            this.xrBaseLocTot.Name = "xrBaseLocTot";
            this.xrBaseLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBaseLocTot.SizeF = new System.Drawing.SizeF(75.00003F, 13F);
            this.xrBaseLocTot.StyleName = "FieldCaption";
            this.xrBaseLocTot.StylePriority.UseFont = false;
            this.xrBaseLocTot.StylePriority.UseForeColor = false;
            this.xrBaseLocTot.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0:n2}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrBaseLocTot.Summary = xrSummary4;
            this.xrBaseLocTot.Text = "xrLabel28";
            this.xrBaseLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrImpLocTot
            // 
            this.xrImpLocTot.CanGrow = false;
            this.xrImpLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.impuestos_loc", "{0:C2}")});
            this.xrImpLocTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrImpLocTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrImpLocTot.LocationFloat = new DevExpress.Utils.PointFloat(586.9999F, 5.000019F);
            this.xrImpLocTot.Name = "xrImpLocTot";
            this.xrImpLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpLocTot.SizeF = new System.Drawing.SizeF(75.02222F, 13F);
            this.xrImpLocTot.StyleName = "FieldCaption";
            this.xrImpLocTot.StylePriority.UseFont = false;
            this.xrImpLocTot.StylePriority.UseForeColor = false;
            this.xrImpLocTot.StylePriority.UseTextAlignment = false;
            xrSummary5.FormatString = "{0:n2}";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrImpLocTot.Summary = xrSummary5;
            this.xrImpLocTot.Text = "xrLabel29";
            this.xrImpLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTotLocTot
            // 
            this.xrTotLocTot.CanGrow = false;
            this.xrTotLocTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_REGVENTAS_DAOT.total_loc", "{0:C2}")});
            this.xrTotLocTot.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrTotLocTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrTotLocTot.LocationFloat = new DevExpress.Utils.PointFloat(662.0222F, 5.000007F);
            this.xrTotLocTot.Name = "xrTotLocTot";
            this.xrTotLocTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTotLocTot.SizeF = new System.Drawing.SizeF(74.98F, 13F);
            this.xrTotLocTot.StyleName = "FieldCaption";
            this.xrTotLocTot.StylePriority.UseFont = false;
            this.xrTotLocTot.StylePriority.UseForeColor = false;
            this.xrTotLocTot.StylePriority.UseTextAlignment = false;
            xrSummary6.FormatString = "{0:n2}";
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTotLocTot.Summary = xrSummary6;
            this.xrTotLocTot.Text = "xrLabel30";
            this.xrTotLocTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(358.5F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(65.79163F, 14.125F);
            this.xrLabel3.StyleName = "FieldCaption";
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.Text = "Paso Limite:";
            // 
            // xrFlagPaso
            // 
            this.xrFlagPaso.LocationFloat = new DevExpress.Utils.PointFloat(424.2917F, 0F);
            this.xrFlagPaso.Name = "xrFlagPaso";
            this.xrFlagPaso.SizeF = new System.Drawing.SizeF(17.71F, 12F);
            // 
            // rpt_RegistroVentaDaotDet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GrupoGeneral,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.PageHeader,
            this.PieGeneral,
            this.PieSummary});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TitFecHoy,
            this.TitPeriodo,
            this.titLimite});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_REGVENTAS_DAOT";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(41, 39, 35, 59);
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
        private DevExpress.XtraReports.UI.XRLabel xrClienteNombre;
        private DevExpress.XtraReports.UI.XRLabel xrTipoDoc;
        private DevExpress.XtraReports.UI.XRLabel xrSerDoc;
        private DevExpress.XtraReports.UI.XRLabel xrNumDoc;
        private DevExpress.XtraReports.UI.XRLabel xrFecEmi;
        private DevExpress.XtraReports.UI.XRLabel xrBaseLoc;
        private DevExpress.XtraReports.UI.XRLabel xrImpLoc;
        private DevExpress.XtraReports.UI.XRLabel xrTotLoc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoGeneral;
        private DevExpress.XtraReports.UI.XRLabel xrClienteRuc;
        private DevExpress.XtraReports.UI.XRLabel xrCodSunatC;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRLabel xrBaseLocGR;
        private DevExpress.XtraReports.UI.XRLabel xrImpLocGR;
        private DevExpress.XtraReports.UI.XRLabel xrTotLocGR;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter prmFlagSupera;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoConsulta;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrTituloGen;
        private DevExpress.XtraReports.UI.XRLabel xrTitCompania;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRLabel xrTitFecHoy;
        private DevExpress.XtraReports.UI.CalculatedField TitFecHoy;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.CalculatedField TitPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrTitPeriodo;
        private DevExpress.XtraReports.UI.XRLabel xrTitLimite;
        private DevExpress.XtraReports.UI.CalculatedField titLimite;
        private DevExpress.XtraReports.UI.XRLabel xrLabel46;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel37;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel42;
        private DevExpress.XtraReports.UI.XRLabel xrLabel43;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.GroupFooterBand PieGeneral;
        private DevExpress.XtraReports.UI.XRLabel xr2UIT;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.GroupFooterBand PieSummary;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrBaseLocTot;
        private DevExpress.XtraReports.UI.XRLabel xrImpLocTot;
        private DevExpress.XtraReports.UI.XRLabel xrTotLocTot;
        private DevExpress.XtraReports.UI.XRCheckBox xrFlagPaso;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
