namespace CapaPresentancion
{
    partial class frmFacturacion
    {
      
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            cmbOrdenesPendientes = new ComboBox();
            cmbCajeros = new ComboBox();
            cmbMetodoPago = new ComboBox();
            dataGridView1 = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            txtSubtotal = new TextBox();
            txtImpuesto = new TextBox();
            txtTotal = new TextBox();
            btnGenerarFactura = new Button();
            btnImprimir = new Button();
            btnRegresar = new Button();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
           
            cmbOrdenesPendientes.FormattingEnabled = true;
            cmbOrdenesPendientes.Location = new Point(34, 273);
            cmbOrdenesPendientes.Name = "cmbOrdenesPendientes";
            cmbOrdenesPendientes.Size = new Size(151, 28);
            cmbOrdenesPendientes.TabIndex = 0;
            cmbOrdenesPendientes.SelectedIndexChanged += cmbOrdenesPendientes_SelectedIndexChanged;
           
            cmbCajeros.FormattingEnabled = true;
            cmbCajeros.Location = new Point(34, 320);
            cmbCajeros.Name = "cmbCajeros";
            cmbCajeros.Size = new Size(151, 28);
            cmbCajeros.TabIndex = 1;
            cmbCajeros.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
                        cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta Crédito  ", "Tarjeta Débito", "Transferencia" });
            cmbMetodoPago.Location = new Point(34, 354);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(151, 28);
            cmbMetodoPago.TabIndex = 2;
            cmbMetodoPago.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
           
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colSubtotal });
            dataGridView1.Location = new Point(64, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(556, 98);
            dataGridView1.TabIndex = 3;
           
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.Width = 125;
           
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 125;
            
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
           
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 125;
           
            txtSubtotal.Location = new Point(251, 261);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 4;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
          
            txtImpuesto.Location = new Point(251, 311);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(125, 27);
            txtImpuesto.TabIndex = 5;
            txtImpuesto.TextChanged += txtImpuesto_TextChanged;
            
            txtTotal.Location = new Point(251, 354);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 6;
            txtTotal.TextChanged += txtTotal_TextChanged;
           
            btnGenerarFactura.Location = new Point(461, 269);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(94, 29);
            btnGenerarFactura.TabIndex = 7;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
             
            btnImprimir.Location = new Point(461, 320);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
          
            btnRegresar.Location = new Point(461, 373);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
           
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(628, 268);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "label1";
            lblMensaje.Click += label1_Click;
          
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(btnRegresar);
            Controls.Add(btnImprimir);
            Controls.Add(btnGenerarFactura);
            Controls.Add(txtTotal);
            Controls.Add(txtImpuesto);
            Controls.Add(txtSubtotal);
            Controls.Add(dataGridView1);
            Controls.Add(cmbMetodoPago);
            Controls.Add(cmbCajeros);
            Controls.Add(cmbOrdenesPendientes);
            Name = "frmFacturacion";
            Text = "frmFacturacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOrdenesPendientes;
        private ComboBox cmbCajeros;
        private ComboBox cmbMetodoPago;
        private DataGridView dataGridView1;
        private TextBox txtSubtotal;
        private TextBox txtImpuesto;
        private TextBox txtTotal;
        private Button btnGenerarFactura;
        private Button btnImprimir;
        private Button btnRegresar;
        private Label lblMensaje;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
    }
}