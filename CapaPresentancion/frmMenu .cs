using System;
using System.Data;
using System.Drawing;
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
            CargarProductos();
            MostrarCamposPlatillos();
        }

        private void CrearCamposEntrada()
        {
            txtCategoriaInput = new TextBox { Location = new Point(140, 380), Size = new Size(150, 25) };
            Controls.Add(txtCategoriaInput);

            txtNombreInput = new TextBox { Location = new Point(140, 410), Size = new Size(150, 25) };
            Controls.Add(txtNombreInput);

            txtPrecioInput = new TextBox { Location = new Point(140, 440), Size = new Size(150, 25) };
            Controls.Add(txtPrecioInput);

            txtDescripcionInput = new TextBox { Location = new Point(570, 380), Size = new Size(150, 25) };
            Controls.Add(txtDescripcionInput);

            txtTiempoPreparacionInput = new TextBox { Location = new Point(610, 410), Size = new Size(100, 25) };
            Controls.Add(txtTiempoPreparacionInput);

            txtTamanoInput = new TextBox { Location = new Point(570, 440), Size = new Size(50, 25) };
            Controls.Add(txtTamanoInput);
        }

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
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlatillos.Checked)
            {
                MostrarCamposPlatillos();
                CargarPlatillos();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBebidas.Checked)
            {
                MostrarCamposBebidas();
                CargarBebidas();
            }
        }

        private void MostrarCamposPlatillos()
        {
            lblTiempoPreparacion.Visible = true;
            txtTiempoPreparacionInput.Visible = true;
            lblTamano.Visible = false;
            txtTamanoInput.Visible = false;
            chkAlcoholica.Visible = false;
        }

        private void MostrarCamposBebidas()
        {
            lblTiempoPreparacion.Visible = false;
            txtTiempoPreparacionInput.Visible = false;
            lblTamano.Visible = true;
            txtTamanoInput.Visible = true;
            chkAlcoholica.Visible = true;
        }

        private void CargarPlatillos()
        {
            dataGridView1.DataSource = productoDAO.ObtenerPlatillos();
            lblMensaje.Text = $"Se cargaron {dataGridView1.Rows.Count} platillos";
        }

        private void CargarBebidas()
        {
            dataGridView1.DataSource = productoDAO.ObtenerBebidas();
            lblMensaje.Text = $"Se cargaron {dataGridView1.Rows.Count} bebidas";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreInput.Text)) { MessageBox.Show("El nombre es requerido"); return; }
            if (!decimal.TryParse(txtPrecioInput.Text, out decimal precio) || precio <= 0) { MessageBox.Show("El precio debe ser mayor a 0"); return; }

            string tipo = radioButtonPlatillos.Checked ? "Platillo" : "Bebida";
            bool resultado = productoDAO.Insertar(txtNombreInput.Text, tipo, precio,
                txtDescripcionInput.Text, txtCategoriaInput.Text);

            if (resultado)
            {
                MessageBox.Show("Producto agregado correctamente");
                LimpiarCampos();
                if (radioButtonPlatillos.Checked) CargarPlatillos();
                else CargarBebidas();
            }
            else MessageBox.Show("Error al agregar el producto");
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtCategoriaInput.Clear();
            txtNombreInput.Clear();
            txtPrecioInput.Clear();
            txtDescripcionInput.Clear();
            txtTiempoPreparacionInput.Clear();
            txtTamanoInput.Clear();
            chkAlcoholica.Checked = false;
            lblMensaje.Text = "Campos limpiados";
        }

        private void btnRegresar_Click(object sender, EventArgs e) => Close();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void chkAlcoholica_CheckedChanged(object sender, EventArgs e) { }
        private void frmMenu_Load(object sender, EventArgs e) { }
    }
}