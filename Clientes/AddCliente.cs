using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas.Clientes
{
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
            txtEstado.SelectedItem = "Activo";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string RTN = this.clienteTableAdapter1.searchRTN(Int64.Parse(txtRTN.Text)).ToString();
            if (txtDireccion.Text == null || txtEstado.Text == null || txtNombre.Text == null || txtRTN.Text == null || txtTelefono.Text == null)
            {
                MessageBox.Show("Faltan campos por llenar.");
            }
            else if (RTN != "")
            {
                MessageBox.Show("Ya existe un usuario con el mismo RTN.");
            }
            else
            { 
            byte estado = 1;
            if (txtEstado.Text == "Inactivo")
            {
                estado = 0;
            }
            else
            {
                estado = 1;
            }
            this.clienteTableAdapter1.Insert(UInt64.Parse(txtRTN.Text), txtNombre.Text, txtDireccion.Text, UInt64.Parse(txtTelefono.Text), estado);
            MessageBox.Show("Cliente ingresado exitosamente!");
                this.Close();
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
