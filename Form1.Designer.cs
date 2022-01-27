namespace Actividad1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_EquipoLabel;
            System.Windows.Forms.Label nombre_EquipoLabel;
            System.Windows.Forms.Label año_CreacionLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label comunidadLabel;
            System.Windows.Forms.Label presupuestoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.equiposBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laLigaDataSet = new Actividad1.LaLigaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.equiposBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.equiposDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_EquipoTextBox = new System.Windows.Forms.TextBox();
            this.nombre_EquipoTextBox = new System.Windows.Forms.TextBox();
            this.año_CreacionTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.comunidadTextBox = new System.Windows.Forms.TextBox();
            this.presupuestoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Actividad1.LaLigaDataSetTableAdapters.EquiposTableAdapter();
            this.tableAdapterManager = new Actividad1.LaLigaDataSetTableAdapters.TableAdapterManager();
            this.estadiosTableAdapter = new Actividad1.LaLigaDataSetTableAdapters.EstadiosTableAdapter();
            this.jugadorTableAdapter = new Actividad1.LaLigaDataSetTableAdapters.JugadorTableAdapter();
            id_EquipoLabel = new System.Windows.Forms.Label();
            nombre_EquipoLabel = new System.Windows.Forms.Label();
            año_CreacionLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            comunidadLabel = new System.Windows.Forms.Label();
            presupuestoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingNavigator)).BeginInit();
            this.equiposBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laLigaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_EquipoLabel
            // 
            id_EquipoLabel.BackColor = System.Drawing.Color.White;
            id_EquipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_EquipoLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            id_EquipoLabel.Location = new System.Drawing.Point(34, 264);
            id_EquipoLabel.Name = "id_EquipoLabel";
            id_EquipoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            id_EquipoLabel.Size = new System.Drawing.Size(155, 32);
            id_EquipoLabel.TabIndex = 3;
            id_EquipoLabel.Text = "id Equipo:";
            // 
            // nombre_EquipoLabel
            // 
            nombre_EquipoLabel.BackColor = System.Drawing.Color.White;
            nombre_EquipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_EquipoLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            nombre_EquipoLabel.Location = new System.Drawing.Point(34, 298);
            nombre_EquipoLabel.Name = "nombre_EquipoLabel";
            nombre_EquipoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nombre_EquipoLabel.Size = new System.Drawing.Size(155, 25);
            nombre_EquipoLabel.TabIndex = 5;
            nombre_EquipoLabel.Text = "Nombre Equipo:";
            // 
            // año_CreacionLabel
            // 
            año_CreacionLabel.BackColor = System.Drawing.Color.White;
            año_CreacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            año_CreacionLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            año_CreacionLabel.Location = new System.Drawing.Point(34, 325);
            año_CreacionLabel.Name = "año_CreacionLabel";
            año_CreacionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            año_CreacionLabel.Size = new System.Drawing.Size(155, 25);
            año_CreacionLabel.TabIndex = 7;
            año_CreacionLabel.Text = "Año Creacion:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.BackColor = System.Drawing.Color.White;
            ciudadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            ciudadLabel.Location = new System.Drawing.Point(34, 353);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            ciudadLabel.Size = new System.Drawing.Size(155, 25);
            ciudadLabel.TabIndex = 9;
            ciudadLabel.Text = "Ciudad:";
            // 
            // comunidadLabel
            // 
            comunidadLabel.BackColor = System.Drawing.Color.White;
            comunidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comunidadLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            comunidadLabel.Location = new System.Drawing.Point(34, 381);
            comunidadLabel.Name = "comunidadLabel";
            comunidadLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            comunidadLabel.Size = new System.Drawing.Size(155, 25);
            comunidadLabel.TabIndex = 11;
            comunidadLabel.Text = "Comunidad:";
            // 
            // presupuestoLabel
            // 
            presupuestoLabel.BackColor = System.Drawing.Color.White;
            presupuestoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            presupuestoLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            presupuestoLabel.Location = new System.Drawing.Point(34, 409);
            presupuestoLabel.Name = "presupuestoLabel";
            presupuestoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            presupuestoLabel.Size = new System.Drawing.Size(155, 25);
            presupuestoLabel.TabIndex = 13;
            presupuestoLabel.Text = "Presupuesto:";
            // 
            // equiposBindingNavigator
            // 
            this.equiposBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.equiposBindingNavigator.BindingSource = this.equiposBindingSource;
            this.equiposBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.equiposBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equiposBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.equiposBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.equiposBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.equiposBindingNavigatorSaveItem});
            this.equiposBindingNavigator.Location = new System.Drawing.Point(0, 725);
            this.equiposBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.equiposBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.equiposBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.equiposBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.equiposBindingNavigator.Name = "equiposBindingNavigator";
            this.equiposBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.equiposBindingNavigator.Size = new System.Drawing.Size(1561, 27);
            this.equiposBindingNavigator.TabIndex = 0;
            this.equiposBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.laLigaDataSet;
            // 
            // laLigaDataSet
            // 
            this.laLigaDataSet.DataSetName = "LaLigaDataSet";
            this.laLigaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // equiposBindingNavigatorSaveItem
            // 
            this.equiposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.equiposBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("equiposBindingNavigatorSaveItem.Image")));
            this.equiposBindingNavigatorSaveItem.Name = "equiposBindingNavigatorSaveItem";
            this.equiposBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.equiposBindingNavigatorSaveItem.Text = "Guardar datos";
            this.equiposBindingNavigatorSaveItem.Click += new System.EventHandler(this.equiposBindingNavigatorSaveItem_Click);
            // 
            // equiposDataGridView
            // 
            this.equiposDataGridView.AutoGenerateColumns = false;
            this.equiposDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equiposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.equiposDataGridView.DataSource = this.equiposBindingSource;
            this.equiposDataGridView.Location = new System.Drawing.Point(466, 264);
            this.equiposDataGridView.Name = "equiposDataGridView";
            this.equiposDataGridView.RowHeadersWidth = 51;
            this.equiposDataGridView.RowTemplate.Height = 24;
            this.equiposDataGridView.Size = new System.Drawing.Size(1083, 208);
            this.equiposDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Equipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Equipo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Equipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre_Equipo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Año_Creacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Año_Creacion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Comunidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Comunidad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Presupuesto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Presupuesto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // id_EquipoTextBox
            // 
            this.id_EquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "id_Equipo", true));
            this.id_EquipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_EquipoTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.id_EquipoTextBox.Location = new System.Drawing.Point(208, 264);
            this.id_EquipoTextBox.Name = "id_EquipoTextBox";
            this.id_EquipoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_EquipoTextBox.Size = new System.Drawing.Size(158, 30);
            this.id_EquipoTextBox.TabIndex = 4;
            // 
            // nombre_EquipoTextBox
            // 
            this.nombre_EquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "Nombre_Equipo", true));
            this.nombre_EquipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_EquipoTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nombre_EquipoTextBox.Location = new System.Drawing.Point(208, 292);
            this.nombre_EquipoTextBox.Name = "nombre_EquipoTextBox";
            this.nombre_EquipoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombre_EquipoTextBox.Size = new System.Drawing.Size(158, 30);
            this.nombre_EquipoTextBox.TabIndex = 6;
            // 
            // año_CreacionTextBox
            // 
            this.año_CreacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "Año_Creacion", true));
            this.año_CreacionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año_CreacionTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.año_CreacionTextBox.Location = new System.Drawing.Point(208, 320);
            this.año_CreacionTextBox.Name = "año_CreacionTextBox";
            this.año_CreacionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.año_CreacionTextBox.Size = new System.Drawing.Size(158, 30);
            this.año_CreacionTextBox.TabIndex = 8;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "Ciudad", true));
            this.ciudadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ciudadTextBox.Location = new System.Drawing.Point(208, 348);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ciudadTextBox.Size = new System.Drawing.Size(158, 30);
            this.ciudadTextBox.TabIndex = 10;
            // 
            // comunidadTextBox
            // 
            this.comunidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "Comunidad", true));
            this.comunidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comunidadTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comunidadTextBox.Location = new System.Drawing.Point(208, 376);
            this.comunidadTextBox.Name = "comunidadTextBox";
            this.comunidadTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comunidadTextBox.Size = new System.Drawing.Size(158, 30);
            this.comunidadTextBox.TabIndex = 12;
            // 
            // presupuestoTextBox
            // 
            this.presupuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "Presupuesto", true));
            this.presupuestoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presupuestoTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.presupuestoTextBox.Location = new System.Drawing.Point(208, 404);
            this.presupuestoTextBox.Name = "presupuestoTextBox";
            this.presupuestoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.presupuestoTextBox.Size = new System.Drawing.Size(158, 30);
            this.presupuestoTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(27, 206);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Detalle de Equipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tabla de Equipos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(211, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 59);
            this.button1.TabIndex = 17;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(34, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 59);
            this.button2.TabIndex = 18;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataMember = "Jugador";
            this.jugadorBindingSource.DataSource = this.laLigaDataSet;
            // 
            // estadiosBindingSource
            // 
            this.estadiosBindingSource.DataMember = "Estadios";
            this.estadiosBindingSource.DataSource = this.laLigaDataSet;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquiposTableAdapter = this.equiposTableAdapter;
            this.tableAdapterManager.EstadiosTableAdapter = this.estadiosTableAdapter;
            this.tableAdapterManager.JugadorTableAdapter = this.jugadorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Actividad1.LaLigaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estadiosTableAdapter
            // 
            this.estadiosTableAdapter.ClearBeforeFill = true;
            // 
            // jugadorTableAdapter
            // 
            this.jugadorTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1561, 752);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(id_EquipoLabel);
            this.Controls.Add(this.id_EquipoTextBox);
            this.Controls.Add(nombre_EquipoLabel);
            this.Controls.Add(this.nombre_EquipoTextBox);
            this.Controls.Add(año_CreacionLabel);
            this.Controls.Add(this.año_CreacionTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(comunidadLabel);
            this.Controls.Add(this.comunidadTextBox);
            this.Controls.Add(presupuestoLabel);
            this.Controls.Add(this.presupuestoTextBox);
            this.Controls.Add(this.equiposDataGridView);
            this.Controls.Add(this.equiposBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingNavigator)).EndInit();
            this.equiposBindingNavigator.ResumeLayout(false);
            this.equiposBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laLigaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadiosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaLigaDataSet laLigaDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private LaLigaDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private LaLigaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator equiposBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton equiposBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView equiposDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private LaLigaDataSetTableAdapters.EstadiosTableAdapter estadiosTableAdapter;
        private System.Windows.Forms.BindingSource estadiosBindingSource;
        private LaLigaDataSetTableAdapters.JugadorTableAdapter jugadorTableAdapter;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.TextBox id_EquipoTextBox;
        private System.Windows.Forms.TextBox nombre_EquipoTextBox;
        private System.Windows.Forms.TextBox año_CreacionTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox comunidadTextBox;
        private System.Windows.Forms.TextBox presupuestoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

