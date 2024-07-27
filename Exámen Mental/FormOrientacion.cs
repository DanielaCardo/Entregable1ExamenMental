using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Exámen_Mental
{
    public partial class FormOrientacion : System.Windows.Forms.Form
    {
        public FormOrientacion()
        {
            InitializeComponent();
        }

        private void btnOrientaGuardar_Click(object sender, EventArgs e)
        {
            var form = new FormMemoria();
            form.Show();
            Hide();
        }

        private void btnOrientaSiguiente_Click_1(object sender, EventArgs e)
        {
            var form = new FormMemoria();
            form.Show();
            Hide();
        }

        private void btnOrientaVolverMenu_Click(object sender, EventArgs e)
        {
            var form = new FormMenu();
            form.Show();
            Hide();
        }

        private void btnOrientaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
