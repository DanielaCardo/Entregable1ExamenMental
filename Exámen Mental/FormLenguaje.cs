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
    public partial class FormLenguaje : System.Windows.Forms.Form
    {
        public FormLenguaje()
        {
            InitializeComponent();
        }

        private void btnLenguajeVolverMenu_Click(object sender, EventArgs e)
        {
            var form = new FormMenu();
            form.Show();
            Hide();
        }
    }
}
