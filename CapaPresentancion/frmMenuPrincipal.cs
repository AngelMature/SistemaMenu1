using System;
using System.Windows.Forms;

namespace CapaPresentancion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmMenu formMenu = new frmMenu();
            formMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            frmOrdenes formOrdenes = new frmOrdenes();
            formOrdenes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            frmFacturacion formFacturacion = new frmFacturacion();
            formFacturacion.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    
    }
}