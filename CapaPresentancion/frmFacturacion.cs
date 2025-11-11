using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentancion
{
    public partial class frmFacturacion : Form
    {
        private EmpleadoDB empleadoDB = new EmpleadoDB();
        private Factura facturaActual;
        private Label lblSeleccionOrden;
        private Label lblSeleccionCajero;
        private Label lblSeleccionMetodo;
        private Label lblTextoSubtotal;
        private Label lblTextoImpuesto;
        private Label lblTextoTotal;

        public frmFacturacion()
        {
            InitializeComponent();
            CrearLabelsDescriptivos();
            ConfigurarControles();
            CargarDatosIniciales();
        }

        private void CrearLabelsDescriptivos()
        {
            // Crear Labels descriptivos
            lblSeleccionOrden = new Label();
            lblSeleccionOrden.Text = "Seleccionar Orden:";
            lblSeleccionOrden.Location = new Point(34, 250);
            lblSeleccionOrden.Size = new Size(150, 20);
            this.Controls.Add(lblSeleccionOrden);

            lblSeleccionCajero = new Label();
            lblSeleccionCajero.Text = "Seleccionar Cajero:";
            lblSeleccionCajero.Location = new Point(34, 300);
            lblSeleccionCajero.Size = new Size(150, 20);
            this.Controls.Add(lblSeleccionCajero);

            lblSeleccionMetodo = new Label();
            lblSeleccionMetodo.Text = "Método de Pago:";
            lblSeleccionMetodo.Location = new Point(34, 334);
            lblSeleccionMetodo.Size = new Size(150, 20);
            this.Controls.Add(lblSeleccionMetodo);

            lblTextoSubtotal = new Label();
            lblTextoSubtotal.Text = "Subtotal:";
            lblTextoSubtotal.Location = new Point(251, 238);
            lblTextoSubtotal.Size = new Size(80, 20);
            this.Controls.Add(lblTextoSubtotal);

            lblTextoImpuesto = new Label();
            lblTextoImpuesto.Text = "Impuesto (15%):";
            lblTextoImpuesto.Location = new Point(251, 288);
            lblTextoImpuesto.Size = new Size(120, 20);
            this.Controls.Add(lblTextoImpuesto);

            lblTextoTotal = new Label();
            lblTextoTotal.Text = "Total:";
            lblTextoTotal.Location = new Point(251, 334);
            lblTextoTotal.Size = new Size(80, 20);
            this.Controls.Add(lblTextoTotal);
        }

        private void ConfigurarControles()
        {
            // Configurar ComboBox
            cmbOrdenesPendientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCajeros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;

            // Configurar TextBox como solo lectura
            txtSubtotal.ReadOnly = true;
            txtImpuesto.ReadOnly = true;
            txtTotal.ReadOnly = true;

            // Establecer valores iniciales
            txtSubtotal.Text = "0.00";
            txtImpuesto.Text = "0.00";
            txtTotal.Text = "0.00";
        }

        private void CargarDatosIniciales()
        {
            try
            {
                // Cargar cajeros
                DataTable dtCajeros = empleadoDB.ObtenerCajeros();
                cmbCajeros.DisplayMember = "Nombre";
                cmbCajeros.ValueMember = "Id";
                cmbCajeros.DataSource = dtCajeros;

                // Simular órdenes pendientes
                CargarOrdenesPendientesSimuladas();

                lblMensaje.Text = "Sistema listo para facturación";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarOrdenesPendientesSimuladas()
        {
            // Simulamos algunas órdenes
            cmbOrdenesPendientes.Items.Clear();
            cmbOrdenesPendientes.Items.Add("Orden #001 - Mesa 1 - $25.50");
            cmbOrdenesPendientes.Items.Add("Orden #002 - Mesa 3 - $18.75");
            cmbOrdenesPendientes.Items.Add("Orden #003 - Mesa 5 - $32.25");
            cmbOrdenesPendientes.Items.Add("Orden #004 - Mesa 2 - $15.80");

            if (cmbOrdenesPendientes.Items.Count > 0)
                cmbOrdenesPendientes.SelectedIndex = 0;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (cmbOrdenesPendientes.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una orden pendiente", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbCajeros.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un cajero", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un método de pago", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener datos seleccionados
                string ordenSeleccionada = cmbOrdenesPendientes.SelectedItem.ToString();
                int idCajero = (int)cmbCajeros.SelectedValue;
                string nombreCajero = cmbCajeros.Text;
                string metodoPago = cmbMetodoPago.SelectedItem.ToString();

                // Crear factura
                facturaActual = new Factura();
                facturaActual.IdCajero = idCajero;
                facturaActual.MetodoPago = metodoPago;

                // Calcular totales
                decimal subtotal = CalcularSubtotalSimulado(ordenSeleccionada);
                facturaActual.CalcularTotales(subtotal);

                // Mostrar resultados
                MostrarTotalesFactura();
                MostrarDetallesFacturaSimulados(ordenSeleccionada);

                string mensaje = $"Factura generada exitosamente:\n" +
                               $"Orden: {ordenSeleccionada}\n" +
                               $"Cajero: {nombreCajero}\n" +
                               $"Método: {metodoPago}\n" +
                               $"Total: {facturaActual.Total:C}";

                MessageBox.Show(mensaje, "Factura Generada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblMensaje.Text = "Factura generada - Lista para imprimir";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar factura: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (facturaActual == null)
            {
                MessageBox.Show("Primero debe generar una factura", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simular impresión
            string contenidoFactura = $"=== FACTURA DEL RESTAURANTE ===\n" +
                                    $"Número: {facturaActual.Id}\n" +
                                    $"Fecha: {DateTime.Now}\n" +
                                    $"Cajero: {cmbCajeros.Text}\n" +
                                    $"Método: {facturaActual.MetodoPago}\n" +
                                    $"Subtotal: {facturaActual.Subtotal:C}\n" +
                                    $"Impuesto: {facturaActual.Impuesto:C}\n" +
                                    $"TOTAL: {facturaActual.Total:C}\n" +
                                    $"===============================";

            MessageBox.Show(contenidoFactura, "Factura para Imprimir",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblMensaje.Text = "Factura impresa (simulación)";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal CalcularSubtotalSimulado(string orden)
        {
            // Simular cálculo basado en la orden seleccionada
            if (orden.Contains("$25.50")) return 25.50m;
            if (orden.Contains("$18.75")) return 18.75m;
            if (orden.Contains("$32.25")) return 32.25m;
            if (orden.Contains("$15.80")) return 15.80m;
            return 0m;
        }

        private void MostrarTotalesFactura()
        {
            txtSubtotal.Text = facturaActual.Subtotal.ToString("C");
            txtImpuesto.Text = facturaActual.Impuesto.ToString("C");
            txtTotal.Text = facturaActual.Total.ToString("C");
        }

        private void MostrarDetallesFacturaSimulados(string orden)
        {
            dataGridView1.Rows.Clear();

            // Simular detalles basados en la orden seleccionada
            if (orden.Contains("Mesa 1"))
            {
                dataGridView1.Rows.Add("Pizza Margarita", 1, 12.99, 12.99);
                dataGridView1.Rows.Add("Coca Cola", 2, 2.50, 5.00);
                dataGridView1.Rows.Add("Ensalada César", 1, 6.99, 6.99);
            }
            else if (orden.Contains("Mesa 3"))
            {
                dataGridView1.Rows.Add("Hamburguesa Clásica", 2, 8.99, 17.98);
                dataGridView1.Rows.Add("Agua Mineral", 1, 1.50, 1.50);
            }
            else if (orden.Contains("Mesa 5"))
            {
                dataGridView1.Rows.Add("Pasta Alfredo", 2, 10.99, 21.98);
                dataGridView1.Rows.Add("Jugo de Naranja", 1, 3.50, 3.50);
                dataGridView1.Rows.Add("Café Americano", 1, 2.00, 2.00);
            }
            else if (orden.Contains("Mesa 2"))
            {
                dataGridView1.Rows.Add("Ensalada César", 1, 6.99, 6.99);
                dataGridView1.Rows.Add("Agua Mineral", 2, 1.50, 3.00);
                dataGridView1.Rows.Add("Café Americano", 1, 2.00, 2.00);
            }
        }

        // Métodos que no necesitan funcionalidad
        private void cmbOrdenesPendientes_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtSubtotal_TextChanged(object sender, EventArgs e) { }
        private void txtImpuesto_TextChanged(object sender, EventArgs e) { }
        private void txtTotal_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}