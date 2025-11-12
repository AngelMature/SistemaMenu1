using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentancion
{
    public partial class frmOrdenes : Form
    {
        private Orden ordenActual;

        public frmOrdenes()
        {
            InitializeComponent();
            CargarProductos();
            ordenActual = new Orden();
        }

        private void CargarProductos()
        {
            cmbProductos.Items.Clear();
            cmbProductos.Items.Add("Pizza Margarita - 12.99");
            cmbProductos.Items.Add("Hamburguesa Clásica - 8.99");
            cmbProductos.Items.Add("Ensalada César - 6.99");
            cmbProductos.Items.Add("Pasta Alfredo - 10.99");
            cmbProductos.Items.Add("Coca Cola - 2.50");
            cmbProductos.Items.Add("Agua Mineral - 1.50");
            cmbProductos.Items.Add("Jugo de Naranja - 3.50");
            cmbProductos.Items.Add("Café Americano - 2.00");
            if (cmbProductos.Items.Count > 0)
                cmbProductos.SelectedIndex = 0;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null) return;

            string producto = cmbProductos.SelectedItem.ToString();
            int cantidad = (int)numericUpDown1.Value;
            decimal precio = Convert.ToDecimal(producto.Split('-')[1].Trim());

            DetalleOrden detalle = new DetalleOrden
            {
                Producto = producto.Split('-')[0].Trim(),
                Cantidad = cantidad,
                PrecioUnitario = precio,
                Subtotal = precio * cantidad
            };

            ordenActual.AgregarDetalle(detalle);
            dataGridView1.Rows.Add(detalle.Producto, detalle.Cantidad, detalle.PrecioUnitario, detalle.Subtotal);
            lblTotal.Text = $"Total: {ordenActual.Total:C}";
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            if (ordenActual.Detalles.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto");
                return;
            }

            MessageBox.Show($"Orden creada con {ordenActual.Detalles.Count} productos. Total: {ordenActual.Total:C}");
            ordenActual = new Orden();
            dataGridView1.Rows.Clear();
            lblTotal.Text = "Total: $0.00";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ordenActual = new Orden();
            lblTotal.Text = "Total: $0.00";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}