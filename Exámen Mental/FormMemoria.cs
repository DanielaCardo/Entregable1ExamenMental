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
    public partial class FormMemoria : System.Windows.Forms.Form
    {
        public FormMemoria()
        {
            InitializeComponent();
        }

        private void btnMemoriaGuardar_Click(object sender, EventArgs e)
        {
            var form = new FormAtencionEvocacion();
            form.Show();
            Hide();
        }
    }
}
