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
    public partial class FormDatosPersonales : System.Windows.Forms.Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnDatosPGuardar_Click(object sender, EventArgs e)
        {
            var form = new TestMiniMental();
            form.Show();
            Hide(); 
        }
      
    }
}
