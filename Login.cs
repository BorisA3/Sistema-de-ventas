using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string nombre;
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_ventasDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_ventasDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.sistema_ventasDataSet.usuario);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult DR;
                if (txtUsuario.Text == this.usuarioTableAdapter.getUser(txtUsuario.Text))
                {
                    if (txtContrasena.Text == this.usuarioTableAdapter.getContrasenaWhereUsuario(txtUsuario.Text, txtContrasena.Text))
                    {
                        DR = MessageBox.Show("Bienvenido: " + this.usuarioTableAdapter.getNombreUsuario(txtUsuario.Text));
                        if (DR == DialogResult.OK)
                        {
                            nombre = txtUsuario.Text;
                            string nvlacceso = this.usuarioTableAdapter.getAccesoUser(txtUsuario.Text);
                            Menu form2 = new Menu(nvlacceso);
                            form2.Show();
                        }
                    }
                    else
                    {
                        DR = MessageBox.Show("La contrasena ingresada no es correcta.");
                    }
                }
                else
                {
                    DR = MessageBox.Show("El usuario ingresado no existe.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
