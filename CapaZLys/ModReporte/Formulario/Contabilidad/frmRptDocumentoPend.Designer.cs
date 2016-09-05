namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad
{
    partial class frmRptDocumentoPend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptDocumentoPend));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.cmbFormato = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCuenta = new DevExpress.XtraEditors.SimpleButton();
            this.txtCuentaNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtCuenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnCuenta);
            this.pnlFilter.Controls.Add(this.txtCuentaNombre);
            this.pnlFilter.Controls.Add(this.txtCuenta);
            this.pnlFilter.Controls.Add(this.labelControl8);
            this.pnlFilter.Controls.Add(this.cmbFormato);
            this.pnlFilter.Controls.Add(this.labelControl5);
            this.pnlFilter.Controls.Add(this.txtPeriodo);
            this.pnlFilter.Controls.Add(this.labelControl2);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(695, 54);
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
            this.lblTitulo.Text = "INVENTARIOS DE DOCUMENTOS PENDIENTES";
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
            this.txtPeriodo.Location = new System.Drawing.Point(298, 6);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(59, 20);
            this.txtPeriodo.TabIndex = 2;
            // 
            // cmbFormato
            // 
            this.cmbFormato.Location = new System.Drawing.Point(547, 5);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFormato.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbFormato.Properties.PopupFormMinSize = new System.Drawing.Size(95, 0);
            this.cmbFormato.Size = new System.Drawing.Size(93, 20);
            this.cmbFormato.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(497, 7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Formato:";
            // 
            // btnCuenta
            // 
            this.btnCuenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCuenta.Image")));
            this.btnCuenta.Location = new System.Drawing.Point(359, 29);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(26, 21);
            this.btnCuenta.TabIndex = 108;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // txtCuentaNombre
            // 
            this.txtCuentaNombre.EditValue = "";
            this.txtCuentaNombre.Location = new System.Drawing.Point(138, 29);
            this.txtCuentaNombre.Name = "txtCuentaNombre";
            this.txtCuentaNombre.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCuentaNombre.Properties.ReadOnly = true;
            this.txtCuentaNombre.Size = new System.Drawing.Size(219, 20);
            this.txtCuentaNombre.TabIndex = 109;
            // 
            // txtCuenta
            // 
            this.txtCuenta.EditValue = "";
            this.txtCuenta.Location = new System.Drawing.Point(69, 29);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Properties.Mask.EditMask = "\\d+";
            this.txtCuenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCuenta.Size = new System.Drawing.Size(68, 20);
            this.txtCuenta.TabIndex = 107;
            this.txtCuenta.EditValueChanged += new System.EventHandler(this.txtCuenta_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 33);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 13);
            this.labelControl8.TabIndex = 110;
            this.labelControl8.Text = "Cuenta:";
            // 
            // frmRptDocumentoPend
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptDocumentoPend";
            this.Text = "Inventario de Documentos Pendientes";
            this.Load += new System.EventHandler(this.frmRptDocumentoPend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuentaNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuenta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbFormato;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCuenta;
        private DevExpress.XtraEditors.TextEdit txtCuentaNombre;
        private DevExpress.XtraEditors.TextEdit txtCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
