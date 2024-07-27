using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            try
            {
                string primerNombre = txtPrimerNombre.Text.Trim();
                string primerApellido = txtPrimerApellido.Text.Trim();
                string tipoDocumento = cboTipoDocumento.Text.Trim();
                string documento = txtNumeroDocumento.Text.Trim();
                string fechaNacimiento = dtpFechaNacimiento.Text.Trim();


                if (string.IsNullOrEmpty(primerNombre))
                {
                    MessageBox.Show("El primer nombre es obligatorio.");
                    txtPrimerNombre.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(primerApellido))
                {
                    MessageBox.Show("El primer apellido es obligatorio.");
                    txtPrimerApellido.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(tipoDocumento))
                {
                    MessageBox.Show("El tipo de documento es obligatorio.");
                    cboTipoDocumento.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(documento))
                {
                    MessageBox.Show("El documento es obligatorio.");
                    txtNumeroDocumento.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(fechaNacimiento))
                {
                    MessageBox.Show("La fecha de nacimiento es obligatoria.");
                    dtpFechaNacimiento.Focus();
                    return;
                }

            }
             
            catch (Exception exc)

            {
                MessageBox.Show(" No fue posible realizar el registro");

            }

            var form = new FormMenu();
            form.Show();
            Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

