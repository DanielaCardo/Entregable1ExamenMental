using Entidades;
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
        public static TestMiniMental TestMiniMental = new TestMiniMental();
        public FormOrientacion()
        {
            InitializeComponent();
            TestMiniMental.PuntajesPregunta = new List<PuntajePregunta>();
        }

        public static string NumeroDocumento { get; set; }

        private bool ValidarDatos() // Validas los campos que deben ser obligatorios
        {
            erpError.SetError(txtNumeroDocumento, null);
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                erpError.SetError(txtNumeroDocumento, "El número de documento es obligatorio");
                return false;
            }
            NumeroDocumento = txtNumeroDocumento.Text;

            var punto1 = cbo1Punt1.SelectedItem as string;
            var punto2 = cbo1Punt2.SelectedItem as string;
            var punto3 = cbo1Punt3.SelectedItem as string;
            var punto4 = cbo1Punt4.SelectedItem as string;
            var punto5 = cbo1Punt5.SelectedItem as string;
            var punto6 = cbo2Punt1.SelectedItem as string;
            var punto7 = cbo2Punt2.SelectedItem as string;
            var punto8 = cbo2Punt3.SelectedItem as string;
            var punto9 = cbo2Punt4.SelectedItem as string;
            var punto10 = cbo2Punt5.SelectedItem as string;

            erpError.SetError(cbo1Punt1, null);
            if (string.IsNullOrEmpty(punto1))
            {
                erpError.SetError(cbo1Punt1, " Campo obligatorio");
                return false;
            }

            erpError.SetError(cbo1Punt2, null);
            if (string.IsNullOrEmpty(punto2))
            {
                erpError.SetError(cbo1Punt2, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo1Punt3, null);
            if (string.IsNullOrEmpty(punto3))
            {
                erpError.SetError(cbo1Punt3, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo1Punt4, null);
            if (string.IsNullOrEmpty(punto4))
            {
                erpError.SetError(cbo1Punt4, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo1Punt5, null);
            if (string.IsNullOrEmpty(punto5))
            {
                erpError.SetError(cbo1Punt5, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo2Punt1, null);
            if (string.IsNullOrEmpty(punto6))
            {
                erpError.SetError(cbo2Punt1, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo2Punt2, null);
            if (string.IsNullOrEmpty(punto7))
            {
                erpError.SetError(cbo2Punt2, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo2Punt3, null);
            if (string.IsNullOrEmpty(punto8))
            {
                erpError.SetError(cbo2Punt3, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo2Punt4, null);
            if (string.IsNullOrEmpty(punto9))
            {
                erpError.SetError(cbo2Punt4, " Campo obligatorio");
                return false;
            }
            erpError.SetError(cbo2Punt5, null);
            if (string.IsNullOrEmpty(punto10))
            {
                erpError.SetError(cbo2Punt5, " Campo obligatorio");
                return false;
            }

            return true;
        }

        private void btnOrientaSiguiente_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    var NumeroDocumento = txtNumeroDocumento.Text.Trim();

                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 1, Puntaje = int.Parse(cbo1Punt1.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 2, Puntaje = int.Parse(cbo1Punt2.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 3, Puntaje = int.Parse(cbo1Punt3.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 4, Puntaje = int.Parse(cbo1Punt4.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 5, Puntaje = int.Parse(cbo1Punt5.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 6, Puntaje = int.Parse(cbo2Punt1.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 7, Puntaje = int.Parse(cbo2Punt2.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 8, Puntaje = int.Parse(cbo2Punt3.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 9, Puntaje = int.Parse(cbo2Punt4.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 10, Puntaje = int.Parse(cbo2Punt5.SelectedItem as string) });

                    var form = new FormMemoria();
                    form.Show();
                    Hide();
                }
                else

                {   // Mensaje de error si la condicion anterior no se cumple
                    MessageBox.Show("Por favor, revise los datos ingresados",
                     this.Text,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
            }
            //Excepciones en la ejecución _ muestra un mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, no fue possible realizar el registro" + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnOrientaVolverMenu_Click(object sender, EventArgs e)
        {
            var form = new FormMenu();
            form.Show();
            Hide();
        }
    }
}
