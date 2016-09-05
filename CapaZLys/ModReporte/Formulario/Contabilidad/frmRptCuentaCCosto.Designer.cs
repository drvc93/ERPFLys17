namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad
{
    partial class frmRptCuentaCCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptCuentaCCosto));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCompania = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMayorDesde = new DevExpress.XtraEditors.TextEdit();
            this.txtMayorDesdeNom = new DevExpress.XtraEditors.TextEdit();
            this.btnMayorDesde = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnMayorHasta = new DevExpress.XtraEditors.SimpleButton();
            this.txtMayorHastaNom = new DevExpress.XtraEditors.TextEdit();
            this.txtMayorHasta = new DevExpress.XtraEditors.TextEdit();
            this.chkCCosto = new DevExpress.XtraEditors.CheckEdit();
            this.btnCCosto = new DevExpress.XtraEditors.SimpleButton();
            this.txtCCostoNom = new DevExpress.XtraEditors.TextEdit();
            this.txtCCosto = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorDesdeNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorHastaNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCostoNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCosto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnCCosto);
            this.pnlFilter.Controls.Add(this.txtCCostoNom);
            this.pnlFilter.Controls.Add(this.txtCCosto);
            this.pnlFilter.Controls.Add(this.chkCCosto);
            this.pnlFilter.Controls.Add(this.btnMayorHasta);
            this.pnlFilter.Controls.Add(this.txtMayorHastaNom);
            this.pnlFilter.Controls.Add(this.txtMayorHasta);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.btnMayorDesde);
            this.pnlFilter.Controls.Add(this.txtMayorDesdeNom);
            this.pnlFilter.Controls.Add(this.txtMayorDesde);
            this.pnlFilter.Controls.Add(this.labelControl7);
            this.pnlFilter.Controls.Add(this.labelControl4);
            this.pnlFilter.Controls.Add(this.txtPeriodo);
            this.pnlFilter.Controls.Add(this.labelControl2);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(686, 52);
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
            this.lblTitulo.Text = "CUENTAS POR CENTRO DE COSTOS";
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
            this.labelControl2.Location = new System.Drawing.Point(243, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(288, 5);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(50, 20);
            this.txtPeriodo.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(328, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Cta Mayor Hasta:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 31);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Cta Mayor Desde:";
            // 
            // txtMayorDesde
            // 
            this.txtMayorDesde.EditValue = "";
            this.txtMayorDesde.Location = new System.Drawing.Point(104, 29);
            this.txtMayorDesde.Name = "txtMayorDesde";
            this.txtMayorDesde.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayorDesde.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMayorDesde.Properties.MaxLength = 3;
            this.txtMayorDesde.Size = new System.Drawing.Size(40, 20);
            this.txtMayorDesde.TabIndex = 12;
            this.txtMayorDesde.EditValueChanged += new System.EventHandler(this.txtMayorDesde_EditValueChanged);
            // 
            // txtMayorDesdeNom
            // 
            this.txtMayorDesdeNom.EditValue = "";
            this.txtMayorDesdeNom.Location = new System.Drawing.Point(145, 29);
            this.txtMayorDesdeNom.Name = "txtMayorDesdeNom";
            this.txtMayorDesdeNom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayorDesdeNom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMayorDesdeNom.Properties.ReadOnly = true;
            this.txtMayorDesdeNom.Size = new System.Drawing.Size(132, 20);
            this.txtMayorDesdeNom.TabIndex = 13;
            // 
            // btnMayorDesde
            // 
            this.btnMayorDesde.Image = ((System.Drawing.Image)(resources.GetObject("btnMayorDesde.Image")));
            this.btnMayorDesde.Location = new System.Drawing.Point(279, 29);
            this.btnMayorDesde.Name = "btnMayorDesde";
            this.btnMayorDesde.Size = new System.Drawing.Size(26, 21);
            this.btnMayorDesde.TabIndex = 19;
            this.btnMayorDesde.Click += new System.EventHandler(this.btnMayorDesde_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(354, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Centro Costo:";
            // 
            // btnMayorHasta
            // 
            this.btnMayorHasta.Image = ((System.Drawing.Image)(resources.GetObject("btnMayorHasta.Image")));
            this.btnMayorHasta.Location = new System.Drawing.Point(619, 30);
            this.btnMayorHasta.Name = "btnMayorHasta";
            this.btnMayorHasta.Size = new System.Drawing.Size(26, 21);
            this.btnMayorHasta.TabIndex = 23;
            this.btnMayorHasta.Click += new System.EventHandler(this.btnMayorHasta_Click);
            // 
            // txtMayorHastaNom
            // 
            this.txtMayorHastaNom.EditValue = "";
            this.txtMayorHastaNom.Location = new System.Drawing.Point(460, 30);
            this.txtMayorHastaNom.Name = "txtMayorHastaNom";
            this.txtMayorHastaNom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayorHastaNom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMayorHastaNom.Properties.ReadOnly = true;
            this.txtMayorHastaNom.Size = new System.Drawing.Size(157, 20);
            this.txtMayorHastaNom.TabIndex = 22;
            // 
            // txtMayorHasta
            // 
            this.txtMayorHasta.EditValue = "";
            this.txtMayorHasta.Location = new System.Drawing.Point(419, 30);
            this.txtMayorHasta.Name = "txtMayorHasta";
            this.txtMayorHasta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMayorHasta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMayorHasta.Properties.MaxLength = 3;
            this.txtMayorHasta.Size = new System.Drawing.Size(40, 20);
            this.txtMayorHasta.TabIndex = 21;
            this.txtMayorHasta.EditValueChanged += new System.EventHandler(this.txtMayorHasta_EditValueChanged);
            // 
            // chkCCosto
            // 
            this.chkCCosto.EditValue = true;
            this.chkCCosto.Location = new System.Drawing.Point(426, 6);
            this.chkCCosto.Name = "chkCCosto";
            this.chkCCosto.Properties.Caption = "";
            this.chkCCosto.Size = new System.Drawing.Size(19, 19);
            this.chkCCosto.TabIndex = 24;
            this.chkCCosto.CheckedChanged += new System.EventHandler(this.chkCCosto_CheckedChanged);
            // 
            // btnCCosto
            // 
            this.btnCCosto.Image = ((System.Drawing.Image)(resources.GetObject("btnCCosto.Image")));
            this.btnCCosto.Location = new System.Drawing.Point(619, 6);
            this.btnCCosto.Name = "btnCCosto";
            this.btnCCosto.Size = new System.Drawing.Size(26, 21);
            this.btnCCosto.TabIndex = 27;
            this.btnCCosto.Click += new System.EventHandler(this.btnCCosto_Click);
            // 
            // txtCCostoNom
            // 
            this.txtCCostoNom.EditValue = "";
            this.txtCCostoNom.Location = new System.Drawing.Point(485, 6);
            this.txtCCostoNom.Name = "txtCCostoNom";
            this.txtCCostoNom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCCostoNom.Properties.ReadOnly = true;
            this.txtCCostoNom.Size = new System.Drawing.Size(132, 20);
            this.txtCCostoNom.TabIndex = 26;
            // 
            // txtCCosto
            // 
            this.txtCCosto.EditValue = "";
            this.txtCCosto.Location = new System.Drawing.Point(444, 6);
            this.txtCCosto.Name = "txtCCosto";
            this.txtCCosto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCCosto.Properties.MaxLength = 6;
            this.txtCCosto.Properties.ReadOnly = true;
            this.txtCCosto.Size = new System.Drawing.Size(40, 20);
            this.txtCCosto.TabIndex = 25;
            this.txtCCosto.EditValueChanged += new System.EventHandler(this.txtCCosto_EditValueChanged);
            // 
            // frmRptCuentaCCosto
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptCuentaCCosto";
            this.Text = "Cuentas por Centro de Costos";
            this.Load += new System.EventHandler(this.frmRptCuentaCCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorDesdeNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorHastaNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMayorHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCostoNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCosto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMayorDesde;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMayorDesdeNom;
        private DevExpress.XtraEditors.SimpleButton btnMayorDesde;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCCosto;
        private DevExpress.XtraEditors.TextEdit txtCCostoNom;
        private DevExpress.XtraEditors.TextEdit txtCCosto;
        private DevExpress.XtraEditors.CheckEdit chkCCosto;
        private DevExpress.XtraEditors.SimpleButton btnMayorHasta;
        private DevExpress.XtraEditors.TextEdit txtMayorHastaNom;
        private DevExpress.XtraEditors.TextEdit txtMayorHasta;
    }
}
