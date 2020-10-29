namespace ClasesVirtualesProgramacion.Forms
{
    partial class frmGastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            this.gastosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClasesVirtuales = new ClasesVirtualesProgramacion.Data.dsClasesVirtuales();
            this.estudiantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblBuscarporg = new System.Windows.Forms.ToolStripLabel();
            this.cmbBuscarporg = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCriteriog = new System.Windows.Forms.ToolStripLabel();
            this.txtCriteriog = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscarg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSeleccionarg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostrarTodosg = new System.Windows.Forms.ToolStripButton();
            this.btnNuevog = new System.Windows.Forms.Button();
            this.btnEditarg = new System.Windows.Forms.Button();
            this.btnEliminarg = new System.Windows.Forms.Button();
            this.btnCerrarg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingNavigator)).BeginInit();
            this.estudiantesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gastosDataGridView
            // 
            this.gastosDataGridView.AllowUserToAddRows = false;
            this.gastosDataGridView.AllowUserToDeleteRows = false;
            this.gastosDataGridView.AutoGenerateColumns = false;
            this.gastosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gastosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gastosDataGridView.DataSource = this.gastosBindingSource;
            this.gastosDataGridView.Location = new System.Drawing.Point(12, 32);
            this.gastosDataGridView.Name = "gastosDataGridView";
            this.gastosDataGridView.ReadOnly = true;
            this.gastosDataGridView.RowHeadersWidth = 4;
            this.gastosDataGridView.Size = new System.Drawing.Size(682, 177);
            this.gastosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "subcategoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "formapago";
            this.dataGridViewTextBoxColumn7.HeaderText = "Forma pago";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataMember = "Gastos";
            this.gastosBindingSource.DataSource = this.dsClasesVirtuales;
            // 
            // dsClasesVirtuales
            // 
            this.dsClasesVirtuales.DataSetName = "dsClasesVirtuales";
            this.dsClasesVirtuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantesBindingNavigator
            // 
            this.estudiantesBindingNavigator.AddNewItem = null;
            this.estudiantesBindingNavigator.CountItem = null;
            this.estudiantesBindingNavigator.DeleteItem = null;
            this.estudiantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBuscarporg,
            this.cmbBuscarporg,
            this.toolStripSeparator1,
            this.lblCriteriog,
            this.txtCriteriog,
            this.toolStripSeparator2,
            this.btnBuscarg,
            this.toolStripSeparator3,
            this.btnSeleccionarg,
            this.toolStripSeparator4,
            this.btnMostrarTodosg});
            this.estudiantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estudiantesBindingNavigator.MoveFirstItem = null;
            this.estudiantesBindingNavigator.MoveLastItem = null;
            this.estudiantesBindingNavigator.MoveNextItem = null;
            this.estudiantesBindingNavigator.MovePreviousItem = null;
            this.estudiantesBindingNavigator.Name = "estudiantesBindingNavigator";
            this.estudiantesBindingNavigator.PositionItem = null;
            this.estudiantesBindingNavigator.Size = new System.Drawing.Size(787, 25);
            this.estudiantesBindingNavigator.TabIndex = 2;
            this.estudiantesBindingNavigator.Text = "bindingNavigator1";
            // 
            // lblBuscarporg
            // 
            this.lblBuscarporg.Name = "lblBuscarporg";
            this.lblBuscarporg.Size = new System.Drawing.Size(66, 22);
            this.lblBuscarporg.Text = "Buscar por:";
            // 
            // cmbBuscarporg
            // 
            this.cmbBuscarporg.Items.AddRange(new object[] {
            "Categoria",
            "Subcategoria",
            "Descripción"});
            this.cmbBuscarporg.Name = "cmbBuscarporg";
            this.cmbBuscarporg.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCriteriog
            // 
            this.lblCriteriog.Name = "lblCriteriog";
            this.lblCriteriog.Size = new System.Drawing.Size(46, 22);
            this.lblCriteriog.Text = "Criterio";
            // 
            // txtCriteriog
            // 
            this.txtCriteriog.Name = "txtCriteriog";
            this.txtCriteriog.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscarg
            // 
            this.btnBuscarg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscarg.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarg.Image")));
            this.btnBuscarg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarg.Name = "btnBuscarg";
            this.btnBuscarg.Size = new System.Drawing.Size(46, 22);
            this.btnBuscarg.Text = "Buscar";
            this.btnBuscarg.Click += new System.EventHandler(this.btnBuscarg_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSeleccionarg
            // 
            this.btnSeleccionarg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSeleccionarg.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarg.Image")));
            this.btnSeleccionarg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeleccionarg.Name = "btnSeleccionarg";
            this.btnSeleccionarg.Size = new System.Drawing.Size(71, 22);
            this.btnSeleccionarg.Text = "Seleccionar";
            this.btnSeleccionarg.Click += new System.EventHandler(this.btnEditarg_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMostrarTodosg
            // 
            this.btnMostrarTodosg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrarTodosg.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodosg.Image")));
            this.btnMostrarTodosg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarTodosg.Name = "btnMostrarTodosg";
            this.btnMostrarTodosg.Size = new System.Drawing.Size(85, 22);
            this.btnMostrarTodosg.Text = "Mostrar todos";
            this.btnMostrarTodosg.Click += new System.EventHandler(this.frmGastos_Load);
            // 
            // btnNuevog
            // 
            this.btnNuevog.Location = new System.Drawing.Point(700, 31);
            this.btnNuevog.Name = "btnNuevog";
            this.btnNuevog.Size = new System.Drawing.Size(75, 23);
            this.btnNuevog.TabIndex = 3;
            this.btnNuevog.Text = "Nuevo";
            this.btnNuevog.UseVisualStyleBackColor = true;
            this.btnNuevog.Click += new System.EventHandler(this.btnNuevog_Click);
            // 
            // btnEditarg
            // 
            this.btnEditarg.Location = new System.Drawing.Point(700, 60);
            this.btnEditarg.Name = "btnEditarg";
            this.btnEditarg.Size = new System.Drawing.Size(75, 23);
            this.btnEditarg.TabIndex = 4;
            this.btnEditarg.Text = "Editar";
            this.btnEditarg.UseVisualStyleBackColor = true;
            this.btnEditarg.Click += new System.EventHandler(this.btnEditarg_Click);
            // 
            // btnEliminarg
            // 
            this.btnEliminarg.Location = new System.Drawing.Point(700, 89);
            this.btnEliminarg.Name = "btnEliminarg";
            this.btnEliminarg.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarg.TabIndex = 5;
            this.btnEliminarg.Text = "Eliminar";
            this.btnEliminarg.UseVisualStyleBackColor = true;
            this.btnEliminarg.Click += new System.EventHandler(this.btnEliminarg_Click);
            // 
            // btnCerrarg
            // 
            this.btnCerrarg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarg.Location = new System.Drawing.Point(700, 186);
            this.btnCerrarg.Name = "btnCerrarg";
            this.btnCerrarg.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarg.TabIndex = 6;
            this.btnCerrarg.Text = "Cerrar";
            this.btnCerrarg.UseVisualStyleBackColor = true;
            this.btnCerrarg.Click += new System.EventHandler(this.btnCerrarg_Click);
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrarg;
            this.ClientSize = new System.Drawing.Size(787, 231);
            this.Controls.Add(this.btnCerrarg);
            this.Controls.Add(this.btnEliminarg);
            this.Controls.Add(this.btnEditarg);
            this.Controls.Add(this.btnNuevog);
            this.Controls.Add(this.estudiantesBindingNavigator);
            this.Controls.Add(this.gastosDataGridView);
            this.Name = "frmGastos";
            this.Text = "Lista de Gastos";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gastosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClasesVirtuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingNavigator)).EndInit();
            this.estudiantesBindingNavigator.ResumeLayout(false);
            this.estudiantesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.dsClasesVirtuales dsClasesVirtuales;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private System.Windows.Forms.DataGridView gastosDataGridView;
        private System.Windows.Forms.BindingNavigator estudiantesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel lblBuscarporg;
        private System.Windows.Forms.ToolStripComboBox cmbBuscarporg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblCriteriog;
        private System.Windows.Forms.ToolStripTextBox txtCriteriog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBuscarg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSeleccionarg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnMostrarTodosg;
        private System.Windows.Forms.Button btnNuevog;
        private System.Windows.Forms.Button btnEditarg;
        private System.Windows.Forms.Button btnEliminarg;
        private System.Windows.Forms.Button btnCerrarg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}