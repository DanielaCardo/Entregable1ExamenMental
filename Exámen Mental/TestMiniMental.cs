﻿using System;
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
    public partial class TestMiniMental : System.Windows.Forms.Form
    {
        private void btnIniciarExamen_Click_1(object sender, EventArgs e)
        {
            var form = new FormOrientacion();
            form.Show();
            Hide();
        }
    }
}
