namespace FiltroLys.ZLys.Sistema
{
    partial class frmListTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTabla));
            this.cmbTabla = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFolder = new DevExpress.XtraEditors.TextEdit();
            this.txtEntidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenQuery = new DevExpress.XtraEditors.SimpleButton();
            this.Posicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Default = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Propiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricVB = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cmbBaseDato = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.PosicionReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnchoSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DefaultNet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlagNull = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricevb = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.PkId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueVB = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Combo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Search = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PropiedadReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabEntidad = new DevExpress.XtraTab.XtraTabPage();
            this.txtQueryEntidad = new DevExpress.XtraEditors.MemoEdit();
            this.tabNegocio = new DevExpress.XtraTab.XtraTabPage();
            this.txtQueryNegocio = new DevExpress.XtraEditors.MemoEdit();
            this.tabData = new DevExpress.XtraTab.XtraTabPage();
            this.txtQueryData = new DevExpress.XtraEditors.MemoEdit();
            this.tabSP = new DevExpress.XtraTab.XtraTabPage();
            this.txtQueryStore = new DevExpress.XtraEditors.MemoEdit();
            this.chkSel = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).BeginInit();
            this.gpFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTabla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricVB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseDato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricevb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueVB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryEntidad.Properties)).BeginInit();
            this.tabNegocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryNegocio.Properties)).BeginInit();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryData.Properties)).BeginInit();
            this.tabSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryStore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFiltrar
            // 
            this.gpFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.gpFiltrar.Controls.Add(this.chkSel);
            this.gpFiltrar.Controls.Add(this.cmbBaseDato);
            this.gpFiltrar.Controls.Add(this.labelControl4);
            this.gpFiltrar.Controls.Add(this.btnGenQuery);
            this.gpFiltrar.Controls.Add(this.txtEntidad);
            this.gpFiltrar.Controls.Add(this.labelControl3);
            this.gpFiltrar.Controls.Add(this.txtFolder);
            this.gpFiltrar.Controls.Add(this.cmbTabla);
            this.gpFiltrar.Controls.Add(this.labelControl2);
            this.gpFiltrar.Controls.Add(this.labelControl1);
            this.gpFiltrar.Size = new System.Drawing.Size(620, 57);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.Location = new System.Drawing.Point(638, 63);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grControl
            // 
            this.grControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grControl.Location = new System.Drawing.Point(6, 95);
            this.grControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricevb,
            this.rilueVB});
            this.grControl.Size = new System.Drawing.Size(694, 345);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(1484, 23);
            this.label1.Text = "TABLAS DE SISTEMA";
            // 
            // gvDatos
            // 
            this.gvDatos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDatos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PosicionReg,
            this.PkId,
            this.NombreReg,
            this.PropiedadReg,
            this.TipoReg,
            this.AnchoSP,
            this.DefaultNet,
            this.FlagNull,
            this.Sel,
            this.Combo,
            this.Search});
            this.gvDatos.OptionsDetail.EnableMasterViewMode = false;
            this.gvDatos.OptionsView.ColumnAutoWidth = false;
            this.gvDatos.OptionsView.ShowGroupPanel = false;
            this.gvDatos.OptionsBehavior.ReadOnly = false;
            this.gvDatos.OptionsBehavior.Editable = true;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.xtraTabControl1);
            this.pnMain.Size = new System.Drawing.Size(813, 445);
            this.pnMain.Controls.SetChildIndex(this.grControl, 0);
            this.pnMain.Controls.SetChildIndex(this.btnBuscar, 0);
            this.pnMain.Controls.SetChildIndex(this.gpFiltrar, 0);
            this.pnMain.Controls.SetChildIndex(this.label1, 0);
            this.pnMain.Controls.SetChildIndex(this.xtraTabControl1, 0);
            // 
            // cmbTabla
            // 
            this.cmbTabla.Location = new System.Drawing.Point(47, 29);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTabla.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableName", 120, "Tabla")});
            this.cmbTabla.Properties.PopupWidth = 250;
            this.cmbTabla.Size = new System.Drawing.Size(190, 20);
            this.cmbTabla.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(250, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Folder";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Tabla:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(286, 5);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(152, 20);
            this.txtFolder.TabIndex = 14;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(496, 5);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(454, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Entidad";
            // 
            // btnGenQuery
            // 
            this.btnGenQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnGenQuery.Image")));
            this.btnGenQuery.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnGenQuery.Location = new System.Drawing.Point(286, 27);
            this.btnGenQuery.Name = "btnGenQuery";
            this.btnGenQuery.Size = new System.Drawing.Size(108, 23);
            this.btnGenQuery.TabIndex = 17;
            this.btnGenQuery.Text = "Generar Query";
            this.btnGenQuery.Click += new System.EventHandler(this.btnGenEntidad_Click);
            // 
            // Posicion
            // 
            this.Posicion.Caption = "#";
            this.Posicion.FieldName = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.OptionsColumn.AllowEdit = false;
            this.Posicion.OptionsColumn.ReadOnly = true;
            this.Posicion.Visible = true;
            this.Posicion.VisibleIndex = 0;
            this.Posicion.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsColumn.ReadOnly = true;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.OptionsColumn.AllowEdit = false;
            this.Tipo.OptionsColumn.ReadOnly = true;
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 2;
            this.Tipo.Width = 80;
            // 
            // Default
            // 
            this.Default.Caption = "Default";
            this.Default.FieldName = "Default";
            this.Default.Name = "Default";
            this.Default.Visible = true;
            this.Default.VisibleIndex = 3;
            this.Default.Width = 70;
            // 
            // Propiedad
            // 
            this.Propiedad.Caption = "Propiedad";
            this.Propiedad.FieldName = "Propiedad";
            this.Propiedad.Name = "Propiedad";
            this.Propiedad.Visible = true;
            this.Propiedad.VisibleIndex = 4;
            this.Propiedad.Width = 120;
            // 
            // VB
            // 
            this.VB.Caption = "VB";
            this.VB.ColumnEdit = this.ricVB;
            this.VB.FieldName = "VB";
            this.VB.Name = "VB";
            this.VB.Visible = true;
            this.VB.VisibleIndex = 5;
            this.VB.Width = 40;
            // 
            // ricVB
            // 
            this.ricVB.AutoHeight = false;
            this.ricVB.Name = "ricVB";
            this.ricVB.ValueChecked = "S";
            this.ricVB.ValueUnchecked = "N";
            // 
            // cmbBaseDato
            // 
            this.cmbBaseDato.Location = new System.Drawing.Point(47, 5);
            this.cmbBaseDato.Name = "cmbBaseDato";
            this.cmbBaseDato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBaseDato.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DataBase", 60, "DataBase")});
            this.cmbBaseDato.Properties.PopupWidth = 250;
            this.cmbBaseDato.Size = new System.Drawing.Size(190, 20);
            this.cmbBaseDato.TabIndex = 18;
            this.cmbBaseDato.EditValueChanged += new System.EventHandler(this.cmbBaseDato_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "BDato:";
            // 
            // PosicionReg
            // 
            this.PosicionReg.Caption = "#";
            this.PosicionReg.FieldName = "Posicion";
            this.PosicionReg.Name = "PosicionReg";
            this.PosicionReg.OptionsColumn.AllowEdit = false;
            this.PosicionReg.OptionsColumn.ReadOnly = true;
            this.PosicionReg.Visible = true;
            this.PosicionReg.VisibleIndex = 0;
            this.PosicionReg.Width = 32;
            // 
            // NombreReg
            // 
            this.NombreReg.Caption = "Nombre";
            this.NombreReg.FieldName = "Nombre";
            this.NombreReg.Name = "NombreReg";
            this.NombreReg.OptionsColumn.AllowEdit = false;
            this.NombreReg.OptionsColumn.ReadOnly = true;
            this.NombreReg.Visible = true;
            this.NombreReg.VisibleIndex = 2;
            this.NombreReg.Width = 96;
            // 
            // TipoReg
            // 
            this.TipoReg.Caption = "Tipo";
            this.TipoReg.FieldName = "Tipo";
            this.TipoReg.Name = "TipoReg";
            this.TipoReg.OptionsColumn.AllowEdit = false;
            this.TipoReg.OptionsColumn.ReadOnly = true;
            this.TipoReg.Visible = true;
            this.TipoReg.VisibleIndex = 3;
            this.TipoReg.Width = 61;
            // 
            // AnchoSP
            // 
            this.AnchoSP.Caption = "Ancho";
            this.AnchoSP.FieldName = "AnchoSP";
            this.AnchoSP.Name = "AnchoSP";
            this.AnchoSP.OptionsColumn.AllowEdit = false;
            this.AnchoSP.OptionsColumn.ReadOnly = true;
            this.AnchoSP.Visible = true;
            this.AnchoSP.VisibleIndex = 4;
            this.AnchoSP.Width = 47;
            // 
            // DefaultNet
            // 
            this.DefaultNet.Caption = "Default";
            this.DefaultNet.FieldName = "DefaultNet";
            this.DefaultNet.Name = "DefaultNet";
            this.DefaultNet.OptionsColumn.AllowEdit = false;
            this.DefaultNet.OptionsColumn.ReadOnly = true;
            this.DefaultNet.Visible = true;
            this.DefaultNet.VisibleIndex = 5;
            this.DefaultNet.Width = 49;
            // 
            // FlagNull
            // 
            this.FlagNull.Caption = "Null";
            this.FlagNull.ColumnEdit = this.ricevb;
            this.FlagNull.FieldName = "FlagNull";
            this.FlagNull.Name = "FlagNull";
            this.FlagNull.OptionsColumn.AllowEdit = false;
            this.FlagNull.OptionsColumn.ReadOnly = true;
            this.FlagNull.Visible = true;
            this.FlagNull.VisibleIndex = 6;
            this.FlagNull.Width = 36;
            // 
            // ricevb
            // 
            this.ricevb.AutoHeight = false;
            this.ricevb.Name = "ricevb";
            this.ricevb.ValueChecked = "S";
            this.ricevb.ValueUnchecked = "N";
            // 
            // PkId
            // 
            this.PkId.Caption = "PkId";
            this.PkId.ColumnEdit = this.ricevb;
            this.PkId.FieldName = "PkId";
            this.PkId.Name = "PkId";
            this.PkId.OptionsColumn.AllowEdit = false;
            this.PkId.OptionsColumn.ReadOnly = true;
            this.PkId.Visible = true;
            this.PkId.VisibleIndex = 1;
            this.PkId.Width = 37;
            // 
            // Sel
            // 
            this.Sel.Caption = "SelList";
            this.Sel.ColumnEdit = this.rilueVB;
            this.Sel.FieldName = "Sel";
            this.Sel.Name = "Sel";
            this.Sel.OptionsColumn.AllowEdit = true;
            this.Sel.OptionsColumn.ReadOnly = false;
            this.Sel.Visible = true;
            this.Sel.VisibleIndex = 8;
            this.Sel.Width = 71;
            // 
            // rilueVB
            // 
            this.rilueVB.AutoHeight = false;
            this.rilueVB.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueVB.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.rilueVB.Name = "rilueVB";
            this.rilueVB.PopupFormMinSize = new System.Drawing.Size(50, 100);
            this.rilueVB.PopupWidth = 50;
            // 
            // Combo
            // 
            this.Combo.Caption = "Combo";
            this.Combo.ColumnEdit = this.rilueVB;
            this.Combo.FieldName = "Combo";
            this.Combo.Name = "Combo";
            this.Combo.Visible = true;
            this.Combo.OptionsColumn.AllowEdit = true;
            this.Combo.OptionsColumn.ReadOnly = false;
            this.Combo.VisibleIndex = 9;
            this.Combo.Width = 64;
            // 
            // Search
            // 
            this.Search.Caption = "Busq";
            this.Search.ColumnEdit = this.rilueVB;
            this.Search.FieldName = "Search";
            this.Search.Name = "Search";
            this.Search.Visible = true;
            this.Search.OptionsColumn.AllowEdit = true;
            this.Search.OptionsColumn.ReadOnly = false;
            this.Search.VisibleIndex = 10;
            this.Search.Width = 64;
            // 
            // PropiedadReg
            // 
            this.PropiedadReg.Caption = "Propiedad";
            this.PropiedadReg.FieldName = "Propiedad";
            this.PropiedadReg.Name = "PropiedadReg";
            this.PropiedadReg.Visible = true;
            this.PropiedadReg.OptionsColumn.AllowEdit = true;
            this.PropiedadReg.OptionsColumn.ReadOnly = false;
            this.PropiedadReg.VisibleIndex = 7;
            this.PropiedadReg.Width = 100;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(706, 95);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabEntidad;
            this.xtraTabControl1.Size = new System.Drawing.Size(97, 345);
            this.xtraTabControl1.TabIndex = 11;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabEntidad,
            this.tabNegocio,
            this.tabData,
            this.tabSP});
            // 
            // tabEntidad
            // 
            this.tabEntidad.Controls.Add(this.txtQueryEntidad);
            this.tabEntidad.Name = "tabEntidad";
            this.tabEntidad.Size = new System.Drawing.Size(91, 317);
            this.tabEntidad.Text = "Entidad";
            // 
            // txtQueryEntidad
            // 
            this.txtQueryEntidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryEntidad.Location = new System.Drawing.Point(0, 0);
            this.txtQueryEntidad.Name = "txtQueryEntidad";
            this.txtQueryEntidad.Size = new System.Drawing.Size(91, 317);
            this.txtQueryEntidad.TabIndex = 0;
            // 
            // tabNegocio
            // 
            this.tabNegocio.Controls.Add(this.txtQueryNegocio);
            this.tabNegocio.Name = "tabNegocio";
            this.tabNegocio.Size = new System.Drawing.Size(91, 317);
            this.tabNegocio.Text = "Negocio";
            // 
            // txtQueryNegocio
            // 
            this.txtQueryNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryNegocio.Location = new System.Drawing.Point(0, 0);
            this.txtQueryNegocio.Name = "txtQueryNegocio";
            this.txtQueryNegocio.Size = new System.Drawing.Size(91, 317);
            this.txtQueryNegocio.TabIndex = 0;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.txtQueryData);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(91, 317);
            this.tabData.Text = "Data";
            // 
            // txtQueryData
            // 
            this.txtQueryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryData.Location = new System.Drawing.Point(0, 0);
            this.txtQueryData.Name = "txtQueryData";
            this.txtQueryData.Size = new System.Drawing.Size(91, 317);
            this.txtQueryData.TabIndex = 0;
            // 
            // tabSP
            // 
            this.tabSP.Controls.Add(this.txtQueryStore);
            this.tabSP.Name = "tabSP";
            this.tabSP.Size = new System.Drawing.Size(91, 317);
            this.tabSP.Text = "Store Proc";
            // 
            // txtQueryStore
            // 
            this.txtQueryStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryStore.Location = new System.Drawing.Point(0, 0);
            this.txtQueryStore.Name = "txtQueryStore";
            this.txtQueryStore.Size = new System.Drawing.Size(91, 317);
            this.txtQueryStore.TabIndex = 0;
            // 
            // chkSel
            // 
            this.chkSel.EditValue = true;
            this.chkSel.Location = new System.Drawing.Point(463, 37);
            this.chkSel.Name = "chkSel";
            this.chkSel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkSel.Properties.Appearance.Options.UseFont = true;
            this.chkSel.Properties.Appearance.Options.UseForeColor = true;
            this.chkSel.Properties.Caption = " Sel.  ALL";
            this.chkSel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSel.Size = new System.Drawing.Size(84, 19);
            this.chkSel.TabIndex = 20;
            this.chkSel.CheckedChanged += new System.EventHandler(this.chkSel_CheckedChanged);
            // 
            // frmListTabla
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(813, 445);
            this.Name = "frmListTabla";
            this.Text = "Tablas Sistema";
            this.Load += new System.EventHandler(this.frmListTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpFiltrar)).EndInit();
            this.gpFiltrar.ResumeLayout(false);
            this.gpFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMain)).EndInit();
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTabla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricVB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseDato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricevb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueVB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabEntidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryEntidad.Properties)).EndInit();
            this.tabNegocio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryNegocio.Properties)).EndInit();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryData.Properties)).EndInit();
            this.tabSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryStore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbTabla;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEntidad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFolder;
        private DevExpress.XtraEditors.SimpleButton btnGenQuery;
        private DevExpress.XtraGrid.Columns.GridColumn Posicion;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Default;
        private DevExpress.XtraGrid.Columns.GridColumn Propiedad;
        private DevExpress.XtraGrid.Columns.GridColumn VB;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricVB;
        private DevExpress.XtraEditors.LookUpEdit cmbBaseDato;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn PosicionReg;
        private DevExpress.XtraGrid.Columns.GridColumn PkId;
        private DevExpress.XtraGrid.Columns.GridColumn NombreReg;
        private DevExpress.XtraGrid.Columns.GridColumn TipoReg;
        private DevExpress.XtraGrid.Columns.GridColumn AnchoSP;
        private DevExpress.XtraGrid.Columns.GridColumn DefaultNet;
        private DevExpress.XtraGrid.Columns.GridColumn FlagNull;
        private DevExpress.XtraGrid.Columns.GridColumn Sel;
        private DevExpress.XtraGrid.Columns.GridColumn Combo;
        private DevExpress.XtraGrid.Columns.GridColumn Search;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricevb;
        private DevExpress.XtraGrid.Columns.GridColumn PropiedadReg;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabEntidad;
        private DevExpress.XtraTab.XtraTabPage tabNegocio;
        private DevExpress.XtraTab.XtraTabPage tabData;
        private DevExpress.XtraTab.XtraTabPage tabSP;
        private DevExpress.XtraEditors.MemoEdit txtQueryEntidad;
        private DevExpress.XtraEditors.MemoEdit txtQueryNegocio;
        private DevExpress.XtraEditors.MemoEdit txtQueryData;
        private DevExpress.XtraEditors.MemoEdit txtQueryStore;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueVB;
        private DevExpress.XtraEditors.CheckEdit chkSel;
    }
}
