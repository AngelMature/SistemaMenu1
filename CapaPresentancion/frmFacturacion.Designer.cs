using System;
using System.Windows.Forms;

namespace CapaPresentancion
{
    public partial class frmFacturacion : Form
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbOrdenesPendientes;
        private ComboBox cmbCajeros;
        private ComboBox cmbMetodoPago;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private TextBox txtSubtotal;
        private TextBox txtImpuesto;
        private TextBox txtTotal;
        private Button btnGenerarFactura;
        private Button btnImprimir;
        private Button btnRegresar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

          
            cmbOrdenesPendientes.Location = new System.Drawing.Point(30, 30);
            cmbOrdenesPendientes.Size = new System.Drawing.Size(200, 28);

            cmbCajeros.Location = new System.Drawing.Point(30, 70);
            cmbCajeros.Size = new System.Drawing.Size(200, 28);

            cmbMetodoPago.Location = new System.Drawing.Point(30, 110);
            cmbMetodoPago.Size = new System.Drawing.Size(200, 28);

           
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colSubtotal });
            dataGridView1.Location = new System.Drawing.Point(30, 150);
            dataGridView1.Size = new System.Drawing.Size(500, 150);

            colProducto.HeaderText = "Producto";
            colCantidad.HeaderText = "Cantidad";
            colPrecio.HeaderText = "Precio";
            colSubtotal.HeaderText = "Subtotal";

          
            txtSubtotal.Location = new System.Drawing.Point(250, 320);
            txtImpuesto.Location = new System.Drawing.Point(250, 350);
            txtTotal.Location = new System.Drawing.Point(250, 380);

           
            btnGenerarFactura.Location = new System.Drawing.Point(500, 30);
            btnGenerarFactura.Size = new System.Drawing.Size(120, 30);
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.Click += btnGenerarFactura_Click;

            btnImprimir.Location = new System.Drawing.Point(500, 70);
            btnImprimir.Size = new System.Drawing.Size(120, 30);
            btnImprimir.Text = "Imprimir";
            btnImprimir.Click += btnImprimir_Click;

            btnRegresar.Location = new System.Drawing.Point(500, 110);
            btnRegresar.Size = new System.Drawing.Size(120, 30);
            btnRegresar.Text = "Regresar";
            btnRegresar.Click += btnRegresar_Click;

            
            Controls.Add(cmbOrdenesPendientes);
            Controls.Add(cmbCajeros);
            Controls.Add(cmbMetodoPago);
            Controls.Add(dataGridView1);
            Controls.Add(txtSubtotal);
            Controls.Add(txtImpuesto);
            Controls.Add(txtTotal);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnImprimir);
            Controls.Add(btnRegresar);

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 450);
            Text = "Facturación";

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}