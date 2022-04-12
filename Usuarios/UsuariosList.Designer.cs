namespace Sistema_Ventas.Usuarios
{
    partial class UsuariosList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidadusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fchnaciusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvlaccesousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoaccesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadousuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenausuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_ventasDataSet = new Sistema_Ventas.sistema_ventasDataSet();
            this.usuarioTableAdapter1 = new Sistema_Ventas.sistema_ventasDataSetTableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_ventasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.userusuarioDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.sexousuarioDataGridViewTextBoxColumn,
            this.identidadusuarioDataGridViewTextBoxColumn,
            this.fchnaciusuarioDataGridViewTextBoxColumn,
            this.direccionusuarioDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.estadocivilusuarioDataGridViewTextBoxColumn,
            this.nvlaccesousuarioDataGridViewTextBoxColumn,
            this.ultimoaccesoDataGridViewTextBoxColumn,
            this.estadousuarioDataGridViewTextBoxColumn,
            this.contrasenausuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 422);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // userusuarioDataGridViewTextBoxColumn
            // 
            this.userusuarioDataGridViewTextBoxColumn.DataPropertyName = "user_usuario";
            this.userusuarioDataGridViewTextBoxColumn.HeaderText = "user_usuario";
            this.userusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userusuarioDataGridViewTextBoxColumn.Name = "userusuarioDataGridViewTextBoxColumn";
            this.userusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            this.nombreusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexousuarioDataGridViewTextBoxColumn
            // 
            this.sexousuarioDataGridViewTextBoxColumn.DataPropertyName = "sexo_usuario";
            this.sexousuarioDataGridViewTextBoxColumn.HeaderText = "sexo_usuario";
            this.sexousuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexousuarioDataGridViewTextBoxColumn.Name = "sexousuarioDataGridViewTextBoxColumn";
            this.sexousuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // identidadusuarioDataGridViewTextBoxColumn
            // 
            this.identidadusuarioDataGridViewTextBoxColumn.DataPropertyName = "identidad_usuario";
            this.identidadusuarioDataGridViewTextBoxColumn.HeaderText = "identidad_usuario";
            this.identidadusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identidadusuarioDataGridViewTextBoxColumn.Name = "identidadusuarioDataGridViewTextBoxColumn";
            this.identidadusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fchnaciusuarioDataGridViewTextBoxColumn
            // 
            this.fchnaciusuarioDataGridViewTextBoxColumn.DataPropertyName = "fchnaci_usuario";
            this.fchnaciusuarioDataGridViewTextBoxColumn.HeaderText = "fchnaci_usuario";
            this.fchnaciusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fchnaciusuarioDataGridViewTextBoxColumn.Name = "fchnaciusuarioDataGridViewTextBoxColumn";
            this.fchnaciusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionusuarioDataGridViewTextBoxColumn
            // 
            this.direccionusuarioDataGridViewTextBoxColumn.DataPropertyName = "direccion_usuario";
            this.direccionusuarioDataGridViewTextBoxColumn.HeaderText = "direccion_usuario";
            this.direccionusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionusuarioDataGridViewTextBoxColumn.Name = "direccionusuarioDataGridViewTextBoxColumn";
            this.direccionusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadocivilusuarioDataGridViewTextBoxColumn
            // 
            this.estadocivilusuarioDataGridViewTextBoxColumn.DataPropertyName = "estadocivil_usuario";
            this.estadocivilusuarioDataGridViewTextBoxColumn.HeaderText = "estadocivil_usuario";
            this.estadocivilusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadocivilusuarioDataGridViewTextBoxColumn.Name = "estadocivilusuarioDataGridViewTextBoxColumn";
            this.estadocivilusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nvlaccesousuarioDataGridViewTextBoxColumn
            // 
            this.nvlaccesousuarioDataGridViewTextBoxColumn.DataPropertyName = "nvlacceso_usuario";
            this.nvlaccesousuarioDataGridViewTextBoxColumn.HeaderText = "nvlacceso_usuario";
            this.nvlaccesousuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nvlaccesousuarioDataGridViewTextBoxColumn.Name = "nvlaccesousuarioDataGridViewTextBoxColumn";
            this.nvlaccesousuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // ultimoaccesoDataGridViewTextBoxColumn
            // 
            this.ultimoaccesoDataGridViewTextBoxColumn.DataPropertyName = "ultimo_acceso";
            this.ultimoaccesoDataGridViewTextBoxColumn.HeaderText = "ultimo_acceso";
            this.ultimoaccesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ultimoaccesoDataGridViewTextBoxColumn.Name = "ultimoaccesoDataGridViewTextBoxColumn";
            this.ultimoaccesoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadousuarioDataGridViewTextBoxColumn
            // 
            this.estadousuarioDataGridViewTextBoxColumn.DataPropertyName = "estado_usuario";
            this.estadousuarioDataGridViewTextBoxColumn.HeaderText = "estado_usuario";
            this.estadousuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadousuarioDataGridViewTextBoxColumn.Name = "estadousuarioDataGridViewTextBoxColumn";
            this.estadousuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // contrasenausuarioDataGridViewTextBoxColumn
            // 
            this.contrasenausuarioDataGridViewTextBoxColumn.DataPropertyName = "contrasena_usuario";
            this.contrasenausuarioDataGridViewTextBoxColumn.HeaderText = "contrasena_usuario";
            this.contrasenausuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contrasenausuarioDataGridViewTextBoxColumn.Name = "contrasenausuarioDataGridViewTextBoxColumn";
            this.contrasenausuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.sistema_ventasDataSet;
            // 
            // sistema_ventasDataSet
            // 
            this.sistema_ventasDataSet.DataSetName = "sistema_ventasDataSet";
            this.sistema_ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // UsuariosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UsuariosList";
            this.Text = "UsuariosList";
            this.Load += new System.EventHandler(this.UsuariosList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_ventasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_ventasDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fchnaciusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivilusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvlaccesousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoaccesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadousuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenausuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private sistema_ventasDataSet sistema_ventasDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}