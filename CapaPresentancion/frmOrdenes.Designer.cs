namespace CapaPresentancion
{
    partial class frmOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colComentarios = new DataGridViewTextBoxColumn();
            lstOrdenesPendientes = new ListBox();
            txtComentarios = new TextBox();
            lblTotal = new Label();
            lblEstado = new Label();
            lblMensaje = new Label();
            ildMensaje = new Label();
            btnAgregarProducto = new Button();
            btnLimpiar = new Button();
            btnCrearOrden = new Button();
            btnRegresar = new Button();
            cmbMeseros = new ComboBox();
            cmbProductos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(132, 259);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(132, 307);
            numericUpDown2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProducto, colCantidad, colPrecio, colSubtotal, colComentarios });
            dataGridView1.Location = new Point(13, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 127);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 125;
            // 
            // colComentarios
            // 
            colComentarios.HeaderText = "Comentarios";
            colComentarios.MinimumWidth = 6;
            colComentarios.Name = "colComentarios";
            colComentarios.Width = 125;
            // 
            // lstOrdenesPendientes
            // 
            lstOrdenesPendientes.FormattingEnabled = true;
            lstOrdenesPendientes.Location = new Point(559, 336);
            lstOrdenesPendientes.Name = "lstOrdenesPendientes";
            lstOrdenesPendientes.Size = new Size(150, 104);
            lstOrdenesPendientes.TabIndex = 5;
            lstOrdenesPendientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(142, 205);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(125, 27);
            txtComentarios.TabIndex = 6;
            txtComentarios.TextChanged += textBox1_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(42, 294);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: $0.00";
            lblTotal.Click += label1_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(13, 343);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(126, 20);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado: Pendiente";
            lblEstado.Click += label2_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(302, 144);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 9;
            lblMensaje.Click += label3_Click;
            // 
            // ildMensaje
            // 
            ildMensaje.AutoSize = true;
            ildMensaje.Location = new Point(12, 392);
            ildMensaje.Name = "ildMensaje";
            ildMensaje.Size = new Size(170, 20);
            ildMensaje.TabIndex = 10;
            ildMensaje.Text = "Para mensajes al usuario";
            ildMensaje.Click += ildMensaje_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(316, 244);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(163, 29);
            btnAgregarProducto.TabIndex = 11;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(348, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCrearOrden
            // 
            btnCrearOrden.Location = new Point(316, 307);
            btnCrearOrden.Name = "btnCrearOrden";
            btnCrearOrden.Size = new Size(163, 29);
            btnCrearOrden.TabIndex = 12;
            btnCrearOrden.Text = "Crear Orden";
            btnCrearOrden.UseVisualStyleBackColor = true;
            btnCrearOrden.Click += btnCrearOrden_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(348, 411);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // cmbMeseros
            // 
            cmbMeseros.FormattingEnabled = true;
            cmbMeseros.Location = new Point(511, 192);
            cmbMeseros.Name = "cmbMeseros";
            cmbMeseros.Size = new Size(151, 28);
            cmbMeseros.TabIndex = 14;
            cmbMeseros.SelectedIndexChanged += cmbMeseros_SelectedIndexChanged;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(511, 259);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(151, 28);
            cmbProductos.TabIndex = 15;
            cmbProductos.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // frmOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbProductos);
            Controls.Add(cmbMeseros);
            Controls.Add(btnRegresar);
            Controls.Add(btnCrearOrden);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregarProducto);
            Controls.Add(ildMensaje);
            Controls.Add(lblMensaje);
            Controls.Add(lblEstado);
            Controls.Add(lblTotal);
            Controls.Add(txtComentarios);
            Controls.Add(lstOrdenesPendientes);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Name = "frmOrdenes";
            Text = "frmOrdenes";
            Load += frmOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private DataGridView dataGridView1;
        private ListBox lstOrdenesPendientes;
        private TextBox txtComentarios;
        private Label lblTotal;
        private Label lblEstado;
        private Label lblMensaje;
        private Label ildMensaje;
        private Button btnAgregarProducto;
        private Button btnLimpiar;
        private Button btnCrearOrden;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colComentarios;
        private ComboBox cmbMeseros;
        private ComboBox cmbProductos;
    }
}