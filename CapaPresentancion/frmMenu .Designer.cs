using System;
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentancion
{
    partial class frmMenu
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Label lblMensaje;
        private RadioButton radioButtonPlatillos;
        private RadioButton radioButtonBebidas;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Label lblTiempoPreparacion;
        private Label lblTamano;
        private CheckBox chkAlcoholica;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblMensaje = new Label();
            radioButtonPlatillos = new RadioButton();
            radioButtonBebidas = new RadioButton();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblTiempoPreparacion = new Label();
            lblTamano = new Label();
            chkAlcoholica = new CheckBox();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            dataGridView1.Location = new Point(30, 30);
            dataGridView1.Size = new Size(880, 250);
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ColumnHeadersHeight = 29;

            lblMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensaje.Location = new Point(30, 300);
            lblMensaje.Size = new Size(300, 25);
            lblMensaje.Text = "Gestión del Menú";

            radioButtonPlatillos.Location = new Point(30, 340);
            radioButtonPlatillos.Size = new Size(100, 24);
            radioButtonPlatillos.Text = "Platillos";
            radioButtonPlatillos.CheckedChanged += radioButton2_CheckedChanged;

            radioButtonBebidas.Location = new Point(140, 340);
            radioButtonBebidas.Size = new Size(100, 24);
            radioButtonBebidas.Text = "Bebidas";
            radioButtonBebidas.CheckedChanged += radioButton3_CheckedChanged;

            lblCategoria.Location = new Point(30, 380);
            lblCategoria.Size = new Size(100, 25);
            lblCategoria.Text = "Categoría:";

            lblNombre.Location = new Point(30, 410);
            lblNombre.Size = new Size(100, 25);
            lblNombre.Text = "Nombre:";

            lblPrecio.Location = new Point(30, 440);
            lblPrecio.Size = new Size(100, 25);
            lblPrecio.Text = "Precio:";

            lblDescripcion.Location = new Point(460, 380);
            lblDescripcion.Size = new Size(100, 25);
            lblDescripcion.Text = "Descripción:";

            lblTiempoPreparacion.Location = new Point(460, 410);
            lblTiempoPreparacion.Size = new Size(150, 25);
            lblTiempoPreparacion.Text = "Tiempo Preparación:";

            lblTamano.Location = new Point(460, 440);
            lblTamano.Size = new Size(100, 25);
            lblTamano.Text = "Tamaño:";

            chkAlcoholica.Location = new Point(630, 440);
            chkAlcoholica.Size = new Size(120, 25);
            chkAlcoholica.Text = "¿Es alcohólica?";
            chkAlcoholica.CheckedChanged += chkAlcoholica_CheckedChanged;

            btnAgregar.Location = new Point(650, 480);
            btnAgregar.Size = new Size(100, 40);
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;

            btnLimpiar.Location = new Point(770, 480);
            btnLimpiar.Size = new Size(100, 40);
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;

            btnRegresar.Location = new Point(890, 480);
            btnRegresar.Size = new Size(100, 40);
            btnRegresar.Text = "Regresar";
            btnRegresar.Click += btnRegresar_Click;

            ClientSize = new Size(1000, 550);
            Controls.Add(dataGridView1);
            Controls.Add(lblMensaje);
            Controls.Add(radioButtonPlatillos);
            Controls.Add(radioButtonBebidas);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTiempoPreparacion);
            Controls.Add(lblTamano);
            Controls.Add(chkAlcoholica);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);

            Name = "frmMenu";
            Text = "Gestión del Menú";
            Load += frmMenu_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}