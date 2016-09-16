namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad
{
    partial class frmRptRegistroDaot
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
            this.cmbConsulta = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbSuperaLimite = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarFileTXT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConsulta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuperaLimite.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.cmbSuperaLimite);
            this.pnlFilter.Controls.Add(this.labelControl6);
            this.pnlFilter.Controls.Add(this.cmbConsulta);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.txtPeriodo);
            this.pnlFilter.Controls.Add(this.labelControl2);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(674, 83);
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
            this.lblTitulo.Text = "REGISTRO DAOT";
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
            this.cmbCompania.Location = new System.Drawing.Point(83, 6);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCompania.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Compania", 40, "Compania"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombres", 100, "Descripcion")});
            this.cmbCompania.Size = new System.Drawing.Size(200, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(183, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(229, 28);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "\\d+";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtPeriodo.Size = new System.Drawing.Size(54, 20);
            this.txtPeriodo.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(318, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Consulta:";
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.Location = new System.Drawing.Point(365, 6);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbConsulta.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbConsulta.Properties.DropDownRows = 4;
            this.cmbConsulta.Properties.PopupFormMinSize = new System.Drawing.Size(88, 0);
            this.cmbConsulta.Size = new System.Drawing.Size(269, 20);
            this.cmbConsulta.TabIndex = 2;
            // 
            // cmbSuperaLimite
            // 
            this.cmbSuperaLimite.Location = new System.Drawing.Point(83, 28);
            this.cmbSuperaLimite.Name = "cmbSuperaLimite";
            this.cmbSuperaLimite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSuperaLimite.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbSuperaLimite.Properties.DropDownRows = 4;
            this.cmbSuperaLimite.Properties.PopupFormMinSize = new System.Drawing.Size(88, 0);
            this.cmbSuperaLimite.Size = new System.Drawing.Size(86, 20);
            this.cmbSuperaLimite.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Supera Limite:";
            // 
            // btnGenerarFileTXT
            // 
            this.btnGenerarFileTXT.Location = new System.Drawing.Point(6, 82);
            this.btnGenerarFileTXT.Name = "btnGenerarFileTXT";
            this.btnGenerarFileTXT.Size = new System.Drawing.Size(99, 24);
            this.btnGenerarFileTXT.TabIndex = 15;
            this.btnGenerarFileTXT.Text = "Generar File TXT";
            this.btnGenerarFileTXT.Click += new System.EventHandler(this.btnGenerarFileTXT_Click);
            // 
            // frmRptDaot
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptDaot";
            this.Text = "Registro DAOT";
            this.Load += new System.EventHandler(this.frmRptDaot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConsulta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuperaLimite.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbSuperaLimite;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbConsulta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGenerarFileTXT;
    }
}
