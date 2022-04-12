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
    public partial class EditCliente : Form
    {
        public int IdCliente;
        public EditCliente(int id)
        {
            InitializeComponent();
            IdCliente = id;
            txtRTN.Text = this.clienteTableAdapter1.getRTN(id).ToString();
            txtNombre.Text = this.clienteTableAdapter1.getNombreCliente(id);
            txtDireccion.Text = this.clienteTableAdapter1.getDireccion(id);
            txtTelefono.Text = this.clienteTableAdapter1.getTelefono(id).ToString();
            if (this.clienteTableAdapter1.getEstado(id).ToString() == "1")
            {
                txtEstado.Text = "Activo";
            }
            else
            {
                txtEstado.Text = "Inactivo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                this.clienteTableAdapter1.UpdateCliente(Int64.Parse(txtRTN.Text), txtNombre.Text, txtDireccion.Text, Int64.Parse(txtTelefono.Text), estado, IdCliente);
                MessageBox.Show("Cliente actualizado exitosamente!");
                this.Close();
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
