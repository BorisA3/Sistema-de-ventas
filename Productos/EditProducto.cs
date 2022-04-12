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
    public partial class EditProducto : Form
    {
        public int IdProducto;
        public EditProducto(int id)
        {
            InitializeComponent();
            IdProducto = id;
            txtMarca.SelectedItem = this.productoTableAdapter1.getMarca(id).ToString();
            txtNombre.Text = this.productoTableAdapter1.getNombre(id);
            txtDescripcion.Text = this.productoTableAdapter1.getDescripcion(id);
            txtCategoria.SelectedItem = this.productoTableAdapter1.getCategoria(id).ToString();
            txtPrecioCompra.Text = this.productoTableAdapter1.getPrecioCompra(id).ToString();
            txtPrecioVenta.Text = this.productoTableAdapter1.getPrecioVenta(id).ToString();
            dtFechaVenci.Value = (DateTime) this.productoTableAdapter1.getFchaVenci(id);
            txtExento.Text = this.productoTableAdapter1.getExento(id);
            txtStock.Text = this.productoTableAdapter1.getStock(id).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == null || txtDescripcion.Text == null || txtNombre.Text == null || txtExento.Text == null || txtMarca.Text == null
                || txtPrecioCompra.Text == null || txtPrecioVenta.Text == null || txtStock.Text == null)
            {
                MessageBox.Show("Faltan campos por llenar.");
            }
            else
            {
                string exento = "No";
                if (txtExento.Text == "Si")
                {
                    exento = "Si";
                }
                else
                {
                    exento = "No";
                }
                this.productoTableAdapter1.UpdateProducto(txtNombre.Text, txtMarca.Text, txtDescripcion.Text, txtCategoria.Text,
                   Int32.Parse(txtStock.Value.ToString()), Decimal.Parse(txtPrecioCompra.Text), Decimal.Parse(txtPrecioVenta.Text),
                   dtFechaVenci.Value, exento, IdProducto);
                MessageBox.Show("Producto actualizado exitosamente!");
                this.Close();
            }
        }

        private void EditProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_ventasDataSet.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.sistema_ventasDataSet.categoria);
            // TODO: This line of code loads data into the 'sistema_ventasDataSet.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.sistema_ventasDataSet.marca);
            txtMarca.SelectedValue = this.productoTableAdapter1.getMarca(IdProducto).ToString();
            txtCategoria.SelectedValue = this.productoTableAdapter1.getCategoria(IdProducto).ToString();
        }
    }
}
