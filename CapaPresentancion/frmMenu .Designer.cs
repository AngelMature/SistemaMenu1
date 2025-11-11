namespace CapaPresentancion
{
    partial class frmMenu
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            txtNombre = new Label();
            txtPrecio = new Label();
            txtDescripcion = new Label();
            txtCategoria = new Label();
            lblMensaje = new Label();
            txtTamano = new Label();
            chkAlcoholica = new CheckBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            txtTiempoPreparacion = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(547, 377);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(252, 329);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Platillos";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(251, 359);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Bebidas";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPrecio, colCategoria, colDescripcion });
            dataGridView1.Location = new Point(33, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(660, 117);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoría";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.Width = 125;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Width = 125;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(53, 252);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(64, 20);
            txtNombre.TabIndex = 4;
            txtNombre.Text = "Nombre";
            txtNombre.Click += txtNombre_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.AutoSize = true;
            txtPrecio.Location = new Point(269, 252);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(50, 20);
            txtPrecio.TabIndex = 5;
            txtPrecio.Text = "Precio";
            txtPrecio.Click += label2_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AutoSize = true;
            txtDescripcion.Location = new Point(30, 361);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(87, 20);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.Text = "Descripción";
            txtDescripcion.Click += txtDescripcion_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.AutoSize = true;
            txtCategoria.Location = new Point(33, 324);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(74, 20);
            txtCategoria.TabIndex = 7;
            txtCategoria.Text = "Categoría";
            txtCategoria.Click += txtCategoria_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(198, 390);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 8;
            // 
            // txtTamano
            // 
            txtTamano.AutoSize = true;
            txtTamano.Location = new Point(33, 405);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(61, 20);
            txtTamano.TabIndex = 9;
            txtTamano.Text = "Tamaño";
            txtTamano.Click += txtTamano_Click;
            // 
            // chkAlcoholica
            // 
            chkAlcoholica.AutoSize = true;
            chkAlcoholica.Location = new Point(522, 414);
            chkAlcoholica.Name = "chkAlcoholica";
            chkAlcoholica.Size = new Size(119, 24);
            chkAlcoholica.TabIndex = 10;
            chkAlcoholica.Text = "Es Alcohólica";
            chkAlcoholica.UseVisualStyleBackColor = true;
            chkAlcoholica.CheckedChanged += chkAlcoholica_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(547, 243);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(547, 289);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(547, 324);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // txtTiempoPreparacion
            // 
            txtTiempoPreparacion.AutoSize = true;
            txtTiempoPreparacion.Location = new Point(547, 208);
            txtTiempoPreparacion.Name = "txtTiempoPreparacion";
            txtTiempoPreparacion.Size = new Size(143, 20);
            txtTiempoPreparacion.TabIndex = 14;
            txtTiempoPreparacion.Text = "Tiempo Preparación";
            txtTiempoPreparacion.Click += txtTiempoPreparacion_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTiempoPreparacion);
            Controls.Add(btnRegresar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(chkAlcoholica);
            Controls.Add(txtTamano);
            Controls.Add(lblMensaje);
            Controls.Add(txtCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "frmMenu";
            Text = "frmMenu";
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DataGridView dataGridView1;
        private Label txtNombre;
        private Label txtPrecio;
        private Label txtDescripcion;
        private Label txtCategoria;
        private Label lblMensaje;
        private Label txtTamano;
        private CheckBox chkAlcoholica;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Label txtTiempoPreparacion;


        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colDescripcion;
    }
}