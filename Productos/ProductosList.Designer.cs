namespace Sistema_Ventas.Productos
{
    partial class ProductosList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompraproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fchavencimientoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exentoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_ventasDataSet = new Sistema_Ventas.sistema_ventasDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoTableAdapter1 = new Sistema_Ventas.sistema_ventasDataSetTableAdapters.productoTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_ventasDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproductoDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.marcaproductoDataGridViewTextBoxColumn,
            this.descripcionproductoDataGridViewTextBoxColumn,
            this.categoriaproductoDataGridViewTextBoxColumn,
            this.stockproductoDataGridViewTextBoxColumn,
            this.preciocompraproductoDataGridViewTextBoxColumn,
            this.precioventaproductoDataGridViewTextBoxColumn,
            this.fchavencimientoproductoDataGridViewTextBoxColumn,
            this.exentoproductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 390);
            this.dataGridView1.TabIndex = 3;
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            this.codigoproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            this.nombreproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaproductoDataGridViewTextBoxColumn
            // 
            this.marcaproductoDataGridViewTextBoxColumn.DataPropertyName = "marca_producto";
            this.marcaproductoDataGridViewTextBoxColumn.HeaderText = "marca_producto";
            this.marcaproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaproductoDataGridViewTextBoxColumn.Name = "marcaproductoDataGridViewTextBoxColumn";
            this.marcaproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionproductoDataGridViewTextBoxColumn
            // 
            this.descripcionproductoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_producto";
            this.descripcionproductoDataGridViewTextBoxColumn.HeaderText = "descripcion_producto";
            this.descripcionproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionproductoDataGridViewTextBoxColumn.Name = "descripcionproductoDataGridViewTextBoxColumn";
            this.descripcionproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriaproductoDataGridViewTextBoxColumn
            // 
            this.categoriaproductoDataGridViewTextBoxColumn.DataPropertyName = "categoria_producto";
            this.categoriaproductoDataGridViewTextBoxColumn.HeaderText = "categoria_producto";
            this.categoriaproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaproductoDataGridViewTextBoxColumn.Name = "categoriaproductoDataGridViewTextBoxColumn";
            this.categoriaproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockproductoDataGridViewTextBoxColumn
            // 
            this.stockproductoDataGridViewTextBoxColumn.DataPropertyName = "stock_producto";
            this.stockproductoDataGridViewTextBoxColumn.HeaderText = "stock_producto";
            this.stockproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockproductoDataGridViewTextBoxColumn.Name = "stockproductoDataGridViewTextBoxColumn";
            this.stockproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // preciocompraproductoDataGridViewTextBoxColumn
            // 
            this.preciocompraproductoDataGridViewTextBoxColumn.DataPropertyName = "preciocompra_producto";
            this.preciocompraproductoDataGridViewTextBoxColumn.HeaderText = "preciocompra_producto";
            this.preciocompraproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preciocompraproductoDataGridViewTextBoxColumn.Name = "preciocompraproductoDataGridViewTextBoxColumn";
            this.preciocompraproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioventaproductoDataGridViewTextBoxColumn
            // 
            this.precioventaproductoDataGridViewTextBoxColumn.DataPropertyName = "precioventa_producto";
            this.precioventaproductoDataGridViewTextBoxColumn.HeaderText = "precioventa_producto";
            this.precioventaproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioventaproductoDataGridViewTextBoxColumn.Name = "precioventaproductoDataGridViewTextBoxColumn";
            this.precioventaproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fchavencimientoproductoDataGridViewTextBoxColumn
            // 
            this.fchavencimientoproductoDataGridViewTextBoxColumn.DataPropertyName = "fchavencimiento_producto";
            this.fchavencimientoproductoDataGridViewTextBoxColumn.HeaderText = "fchavencimiento_producto";
            this.fchavencimientoproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fchavencimientoproductoDataGridViewTextBoxColumn.Name = "fchavencimientoproductoDataGridViewTextBoxColumn";
            this.fchavencimientoproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // exentoproductoDataGridViewTextBoxColumn
            // 
            this.exentoproductoDataGridViewTextBoxColumn.DataPropertyName = "exento_producto";
            this.exentoproductoDataGridViewTextBoxColumn.HeaderText = "exento_producto";
            this.exentoproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exentoproductoDataGridViewTextBoxColumn.Name = "exentoproductoDataGridViewTextBoxColumn";
            this.exentoproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.sistema_ventasDataSet;
            // 
            // sistema_ventasDataSet
            // 
            this.sistema_ventasDataSet.DataSetName = "sistema_ventasDataSet";
            this.sistema_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 420);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // ProductosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "ProductosList";
            this.Text = "ProductosList";
            this.Load += new System.EventHandler(this.ProductosList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_ventasDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private sistema_ventasDataSetTableAdapters.productoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocompraproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fchavencimientoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exentoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private sistema_ventasDataSet sistema_ventasDataSet;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}