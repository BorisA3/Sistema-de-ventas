using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas.Productos
{
    public partial class AddMarca : Form
    {
        public AddMarca()
        {
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text != "")
            {
                this.marcaTableAdapter1.Insert(txtMarca.Text);
                MessageBox.Show("Marca ingresada exitosamente!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar.");
            }
        }
    }
}
