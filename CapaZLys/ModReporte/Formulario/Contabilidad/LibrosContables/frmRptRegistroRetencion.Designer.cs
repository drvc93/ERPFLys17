namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    partial class frmRptRegistroRetencion
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
            this.cmbOrigenRet = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTipoExp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarFileTXT = new DevExpress.XtraEditors.SimpleButton();
            this.chkPeriodo = new DevExpress.XtraEditors.CheckEdit();
            this.chkExcAnul = new DevExpress.XtraEditors.CheckEdit();
            this.chkOrigenRet = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkFecPago = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.deFecRet = new DevExpress.XtraEditors.DateEdit();
            this.deFecIni = new DevExpress.XtraEditors.DateEdit();
            this.deFecFin = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrigenRet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoExp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcAnul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOrigenRet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFecPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecRet.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecRet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecIni.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecFin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.chkOrigenRet);
            this.pnlFilter.Controls.Add(this.chkFecPago);
            this.pnlFilter.Controls.Add(this.deFecFin);
            this.pnlFilter.Controls.Add(this.deFecIni);
            this.pnlFilter.Controls.Add(this.deFecRet);
            this.pnlFilter.Controls.Add(this.labelControl6);
            this.pnlFilter.Controls.Add(this.labelControl3);
            this.pnlFilter.Controls.Add(this.chkExcAnul);
            this.pnlFilter.Controls.Add(this.chkPeriodo);
            this.pnlFilter.Controls.Add(this.cmbTipoExp);
            this.pnlFilter.Controls.Add(this.labelControl5);
            this.pnlFilter.Controls.Add(this.cmbOrigenRet);
            this.pnlFilter.Controls.Add(this.labelControl4);
            this.pnlFilter.Controls.Add(this.txtPeriodo);
            this.pnlFilter.Controls.Add(this.labelControl2);
            this.pnlFilter.Controls.Add(this.cmbCompania);
            this.pnlFilter.Controls.Add(this.labelControl1);
            this.pnlFilter.Size = new System.Drawing.Size(711, 54);
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
            this.lblTitulo.Text = "RETENCIONES PDT";
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
            this.cmbCompania.Size = new System.Drawing.Size(169, 20);
            this.cmbCompania.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Periodo:";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(86, 28);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Properties.Mask.EditMask = "0000-00";
            this.txtPeriodo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtPeriodo.Size = new System.Drawing.Size(48, 20);
            this.txtPeriodo.TabIndex = 2;
            // 
            // cmbOrigenRet
            // 
            this.cmbOrigenRet.Location = new System.Drawing.Point(633, 28);
            this.cmbOrigenRet.Name = "cmbOrigenRet";
            this.cmbOrigenRet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOrigenRet.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbOrigenRet.Properties.DropDownRows = 4;
            this.cmbOrigenRet.Properties.PopupFormMinSize = new System.Drawing.Size(70, 0);
            this.cmbOrigenRet.Properties.ReadOnly = true;
            this.cmbOrigenRet.Size = new System.Drawing.Size(69, 20);
            this.cmbOrigenRet.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(553, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Origen Ret:";
            // 
            // cmbTipoExp
            // 
            this.cmbTipoExp.Location = new System.Drawing.Point(331, 6);
            this.cmbTipoExp.Name = "cmbTipoExp";
            this.cmbTipoExp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoExp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 100, "Nombre")});
            this.cmbTipoExp.Properties.DropDownRows = 4;
            this.cmbTipoExp.Properties.PopupFormMinSize = new System.Drawing.Size(82, 0);
            this.cmbTipoExp.Size = new System.Drawing.Size(90, 20);
            this.cmbTipoExp.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(264, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tipo Exp:";
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
            // chkPeriodo
            // 
            this.chkPeriodo.Location = new System.Drawing.Point(69, 28);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Properties.Caption = "";
            this.chkPeriodo.Size = new System.Drawing.Size(15, 19);
            this.chkPeriodo.TabIndex = 11;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // chkExcAnul
            // 
            this.chkExcAnul.Location = new System.Drawing.Point(140, 29);
            this.chkExcAnul.Name = "chkExcAnul";
            this.chkExcAnul.Properties.Caption = ": Excluir Anulados";
            this.chkExcAnul.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkExcAnul.Size = new System.Drawing.Size(110, 19);
            this.chkExcAnul.TabIndex = 12;
            // 
            // chkOrigenRet
            // 
            this.chkOrigenRet.EditValue = true;
            this.chkOrigenRet.Location = new System.Drawing.Point(615, 29);
            this.chkOrigenRet.Name = "chkOrigenRet";
            this.chkOrigenRet.Properties.Caption = "";
            this.chkOrigenRet.Size = new System.Drawing.Size(15, 19);
            this.chkOrigenRet.TabIndex = 13;
            this.chkOrigenRet.CheckedChanged += new System.EventHandler(this.chkOrigenRet_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "F.Retención:";
            // 
            // chkFecPago
            // 
            this.chkFecPago.EditValue = true;
            this.chkFecPago.Location = new System.Drawing.Point(511, 8);
            this.chkFecPago.Name = "chkFecPago";
            this.chkFecPago.Properties.Caption = "";
            this.chkFecPago.Size = new System.Drawing.Size(15, 19);
            this.chkFecPago.TabIndex = 16;
            this.chkFecPago.CheckedChanged += new System.EventHandler(this.chkFecPago_CheckedChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(446, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Fecha Pago :";
            // 
            // deFecRet
            // 
            this.deFecRet.EditValue = null;
            this.deFecRet.Location = new System.Drawing.Point(331, 28);
            this.deFecRet.Name = "deFecRet";
            this.deFecRet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecRet.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecRet.Size = new System.Drawing.Size(90, 20);
            this.deFecRet.TabIndex = 17;
            // 
            // deFecIni
            // 
            this.deFecIni.EditValue = null;
            this.deFecIni.Location = new System.Drawing.Point(529, 6);
            this.deFecIni.Name = "deFecIni";
            this.deFecIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecIni.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecIni.Properties.ReadOnly = true;
            this.deFecIni.Size = new System.Drawing.Size(80, 20);
            this.deFecIni.TabIndex = 18;
            // 
            // deFecFin
            // 
            this.deFecFin.EditValue = null;
            this.deFecFin.Location = new System.Drawing.Point(615, 6);
            this.deFecFin.Name = "deFecFin";
            this.deFecFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecFin.Properties.ReadOnly = true;
            this.deFecFin.Size = new System.Drawing.Size(87, 20);
            this.deFecFin.TabIndex = 19;
            // 
            // frmRptRegistroRetencion
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(815, 496);
            this.Name = "frmRptRegistroRetencion";
            this.Text = "Retenciones PDT";
            this.Load += new System.EventHandler(this.frmRptRegistroRetencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompania.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrigenRet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoExp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcAnul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOrigenRet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFecPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecRet.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecRet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecIni.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecFin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbCompania;
        private DevExpress.XtraEditors.LookUpEdit cmbTipoExp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbOrigenRet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGenerarFileTXT;
        private DevExpress.XtraEditors.CheckEdit chkPeriodo;
        private DevExpress.XtraEditors.CheckEdit chkExcAnul;
        private DevExpress.XtraEditors.CheckEdit chkOrigenRet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit deFecRet;
        private DevExpress.XtraEditors.CheckEdit chkFecPago;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit deFecFin;
        private DevExpress.XtraEditors.DateEdit deFecIni;
    }
}
