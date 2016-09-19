namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.Varios
{
    partial class frmRptPlanCuenta
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
            this.cmbMayor02 = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTipoCuenta = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEstado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMayor03 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarFileTXT = new DevExpress.XtraEditors.SimpleButton();
            this.cmbMayor04 = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbMayor05 = new DevExpress.XtraEditors.LookUpEdit();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.chkMayor02 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor02.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor03.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor04.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor05.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMayor02.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.chkMayor02);
            this.pnlFilter.Controls.Add(this.chkEstado);
            this.pnlFilter.Controls.Add(this.cmbMayor05);
            this.pnlFilter.Controls.Add(this.cmbMayor04);
            this.pnlFilter.Controls.Add(this.cmbTipoCuenta);
            this.pnlFilter.Controls.Add(this.labelControl4);
            this.pnlFilter.Controls.Add(this.cmbEstado);
            this.pnlFilter.Controls.Add(this.labelControl5);
            this.pnlFilter.Controls.Add(this.cmbMayor03);
            this.pnlFilter.Controls.Add(this.labelControl6);
            this.pnlFilter.Controls.Add(this.cmbMayor02);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.txtPeriodo);
            this.pnlFilter.Controls.Add(this.labelControl2);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            this.pnlFilter.Size = new System.Drawing.Size(737, 54);
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
            this.lblTitulo.Text = "PLAN DE CUENTAS";
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
            this.cmbCompania.Location = new System.Drawing.Point(77, 6);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 40, "Compania"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Descripcion")});
            this.cmbCompania.Size = new System.Drawing.Size(144, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(234, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Per.DIA TXT:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(299, 6);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(59, 20);
            this.txtPeriodo.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Clasific(2):";
            // 
            // cmbMayor02
            // 
            this.cmbMayor02.Location = new System.Drawing.Point(94, 29);
            this.cmbMayor02.Name = "cmbMayor02";
            this.cmbMayor02.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMayor02.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clasificacion", 22, "Cod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbMayor02.Properties.DropDownRows = 10;
            this.cmbMayor02.Properties.ReadOnly = true;
            this.cmbMayor02.Size = new System.Drawing.Size(127, 20);
            this.cmbMayor02.TabIndex = 3;
            this.cmbMayor02.EditValueChanged += new System.EventHandler(this.cmbMayor02_EditValueChanged);
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.Location = new System.Drawing.Point(494, 6);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoCuenta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbTipoCuenta.Properties.DropDownRows = 4;
            this.cmbTipoCuenta.Properties.PopupFormMinSize = new System.Drawing.Size(93, 0);
            this.cmbTipoCuenta.Size = new System.Drawing.Size(87, 20);
            this.cmbTipoCuenta.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(430, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tipo Cuenta:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(654, 6);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbEstado.Properties.DropDownRows = 4;
            this.cmbEstado.Properties.PopupFormMinSize = new System.Drawing.Size(93, 0);
            this.cmbEstado.Properties.ReadOnly = true;
            this.cmbEstado.Size = new System.Drawing.Size(78, 20);
            this.cmbEstado.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(595, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Estado:";
            // 
            // cmbMayor03
            // 
            this.cmbMayor03.Location = new System.Drawing.Point(299, 29);
            this.cmbMayor03.Name = "cmbMayor03";
            this.cmbMayor03.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMayor03.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaMayor", 24, "Cod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbMayor03.Properties.DropDownRows = 10;
            this.cmbMayor03.Properties.ReadOnly = true;
            this.cmbMayor03.Size = new System.Drawing.Size(129, 20);
            this.cmbMayor03.TabIndex = 5;
            this.cmbMayor03.EditValueChanged += new System.EventHandler(this.cmbMayor03_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(234, 31);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Cta.Mayor:";
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
            // cmbMayor04
            // 
            this.cmbMayor04.Location = new System.Drawing.Point(430, 29);
            this.cmbMayor04.Name = "cmbMayor04";
            this.cmbMayor04.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMayor04.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaMayor04", 30, "Cod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbMayor04.Properties.DropDownRows = 10;
            this.cmbMayor04.Properties.ReadOnly = true;
            this.cmbMayor04.Size = new System.Drawing.Size(151, 20);
            this.cmbMayor04.TabIndex = 11;
            this.cmbMayor04.EditValueChanged += new System.EventHandler(this.cmbMayor04_EditValueChanged);
            // 
            // cmbMayor05
            // 
            this.cmbMayor05.Location = new System.Drawing.Point(582, 29);
            this.cmbMayor05.Name = "cmbMayor05";
            this.cmbMayor05.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMayor05.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaMayor05", 35, "Cod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 100, "Nombre")});
            this.cmbMayor05.Properties.DropDownRows = 4;
            this.cmbMayor05.Properties.ReadOnly = true;
            this.cmbMayor05.Size = new System.Drawing.Size(150, 20);
            this.cmbMayor05.TabIndex = 12;
            // 
            // chkEstado
            // 
            this.chkEstado.EditValue = true;
            this.chkEstado.Location = new System.Drawing.Point(636, 7);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "";
            this.chkEstado.Size = new System.Drawing.Size(17, 19);
            this.chkEstado.TabIndex = 13;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // chkMayor02
            // 
            this.chkMayor02.EditValue = true;
            this.chkMayor02.Location = new System.Drawing.Point(76, 28);
            this.chkMayor02.Name = "chkMayor02";
            this.chkMayor02.Properties.Caption = "";
            this.chkMayor02.Size = new System.Drawing.Size(17, 19);
            this.chkMayor02.TabIndex = 14;
            this.chkMayor02.CheckedChanged += new System.EventHandler(this.chkMayor02_CheckedChanged);
            // 
            // frmRptPlanCuenta
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptPlanCuenta";
            this.Text = "Plan de Cuentas";
            this.Load += new System.EventHandler(this.frmRptPlanCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor02.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor03.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor04.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMayor05.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMayor02.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbMayor03;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoCuenta;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmbMayor02;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGenerarFileTXT;
        private DevExpress.XtraEditors.LookUpEdit cmbMayor05;
        private DevExpress.XtraEditors.LookUpEdit cmbMayor04;
        private DevExpress.XtraEditors.CheckEdit chkMayor02;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
    }
}
