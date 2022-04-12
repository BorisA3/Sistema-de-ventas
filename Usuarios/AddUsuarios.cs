using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas.Usuarios
{
    public partial class AddUsuarios : Form
    {
        public AddUsuarios()
        {
            InitializeComponent();
            txtSexo.SelectedItem = "F";
            txtEstadoCivil.SelectedItem = "Soltero";
            txtNvlAcceso.SelectedItem = "Vendedor";
            txtEstadoUsuario.SelectedItem = "Activo";
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "" || txtEstadoCivil.Text == "" || txtNombre.Text == "" || txtIdentidad.Text == "" || txtNvlAcceso.Text == ""
                || txtSexo.Text == "" || txtTelefono.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar.");
            }
            else if (this.usuarioTableAdapter1.getNombreUsuario(txtUsuario.Text) != null)
            {
                MessageBox.Show("El usuario ya existe");
            }
            else
            {
                string sexo = "M";
                if (txtSexo.Text == "M")
                {
                    sexo = "M";
                }
                else
                {
                    sexo = "F";
                }

                string estcivil = "Soltero";
                if (txtEstadoCivil.Text == "Divorciado")
                {
                    estcivil = "Divorciado";
                }
                else if (txtEstadoCivil.Text == "Casado")
                {
                    estcivil = "Casado";
                }
                else if (txtEstadoCivil.Text == "Viudo")
                {
                    estcivil = "Viudo";
                }
                else
                {
                    estcivil = "Soltero";
                }

                string nvlAcceso = "Vendedor";
                if (txtNvlAcceso.Text == "Administrador")
                {
                    nvlAcceso = "Administrador";
                }
                else if (txtEstadoCivil.Text == "Bodeguero")
                {
                    nvlAcceso = "Bodeguero";
                }
                else
                {
                    nvlAcceso = "Vendedor";
                }

                string estadosuario = "Activo";
                if (txtEstadoUsuario.Text == "Inactivo")
                {
                    estadosuario = "Inactivo";
                }
                else
                {
                    estadosuario = "Activo";
                }

                this.usuarioTableAdapter1.Insert(txtUsuario.Text, txtNombre.Text, sexo, UInt64.Parse(txtIdentidad.Text),
                    dtFchaNaci.Value, txtDireccion.Text, Int32.Parse(txtTelefono.Text), estcivil, nvlAcceso, null, estadosuario, txtContrasena.Text);
                MessageBox.Show("Usuario ingresado exitosamente!");
                this.Close();
            }
        }
    }
}
