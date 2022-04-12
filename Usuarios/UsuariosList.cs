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
    public partial class UsuariosList : Form
    {
        public UsuariosList()
        {
            InitializeComponent();
        }

        private void UsuariosList_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter1.Fill(this.sistema_ventasDataSet.usuario);
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.usuarioTableAdapter1.GetData();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsuarios addusuarios = new AddUsuarios();
            addusuarios.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            EditUsuarios editUsuarios = new EditUsuarios(id);
            editUsuarios.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult DR;
            DR = MessageBox.Show("Seguro que desea eliminar este registro?", "Eliminar Usuario", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.usuarioTableAdapter1.DeleteUsuario(id);
                MessageBox.Show("Usuario eliminado exitosamente.");
            }
        }
    }
}
