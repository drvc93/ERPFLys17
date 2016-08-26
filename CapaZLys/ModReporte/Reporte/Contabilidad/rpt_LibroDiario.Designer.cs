namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad
{
    partial class rpt_LibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_LibroDiario));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLinea = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCuenta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripCta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPersona = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCCosto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescripD = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDebe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHaber = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.pageHeaderBand1 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrFechaFinMes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.prmPeriodo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.PeriodoVoucher = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrDescripVGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrFechaGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPeriodoVouchGR = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHaberGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDebeGR = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrDebeTot = new DevExpress.XtraReports.UI.XRLabel();
            this.xrHaberTot = new DevExpress.XtraReports.UI.XRLabel();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmMoneda = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoCuenta = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmIncPerRel = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTipoRep = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmTCCosto = new DevExpress.XtraReports.Parameters.Parameter();
            this.MonedaExp = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLinea,
            this.xrDocumento,
            this.xrCuenta,
            this.xrDescripCta,
            this.xrPersona,
            this.xrCCosto,
            this.xrDescripD,
            this.xrDebe,
            this.xrHaber});
            this.Detail.HeightF = 14.66662F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLinea
            // 
            this.xrLinea.BackColor = System.Drawing.Color.Transparent;
            this.xrLinea.BorderColor = System.Drawing.Color.Black;
            this.xrLinea.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLinea.BorderWidth = 1F;
            this.xrLinea.CanGrow = false;
            this.xrLinea.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.linea")});
            this.xrLinea.Font = new System.Drawing.Font("Arial", 6F);
            this.xrLinea.ForeColor = System.Drawing.Color.Black;
            this.xrLinea.LocationFloat = new DevExpress.Utils.PointFloat(4.999987F, 0F);
            this.xrLinea.Name = "xrLinea";
            this.xrLinea.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLinea.SizeF = new System.Drawing.SizeF(28.17501F, 14.66661F);
            this.xrLinea.StylePriority.UseBackColor = false;
            this.xrLinea.StylePriority.UseBorderColor = false;
            this.xrLinea.StylePriority.UseBorders = false;
            this.xrLinea.StylePriority.UseBorderWidth = false;
            this.xrLinea.StylePriority.UseFont = false;
            this.xrLinea.StylePriority.UseForeColor = false;
            this.xrLinea.StylePriority.UsePadding = false;
            this.xrLinea.StylePriority.UseTextAlignment = false;
            this.xrLinea.Text = "xrLinea";
            this.xrLinea.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrDocumento
            // 
            this.xrDocumento.BackColor = System.Drawing.Color.Transparent;
            this.xrDocumento.BorderColor = System.Drawing.Color.Black;
            this.xrDocumento.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrDocumento.BorderWidth = 1F;
            this.xrDocumento.CanGrow = false;
            this.xrDocumento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.documento")});
            this.xrDocumento.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDocumento.ForeColor = System.Drawing.Color.Black;
            this.xrDocumento.LocationFloat = new DevExpress.Utils.PointFloat(33.17499F, 0F);
            this.xrDocumento.Name = "xrDocumento";
            this.xrDocumento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDocumento.SizeF = new System.Drawing.SizeF(94.3251F, 14.66661F);
            this.xrDocumento.StylePriority.UseBackColor = false;
            this.xrDocumento.StylePriority.UseBorderColor = false;
            this.xrDocumento.StylePriority.UseBorders = false;
            this.xrDocumento.StylePriority.UseBorderWidth = false;
            this.xrDocumento.StylePriority.UseFont = false;
            this.xrDocumento.StylePriority.UseForeColor = false;
            this.xrDocumento.StylePriority.UsePadding = false;
            this.xrDocumento.StylePriority.UseTextAlignment = false;
            this.xrDocumento.Text = "xrDocumento";
            this.xrDocumento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCuenta
            // 
            this.xrCuenta.BackColor = System.Drawing.Color.Transparent;
            this.xrCuenta.BorderColor = System.Drawing.Color.Black;
            this.xrCuenta.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCuenta.BorderWidth = 1F;
            this.xrCuenta.CanGrow = false;
            this.xrCuenta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.cuenta")});
            this.xrCuenta.Font = new System.Drawing.Font("Arial", 6F);
            this.xrCuenta.ForeColor = System.Drawing.Color.Black;
            this.xrCuenta.LocationFloat = new DevExpress.Utils.PointFloat(127.5001F, 0F);
            this.xrCuenta.Name = "xrCuenta";
            this.xrCuenta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCuenta.SizeF = new System.Drawing.SizeF(47.59956F, 14.66661F);
            this.xrCuenta.StylePriority.UseBackColor = false;
            this.xrCuenta.StylePriority.UseBorderColor = false;
            this.xrCuenta.StylePriority.UseBorders = false;
            this.xrCuenta.StylePriority.UseBorderWidth = false;
            this.xrCuenta.StylePriority.UseFont = false;
            this.xrCuenta.StylePriority.UseForeColor = false;
            this.xrCuenta.StylePriority.UsePadding = false;
            this.xrCuenta.StylePriority.UseTextAlignment = false;
            this.xrCuenta.Text = "xrCuenta";
            this.xrCuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrDescripCta
            // 
            this.xrDescripCta.BackColor = System.Drawing.Color.Transparent;
            this.xrDescripCta.BorderColor = System.Drawing.Color.Black;
            this.xrDescripCta.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrDescripCta.BorderWidth = 1F;
            this.xrDescripCta.CanGrow = false;
            this.xrDescripCta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.descrip_cta")});
            this.xrDescripCta.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDescripCta.ForeColor = System.Drawing.Color.Black;
            this.xrDescripCta.LocationFloat = new DevExpress.Utils.PointFloat(175.0997F, 0F);
            this.xrDescripCta.Name = "xrDescripCta";
            this.xrDescripCta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripCta.SizeF = new System.Drawing.SizeF(148.9003F, 14.66661F);
            this.xrDescripCta.StylePriority.UseBackColor = false;
            this.xrDescripCta.StylePriority.UseBorderColor = false;
            this.xrDescripCta.StylePriority.UseBorders = false;
            this.xrDescripCta.StylePriority.UseBorderWidth = false;
            this.xrDescripCta.StylePriority.UseFont = false;
            this.xrDescripCta.StylePriority.UseForeColor = false;
            this.xrDescripCta.StylePriority.UsePadding = false;
            this.xrDescripCta.StylePriority.UseTextAlignment = false;
            this.xrDescripCta.Text = "xrDescripCuenta";
            this.xrDescripCta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPersona
            // 
            this.xrPersona.BackColor = System.Drawing.Color.Transparent;
            this.xrPersona.BorderColor = System.Drawing.Color.Black;
            this.xrPersona.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPersona.BorderWidth = 1F;
            this.xrPersona.CanGrow = false;
            this.xrPersona.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.persona")});
            this.xrPersona.Font = new System.Drawing.Font("Arial", 6F);
            this.xrPersona.ForeColor = System.Drawing.Color.Black;
            this.xrPersona.LocationFloat = new DevExpress.Utils.PointFloat(323.9999F, 0F);
            this.xrPersona.Name = "xrPersona";
            this.xrPersona.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPersona.SizeF = new System.Drawing.SizeF(43.35669F, 14.66661F);
            this.xrPersona.StylePriority.UseBackColor = false;
            this.xrPersona.StylePriority.UseBorderColor = false;
            this.xrPersona.StylePriority.UseBorders = false;
            this.xrPersona.StylePriority.UseBorderWidth = false;
            this.xrPersona.StylePriority.UseFont = false;
            this.xrPersona.StylePriority.UseForeColor = false;
            this.xrPersona.StylePriority.UsePadding = false;
            this.xrPersona.StylePriority.UseTextAlignment = false;
            this.xrPersona.Text = "xrPersona";
            this.xrPersona.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCCosto
            // 
            this.xrCCosto.BackColor = System.Drawing.Color.Transparent;
            this.xrCCosto.BorderColor = System.Drawing.Color.Black;
            this.xrCCosto.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCCosto.BorderWidth = 1F;
            this.xrCCosto.CanGrow = false;
            this.xrCCosto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.centrocosto")});
            this.xrCCosto.Font = new System.Drawing.Font("Arial", 6F);
            this.xrCCosto.ForeColor = System.Drawing.Color.Black;
            this.xrCCosto.LocationFloat = new DevExpress.Utils.PointFloat(367.3566F, 0F);
            this.xrCCosto.Name = "xrCCosto";
            this.xrCCosto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCCosto.SizeF = new System.Drawing.SizeF(21.86804F, 14.66661F);
            this.xrCCosto.StylePriority.UseBackColor = false;
            this.xrCCosto.StylePriority.UseBorderColor = false;
            this.xrCCosto.StylePriority.UseBorders = false;
            this.xrCCosto.StylePriority.UseBorderWidth = false;
            this.xrCCosto.StylePriority.UseFont = false;
            this.xrCCosto.StylePriority.UseForeColor = false;
            this.xrCCosto.StylePriority.UsePadding = false;
            this.xrCCosto.StylePriority.UseTextAlignment = false;
            this.xrCCosto.Text = "xrCCosto";
            this.xrCCosto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrDescripD
            // 
            this.xrDescripD.BackColor = System.Drawing.Color.Transparent;
            this.xrDescripD.BorderColor = System.Drawing.Color.Black;
            this.xrDescripD.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrDescripD.BorderWidth = 1F;
            this.xrDescripD.CanGrow = false;
            this.xrDescripD.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.d_descrip")});
            this.xrDescripD.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDescripD.ForeColor = System.Drawing.Color.Black;
            this.xrDescripD.LocationFloat = new DevExpress.Utils.PointFloat(389.2246F, 0F);
            this.xrDescripD.Name = "xrDescripD";
            this.xrDescripD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripD.SizeF = new System.Drawing.SizeF(193.1056F, 14.66661F);
            this.xrDescripD.StylePriority.UseBackColor = false;
            this.xrDescripD.StylePriority.UseBorderColor = false;
            this.xrDescripD.StylePriority.UseBorders = false;
            this.xrDescripD.StylePriority.UseBorderWidth = false;
            this.xrDescripD.StylePriority.UseFont = false;
            this.xrDescripD.StylePriority.UseForeColor = false;
            this.xrDescripD.StylePriority.UsePadding = false;
            this.xrDescripD.StylePriority.UseTextAlignment = false;
            this.xrDescripD.Text = "xrDescripD";
            this.xrDescripD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrDebe
            // 
            this.xrDebe.BackColor = System.Drawing.Color.Transparent;
            this.xrDebe.BorderColor = System.Drawing.Color.Black;
            this.xrDebe.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrDebe.BorderWidth = 1F;
            this.xrDebe.CanGrow = false;
            this.xrDebe.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.debe", "{0:n2}")});
            this.xrDebe.Font = new System.Drawing.Font("Arial", 6F);
            this.xrDebe.ForeColor = System.Drawing.Color.Black;
            this.xrDebe.LocationFloat = new DevExpress.Utils.PointFloat(582.3302F, 0F);
            this.xrDebe.Name = "xrDebe";
            this.xrDebe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDebe.SizeF = new System.Drawing.SizeF(81.1543F, 14.66661F);
            this.xrDebe.StylePriority.UseBackColor = false;
            this.xrDebe.StylePriority.UseBorderColor = false;
            this.xrDebe.StylePriority.UseBorders = false;
            this.xrDebe.StylePriority.UseBorderWidth = false;
            this.xrDebe.StylePriority.UseFont = false;
            this.xrDebe.StylePriority.UseForeColor = false;
            this.xrDebe.StylePriority.UsePadding = false;
            this.xrDebe.StylePriority.UseTextAlignment = false;
            this.xrDebe.Text = "xrDebe";
            this.xrDebe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebe.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrDebe_BeforePrint);
            // 
            // xrHaber
            // 
            this.xrHaber.BackColor = System.Drawing.Color.Transparent;
            this.xrHaber.BorderColor = System.Drawing.Color.Black;
            this.xrHaber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrHaber.BorderWidth = 1F;
            this.xrHaber.CanGrow = false;
            this.xrHaber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.haber", "{0:n2}")});
            this.xrHaber.Font = new System.Drawing.Font("Arial", 6F);
            this.xrHaber.ForeColor = System.Drawing.Color.Black;
            this.xrHaber.LocationFloat = new DevExpress.Utils.PointFloat(663.4844F, 0F);
            this.xrHaber.Name = "xrHaber";
            this.xrHaber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHaber.SizeF = new System.Drawing.SizeF(82.5155F, 14.66661F);
            this.xrHaber.StylePriority.UseBackColor = false;
            this.xrHaber.StylePriority.UseBorderColor = false;
            this.xrHaber.StylePriority.UseBorders = false;
            this.xrHaber.StylePriority.UseBorderWidth = false;
            this.xrHaber.StylePriority.UseFont = false;
            this.xrHaber.StylePriority.UseForeColor = false;
            this.xrHaber.StylePriority.UsePadding = false;
            this.xrHaber.StylePriority.UseTextAlignment = false;
            this.xrHaber.Text = "xrHaber";
            this.xrHaber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrHaber.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrHaber_BeforePrint);
            // 
            // TopMargin
            // 
            this.TopMargin.Font = new System.Drawing.Font("Arial", 8F);
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseFont = false;
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
            storedProcQuery1.Name = "SP_CB_REP_LIBRODIARIO";
            queryParameter1.Name = "@compania";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@periodo";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPeriodo]", typeof(string));
            queryParameter3.Name = "@moneda";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmMoneda]", typeof(string));
            queryParameter4.Name = "@tipocta";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoCuenta]", typeof(string));
            queryParameter5.Name = "@incperrel";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.prmIncPerRel]", typeof(string));
            queryParameter6.Name = "@tiporep";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTipoRep]", typeof(string));
            queryParameter7.Name = "@TCCosto";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.prmTCCosto]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.StoredProcName = "SP_CB_REP_LIBRODIARIO";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // pageHeaderBand1
            // 
            this.pageHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrFechaFinMes,
            this.xrLabel13,
            this.xrLabel4,
            this.xrLabel3,
            this.xrPageInfo3,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel5,
            this.xrLabel1,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel14,
            this.xrLabel16,
            this.xrLabel21,
            this.xrLabel19,
            this.xrLabel17,
            this.xrLabel22,
            this.xrLabel15,
            this.xrLabel18,
            this.xrLabel2});
            this.pageHeaderBand1.Font = new System.Drawing.Font("Arial", 8F);
            this.pageHeaderBand1.HeightF = 113.0832F;
            this.pageHeaderBand1.Name = "pageHeaderBand1";
            this.pageHeaderBand1.StylePriority.UseFont = false;
            // 
            // xrFechaFinMes
            // 
            this.xrFechaFinMes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrFechaFinMes.LocationFloat = new DevExpress.Utils.PointFloat(664.4846F, 3.999996F);
            this.xrFechaFinMes.Name = "xrFechaFinMes";
            this.xrFechaFinMes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFechaFinMes.SizeF = new System.Drawing.SizeF(82.51532F, 15.70834F);
            this.xrFechaFinMes.StylePriority.UseFont = false;
            this.xrFechaFinMes.Text = "xrFechaFinMes";
            // 
            // xrLabel13
            // 
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.MonedaExp")});
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(84.16663F, 66.83334F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(209.375F, 15.70833F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "xrLabel13";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.prmPeriodo, "Text", "")});
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(66.45832F, 19.70833F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(90.62507F, 16.66667F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // prmPeriodo
            // 
            this.prmPeriodo.Description = "Periodo";
            this.prmPeriodo.Name = "prmPeriodo";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.nombrecompania")});
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(102.9167F, 51.04167F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(328.125F, 15.79168F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(536.9012F, 3.999996F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(127.5833F, 15.70834F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(5F, 19.70832F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(61.45833F, 15.70833F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "PERIODO:";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(5F, 35.41667F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(32.29167F, 15.70833F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "RUC:";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(5F, 51.12502F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(97.91665F, 15.70833F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "RAZON SOCIAL :";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(4.999987F, 67.83334F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(79.16665F, 15.70833F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Expresado en ";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(5F, 4F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(205.2083F, 15.70833F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "FORMATO 5.1: LIBRO DIARIO";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.BorderWidth = 1F;
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(367.3566F, 99.5417F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(21.86807F, 11F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "CC";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel10.BorderColor = System.Drawing.Color.Black;
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.BorderWidth = 1F;
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.Black;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(127.5F, 99.5417F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(47.59966F, 11F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseBorderWidth = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "cuenta";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.BorderWidth = 1F;
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.Black;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(175.0996F, 99.5417F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(148.9003F, 11F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseBorderWidth = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Descripcion de Cta.";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel12.BorderWidth = 1F;
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(583.3302F, 99.5417F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(81.1543F, 11F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Debe";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel14.BorderColor = System.Drawing.Color.Black;
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.BorderWidth = 1F;
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.Black;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(34.17505F, 99.54169F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(93.32503F, 11F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Doc. sustentatorio";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.BorderColor = System.Drawing.Color.Black;
            this.xrLabel16.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel16.BorderWidth = 1F;
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(664.4845F, 99.5417F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(82.5155F, 10.99998F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseBorderWidth = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Haber";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel21.BorderColor = System.Drawing.Color.Black;
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.BorderWidth = 1F;
            this.xrLabel21.CanGrow = false;
            this.xrLabel21.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.ForeColor = System.Drawing.Color.Black;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(389.2246F, 99.5417F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(194.1056F, 11F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseBorderWidth = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Detalle";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel19.BorderColor = System.Drawing.Color.Black;
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.BorderWidth = 1F;
            this.xrLabel19.CanGrow = false;
            this.xrLabel19.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.ForeColor = System.Drawing.Color.Black;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(322.9382F, 99.5417F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(44.4184F, 11F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseBorderWidth = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "persona";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.BorderColor = System.Drawing.Color.Black;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.BorderWidth = 1F;
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(4.999987F, 99.5416F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(29.17504F, 11F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseBorderWidth = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "linea";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel22.BorderColor = System.Drawing.Color.Black;
            this.xrLabel22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel22.BorderWidth = 1F;
            this.xrLabel22.CanGrow = false;
            this.xrLabel22.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel22.ForeColor = System.Drawing.Color.Black;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(4.999987F, 86.45836F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(111F, 13.08334F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorderColor = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseBorderWidth = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "voucher";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.BorderColor = System.Drawing.Color.Black;
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.BorderWidth = 1F;
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.ForeColor = System.Drawing.Color.Black;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(115F, 86.45834F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(115F, 13.08334F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseBorderWidth = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "fecha";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrLabel18.BorderColor = System.Drawing.Color.Black;
            this.xrLabel18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel18.BorderWidth = 1F;
            this.xrLabel18.CanGrow = false;
            this.xrLabel18.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.ForeColor = System.Drawing.Color.Black;
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(229.1063F, 86.45836F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(517.8937F, 13.08333F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseBorderWidth = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Descripcion";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.ruc")});
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(37.29169F, 36.375F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(119.7917F, 14.66667F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
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
            this.Title.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Teal;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
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
            // PeriodoVoucher
            // 
            this.PeriodoVoucher.DataMember = "SP_CB_REP_LIBRODIARIO";
            this.PeriodoVoucher.Expression = " [Parameters.prmPeriodo] + \'-\' + [voucher]";
            this.PeriodoVoucher.Name = "PeriodoVoucher";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrDescripVGR,
            this.xrFechaGR,
            this.xrPeriodoVouchGR});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("voucher", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("fecha", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 17.70833F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrDescripVGR
            // 
            this.xrDescripVGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.v_descrip")});
            this.xrDescripVGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrDescripVGR.LocationFloat = new DevExpress.Utils.PointFloat(236.1094F, 3.000005F);
            this.xrDescripVGR.Name = "xrDescripVGR";
            this.xrDescripVGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescripVGR.SizeF = new System.Drawing.SizeF(487.5001F, 12.58334F);
            this.xrDescripVGR.StylePriority.UseFont = false;
            this.xrDescripVGR.Text = "xrDescripVGR";
            // 
            // xrFechaGR
            // 
            this.xrFechaGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.fecha", "{0:dd/MM/yyyy}")});
            this.xrFechaGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrFechaGR.LocationFloat = new DevExpress.Utils.PointFloat(115F, 2.999996F);
            this.xrFechaGR.Name = "xrFechaGR";
            this.xrFechaGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFechaGR.SizeF = new System.Drawing.SizeF(100F, 12.58334F);
            this.xrFechaGR.StylePriority.UseFont = false;
            // 
            // xrPeriodoVouchGR
            // 
            this.xrPeriodoVouchGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.PeriodoVoucher")});
            this.xrPeriodoVouchGR.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrPeriodoVouchGR.LocationFloat = new DevExpress.Utils.PointFloat(7.000019F, 3.000007F);
            this.xrPeriodoVouchGR.Name = "xrPeriodoVouchGR";
            this.xrPeriodoVouchGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPeriodoVouchGR.SizeF = new System.Drawing.SizeF(100F, 12.58333F);
            this.xrPeriodoVouchGR.StylePriority.UseFont = false;
            this.xrPeriodoVouchGR.Text = "xrPeriodoVouchGR";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrHaberGR,
            this.xrDebeGR});
            this.GroupFooter1.Font = new System.Drawing.Font("Arial", 8F);
            this.GroupFooter1.HeightF = 17.79165F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.StylePriority.UseFont = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(433.6649F, 2.000014F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(143.1304F, 13F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "TOTAL VOUCHER  ------->";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrHaberGR
            // 
            this.xrHaberGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.haber")});
            this.xrHaberGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrHaberGR.LocationFloat = new DevExpress.Utils.PointFloat(664.4845F, 2.000014F);
            this.xrHaberGR.Name = "xrHaberGR";
            this.xrHaberGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHaberGR.SizeF = new System.Drawing.SizeF(82.51544F, 13F);
            this.xrHaberGR.StylePriority.UseFont = false;
            this.xrHaberGR.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrHaberGR.Summary = xrSummary1;
            this.xrHaberGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrDebeGR
            // 
            this.xrDebeGR.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.debe", "{0:n2}")});
            this.xrDebeGR.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrDebeGR.LocationFloat = new DevExpress.Utils.PointFloat(583.3301F, 2.000014F);
            this.xrDebeGR.Name = "xrDebeGR";
            this.xrDebeGR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDebeGR.SizeF = new System.Drawing.SizeF(81.15442F, 13F);
            this.xrDebeGR.StylePriority.UseFont = false;
            this.xrDebeGR.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrDebeGR.Summary = xrSummary2;
            this.xrDebeGR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebeGR.XlsxFormatString = "";
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(433.6649F, 3.999996F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(143.1305F, 10.99999F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "TOTAL GENERAL  ------->";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrDebeTot,
            this.xrHaberTot,
            this.xrLabel23});
            this.ReportFooter.HeightF = 19.79167F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrDebeTot
            // 
            this.xrDebeTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.debe", "{0:n2}")});
            this.xrDebeTot.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrDebeTot.LocationFloat = new DevExpress.Utils.PointFloat(583.3301F, 3.999996F);
            this.xrDebeTot.Name = "xrDebeTot";
            this.xrDebeTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDebeTot.SizeF = new System.Drawing.SizeF(81.15436F, 10.99999F);
            this.xrDebeTot.StylePriority.UseFont = false;
            this.xrDebeTot.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:n2}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrDebeTot.Summary = xrSummary3;
            this.xrDebeTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebeTot.XlsxFormatString = "";
            // 
            // xrHaberTot
            // 
            this.xrHaberTot.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_LIBRODIARIO.haber")});
            this.xrHaberTot.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrHaberTot.LocationFloat = new DevExpress.Utils.PointFloat(664.4845F, 3.999996F);
            this.xrHaberTot.Name = "xrHaberTot";
            this.xrHaberTot.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrHaberTot.SizeF = new System.Drawing.SizeF(82.51538F, 10.99999F);
            this.xrHaberTot.StylePriority.UseFont = false;
            this.xrHaberTot.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "{0:n2}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrHaberTot.Summary = xrSummary4;
            this.xrHaberTot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // prmCompania
            // 
            this.prmCompania.Description = "Compania";
            this.prmCompania.Name = "prmCompania";
            // 
            // prmMoneda
            // 
            this.prmMoneda.Description = "Moneda";
            this.prmMoneda.Name = "prmMoneda";
            // 
            // prmTipoCuenta
            // 
            this.prmTipoCuenta.Description = "TipoCuenta";
            this.prmTipoCuenta.Name = "prmTipoCuenta";
            // 
            // prmIncPerRel
            // 
            this.prmIncPerRel.Description = "IncPerRel";
            this.prmIncPerRel.Name = "prmIncPerRel";
            this.prmIncPerRel.Type = typeof(int);
            this.prmIncPerRel.ValueInfo = "0";
            // 
            // prmTipoRep
            // 
            this.prmTipoRep.Description = "TipoRep";
            this.prmTipoRep.Name = "prmTipoRep";
            // 
            // prmTCCosto
            // 
            this.prmTCCosto.Description = "TCCosto";
            this.prmTCCosto.Name = "prmTCCosto";
            // 
            // MonedaExp
            // 
            this.MonedaExp.DataMember = "SP_CB_REP_LIBRODIARIO";
            this.MonedaExp.Expression = "Iif([Parameters.prmMoneda]=\'L\',\'Moneda Local\',\'Moneda Extranjera\' )";
            this.MonedaExp.Name = "MonedaExp";
            // 
            // rpt_LibroDiario
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.pageHeaderBand1,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.GroupHeader1,
            this.GroupFooter1,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.PeriodoVoucher,
            this.MonedaExp});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_LIBRODIARIO";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(44, 36, 20, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmPeriodo,
            this.prmMoneda,
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
        private DevExpress.XtraReports.UI.CalculatedField PeriodoVoucher;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrDescripVGR;
        private DevExpress.XtraReports.UI.XRLabel xrFechaGR;
        private DevExpress.XtraReports.UI.XRLabel xrPeriodoVouchGR;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrDebeGR;
        private DevExpress.XtraReports.UI.XRLabel xrHaberGR;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrDebeTot;
        private DevExpress.XtraReports.UI.XRLabel xrHaberTot;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmPeriodo;
        private DevExpress.XtraReports.Parameters.Parameter prmMoneda;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoCuenta;
        private DevExpress.XtraReports.Parameters.Parameter prmIncPerRel;
        private DevExpress.XtraReports.Parameters.Parameter prmTipoRep;
        private DevExpress.XtraReports.Parameters.Parameter prmTCCosto;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.CalculatedField MonedaExp;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrFechaFinMes;
        private DevExpress.XtraReports.UI.XRLabel xrLinea;
        private DevExpress.XtraReports.UI.XRLabel xrDocumento;
        private DevExpress.XtraReports.UI.XRLabel xrCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrDescripCta;
        private DevExpress.XtraReports.UI.XRLabel xrPersona;
        private DevExpress.XtraReports.UI.XRLabel xrCCosto;
        private DevExpress.XtraReports.UI.XRLabel xrDescripD;
        private DevExpress.XtraReports.UI.XRLabel xrDebe;
        private DevExpress.XtraReports.UI.XRLabel xrHaber;
    }
}
