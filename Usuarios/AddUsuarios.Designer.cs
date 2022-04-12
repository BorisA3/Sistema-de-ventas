namespace Sistema_Ventas.Usuarios
{
    partial class AddUsuarios
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
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.dtFchaNaci = new System.Windows.Forms.DateTimePicker();
            this.txtNvlAcceso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.usuarioTableAdapter1 = new Sistema_Ventas.sistema_ventasDataSetTableAdapters.usuarioTableAdapter();
            this.txtEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSexo
            // 
            this.txtSexo.DisplayMember = "categoria";
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtSexo.Location = new System.Drawing.Point(254, 181);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 24);
            this.txtSexo.TabIndex = 55;
            this.txtSexo.ValueMember = "categoria";
            // 
            // dtFchaNaci
            // 
            this.dtFchaNaci.Location = new System.Drawing.Point(254, 283);
            this.dtFchaNaci.Name = "dtFchaNaci";
            this.dtFchaNaci.Size = new System.Drawing.Size(100, 22);
            this.dtFchaNaci.TabIndex = 53;
            // 
            // txtNvlAcceso
            // 
            this.txtNvlAcceso.FormattingEnabled = true;
            this.txtNvlAcceso.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Bodeguero"});
            this.txtNvlAcceso.Location = new System.Drawing.Point(581, 225);
            this.txtNvlAcceso.Name = "txtNvlAcceso";
            this.txtNvlAcceso.Size = new System.Drawing.Size(100, 24);
            this.txtNvlAcceso.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Nivel de Acceso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado Civil:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(581, 138);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(581, 98);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Direccion:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(426, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Identidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(254, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(254, 98);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Usuario:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.FormattingEnabled = true;
            this.txtEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Soltero",
            "Viudo",
            "Divorciado"});
            this.txtEstadoCivil.Location = new System.Drawing.Point(581, 184);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(100, 24);
            this.txtEstadoCivil.TabIndex = 57;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Location = new System.Drawing.Point(254, 229);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(100, 22);
            this.txtIdentidad.TabIndex = 58;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // txtEstadoUsuario
            // 
            this.txtEstadoUsuario.FormattingEnabled = true;
            this.txtEstadoUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstadoUsuario.Location = new System.Drawing.Point(581, 276);
            this.txtEstadoUsuario.Name = "txtEstadoUsuario";
            this.txtEstadoUsuario.Size = new System.Drawing.Size(100, 24);
            this.txtEstadoUsuario.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Estado del usuario:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(254, 328);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 22);
            this.txtContrasena.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Contraseña:";
            // 
            // AddUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEstadoUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.dtFchaNaci);
            this.Controls.Add(this.txtNvlAcceso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddUsuarios";
            this.Text = "AddUsuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.DateTimePicker dtFchaNaci;
        private System.Windows.Forms.ComboBox txtNvlAcceso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.ComboBox txtEstadoCivil;
        private System.Windows.Forms.TextBox txtIdentidad;
        private sistema_ventasDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.ComboBox txtEstadoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label11;
    }
}