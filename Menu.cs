using Sistema_Ventas.Clientes;
using Sistema_Ventas.Productos;
using Sistema_Ventas.Usuarios;
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
    public partial class Menu : Form
    {
        public string aceso;
        public Menu(string acceso)
        {
            InitializeComponent();
            aceso = acceso;
            if (acceso == "Vendedor")
            {
                productosToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
            else if (acceso == "Bodeguero")
            {
                clientesToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosList productosList = new ProductosList();
            //this.Hide();
            productosList.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosList usuariosList = new UsuariosList();
            //this.Hide();
            usuariosList.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteList clienteList = new ClienteList();
            //this.Hide();
            clienteList.Show();
        }
    }
}
