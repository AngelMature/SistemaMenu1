namespace CapaPresentancion
{
    partial class frmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();

            button1.Location = new Point(300, 153);
            button1.Name = "button1";
            button1.Size = new Size(194, 29);
            button1.TabIndex = 0;
            button1.Text = "Gestión de Menú";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            button2.Location = new Point(300, 198);
            button2.Name = "button2";
            button2.Size = new Size(194, 29);
            button2.TabIndex = 1;
            button2.Text = "Gestión de Órdenes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;

            button3.Location = new Point(300, 246);
            button3.Name = "button3";
            button3.Size = new Size(194, 29);
            button3.TabIndex = 2;
            button3.Text = "Facturación";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;

            button4.Location = new Point(300, 281);
            button4.Name = "button4";
            button4.Size = new Size(194, 29);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}