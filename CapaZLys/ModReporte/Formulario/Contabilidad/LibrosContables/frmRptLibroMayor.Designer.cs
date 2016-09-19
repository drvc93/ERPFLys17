namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    partial class frmRptLibroMayor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTipoCuenta = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbVersion = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTCCosto = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarFileTXT = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaIni = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaFin = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTCCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaFin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtCuentaFin);
            this.pnlFilter.Controls.Add(this.txtCuentaIni);
            this.pnlFilter.Controls.Add(this.labelControl7);
            this.pnlFilter.Controls.Add(this.cmbVersion);
            this.pnlFilter.Controls.Add(this.labelControl5);
            this.pnlFilter.Controls.Add(this.cmbTCCosto);
            this.pnlFilter.Controls.Add(this.labelControl6);
            this.pnlFilter.Controls.Add(this.cmbTipoCuenta);
            this.pnlFilter.Controls.Add(this.labelControl4);
            this.pnlFilter.Controls.Add(this.cmbMoneda);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.txtPeriodo);
            this.pnlFilter.Controls.Add(this.labelControl2);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(680, 83);
            this.btnBuscar.Size = new System.Drawing.Size(63, 23);
            // 
            // dvReport
            // 
            this.dvReport.Size = new System.Drawing.Size(765, 355);
            // 
            // pbBarInferior
            // 
            this.pbBarInferior.OptionsBar.AllowQuickCustomization = false;
            this.pbBarInferior.OptionsBar.DrawDragBorder = false;
            this.pbBarInferior.OptionsBar.UseWholeRow = true;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Panel1.Controls.Add(this.btnGenerarFileTXT);
            this.pnlCuerpo.Size = new System.Drawing.Size(765, 466);
            this.pnlCuerpo.SplitterPosition = 106;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.Size = new System.Drawing.Size(765, 25);
            this.lblTitulo.Text = "LIBRO MAYOR";
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(46, 0);
            this.pnMain.Size = new System.Drawing.Size(769, 470);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Compañía:";
            // 
            // cmbCompania
            // 
            this.cmbCompania.Location = new System.Drawing.Point(69, 6);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 40, "Compania"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Descripcion")});
            this.cmbCompania.Size = new System.Drawing.Size(157, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(245, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(290, 6);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(59, 20);
            this.txtPeriodo.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(365, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Moneda:";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.Location = new System.Drawing.Point(412, 6);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbMoneda.Properties.DropDownRows = 4;
            this.cmbMoneda.Properties.PopupFormMinSize = new System.Drawing.Size(86, 0);
            this.cmbMoneda.Size = new System.Drawing.Size(86, 20);
            this.cmbMoneda.TabIndex = 3;
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Location = new System.Drawing.Point(545, 6);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCuenta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbTipoCuenta.Properties.DropDownRows = 4;
            this.cmbTipoCuenta.Properties.PopupFormMinSize = new System.Drawing.Size(93, 0);
            this.cmbTipoCuenta.Size = new System.Drawing.Size(93, 20);
            this.cmbTipoCuenta.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(517, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tipo:";
            // 
            // cmbVersion
            // 
            this.cmbVersion.Location = new System.Drawing.Point(545, 29);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVersion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbVersion.Properties.DropDownRows = 4;
            this.cmbVersion.Properties.PopupFormMinSize = new System.Drawing.Size(93, 0);
            this.cmbVersion.Size = new System.Drawing.Size(93, 20);
            this.cmbVersion.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(517, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Vers.:";
            // 
            // cmbTCCosto
            // 
            this.cmbTCCosto.Location = new System.Drawing.Point(412, 29);
            this.cmbTCCosto.Name = "cmbTCCosto";
            this.cmbTCCosto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTCCosto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbTCCosto.Properties.DropDownRows = 4;
            this.cmbTCCosto.Properties.PopupFormMinSize = new System.Drawing.Size(86, 0);
            this.cmbTCCosto.Size = new System.Drawing.Size(86, 20);
            this.cmbTCCosto.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(365, 31);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "T.CCosto:";
            // 
            // btnGenerarFileTXT
            // 
            this.btnGenerarFileTXT.Location = new System.Drawing.Point(6, 82);
            this.btnGenerarFileTXT.Name = "btnGenerarFileTXT";
            this.btnGenerarFileTXT.Size = new System.Drawing.Size(99, 24);
            this.btnGenerarFileTXT.TabIndex = 7;
            this.btnGenerarFileTXT.Text = "Generar File TXT";
            this.btnGenerarFileTXT.Click += new System.EventHandler(this.btnGenerarFileTXT_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 31);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Cuentas:";
            // 
            // txtCuentaIni
            // 
            this.txtCuentaIni.EditValue = "";
            this.txtCuentaIni.Location = new System.Drawing.Point(69, 29);
            this.txtCuentaIni.Name = "txtCuentaIni";
            this.txtCuentaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCuentaIni.Size = new System.Drawing.Size(68, 20);
            this.txtCuentaIni.TabIndex = 12;
            // 
            // txtCuentaFin
            // 
            this.txtCuentaFin.EditValue = "";
            this.txtCuentaFin.Location = new System.Drawing.Point(140, 29);
            this.txtCuentaFin.Name = "txtCuentaFin";
            this.txtCuentaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCuentaFin.Size = new System.Drawing.Size(68, 20);
            this.txtCuentaFin.TabIndex = 13;
            // 
            // frmRptLibroMayor
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptLibroMayor";
            this.Text = "Libro Mayor";
            this.Load += new System.EventHandler(this.frmRptLibroMayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTCCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaFin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbVersion;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbTCCosto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmbMoneda;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGenerarFileTXT;
        private DevExpress.XtraEditors.TextEdit txtCuentaIni;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCuentaFin;
    }
}
