using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exámen_Mental
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnIniciarExamen_Click(object sender, EventArgs e)
        {
            var form = new FormOrientacion();
            form.Show();
            Hide();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            var form = new FormDatosPersonales();
            form.Show();
            Hide();
        }

        private void btnMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
