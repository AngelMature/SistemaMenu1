namespace CapaPresentancion
{
    partial class frmOrdenes
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbProductos;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private Button btnAgregarProducto;
        private Button btnCrearOrden;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Label lblTotal;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbProductos = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnAgregarProducto = new Button();
            btnCrearOrden = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            lblTotal = new Label();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            cmbProductos.Location = new System.Drawing.Point(30, 30);
            cmbProductos.Size = new System.Drawing.Size(200, 28);

            numericUpDown1.Location = new System.Drawing.Point(250, 30);
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;
            numericUpDown1.Size = new System.Drawing.Size(60, 27);

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colSubtotal });
            dataGridView1.Location = new System.Drawing.Point(30, 70);
            dataGridView1.Size = new System.Drawing.Size(500, 200);

            colProducto.HeaderText = "Producto";
            colCantidad.HeaderText = "Cantidad";
            colPrecio.HeaderText = "Precio Unitario";
            colSubtotal.HeaderText = "Subtotal";

            btnAgregarProducto.Location = new System.Drawing.Point(30, 280);
            btnAgregarProducto.Size = new System.Drawing.Size(120, 30);
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);

            btnCrearOrden.Location = new System.Drawing.Point(160, 280);
            btnCrearOrden.Size = new System.Drawing.Size(120, 30);
            btnCrearOrden.Text = "Crear Orden";
            btnCrearOrden.Click += new System.EventHandler(this.btnCrearOrden_Click);

            btnLimpiar.Location = new System.Drawing.Point(290, 280);
            btnLimpiar.Size = new System.Drawing.Size(120, 30);
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            btnRegresar.Location = new System.Drawing.Point(420, 280);
            btnRegresar.Size = new System.Drawing.Size(110, 30);
            btnRegresar.Text = "Regresar";
            btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);

            lblTotal.Location = new System.Drawing.Point(30, 320);
            lblTotal.Size = new System.Drawing.Size(200, 20);
            lblTotal.Text = "Total: $0.00";

            Controls.Add(cmbProductos);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnCrearOrden);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Controls.Add(lblTotal);

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 360);
            Text = "Gestión de Órdenes";

            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}