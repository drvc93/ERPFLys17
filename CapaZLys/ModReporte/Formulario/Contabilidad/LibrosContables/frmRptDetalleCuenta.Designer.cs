namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    partial class frmRptDetalleCuenta
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCuentaIni = new DevExpress.XtraEditors.TextEdit();
            this.txtCuentaFin = new DevExpress.XtraEditors.TextEdit();
            this.txtPerFin = new DevExpress.XtraEditors.TextEdit();
            this.txtPerIni = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerIni.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtPerFin);
            this.pnlFilter.Controls.Add(this.txtPerIni);
            this.pnlFilter.Controls.Add(this.labelControl5);
            this.pnlFilter.Controls.Add(this.txtCuentaFin);
            this.pnlFilter.Controls.Add(this.txtCuentaIni);
            this.pnlFilter.Controls.Add(this.labelControl7);
            this.pnlFilter.Controls.Add(this.cmbMoneda);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(683, 56);
            this.btnBuscar.Size = new System.Drawing.Size(63, 23);
            // 
            // dvReport
            // 
            this.dvReport.Size = new System.Drawing.Size(765, 382);
            // 
            // pbBarInferior
            // 
            this.pbBarInferior.OptionsBar.AllowQuickCustomization = false;
            this.pbBarInferior.OptionsBar.DrawDragBorder = false;
            this.pbBarInferior.OptionsBar.UseWholeRow = true;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Size = new System.Drawing.Size(765, 466);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.Size = new System.Drawing.Size(765, 25);
            this.lblTitulo.Text = "DETALLE DE VOUCHERS POR CUENTAS Y PERIODOS";
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
            this.cmbCompania.Size = new System.Drawing.Size(153, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(502, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 100;
            this.labelControl3.Text = "Moneda:";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.Location = new System.Drawing.Point(548, 5);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbMoneda.Properties.DropDownRows = 4;
            this.cmbMoneda.Properties.PopupFormMinSize = new System.Drawing.Size(90, 0);
            this.cmbMoneda.Size = new System.Drawing.Size(86, 20);
            this.cmbMoneda.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 31);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 103;
            this.labelControl7.Text = "Cuenta:";
            // 
            // txtCuentaIni
            // 
            this.txtCuentaIni.EditValue = "";
            this.txtCuentaIni.Location = new System.Drawing.Point(69, 29);
            this.txtCuentaIni.Name = "txtCuentaIni";
            this.txtCuentaIni.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCuentaIni.Properties.Mask.EditMask = "\\d+";
            this.txtCuentaIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCuentaIni.Properties.MaxLength = 10;
            this.txtCuentaIni.Size = new System.Drawing.Size(68, 20);
            this.txtCuentaIni.TabIndex = 5;
            // 
            // txtCuentaFin
            // 
            this.txtCuentaFin.EditValue = "";
            this.txtCuentaFin.Location = new System.Drawing.Point(140, 29);
            this.txtCuentaFin.Name = "txtCuentaFin";
            this.txtCuentaFin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuentaFin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCuentaFin.Properties.Mask.EditMask = "\\d+";
            this.txtCuentaFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCuentaFin.Properties.MaxLength = 10;
            this.txtCuentaFin.Size = new System.Drawing.Size(68, 20);
            this.txtCuentaFin.TabIndex = 6;
            // 
            // txtPerFin
            // 
            this.txtPerFin.EditValue = "";
            this.txtPerFin.Location = new System.Drawing.Point(395, 6);
            this.txtPerFin.Name = "txtPerFin";
            this.txtPerFin.Properties.Mask.EditMask = "0000-00";
            this.txtPerFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPerFin.Size = new System.Drawing.Size(58, 20);
            this.txtPerFin.TabIndex = 4;
            // 
            // txtPerIni
            // 
            this.txtPerIni.EditValue = "";
            this.txtPerIni.Location = new System.Drawing.Point(335, 6);
            this.txtPerIni.Name = "txtPerIni";
            this.txtPerIni.Properties.Mask.EditMask = "0000-00";
            this.txtPerIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPerIni.Size = new System.Drawing.Size(58, 20);
            this.txtPerIni.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(287, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 101;
            this.labelControl5.Text = "Periodos:";
            // 
            // frmRptDetalleCuenta
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptDetalleCuenta";
            this.Text = "Detalle de vouchers por cuentas y periodos";
            this.Load += new System.EventHandler(this.frmRptDetalleCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerIni.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbMoneda;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCuentaIni;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCuentaFin;
        private DevExpress.XtraEditors.TextEdit txtPerFin;
        private DevExpress.XtraEditors.TextEdit txtPerIni;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
