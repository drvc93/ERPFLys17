namespace FiltroLys.ZLys.ModReporte.Formulario.Contabilidad.LibrosContables
{
    partial class frmRptSaldoContableDet
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
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBarSuperior
            // 
            this.pbBarSuperior.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.pbBarSuperior.FloatLocation = new System.Drawing.Point(115, 143);
            this.pbBarSuperior.Offset = 67;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Size = new System.Drawing.Size(655, 10);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(-191, 25);
            this.btnBuscar.Size = new System.Drawing.Size(63, 23);
            this.btnBuscar.Visible = false;
            // 
            // dvReport
            // 
            this.dvReport.Size = new System.Drawing.Size(596, 321);
            // 
            // pbBarInferior
            // 
            this.pbBarInferior.OptionsBar.AllowQuickCustomization = false;
            this.pbBarInferior.OptionsBar.DrawDragBorder = false;
            this.pbBarInferior.OptionsBar.UseWholeRow = true;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Size = new System.Drawing.Size(596, 327);
            this.pnlCuerpo.SplitterPosition = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitulo.Size = new System.Drawing.Size(596, 1);
            this.lblTitulo.Text = "";
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(0, 31);
            this.pnMain.Size = new System.Drawing.Size(600, 331);
            // 
            // frmRptSaldoContableDet
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRptSaldoContableDet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Cuenta - Balance";
            this.Load += new System.EventHandler(this.frmSaldoContableDet_Load);
            this.Shown += new System.EventHandler(this.frmRptSaldoContableDet_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCuerpo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
