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
    public partial class FormAtencionEvocacion : System.Windows.Forms.Form
    {
        public FormAtencionEvocacion()
        {
            InitializeComponent();
        }

        private void btnAtencionCEGuardar_Click(object sender, EventArgs e)
        {
            var form = new FormLenguaje();
            form.Show();
            Hide();
        }

        private void btnAtrasAtencionCE_Click(object sender, EventArgs e)
        {
            var form = new FormMemoria();
            form.Show();
            Hide();
        }

        private void btnSiguienteAtencion_Click(object sender, EventArgs e)
        {
            var form = new FormLenguaje();
            form.Show();
            Hide();
        }

        private void btnAtencionCECancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        
    }
}
