namespace FiltroLys.ZLys.ModReporte.Reporte.Contabilidad.LibrosContables
{
    partial class rpt_DetalleVouchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_DetalleVouchers));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrFecha = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPeriodo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrMoneda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCCosto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCodMaquina = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpLocal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrImpDolar = new DevExpress.XtraReports.UI.XRLabel();
            this.xrDescVoucher = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlConnRPT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GRPersonaCuenta = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrGRCuenta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrGRPersona = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.groupFooterBand1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrGRImpLoc = new DevExpress.XtraReports.UI.XRLabel();
            this.xrGRImpDolar = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            this.prmCompania = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmProveedor = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPerIni = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmPerFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmOrdenar = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmDocPend = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmMoneda = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCCosto = new DevExpress.XtraReports.Parameters.Parameter();
            this.prmCtaDestino = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrTitFechaHoy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitGeneral = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTitCompania = new DevExpress.XtraReports.UI.XRLabel();
            this.titGeneral = new DevExpress.XtraReports.UI.CalculatedField();
            this.titFecHoy = new DevExpress.XtraReports.UI.CalculatedField();
            this.titGRPersona = new DevExpress.XtraReports.UI.CalculatedField();
            this.titGRCuenta = new DevExpress.XtraReports.UI.CalculatedField();
            this.PiePersonaCuenta = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.regVoucher = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrRegVoucher = new DevExpress.XtraReports.UI.XRLabel();
            this.titGRDestino = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrTitGRDestino = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrFecha,
            this.xrPeriodo,
            this.xrMoneda,
            this.xrDocumento,
            this.xrCCosto,
            this.xrCodMaquina,
            this.xrImpLocal,
            this.xrImpDolar,
            this.xrDescVoucher,
            this.xrRegVoucher});
            this.Detail.Font = new System.Drawing.Font("Arial", 7F);
            this.Detail.HeightF = 26.91666F;
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.d_fecha", "{0:dd/MM/yyyy}")});
            this.xrFecha.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.9999912F);
            this.xrFecha.Name = "xrFecha";
            this.xrFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrFecha.SizeF = new System.Drawing.SizeF(49.00001F, 18F);
            // 
            // xrPeriodo
            // 
            this.xrPeriodo.CanGrow = false;
            this.xrPeriodo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.c_periodo")});
            this.xrPeriodo.LocationFloat = new DevExpress.Utils.PointFloat(49.00001F, 0.9999912F);
            this.xrPeriodo.Name = "xrPeriodo";
            this.xrPeriodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPeriodo.SizeF = new System.Drawing.SizeF(43.61837F, 18F);
            this.xrPeriodo.Text = "xrPeriodo";
            // 
            // xrMoneda
            // 
            this.xrMoneda.CanGrow = false;
            this.xrMoneda.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.C_MONEDA")});
            this.xrMoneda.LocationFloat = new DevExpress.Utils.PointFloat(152.6184F, 0.9999912F);
            this.xrMoneda.Name = "xrMoneda";
            this.xrMoneda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrMoneda.SizeF = new System.Drawing.SizeF(29.99997F, 18F);
            this.xrMoneda.Text = "xrMoneda";
            // 
            // xrDocumento
            // 
            this.xrDocumento.CanGrow = false;
            this.xrDocumento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.c_documento")});
            this.xrDocumento.LocationFloat = new DevExpress.Utils.PointFloat(182.6183F, 0.9999912F);
            this.xrDocumento.Name = "xrDocumento";
            this.xrDocumento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDocumento.SizeF = new System.Drawing.SizeF(130F, 18F);
            this.xrDocumento.Text = "xrDocumento";
            // 
            // xrCCosto
            // 
            this.xrCCosto.CanGrow = false;
            this.xrCCosto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.c_centrocosto")});
            this.xrCCosto.LocationFloat = new DevExpress.Utils.PointFloat(312.6183F, 0.9999912F);
            this.xrCCosto.Name = "xrCCosto";
            this.xrCCosto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCCosto.SizeF = new System.Drawing.SizeF(55F, 18F);
            this.xrCCosto.Text = "xrCCosto";
            // 
            // xrCodMaquina
            // 
            this.xrCodMaquina.CanGrow = false;
            this.xrCodMaquina.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.c_codmaquina")});
            this.xrCodMaquina.LocationFloat = new DevExpress.Utils.PointFloat(367.6184F, 0.9999912F);
            this.xrCodMaquina.Name = "xrCodMaquina";
            this.xrCodMaquina.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCodMaquina.SizeF = new System.Drawing.SizeF(54.99994F, 18F);
            this.xrCodMaquina.Text = "xrCodMaquina";
            // 
            // xrImpLocal
            // 
            this.xrImpLocal.CanGrow = false;
            this.xrImpLocal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.n_importelocal", "{0:n2}")});
            this.xrImpLocal.LocationFloat = new DevExpress.Utils.PointFloat(422.6183F, 0.9999912F);
            this.xrImpLocal.Name = "xrImpLocal";
            this.xrImpLocal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpLocal.SizeF = new System.Drawing.SizeF(82.00003F, 18F);
            // 
            // xrImpDolar
            // 
            this.xrImpDolar.CanGrow = false;
            this.xrImpDolar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.n_importedollar", "{0:n2}")});
            this.xrImpDolar.LocationFloat = new DevExpress.Utils.PointFloat(504.6183F, 0.9999912F);
            this.xrImpDolar.Name = "xrImpDolar";
            this.xrImpDolar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrImpDolar.SizeF = new System.Drawing.SizeF(81.99997F, 18F);
            // 
            // xrDescVoucher
            // 
            this.xrDescVoucher.CanGrow = false;
            this.xrDescVoucher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.c_decripcionvoucher")});
            this.xrDescVoucher.LocationFloat = new DevExpress.Utils.PointFloat(586.6183F, 0.9999911F);
            this.xrDescVoucher.Name = "xrDescVoucher";
            this.xrDescVoucher.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDescVoucher.SizeF = new System.Drawing.SizeF(182.38F, 25F);
            this.xrDescVoucher.Text = "xrDescVoucher";
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
            storedProcQuery1.Name = "SP_CB_REP_DETALLE_VOUCHERS";
            queryParameter1.Name = "@companyowner";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCompania]", typeof(string));
            queryParameter2.Name = "@proveedor";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.prmProveedor]", typeof(int));
            queryParameter3.Name = "@accountdesde";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaIni]", typeof(string));
            queryParameter4.Name = "@accounthasta";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaFin]", typeof(string));
            queryParameter5.Name = "@periododesde";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPerIni]", typeof(string));
            queryParameter6.Name = "@periodohasta";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.prmPerFin]", typeof(string));
            queryParameter7.Name = "@ordenar";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.prmOrdenar]", typeof(string));
            queryParameter8.Name = "@docpend";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.prmDocPend]", typeof(string));
            queryParameter9.Name = "@Moneda";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.prmMoneda]", typeof(string));
            queryParameter10.Name = "@CentroCosto";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCCosto]", typeof(string));
            queryParameter11.Name = "@CuentaDestino";
            queryParameter11.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter11.Value = new DevExpress.DataAccess.Expression("[Parameters.prmCtaDestino]", typeof(string));
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
            storedProcQuery1.StoredProcName = "SP_CB_REP_DETALLE_VOUCHERS";
            this.sqlConnRPT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlConnRPT.ResultSchemaSerializable = resources.GetString("sqlConnRPT.ResultSchemaSerializable");
            // 
            // GRPersonaCuenta
            // 
            this.GRPersonaCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTitGRDestino,
            this.xrGRCuenta,
            this.xrGRPersona,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel8});
            this.GRPersonaCuenta.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.GRPersonaCuenta.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("n_persona", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("c_cuenta", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GRPersonaCuenta.HeightF = 57.875F;
            this.GRPersonaCuenta.Name = "GRPersonaCuenta";
            this.GRPersonaCuenta.StylePriority.UseFont = false;
            // 
            // xrGRCuenta
            // 
            this.xrGRCuenta.CanGrow = false;
            this.xrGRCuenta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.titGRCuenta")});
            this.xrGRCuenta.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrGRCuenta.LocationFloat = new DevExpress.Utils.PointFloat(0F, 16.75F);
            this.xrGRCuenta.Name = "xrGRCuenta";
            this.xrGRCuenta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRCuenta.SizeF = new System.Drawing.SizeF(497.9167F, 16.75F);
            this.xrGRCuenta.StylePriority.UseFont = false;
            this.xrGRCuenta.Text = "xrGRCuenta";
            // 
            // xrGRPersona
            // 
            this.xrGRPersona.CanGrow = false;
            this.xrGRPersona.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.titGRPersona")});
            this.xrGRPersona.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.xrGRPersona.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrGRPersona.Name = "xrGRPersona";
            this.xrGRPersona.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRPersona.SizeF = new System.Drawing.SizeF(515F, 16.75F);
            this.xrGRPersona.StylePriority.UseFont = false;
            this.xrGRPersona.Text = "xrGRPersona";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.CanGrow = false;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(586.6183F, 41.5F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(182.3817F, 14.875F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Descripcion Voucher";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(504.6183F, 41.5F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(81.99997F, 14.875F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Importe Ext.";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(422.6183F, 41.5F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(82F, 14.875F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Importe Local";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(367.6183F, 41.5F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(55F, 14.875F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Maquina";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.CanGrow = false;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(312.6183F, 41.5F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(55F, 14.875F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "C.Costo";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(182.6184F, 41.5F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(130F, 14.875F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Documento";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(92.61839F, 41.50001F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(60.00001F, 14.875F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Voucher";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(49.00001F, 41.5F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(43.61837F, 14.875F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Periodo";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 41.5F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(49F, 14.875F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Fecha";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(152.6184F, 41.50001F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(30F, 14.875F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Mon";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            // xrGRImpLoc
            // 
            this.xrGRImpLoc.CanGrow = false;
            this.xrGRImpLoc.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.n_importelocal", "{0:C2}")});
            this.xrGRImpLoc.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrGRImpLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrGRImpLoc.LocationFloat = new DevExpress.Utils.PointFloat(422.6183F, 6.00001F);
            this.xrGRImpLoc.Name = "xrGRImpLoc";
            this.xrGRImpLoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRImpLoc.SizeF = new System.Drawing.SizeF(82.00003F, 14.00002F);
            this.xrGRImpLoc.StyleName = "FieldCaption";
            this.xrGRImpLoc.StylePriority.UseFont = false;
            this.xrGRImpLoc.StylePriority.UseForeColor = false;
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrGRImpLoc.Summary = xrSummary1;
            this.xrGRImpLoc.Text = "xrGRImpLoc";
            // 
            // xrGRImpDolar
            // 
            this.xrGRImpDolar.CanGrow = false;
            this.xrGRImpDolar.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.n_importedollar", "{0:C2}")});
            this.xrGRImpDolar.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.xrGRImpDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.xrGRImpDolar.LocationFloat = new DevExpress.Utils.PointFloat(504.6183F, 6.00001F);
            this.xrGRImpDolar.Name = "xrGRImpDolar";
            this.xrGRImpDolar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrGRImpDolar.SizeF = new System.Drawing.SizeF(81.99991F, 14.00002F);
            this.xrGRImpDolar.StyleName = "FieldCaption";
            this.xrGRImpDolar.StylePriority.UseFont = false;
            this.xrGRImpDolar.StylePriority.UseForeColor = false;
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrGRImpDolar.Summary = xrSummary2;
            this.xrGRImpDolar.Text = "xrGRImpDolar";
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
            // prmProveedor
            // 
            this.prmProveedor.Name = "prmProveedor";
            this.prmProveedor.Type = typeof(int);
            this.prmProveedor.ValueInfo = "0";
            // 
            // prmCtaIni
            // 
            this.prmCtaIni.Name = "prmCtaIni";
            // 
            // prmCtaFin
            // 
            this.prmCtaFin.Name = "prmCtaFin";
            // 
            // prmPerIni
            // 
            this.prmPerIni.Name = "prmPerIni";
            // 
            // prmPerFin
            // 
            this.prmPerFin.Name = "prmPerFin";
            // 
            // prmOrdenar
            // 
            this.prmOrdenar.Name = "prmOrdenar";
            // 
            // prmDocPend
            // 
            this.prmDocPend.Name = "prmDocPend";
            // 
            // prmMoneda
            // 
            this.prmMoneda.Name = "prmMoneda";
            // 
            // prmCCosto
            // 
            this.prmCCosto.Name = "prmCCosto";
            // 
            // prmCtaDestino
            // 
            this.prmCtaDestino.Name = "prmCtaDestino";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo3,
            this.xrTitFechaHoy,
            this.xrTitGeneral,
            this.xrTitCompania});
            this.PageHeader.Font = new System.Drawing.Font("Arial", 8F);
            this.PageHeader.HeightF = 57.29167F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.Format = "Página {0} de {1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(597.9999F, 0F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(70F, 14.67F);
            this.xrPageInfo3.StyleName = "PageInfo";
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTitFechaHoy
            // 
            this.xrTitFechaHoy.CanGrow = false;
            this.xrTitFechaHoy.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.titFecHoy", "{0:dd/MM/yyyy}")});
            this.xrTitFechaHoy.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.xrTitFechaHoy.LocationFloat = new DevExpress.Utils.PointFloat(667.9999F, 0F);
            this.xrTitFechaHoy.Name = "xrTitFechaHoy";
            this.xrTitFechaHoy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitFechaHoy.SizeF = new System.Drawing.SizeF(75F, 14.67F);
            this.xrTitFechaHoy.StylePriority.UseFont = false;
            // 
            // xrTitGeneral
            // 
            this.xrTitGeneral.CanGrow = false;
            this.xrTitGeneral.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.titGeneral")});
            this.xrTitGeneral.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.xrTitGeneral.LocationFloat = new DevExpress.Utils.PointFloat(77F, 14.67001F);
            this.xrTitGeneral.Name = "xrTitGeneral";
            this.xrTitGeneral.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitGeneral.SizeF = new System.Drawing.SizeF(525F, 23F);
            this.xrTitGeneral.StylePriority.UseFont = false;
            this.xrTitGeneral.StylePriority.UseTextAlignment = false;
            this.xrTitGeneral.Text = "xrTitGeneral";
            this.xrTitGeneral.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTitCompania
            // 
            this.xrTitCompania.CanGrow = false;
            this.xrTitCompania.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.c_compania")});
            this.xrTitCompania.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTitCompania.Name = "xrTitCompania";
            this.xrTitCompania.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTitCompania.SizeF = new System.Drawing.SizeF(286F, 14.67F);
            this.xrTitCompania.Text = "xrTitCompania";
            // 
            // titGeneral
            // 
            this.titGeneral.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.titGeneral.Expression = "\'DETALLE DE VOUCHERS, DEL PERIODO \'+  [Parameters.prmPerIni]+ \'  AL PERIODO \'+ [P" +
    "arameters.prmPerFin]";
            this.titGeneral.Name = "titGeneral";
            // 
            // titFecHoy
            // 
            this.titFecHoy.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.titFecHoy.Expression = "Today()";
            this.titFecHoy.Name = "titFecHoy";
            // 
            // titGRPersona
            // 
            this.titGRPersona.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.titGRPersona.Expression = "iif(IsNull([n_persona]) ||  [n_persona] == 0,\'\',\' Persona :  ( \'+ [n_persona] + \'" +
    " ) \' + [c_NombreCompleto])";
            this.titGRPersona.Name = "titGRPersona";
            // 
            // titGRCuenta
            // 
            this.titGRCuenta.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.titGRCuenta.Expression = "\'Cuenta : ( \'+ [c_cuenta] +\' ) \' + [c_descripcta]";
            this.titGRCuenta.Name = "titGRCuenta";
            // 
            // PiePersonaCuenta
            // 
            this.PiePersonaCuenta.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLine1,
            this.xrGRImpDolar,
            this.xrGRImpLoc});
            this.PiePersonaCuenta.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.PiePersonaCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PiePersonaCuenta.HeightF = 25F;
            this.PiePersonaCuenta.Name = "PiePersonaCuenta";
            this.PiePersonaCuenta.StylePriority.UseFont = false;
            this.PiePersonaCuenta.StylePriority.UseForeColor = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(322.6183F, 6.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 14.00002F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Saldo Final --> ";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.00001F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(765.5416F, 2F);
            // 
            // regVoucher
            // 
            this.regVoucher.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.regVoucher.Expression = "[c_tipovocuher] +  [C_NUMEROVOUCHER]";
            this.regVoucher.Name = "regVoucher";
            // 
            // xrRegVoucher
            // 
            this.xrRegVoucher.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.regVoucher")});
            this.xrRegVoucher.LocationFloat = new DevExpress.Utils.PointFloat(92.6184F, 0.9999911F);
            this.xrRegVoucher.Name = "xrRegVoucher";
            this.xrRegVoucher.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRegVoucher.SizeF = new System.Drawing.SizeF(60.00001F, 18F);
            this.xrRegVoucher.Text = "xrRegVoucher";
            // 
            // titGRDestino
            // 
            this.titGRDestino.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.titGRDestino.Expression = "iif(IsNull([c_cuentadestino]) || Len([c_cuentadestino])==0,\'\',\'Cuenta Destino : \'" +
    " + [c_cuentadestino])";
            this.titGRDestino.Name = "titGRDestino";
            // 
            // xrTitGRDestino
            // 
            this.xrTitGRDestino.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SP_CB_REP_DETALLE_VOUCHERS.titGRDestino")});
            this.xrTitGRDestino.Font = new System.Drawing.Font("Arial", 8F);
            this.xrTitGRDestino.LocationFloat = new DevExpress.Utils.PointFloat(597.9999F, 0F);
            this.xrTitGRDestino.Name = "xrTitGRDestino";
            this.xrTitGRDestino.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTitGRDestino.SizeF = new System.Drawing.SizeF(167.5417F, 16.75F);
            this.xrTitGRDestino.StylePriority.UseFont = false;
            this.xrTitGRDestino.StylePriority.UseTextAlignment = false;
            this.xrTitGRDestino.Text = "xrTitGRDestino";
            this.xrTitGRDestino.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // rpt_DetalleVouchers
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GRPersonaCuenta,
            this.pageFooterBand1,
            this.reportHeaderBand1,
            this.PageHeader,
            this.PiePersonaCuenta});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.titGeneral,
            this.titFecHoy,
            this.titGRPersona,
            this.titGRCuenta,
            this.regVoucher,
            this.titGRDestino});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlConnRPT});
            this.DataMember = "SP_CB_REP_DETALLE_VOUCHERS";
            this.DataSource = this.sqlConnRPT;
            this.Margins = new System.Drawing.Printing.Margins(31, 27, 34, 59);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.prmCompania,
            this.prmProveedor,
            this.prmCtaIni,
            this.prmCtaFin,
            this.prmPerIni,
            this.prmPerFin,
            this.prmOrdenar,
            this.prmDocPend,
            this.prmMoneda,
            this.prmCCosto,
            this.prmCtaDestino});
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
        private DevExpress.XtraReports.UI.XRLabel xrCodMaquina;
        private DevExpress.XtraReports.UI.XRLabel xrImpLocal;
        private DevExpress.XtraReports.UI.XRLabel xrImpDolar;
        private DevExpress.XtraReports.UI.XRLabel xrDescVoucher;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlConnRPT;
        private DevExpress.XtraReports.UI.GroupHeaderBand GRPersonaCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.GroupFooterBand groupFooterBand1;
        private DevExpress.XtraReports.UI.XRLabel xrGRImpLoc;
        private DevExpress.XtraReports.UI.XRLabel xrGRImpDolar;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.Parameters.Parameter prmCompania;
        private DevExpress.XtraReports.Parameters.Parameter prmProveedor;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaIni;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaFin;
        private DevExpress.XtraReports.Parameters.Parameter prmPerIni;
        private DevExpress.XtraReports.Parameters.Parameter prmPerFin;
        private DevExpress.XtraReports.Parameters.Parameter prmOrdenar;
        private DevExpress.XtraReports.Parameters.Parameter prmDocPend;
        private DevExpress.XtraReports.Parameters.Parameter prmMoneda;
        private DevExpress.XtraReports.Parameters.Parameter prmCCosto;
        private DevExpress.XtraReports.Parameters.Parameter prmCtaDestino;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrTitCompania;
        private DevExpress.XtraReports.UI.CalculatedField titGeneral;
        private DevExpress.XtraReports.UI.XRLabel xrTitGeneral;
        private DevExpress.XtraReports.UI.CalculatedField titFecHoy;
        private DevExpress.XtraReports.UI.XRLabel xrTitFechaHoy;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.CalculatedField titGRPersona;
        private DevExpress.XtraReports.UI.CalculatedField titGRCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrGRCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrGRPersona;
        private DevExpress.XtraReports.UI.GroupFooterBand PiePersonaCuenta;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrRegVoucher;
        private DevExpress.XtraReports.UI.CalculatedField regVoucher;
        private DevExpress.XtraReports.UI.CalculatedField titGRDestino;
        private DevExpress.XtraReports.UI.XRLabel xrTitGRDestino;
    }
}
