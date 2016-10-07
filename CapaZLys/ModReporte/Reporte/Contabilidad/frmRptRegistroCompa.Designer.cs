namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    partial class frmRptRegistroCompa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptRegistroCompa));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbConsulta = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPerFin = new DevExpress.XtraEditors.TextEdit();
            this.txtPerIni = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chkProveedor = new DevExpress.XtraEditors.CheckEdit();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedorNom = new DevExpress.XtraEditors.TextEdit();
            this.btnProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.chkMayorUIT = new DevExpress.XtraEditors.CheckEdit();
            this.chkDatoProv = new DevExpress.XtraEditors.CheckEdit();
            this.cmbDatoProv = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbVersion = new DevExpress.XtraEditors.LookUpEdit();
            this.ccbRegistro = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarFileTXT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConsulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedorNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMayorUIT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDatoProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatoProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbRegistro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.labelControl4);
            this.pnlFilter.Controls.Add(this.ccbRegistro);
            this.pnlFilter.Controls.Add(this.cmbVersion);
            this.pnlFilter.Controls.Add(this.labelControl9);
            this.pnlFilter.Controls.Add(this.cmbDatoProv);
            this.pnlFilter.Controls.Add(this.chkDatoProv);
            this.pnlFilter.Controls.Add(this.chkMayorUIT);
            this.pnlFilter.Controls.Add(this.btnProveedor);
            this.pnlFilter.Controls.Add(this.txtProveedorNom);
            this.pnlFilter.Controls.Add(this.txtProveedor);
            this.pnlFilter.Controls.Add(this.chkProveedor);
            this.pnlFilter.Controls.Add(this.labelControl8);
            this.pnlFilter.Controls.Add(this.txtPerFin);
            this.pnlFilter.Controls.Add(this.txtPerIni);
            this.pnlFilter.Controls.Add(this.labelControl5);
            this.pnlFilter.Controls.Add(this.cmbConsulta);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            this.pnlFilter.Size = new System.Drawing.Size(655, 74);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(683, 76);
            this.btnBuscar.Size = new System.Drawing.Size(63, 23);
            // 
            // dvReport
            // 
            this.dvReport.Size = new System.Drawing.Size(765, 335);
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
            this.pnlCuerpo.SplitterPosition = 126;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.Size = new System.Drawing.Size(765, 25);
            this.lblTitulo.Text = "REGISTRO DE COMPRAS";
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
            this.cmbCompania.Size = new System.Drawing.Size(139, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(392, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 100;
            this.labelControl3.Text = "Consulta:";
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.Location = new System.Drawing.Point(453, 6);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbConsulta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbConsulta.Properties.DropDownRows = 5;
            this.cmbConsulta.Size = new System.Drawing.Size(197, 20);
            this.cmbConsulta.TabIndex = 2;
            // 
            // txtPerFin
            // 
            this.txtPerFin.EditValue = "";
            this.txtPerFin.Location = new System.Drawing.Point(320, 6);
            this.txtPerFin.Name = "txtPerFin";
            this.txtPerFin.Properties.Mask.EditMask = "0000-00";
            this.txtPerFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPerFin.Size = new System.Drawing.Size(55, 20);
            this.txtPerFin.TabIndex = 4;
            // 
            // txtPerIni
            // 
            this.txtPerIni.EditValue = "";
            this.txtPerIni.Location = new System.Drawing.Point(264, 6);
            this.txtPerIni.Name = "txtPerIni";
            this.txtPerIni.Properties.Mask.EditMask = "0000-00";
            this.txtPerIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPerIni.Size = new System.Drawing.Size(55, 20);
            this.txtPerIni.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(218, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 101;
            this.labelControl5.Text = "Periodo:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 31);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 105;
            this.labelControl8.Text = "Proveedor:";
            // 
            // chkProveedor
            // 
            this.chkProveedor.EditValue = true;
            this.chkProveedor.Location = new System.Drawing.Point(69, 29);
            this.chkProveedor.Name = "chkProveedor";
            this.chkProveedor.Properties.Caption = "";
            this.chkProveedor.Size = new System.Drawing.Size(16, 19);
            this.chkProveedor.TabIndex = 7;
            this.chkProveedor.CheckedChanged += new System.EventHandler(this.chkProveedor_CheckedChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.EditValue = "";
            this.txtProveedor.Location = new System.Drawing.Point(87, 29);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Mask.EditMask = "\\d+";
            this.txtProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtProveedor.Properties.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(58, 20);
            this.txtProveedor.TabIndex = 8;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // txtProveedorNom
            // 
            this.txtProveedorNom.EditValue = "";
            this.txtProveedorNom.Location = new System.Drawing.Point(147, 29);
            this.txtProveedorNom.Name = "txtProveedorNom";
            this.txtProveedorNom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtProveedorNom.Properties.ReadOnly = true;
            this.txtProveedorNom.Size = new System.Drawing.Size(200, 20);
            this.txtProveedorNom.TabIndex = 11;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.Location = new System.Drawing.Point(349, 28);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(26, 21);
            this.btnProveedor.TabIndex = 9;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // chkMayorUIT
            // 
            this.chkMayorUIT.EditValue = true;
            this.chkMayorUIT.Location = new System.Drawing.Point(214, 51);
            this.chkMayorUIT.Name = "chkMayorUIT";
            this.chkMayorUIT.Properties.Caption = ":Mayor a UIT";
            this.chkMayorUIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMayorUIT.Size = new System.Drawing.Size(84, 19);
            this.chkMayorUIT.TabIndex = 106;
            // 
            // chkDatoProv
            // 
            this.chkDatoProv.EditValue = true;
            this.chkDatoProv.Location = new System.Drawing.Point(469, 28);
            this.chkDatoProv.Name = "chkDatoProv";
            this.chkDatoProv.Properties.Caption = ":Dato Prov";
            this.chkDatoProv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDatoProv.Size = new System.Drawing.Size(76, 19);
            this.chkDatoProv.TabIndex = 107;
            this.chkDatoProv.CheckedChanged += new System.EventHandler(this.chkDatoProv_CheckedChanged);
            // 
            // cmbDatoProv
            // 
            this.cmbDatoProv.Location = new System.Drawing.Point(551, 27);
            this.cmbDatoProv.Name = "cmbDatoProv";
            this.cmbDatoProv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDatoProv.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbDatoProv.Properties.DropDownRows = 4;
            this.cmbDatoProv.Properties.PopupFormMinSize = new System.Drawing.Size(100, 0);
            this.cmbDatoProv.Properties.ReadOnly = true;
            this.cmbDatoProv.Size = new System.Drawing.Size(99, 20);
            this.cmbDatoProv.TabIndex = 108;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(472, 51);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 109;
            this.labelControl9.Text = "Version PLE:";
            // 
            // cmbVersion
            // 
            this.cmbVersion.Location = new System.Drawing.Point(551, 48);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVersion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbVersion.Properties.DropDownRows = 4;
            this.cmbVersion.Properties.PopupFormMinSize = new System.Drawing.Size(100, 0);
            this.cmbVersion.Size = new System.Drawing.Size(99, 20);
            this.cmbVersion.TabIndex = 110;
            // 
            // ccbRegistro
            // 
            this.ccbRegistro.EditValue = ", , ";
            this.ccbRegistro.Location = new System.Drawing.Point(69, 51);
            this.ccbRegistro.Name = "ccbRegistro";
            this.ccbRegistro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbRegistro.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Obligaciones", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Caja Chica", System.Windows.Forms.CheckState.Checked),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Rep. Gasto", System.Windows.Forms.CheckState.Checked)});
            this.ccbRegistro.Size = new System.Drawing.Size(139, 20);
            this.ccbRegistro.TabIndex = 112;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 113;
            this.labelControl4.Text = "Registros:";
            // 
            // btnGenerarFileTXT
            // 
            this.btnGenerarFileTXT.Location = new System.Drawing.Point(6, 101);
            this.btnGenerarFileTXT.Name = "btnGenerarFileTXT";
            this.btnGenerarFileTXT.Size = new System.Drawing.Size(99, 25);
            this.btnGenerarFileTXT.TabIndex = 114;
            this.btnGenerarFileTXT.Text = "Generar File TXT";
            this.btnGenerarFileTXT.Click += new System.EventHandler(this.btnGenerarFileTXT_Click);
            // 
            // frmRptRegistroCompa
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptRegistroCompa";
            this.Text = "Registro de Compras";
            this.Load += new System.EventHandler(this.frmRptRegistroCompa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConsulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedorNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMayorUIT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDatoProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDatoProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbRegistro.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbConsulta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPerFin;
        private DevExpress.XtraEditors.TextEdit txtPerIni;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtProveedorNom;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraEditors.CheckEdit chkProveedor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnProveedor;
        private DevExpress.XtraEditors.CheckEdit chkMayorUIT;
        private DevExpress.XtraEditors.LookUpEdit cmbVersion;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit cmbDatoProv;
        private DevExpress.XtraEditors.CheckEdit chkDatoProv;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbRegistro;
        private DevExpress.XtraEditors.SimpleButton btnGenerarFileTXT;
    }
}
