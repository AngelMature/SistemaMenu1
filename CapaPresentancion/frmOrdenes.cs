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
    public partial class frmOrdenes : Form
    {
        private EmpleadoDB empleadoDB = new EmpleadoDB();
        private ProductoDAO productoDAO = new ProductoDAO();
        private List<DetalleOrden> detallesOrden = new List<DetalleOrden>();
        private Label lblNumeroMesa;
        private Label lblCantidad;
        private Label lblSeleccionMesero;
        private Label lblSeleccionProducto;

        public frmOrdenes()
        {
            InitializeComponent();
            CrearLabelsDescriptivos();
            ConfigurarControles();
            CargarDatosIniciales();
        }

        private void CrearLabelsDescriptivos()
        {
            // Crear Labels descriptivos
            lblNumeroMesa = new Label();
            lblNumeroMesa.Text = "Número Mesa:";
            lblNumeroMesa.Location = new Point(132, 229);
            lblNumeroMesa.Size = new Size(120, 20);
            this.Controls.Add(lblNumeroMesa);

            lblCantidad = new Label();
            lblCantidad.Text = "Cantidad:";
            lblCantidad.Location = new Point(132, 287);
            lblCantidad.Size = new Size(120, 20);
            this.Controls.Add(lblCantidad);

            lblSeleccionMesero = new Label();
            lblSeleccionMesero.Text = "Seleccionar Mesero:";
            lblSeleccionMesero.Location = new Point(560, 178);
            lblSeleccionMesero.Size = new Size(150, 20);
            this.Controls.Add(lblSeleccionMesero);

            lblSeleccionProducto = new Label();
            lblSeleccionProducto.Text = "Seleccionar Producto:";
            lblSeleccionProducto.Location = new Point(560, 222);
            lblSeleccionProducto.Size = new Size(150, 20);
            this.Controls.Add(lblSeleccionProducto);
        }

        private void ConfigurarControles()
        {
            // Configurar NumericUpDown
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 20;
            numericUpDown1.Value = 1;

            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 10;
            numericUpDown2.Value = 1;

            // Configurar ComboBox
            cmbMeseros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarDatosIniciales()
        {
            try
            {
                // Cargar meseros
                DataTable dtMeseros = empleadoDB.ObtenerMeseros();
                cmbMeseros.DisplayMember = "Nombre";
                cmbMeseros.ValueMember = "Id";
                cmbMeseros.DataSource = dtMeseros;

                // Cargar productos
                DataTable dtProductos = productoDAO.ObtenerTodos();
                cmbProductos.DisplayMember = "Nombre";
                cmbProductos.ValueMember = "Id";
                cmbProductos.DataSource = dtProductos;

                ActualizarTotal();
                ildMensaje.Text = "Sistema listo para tomar órdenes";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductos.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un producto", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProducto = (int)cmbProductos.SelectedValue;
                string nombreProducto = cmbProductos.Text;
                int cantidad = (int)numericUpDown2.Value;
                decimal precio = productoDAO.ObtenerPrecio(idProducto);
                string comentarios = txtComentarios.Text;

                // Crear detalle de orden
                DetalleOrden detalle = new DetalleOrden(idProducto, nombreProducto, cantidad, precio, comentarios);
                detallesOrden.Add(detalle);

                // Actualizar DataGridView
                ActualizarDataGridView();
                ActualizarTotal();

                ildMensaje.Text = $"Producto '{nombreProducto}' agregado a la orden";
                txtComentarios.Clear();
                numericUpDown2.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (cmbMeseros.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un mesero", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (detallesOrden.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto a la orden", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int numeroMesa = (int)numericUpDown1.Value;
                int idMesero = (int)cmbMeseros.SelectedValue;
                string nombreMesero = cmbMeseros.Text;

                // Crear orden
                Orden orden = new Orden();
                orden.NumeroMesa = numeroMesa;
                orden.IdMesero = idMesero;

                foreach (var detalle in detallesOrden)
                {
                    orden.AgregarDetalle(detalle);
                }

                // Mostrar resumen
                string mensaje = $"Orden creada exitosamente:\n" +
                               $"Mesa: {numeroMesa}\n" +
                               $"Mesero: {nombreMesero}\n" +
                               $"Total: {orden.Total:C}\n" +
                               $"Productos: {detallesOrden.Count}";

                MessageBox.Show(mensaje, "Orden Creada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar para nueva orden
                LimpiarOrden();
                ildMensaje.Text = "Orden creada exitosamente. Listo para nueva orden.";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear orden: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarOrden();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var detalle in detallesOrden)
            {
                dataGridView1.Rows.Add(
                    detalle.NombreProducto,
                    detalle.Cantidad,
                    detalle.PrecioUnitario,
                    detalle.Subtotal,
                    detalle.Comentarios
                );
            }
        }

        private void ActualizarTotal()
        {
            decimal total = detallesOrden.Sum(d => d.Subtotal);
            lblTotal.Text = $"Total: {total:C}";
        }

        private void LimpiarOrden()
        {
            detallesOrden.Clear();
            dataGridView1.Rows.Clear();
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            txtComentarios.Clear();
            ActualizarTotal();
            lblEstado.Text = "Estado: Pendiente";
            ildMensaje.Text = "Orden limpiada. Listo para nueva orden.";
        }

        // Métodos que no necesitan funcionalidad (pueden quedar vacíos)
        private void frmOrdenes_Load(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void ildMensaje_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbMeseros_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}