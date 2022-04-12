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
    public partial class EditUsuarios : Form
    {
        public int IdUsuario;
        public EditUsuarios(int id)
        {
            InitializeComponent();
            IdUsuario = id;
            txtUsuario.Text = this.usuarioTableAdapter1.getUsuario(id).ToString();
            txtNombre.Text = this.usuarioTableAdapter1.getNombre(id);
            txtIdentidad.Text = this.usuarioTableAdapter1.getIdentidad(id).ToString();
            txtEstadoUsuario.SelectedItem = this.usuarioTableAdapter1.getEstadoUsuario(id).ToString();
            txtDireccion.Text = this.usuarioTableAdapter1.getDireccion(id).ToString();
            txtContrasena.Text = this.usuarioTableAdapter1.getContrasena(id).ToString();
            dtFchaNaci.Value = (DateTime)this.usuarioTableAdapter1.getFchaNacimiento(id);
            txtEstadoCivil.SelectedItem = this.usuarioTableAdapter1.getEstadoCivil(id);
            txtSexo.SelectedItem = this.usuarioTableAdapter1.getSexo(id).ToString();
            txtNvlAcceso.SelectedItem = this.usuarioTableAdapter1.getNvlAcceso(id).ToString();
            txtTelefono.Text = this.usuarioTableAdapter1.getTelefono(id).ToString();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

                this.usuarioTableAdapter1.UpdateUsuario(txtUsuario.Text, txtNombre.Text, sexo, Int64.Parse(txtIdentidad.Text),
                    dtFchaNaci.Value, txtDireccion.Text, Int32.Parse(txtTelefono.Text), estcivil, nvlAcceso, estadosuario, txtContrasena.Text, IdUsuario);
                MessageBox.Show("Usuario actualizado exitosamente!");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
