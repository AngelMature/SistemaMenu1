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
    public partial class frmMenu : Form
    {
        private ProductoDAO productoDAO = new ProductoDAO();
        private TextBox txtNombreInput;
        private TextBox txtPrecioInput;
        private TextBox txtDescripcionInput;
        private TextBox txtCategoriaInput;
        private TextBox txtTiempoPreparacionInput;
        private TextBox txtTamanoInput;

        public frmMenu()
        {
            InitializeComponent();
            CrearCamposEntrada();
            CargarProductos(); // ← AQUÍ ESTÁ INTEGRADO
            MostrarCamposPlatillos();
        }

        private void CrearCamposEntrada()
        {
            // Crear TextBox para Nombre
            txtNombreInput = new TextBox();
            txtNombreInput.Location = new Point(436, 350);
            txtNombreInput.Size = new Size(150, 25);
            this.Controls.Add(txtNombreInput);

            // Crear TextBox para Precio
            txtPrecioInput = new TextBox();
            txtPrecioInput.Location = new Point(630, 350);
            txtPrecioInput.Size = new Size(100, 25);
            this.Controls.Add(txtPrecioInput);

            // Crear TextBox para Descripción
            txtDescripcionInput = new TextBox();
            txtDescripcionInput.Location = new Point(679, 300);
            txtDescripcionInput.Size = new Size(200, 25);
            this.Controls.Add(txtDescripcionInput);

            // Crear TextBox para Categoría
            txtCategoriaInput = new TextBox();
            txtCategoriaInput.Location = new Point(553, 320);
            txtCategoriaInput.Size = new Size(120, 25);
            this.Controls.Add(txtCategoriaInput);

            // Crear TextBox para Tiempo Preparación
            txtTiempoPreparacionInput = new TextBox();
            txtTiempoPreparacionInput.Location = new Point(460, 425);
            txtTiempoPreparacionInput.Size = new Size(120, 25);
            this.Controls.Add(txtTiempoPreparacionInput);

            // Crear TextBox para Tamaño
            txtTamanoInput = new TextBox();
            txtTamanoInput.Location = new Point(46, 400);
            txtTamanoInput.Size = new Size(120, 25);
            this.Controls.Add(txtTamanoInput);
        }

        // AQUÍ ESTÁ EL MÉTODO CargarProductos INTEGRADO
        private void CargarProductos()
        {
            try
            {
                DataTable dt = productoDAO.ObtenerTodos();

                if (dt == null || dt.Rows.Count == 0)
                {
                    lblMensaje.Text = "No hay productos registrados";
                    dataGridView1.DataSource = null;
                    return;
                }

                dataGridView1.DataSource = dt;
                lblMensaje.Text = $"Se cargaron {dt.Rows.Count} productos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MostrarCamposPlatillos();
                CargarPlatillos();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MostrarCamposBebidas();
                CargarBebidas();
            }
        }

        private void MostrarCamposPlatillos()
        {
            txtTiempoPreparacion.Visible = true;
            txtTiempoPreparacionInput.Visible = true;
            txtTamano.Visible = false;
            txtTamanoInput.Visible = false;
            chkAlcoholica.Visible = false;
        }

        private void MostrarCamposBebidas()
        {
            txtTiempoPreparacion.Visible = false;
            txtTiempoPreparacionInput.Visible = false;
            txtTamano.Visible = true;
            txtTamanoInput.Visible = true;
            chkAlcoholica.Visible = true;
        }

        private void CargarPlatillos()
        {
            try
            {
                DataTable dt = productoDAO.ObtenerPlatillos();
                dataGridView1.DataSource = dt;
                lblMensaje.Text = $"Se cargaron {dt.Rows.Count} platillos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar platillos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBebidas()
        {
            try
            {
                DataTable dt = productoDAO.ObtenerBebidas();
                dataGridView1.DataSource = dt;
                lblMensaje.Text = $"Se cargaron {dt.Rows.Count} bebidas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bebidas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (string.IsNullOrWhiteSpace(txtNombreInput.Text))
                {
                    MessageBox.Show("El nombre es requerido", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecioInput.Text, out decimal precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número mayor a 0", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tipo = radioButton2.Checked ? "Platillo" : "Bebida";
                string descripcion = txtDescripcionInput.Text;
                string categoria = txtCategoriaInput.Text;

                bool resultado = productoDAO.Insertar(
                    txtNombreInput.Text,
                    tipo,
                    precio,
                    descripcion,
                    categoria
                );

                if (resultado)
                {
                    MessageBox.Show("Producto agregado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();

                    // Recargar la lista según el tipo seleccionado
                    if (radioButton2.Checked) CargarPlatillos();
                    else CargarBebidas();
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreInput.Clear();
            txtPrecioInput.Clear();
            txtDescripcionInput.Clear();
            txtCategoriaInput.Clear();
            txtTiempoPreparacionInput.Clear();
            txtTamanoInput.Clear();
            chkAlcoholica.Checked = false;
            lblMensaje.Text = "Campos limpiados";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Métodos que no necesitan funcionalidad (pueden quedar vacíos)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtTamano_Click(object sender, EventArgs e) { }
        private void chkAlcoholica_CheckedChanged(object sender, EventArgs e) { }
        private void txtNombre_Click(object sender, EventArgs e) { }
        private void txtDescripcion_Click(object sender, EventArgs e) { }
        private void txtCategoria_Click(object sender, EventArgs e) { }
        private void txtTiempoPreparacion_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}