namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_LibroMayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_LibroMayor));
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrCCosto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDebe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHaber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPersona = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPersonaDesc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTipoPago = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripV = new DevExpress.XtraReports.UI.XRLabel();
            this.xrVoucher = new DevExpress.XtraReports.UI.XRLabel();
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
            this.prmIncPerRel = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoRep = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTCCosto = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrFechaFinMes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.MonedaExp = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.GrupoCuenta2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.PieCuenta2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.GrupoCuenta = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.PieCuenta = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.VoucherDebe = new DevExpress.XtraReports.UI.CalculatedField();
            this.VoucherHaber = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrGRVoucherHaber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrGRVoucherDebe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrGRCuentaDebe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrGRCuentaHaber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCCosto,
            this.xrDebe,
            this.xrDocumento,
            this.xrFecha,
            this.xrHaber,
            this.xrPersona,
            this.xrPersonaDesc,
            this.xrTipoPago,
            this.xrDescripV,
            this.xrVoucher});
            this.Detail.HeightF = 19.625F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "DataField";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 26F;
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
            storedProcQuery1.Name = "SP_CB_REP_LIBROMAYOR";
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
            queryParameter7.Name = "@incperrel";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.prmIncPerRel]", typeof(string));
            queryParameter8.Name = "@tiporep";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoRep]", typeof(string));
            queryParameter9.Name = "@TCCosto";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTCCosto]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.Parameters.Add(queryParameter8);
            storedProcQuery1.Parameters.Add(queryParameter9);
            storedProcQuery1.StoredProcName = "SP_CB_REP_LIBROMAYOR";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // xrCCosto
            // 
            this.xrCCosto.CanGrow = false;
            this.xrCCosto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.centrocosto")});
            this.xrCCosto.Font = new System.Drawing.Font("Arial", 6F);
            this.xrCCosto.LocationFloat = new DevExpress.Utils.PointFloat(558.0357F, 0F);
            this.xrCCosto.Name = "xrCCosto";
            this.xrCCosto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrCCosto.SizeF = new System.Drawing.SizeF(25.19495F, 18F);
            this.xrCCosto.StylePriority.UseFont = false;
            this.xrCCosto.Text = "xrCCosto";
            // 
            // xrDebe
            // 
            this.xrDebe.CanGrow = false;
            this.xrDebe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.debe", "{0:n2}")});
            this.xrDebe.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDebe.LocationFloat = new DevExpress.Utils.PointFloat(583.2307F, 0F);
            this.xrDebe.Name = "xrDebe";
            this.xrDebe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrDebe.SizeF = new System.Drawing.SizeF(81.15424F, 18F);
            this.xrDebe.StylePriority.UseFont = false;
            this.xrDebe.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrDebe_BeforePrint);
            // 
            // xrDocumento
            // 
            this.xrDocumento.CanGrow = false;
            this.xrDocumento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.documento")});
            this.xrDocumento.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDocumento.LocationFloat = new DevExpress.Utils.PointFloat(494.1521F, 0F);
            this.xrDocumento.Name = "xrDocumento";
            this.xrDocumento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrDocumento.SizeF = new System.Drawing.SizeF(63.88364F, 18F);
            this.xrDocumento.StylePriority.UseFont = false;
            this.xrDocumento.Text = "xrDocumento";
            // 
            // xrFecha
            // 
            this.xrFecha.CanGrow = false;
            this.xrFecha.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.fecha", "{0:dd/MM/yyyy}")});
            this.xrFecha.Font = new System.Drawing.Font("Arial", 6F);
            this.xrFecha.LocationFloat = new DevExpress.Utils.PointFloat(4.900424F, 0F);
            this.xrFecha.Name = "xrFecha";
            this.xrFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrFecha.SizeF = new System.Drawing.SizeF(43.75839F, 18F);
            this.xrFecha.StylePriority.UseFont = false;
            // 
            // xrHaber
            // 
            this.xrHaber.CanGrow = false;
            this.xrHaber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.haber", "{0:n2}")});
            this.xrHaber.Font = new System.Drawing.Font("Arial", 6F);
            this.xrHaber.LocationFloat = new DevExpress.Utils.PointFloat(664.3849F, 0F);
            this.xrHaber.Name = "xrHaber";
            this.xrHaber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrHaber.SizeF = new System.Drawing.SizeF(74.61517F, 18F);
            this.xrHaber.StylePriority.UseFont = false;
            this.xrHaber.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrHaber_BeforePrint);
            // 
            // xrPersona
            // 
            this.xrPersona.CanGrow = false;
            this.xrPersona.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.persona")});
            this.xrPersona.Font = new System.Drawing.Font("Arial", 6F);
            this.xrPersona.LocationFloat = new DevExpress.Utils.PointFloat(308.7531F, 0F);
            this.xrPersona.Name = "xrPersona";
            this.xrPersona.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrPersona.SizeF = new System.Drawing.SizeF(44.41843F, 18F);
            this.xrPersona.StylePriority.UseFont = false;
            this.xrPersona.Text = "xrPersona";
            // 
            // xrPersonaDesc
            // 
            this.xrPersonaDesc.CanGrow = false;
            this.xrPersonaDesc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.personades")});
            this.xrPersonaDesc.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrPersonaDesc.LocationFloat = new DevExpress.Utils.PointFloat(353.1715F, 0F);
            this.xrPersonaDesc.Name = "xrPersonaDesc";
            this.xrPersonaDesc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrPersonaDesc.SizeF = new System.Drawing.SizeF(140.9806F, 18F);
            this.xrPersonaDesc.StylePriority.UseFont = false;
            this.xrPersonaDesc.Text = "xrPersonaDesc";
            // 
            // xrTipoPago
            // 
            this.xrTipoPago.CanGrow = false;
            this.xrTipoPago.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.tipopago")});
            this.xrTipoPago.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrTipoPago.LocationFloat = new DevExpress.Utils.PointFloat(101.9167F, 0F);
            this.xrTipoPago.Name = "xrTipoPago";
            this.xrTipoPago.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTipoPago.SizeF = new System.Drawing.SizeF(47.59966F, 18F);
            this.xrTipoPago.StylePriority.UseFont = false;
            this.xrTipoPago.Text = "xrTipoPago";
            // 
            // xrDescripV
            // 
            this.xrDescripV.CanGrow = false;
            this.xrDescripV.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.v_descrip")});
            this.xrDescripV.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDescripV.LocationFloat = new DevExpress.Utils.PointFloat(149.5164F, 0F);
            this.xrDescripV.Name = "xrDescripV";
            this.xrDescripV.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrDescripV.SizeF = new System.Drawing.SizeF(159.2367F, 18F);
            this.xrDescripV.StylePriority.UseFont = false;
            this.xrDescripV.Text = "xrDescripV";
            // 
            // xrVoucher
            // 
            this.xrVoucher.CanGrow = false;
            this.xrVoucher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.voucher")});
            this.xrVoucher.Font = new System.Drawing.Font("Arial", 6F);
            this.xrVoucher.LocationFloat = new DevExpress.Utils.PointFloat(48.65882F, 0F);
            this.xrVoucher.Name = "xrVoucher";
            this.xrVoucher.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrVoucher.SizeF = new System.Drawing.SizeF(53.25785F, 18F);
            this.xrVoucher.StylePriority.UseFont = false;
            this.xrVoucher.Text = "xrVoucher";
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
            this.Title.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Teal;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font("Arial", 10F);
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
            // prmIncPerRel
            // 
            this.prmIncPerRel.Name = "prmIncPerRel";
            // 
            // prmTipoRep
            // 
            this.prmTipoRep.Name = "prmTipoRep";
            // 
            // prmTCCosto
            // 
            this.prmTCCosto.Name = "prmTCCosto";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel53,
            this.xrLabel52,
            this.xrLabel68,
            this.xrLabel67,
            this.xrLabel66,
            this.xrLabel65,
            this.xrLabel64,
            this.xrLabel63,
            this.xrLabel62,
            this.xrLabel61,
            this.xrLabel50,
            this.xrLabel49,
            this.xrLabel48,
            this.xrLabel47,
            this.xrPageInfo3,
            this.xrFechaFinMes,
            this.xrLabel51,
            this.xrLabel37,
            this.xrLabel44,
            this.xrLabel45,
            this.xrLabel46});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F);
            this.PageHeader.HeightF = 98.95834F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel51
            // 
            this.xrLabel51.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(4F, 18.70832F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(61.45833F, 15.70833F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.Text = "PERIODO:";
            // 
            // xrLabel37
            // 
            this.xrLabel37.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(4F, 66.83333F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(79.16665F, 15.70833F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.Text = "Expresado en ";
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(4F, 50.12502F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(97.91665F, 15.70833F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.Text = "RAZON SOCIAL :";
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(4F, 34.41667F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(32.29167F, 15.70833F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.Text = "RUC:";
            // 
            // xrLabel46
            // 
            this.xrLabel46.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(4F, 3F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(205.2083F, 15.70833F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.Text = "FORMATO 6.1: LIBRO MAYOR";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(528.9015F, 3.000005F);
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
            this.xrFechaFinMes.LocationFloat = new DevExpress.Utils.PointFloat(656.4847F, 3.000005F);
            this.xrFechaFinMes.Name = "xrFechaFinMes";
            this.xrFechaFinMes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFechaFinMes.SizeF = new System.Drawing.SizeF(82.51532F, 15.70834F);
            this.xrFechaFinMes.StylePriority.UseFont = false;
            this.xrFechaFinMes.Text = "xrFechaFinMes";
            // 
            // xrLabel47
            // 
            this.xrLabel47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriodo, "Text", "")});
            this.xrLabel47.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(65.45833F, 18.70832F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(100F, 15.70833F);
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.Text = "xrLabel47";
            // 
            // xrLabel48
            // 
            this.xrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.ruc")});
            this.xrLabel48.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(36.29166F, 34.41665F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(129.1667F, 15.70833F);
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.Text = "xrLabel48";
            // 
            // xrLabel49
            // 
            this.xrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.NOMBRECOMPANIA")});
            this.xrLabel49.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(101.9167F, 50.12503F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(335.3283F, 15.70832F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.Text = "xrLabel49";
            // 
            // MonedaExp
            // 
            this.MonedaExp.DataMember = "SP_CB_REP_LIBROMAYOR";
            this.MonedaExp.Expression = "Iif([Parameters.prmMoneda]=\'L\',\'Moneda Local\'  ,\'Moneda Extranjera\' )";
            this.MonedaExp.Name = "MonedaExp";
            // 
            // xrLabel50
            // 
            this.xrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.MonedaExp")});
            this.xrLabel50.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(85.0605F, 66.83334F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(165.0645F, 15.70832F);
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.Text = "xrLabel50";
            // 
            // xrLabel68
            // 
            this.xrLabel68.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel68.BorderColor = System.Drawing.Color.Black;
            this.xrLabel68.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel68.BorderWidth = 1F;
            this.xrLabel68.CanGrow = false;
            this.xrLabel68.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel68.ForeColor = System.Drawing.Color.Black;
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(101.9167F, 85.54166F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(47.59966F, 11F);
            this.xrLabel68.StylePriority.UseBackColor = false;
            this.xrLabel68.StylePriority.UseBorderColor = false;
            this.xrLabel68.StylePriority.UseBorders = false;
            this.xrLabel68.StylePriority.UseBorderWidth = false;
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UseForeColor = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            this.xrLabel68.Text = "F.Pago";
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel67
            // 
            this.xrLabel67.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel67.BorderColor = System.Drawing.Color.Black;
            this.xrLabel67.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel67.BorderWidth = 1F;
            this.xrLabel67.CanGrow = false;
            this.xrLabel67.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel67.ForeColor = System.Drawing.Color.Black;
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(149.5163F, 85.54166F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(159.2368F, 11F);
            this.xrLabel67.StylePriority.UseBackColor = false;
            this.xrLabel67.StylePriority.UseBorderColor = false;
            this.xrLabel67.StylePriority.UseBorders = false;
            this.xrLabel67.StylePriority.UseBorderWidth = false;
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseForeColor = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            this.xrLabel67.Text = "Descripcion de Operación";
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel66
            // 
            this.xrLabel66.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel66.BorderColor = System.Drawing.Color.Black;
            this.xrLabel66.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel66.BorderWidth = 1F;
            this.xrLabel66.CanGrow = false;
            this.xrLabel66.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel66.ForeColor = System.Drawing.Color.Black;
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(583.2307F, 85.54166F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(81.1543F, 11F);
            this.xrLabel66.StylePriority.UseBackColor = false;
            this.xrLabel66.StylePriority.UseBorderColor = false;
            this.xrLabel66.StylePriority.UseBorders = false;
            this.xrLabel66.StylePriority.UseBorderWidth = false;
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseForeColor = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            this.xrLabel66.Text = "Debe";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel65
            // 
            this.xrLabel65.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel65.BorderColor = System.Drawing.Color.Black;
            this.xrLabel65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel65.BorderWidth = 1F;
            this.xrLabel65.CanGrow = false;
            this.xrLabel65.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.ForeColor = System.Drawing.Color.Black;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(48.65882F, 85.5416F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(53.25782F, 11F);
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
            // xrLabel64
            // 
            this.xrLabel64.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel64.BorderColor = System.Drawing.Color.Black;
            this.xrLabel64.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel64.BorderWidth = 1F;
            this.xrLabel64.CanGrow = false;
            this.xrLabel64.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel64.ForeColor = System.Drawing.Color.Black;
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(664.3849F, 85.54166F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(74.61511F, 10.99998F);
            this.xrLabel64.StylePriority.UseBackColor = false;
            this.xrLabel64.StylePriority.UseBorderColor = false;
            this.xrLabel64.StylePriority.UseBorders = false;
            this.xrLabel64.StylePriority.UseBorderWidth = false;
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseForeColor = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            this.xrLabel64.Text = "Haber";
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel63
            // 
            this.xrLabel63.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel63.BorderColor = System.Drawing.Color.Black;
            this.xrLabel63.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel63.BorderWidth = 1F;
            this.xrLabel63.CanGrow = false;
            this.xrLabel63.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel63.ForeColor = System.Drawing.Color.Black;
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(353.1715F, 85.5416F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(140.9806F, 11F);
            this.xrLabel63.StylePriority.UseBackColor = false;
            this.xrLabel63.StylePriority.UseBorderColor = false;
            this.xrLabel63.StylePriority.UseBorders = false;
            this.xrLabel63.StylePriority.UseBorderWidth = false;
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseForeColor = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            this.xrLabel63.Text = "Razon Social";
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel62
            // 
            this.xrLabel62.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel62.BorderColor = System.Drawing.Color.Black;
            this.xrLabel62.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel62.BorderWidth = 1F;
            this.xrLabel62.CanGrow = false;
            this.xrLabel62.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel62.ForeColor = System.Drawing.Color.Black;
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(308.7531F, 85.54166F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(44.4184F, 11F);
            this.xrLabel62.StylePriority.UseBackColor = false;
            this.xrLabel62.StylePriority.UseBorderColor = false;
            this.xrLabel62.StylePriority.UseBorders = false;
            this.xrLabel62.StylePriority.UseBorderWidth = false;
            this.xrLabel62.StylePriority.UseFont = false;
            this.xrLabel62.StylePriority.UseForeColor = false;
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            this.xrLabel62.Text = "Persona";
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(4.900424F, 85.5416F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(43.7584F, 11F);
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
            // xrLabel52
            // 
            this.xrLabel52.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel52.BorderColor = System.Drawing.Color.Black;
            this.xrLabel52.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel52.BorderWidth = 1F;
            this.xrLabel52.CanGrow = false;
            this.xrLabel52.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel52.ForeColor = System.Drawing.Color.Black;
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(494.1521F, 85.54166F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(63.88367F, 11F);
            this.xrLabel52.StylePriority.UseBackColor = false;
            this.xrLabel52.StylePriority.UseBorderColor = false;
            this.xrLabel52.StylePriority.UseBorders = false;
            this.xrLabel52.StylePriority.UseBorderWidth = false;
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseForeColor = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "Documento";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel53
            // 
            this.xrLabel53.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel53.BorderColor = System.Drawing.Color.Black;
            this.xrLabel53.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel53.BorderWidth = 1F;
            this.xrLabel53.CanGrow = false;
            this.xrLabel53.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel53.ForeColor = System.Drawing.Color.Black;
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(558.0358F, 85.5416F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(25.19489F, 11F);
            this.xrLabel53.StylePriority.UseBackColor = false;
            this.xrLabel53.StylePriority.UseBorderColor = false;
            this.xrLabel53.StylePriority.UseBorders = false;
            this.xrLabel53.StylePriority.UseBorderWidth = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseForeColor = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.Text = "C.C";
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GrupoCuenta2
            // 
            this.GrupoCuenta2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cuenta2", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoCuenta2.HeightF = 0F;
            this.GrupoCuenta2.Level = 1;
            this.GrupoCuenta2.Name = "GrupoCuenta2";
            // 
            // PieCuenta2
            // 
            this.PieCuenta2.HeightF = 22.91667F;
            this.PieCuenta2.Level = 1;
            this.PieCuenta2.Name = "PieCuenta2";
            // 
            // GrupoCuenta
            // 
            this.GrupoCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.GrupoCuenta.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.GrupoCuenta.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cuenta", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GrupoCuenta.HeightF = 18.75F;
            this.GrupoCuenta.Name = "GrupoCuenta";
            this.GrupoCuenta.StylePriority.UseFont = false;
            // 
            // PieCuenta
            // 
            this.PieCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrGRCuentaHaber,
            this.xrGRCuentaDebe,
            this.xrGRVoucherHaber,
            this.xrGRVoucherDebe});
            this.PieCuenta.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.PieCuenta.HeightF = 41.66667F;
            this.PieCuenta.Name = "PieCuenta";
            this.PieCuenta.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(7.900429F, 1.999982F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(104.2662F, 15.70833F);
            this.xrLabel1.Text = "Cuenta Contable :";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.cuenta")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(112.1667F, 1.999982F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(84.375F, 15.70833F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // VoucherDebe
            // 
            this.VoucherDebe.DataMember = "SP_CB_REP_LIBROMAYOR";
            this.VoucherDebe.Expression = "iif([voucher]=\'\',0,[debe])";
            this.VoucherDebe.Name = "VoucherDebe";
            // 
            // VoucherHaber
            // 
            this.VoucherHaber.DataMember = "SP_CB_REP_LIBROMAYOR";
            this.VoucherHaber.Expression = "iif([voucher]=\'\',0,[haber])";
            this.VoucherHaber.Name = "VoucherHaber";
            // 
            // xrGRVoucherHaber
            // 
            this.xrGRVoucherHaber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.VoucherHaber")});
            this.xrGRVoucherHaber.LocationFloat = new DevExpress.Utils.PointFloat(656.4848F, 0F);
            this.xrGRVoucherHaber.Name = "xrGRVoucherHaber";
            this.xrGRVoucherHaber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRVoucherHaber.SizeF = new System.Drawing.SizeF(81.1543F, 15.70833F);
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrGRVoucherHaber.Summary = xrSummary3;
            // 
            // xrGRVoucherDebe
            // 
            this.xrGRVoucherDebe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.VoucherDebe")});
            this.xrGRVoucherDebe.LocationFloat = new DevExpress.Utils.PointFloat(575.3305F, 0F);
            this.xrGRVoucherDebe.Name = "xrGRVoucherDebe";
            this.xrGRVoucherDebe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRVoucherDebe.SizeF = new System.Drawing.SizeF(81.1543F, 15.70833F);
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrGRVoucherDebe.Summary = xrSummary4;
            // 
            // xrGRCuentaDebe
            // 
            this.xrGRCuentaDebe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.debe")});
            this.xrGRCuentaDebe.LocationFloat = new DevExpress.Utils.PointFloat(319.7917F, 0F);
            this.xrGRCuentaDebe.Name = "xrGRCuentaDebe";
            this.xrGRCuentaDebe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrGRCuentaDebe.SizeF = new System.Drawing.SizeF(60.41666F, 12.58333F);
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrGRCuentaDebe.Summary = xrSummary2;
            // 
            // xrGRCuentaHaber
            // 
            this.xrGRCuentaHaber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBROMAYOR.haber")});
            this.xrGRCuentaHaber.LocationFloat = new DevExpress.Utils.PointFloat(380.2083F, 0F);
            this.xrGRCuentaHaber.Name = "xrGRCuentaHaber";
            this.xrGRCuentaHaber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRCuentaHaber.SizeF = new System.Drawing.SizeF(64.58334F, 12.58333F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrGRCuentaHaber.Summary = xrSummary1;
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(3.999996F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(145.5163F, 15.70833F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Total Movimiento del Mes  ---> ";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // rpt_LibroMayor
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.reportFooterBand1,
            this.PageHeader,
            this.GrupoCuenta2,
            this.PieCuenta2,
            this.GrupoCuenta,
            this.PieCuenta});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.MonedaExp,
            this.VoucherDebe,
            this.VoucherHaber});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_LIBROMAYOR";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(41, 47, 26, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmMoneda,
            this.prmCuentaIni,
            this.prmCuentaFin,
            this.prmTipoCuenta,
            this.prmIncPerRel,
            this.prmTipoRep,
            this.prmTCCosto});
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
        private DevExpress.XtraReports.UI.XRLabel xrCCosto;
        private DevExpress.XtraReports.UI.XRLabel xrDebe;
        private DevExpress.XtraReports.UI.XRLabel xrDocumento;
        private DevExpress.XtraReports.UI.XRLabel xrFecha;
        private DevExpress.XtraReports.UI.XRLabel xrHaber;
        private DevExpress.XtraReports.UI.XRLabel xrPersona;
        private DevExpress.XtraReports.UI.XRLabel xrPersonaDesc;
        private DevExpress.XtraReports.UI.XRLabel xrTipoPago;
        private DevExpress.XtraReports.UI.XRLabel xrDescripV;
        private DevExpress.XtraReports.UI.XRLabel xrVoucher;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
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
        private DevExpress.XtraReports.Parameters.Parameter prmIncPerRel;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoRep;
        private DevExpress.XtraReports.Parameters.Parameter prmTCCosto;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel51;
        private DevExpress.XtraReports.UI.XRLabel xrLabel37;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.XtraReports.UI.XRLabel xrLabel46;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrFechaFinMes;
        private DevExpress.XtraReports.UI.XRLabel xrLabel48;
        private DevExpress.XtraReports.UI.XRLabel xrLabel47;
        private DevExpress.XtraReports.UI.XRLabel xrLabel49;
        private DevExpress.XtraReports.UI.XRLabel xrLabel50;
        private DevExpress.XtraReports.UI.CalculatedField MonedaExp;
        private DevExpress.XtraReports.UI.XRLabel xrLabel68;
        private DevExpress.XtraReports.UI.XRLabel xrLabel67;
        private DevExpress.XtraReports.UI.XRLabel xrLabel66;
        private DevExpress.XtraReports.UI.XRLabel xrLabel65;
        private DevExpress.XtraReports.UI.XRLabel xrLabel64;
        private DevExpress.XtraReports.UI.XRLabel xrLabel63;
        private DevExpress.XtraReports.UI.XRLabel xrLabel62;
        private DevExpress.XtraReports.UI.XRLabel xrLabel61;
        private DevExpress.XtraReports.UI.XRLabel xrLabel53;
        private DevExpress.XtraReports.UI.XRLabel xrLabel52;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoCuenta2;
        private DevExpress.XtraReports.UI.GroupFooterBand PieCuenta2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GrupoCuenta;
        private DevExpress.XtraReports.UI.GroupFooterBand PieCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.CalculatedField VoucherDebe;
        private DevExpress.XtraReports.UI.CalculatedField VoucherHaber;
        private DevExpress.XtraReports.UI.XRLabel xrGRVoucherHaber;
        private DevExpress.XtraReports.UI.XRLabel xrGRVoucherDebe;
        private DevExpress.XtraReports.UI.XRLabel xrGRCuentaHaber;
        private DevExpress.XtraReports.UI.XRLabel xrGRCuentaDebe;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
