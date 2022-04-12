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
    public partial class AddProducto : Form
    {
        public AddProducto()
        {
            InitializeComponent();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistema_ventasDataSet.categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.sistema_ventasDataSet.categoria);
            // TODO: This line of code loads data into the 'sistema_ventasDataSet.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.sistema_ventasDataSet.marca);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "" || txtExento.Text == "" || txtMarca.Text == ""
                || txtPrecioCompra.Text == "" || txtPrecioVenta.Text == "" || txtStock.Text == "")
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
                this.productoTableAdapter1.Insert(txtNombre.Text,txtMarca.Text, txtDescripcion.Text, txtCategoria.Text, 
                   Int32.Parse(txtStock.Value.ToString()), Decimal.Parse(txtPrecioCompra.Text), Decimal.Parse(txtPrecioVenta.Text), 
                   dtFechaVenci.Value, exento);
                MessageBox.Show("Usuario ingresado exitosamente!");
                this.Close();
            }
        }

        private void btnAddMarca_Click(object sender, EventArgs e)
        {
            AddMarca addMarca = new AddMarca();
            addMarca.Show();
        }
    }
}
