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
    public partial class ClienteList : Form
    {
        public ClienteList()
        {
            InitializeComponent();
        }

        private void ClienteList_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter1.Fill(this.sistema_ventasDataSet.cliente);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCliente addCliente = new AddCliente();
            addCliente.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            EditCliente editCliente = new EditCliente(id);
            editCliente.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult DR;
            DR = MessageBox.Show("Seguro que desea eliminar este registro?","Eliminar Cliente", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.clienteTableAdapter1.DeleteCliente(id);
                MessageBox.Show("Cliente eliminado exitosamente");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.clienteTableAdapter1.GetData();
        }
    }
}
