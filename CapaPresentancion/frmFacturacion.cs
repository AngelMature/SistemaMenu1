using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentancion
{
    public partial class frmFacturacion : Form
    {
        private Factura facturaActual;

        public frmFacturacion()
        {
            InitializeComponent();
            ConfigurarControles();
            CargarDatosIniciales();
        }

        private void ConfigurarControles()
        {
            cmbOrdenesPendientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCajeros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;

            txtSubtotal.ReadOnly = true;
            txtImpuesto.ReadOnly = true;
            txtTotal.ReadOnly = true;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Subtotal", "Subtotal");

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void CargarDatosIniciales()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta Crédito");
            cmbMetodoPago.Items.Add("Tarjeta Débito");
            cmbMetodoPago.Items.Add("Transferencia");
            cmbMetodoPago.SelectedIndex = 0;

            cmbCajeros.Items.Clear();
            cmbCajeros.Items.Add("Cajero 1");
            cmbCajeros.Items.Add("Cajero 2");
            cmbCajeros.SelectedIndex = 0;

            cmbOrdenesPendientes.Items.Clear();
            cmbOrdenesPendientes.Items.Add("Orden #001 - Mesa 1 - $25.50");
            cmbOrdenesPendientes.Items.Add("Orden #002 - Mesa 3 - $18.75");
            cmbOrdenesPendientes.Items.Add("Orden #003 - Mesa 5 - $32.25");
            cmbOrdenesPendientes.SelectedIndex = 0;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (cmbOrdenesPendientes.SelectedItem == null) return;

            facturaActual = new Factura();
            facturaActual.MetodoPago = cmbMetodoPago.SelectedItem.ToString();

            string ordenSeleccionada = cmbOrdenesPendientes.SelectedItem.ToString();
            decimal subtotal = ObtenerSubtotalOrden(ordenSeleccionada);
            facturaActual.CalcularTotales(subtotal);

            txtSubtotal.Text = facturaActual.Subtotal.ToString("C");
            txtImpuesto.Text = facturaActual.Impuesto.ToString("C");
            txtTotal.Text = facturaActual.Total.ToString("C");

            dataGridView1.Rows.Clear();

            if (ordenSeleccionada.Contains("Mesa 1"))
            {
                dataGridView1.Rows.Add("Pizza Margarita", 1, 12.99m, 12.99m);
                dataGridView1.Rows.Add("Coca Cola", 2, 2.50m, 5.00m);
                dataGridView1.Rows.Add("Ensalada César", 1, 6.99m, 6.99m);
            }
            else if (ordenSeleccionada.Contains("Mesa 3"))
            {
                dataGridView1.Rows.Add("Hamburguesa Clásica", 2, 8.99m, 17.98m);
                dataGridView1.Rows.Add("Agua Mineral", 1, 1.50m, 1.50m);
            }
            else if (ordenSeleccionada.Contains("Mesa 5"))
            {
                dataGridView1.Rows.Add("Pasta Alfredo", 2, 10.99m, 21.98m);
                dataGridView1.Rows.Add("Jugo de Naranja", 1, 3.50m, 3.50m);
                dataGridView1.Rows.Add("Café Americano", 1, 2.00m, 2.00m);
            }
        }

        private decimal ObtenerSubtotalOrden(string orden)
        {
            if (orden.Contains("$25.50")) return 25.50m;
            if (orden.Contains("$18.75")) return 18.75m;
            if (orden.Contains("$32.25")) return 32.25m;
            return 0m;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (facturaActual == null)
            {
                MessageBox.Show("Debe generar la factura primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contenido = $"=== FACTURA ===\n" +
                               $"Método de Pago: {facturaActual.MetodoPago}\n" +
                               $"Subtotal: {facturaActual.Subtotal:C}\n" +
                               $"Impuesto: {facturaActual.Impuesto:C}\n" +
                               $"TOTAL: {facturaActual.Total:C}";

            MessageBox.Show(contenido, "Imprimir Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}