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
    public partial class ProductosList : Form
    {
        public ProductosList()
        {
            InitializeComponent();
        }

        private void ProductosList_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter1.Fill(this.sistema_ventasDataSet.producto);
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProducto addProducto = new AddProducto();
            addProducto.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            EditProducto editProducto = new EditProducto(id);
            editProducto.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DialogResult DR;
            DR = MessageBox.Show("Seguro que desea eliminar este registro?", "Eliminar Producto", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                this.productoTableAdapter1.DeleteProducto(id);
                MessageBox.Show("Producto eliminado exitosamente.");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.productoTableAdapter1.GetData();
        }
    }
}
