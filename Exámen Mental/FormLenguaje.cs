using Entidades;
using Negocio;

namespace Exámen_Mental
{
    public partial class FormLenguaje : System.Windows.Forms.Form
    {
        public static TestMiniMental TestMiniMental = new TestMiniMental();
        public FormLenguaje()
        {
            InitializeComponent();
            TestMiniMental.PuntajesPregunta = new List<PuntajePregunta>();
        }


        private bool ValidarDatos() // Validas los campos que deben ser obligatorios
        {
            var punto14 = cbo6Lenguaje.SelectedItem as string;
            var punto15 = cbo7Lenguaje.SelectedItem as string;
            var punto16 = cbo8Lenguaje.SelectedItem as string;
            var punto17 = cbo9Lenguaje.SelectedItem as string;
            var punto18 = cbo10Lenguaje.SelectedItem as string;
            var punto19 = cbo11Lenguaje.SelectedItem as string;

            erpErrorL.SetError(cbo6Lenguaje, null);
            if (string.IsNullOrEmpty(punto14))
            {
                erpErrorL.SetError(cbo6Lenguaje, " Campo obligatorio");
                return false;
            }
            erpErrorL.SetError(cbo7Lenguaje, null);
            if (string.IsNullOrEmpty(punto15))
            {
                erpErrorL.SetError(cbo7Lenguaje, " Campo obligatorio");
                return false;
            }
            erpErrorL.SetError(cbo8Lenguaje, null);
            if (string.IsNullOrEmpty(punto16))
            {
                erpErrorL.SetError(cbo8Lenguaje, " Campo obligatorio");
                return false;
            }
            erpErrorL.SetError(cbo9Lenguaje, null);
            if (string.IsNullOrEmpty(punto17))
            {
                erpErrorL.SetError(cbo9Lenguaje, " Campo obligatorio");
                return false;
            }
            erpErrorL.SetError(cbo10Lenguaje, null);
            if (string.IsNullOrEmpty(punto18))
            {
                erpErrorL.SetError(cbo10Lenguaje, " Campo obligatorio");
                return false;
            }
            erpErrorL.SetError(cbo11Lenguaje, null);
            if (string.IsNullOrEmpty(punto19))
            {
                erpErrorL.SetError(cbo11Lenguaje, " Campo obligatorio");
                return false;
            }

            return true;
        }

        private void btnLengiuajeGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {

                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 14, Puntaje = int.Parse(cbo6Lenguaje.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 15, Puntaje = int.Parse(cbo7Lenguaje.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 16, Puntaje = int.Parse(cbo8Lenguaje.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 17, Puntaje = int.Parse(cbo9Lenguaje.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 18, Puntaje = int.Parse(cbo10Lenguaje.SelectedItem as string) });
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 19, Puntaje = int.Parse(cbo11Lenguaje.SelectedItem as string) });

                    TestMiniMental testMiniMental = new TestMiniMental();
                    testMiniMental.Persona = new Persona();
                    testMiniMental.Persona.NumeroDocumento = FormOrientacion.NumeroDocumento;
                    testMiniMental.PuntajesPregunta = new List<PuntajePregunta>();
                    testMiniMental.PuntajesPregunta.AddRange(FormOrientacion.TestMiniMental.PuntajesPregunta);
                    testMiniMental.PuntajesPregunta.AddRange(FormMemoria.TestMiniMental.PuntajesPregunta);
                    testMiniMental.PuntajesPregunta.AddRange(FormLenguaje.TestMiniMental.PuntajesPregunta);
                    testMiniMental.PuntajesPregunta.AddRange(FormAtencionEvocacion.TestMiniMental.PuntajesPregunta);

                    IServicioTestMiniMental servicioTestMiniMental = new ServicioTestMiniMental();
                    servicioTestMiniMental.GuardarTestMiniMental(testMiniMental);
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

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            TestMiniMental testMiniMental = new TestMiniMental();
            testMiniMental.PuntajesPregunta = new List<PuntajePregunta>();
            testMiniMental.PuntajesPregunta.AddRange(FormOrientacion.TestMiniMental.PuntajesPregunta);
            testMiniMental.PuntajesPregunta.AddRange(FormMemoria.TestMiniMental.PuntajesPregunta);
            testMiniMental.PuntajesPregunta.AddRange(FormLenguaje.TestMiniMental.PuntajesPregunta);
            testMiniMental.PuntajesPregunta.AddRange(FormAtencionEvocacion.TestMiniMental.PuntajesPregunta);

            int total = testMiniMental.PuntajesPregunta.Sum(p => p.Puntaje);    
        }

        private void btnLenguajeVolverMenu_Click(object sender, EventArgs e)
        {
            var form = new FormMenu();
            form.Show();
            Hide();
        }

        private void btnLenguajeCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtrasLenguaje_Click(object sender, EventArgs e)
        {
            var form = new FormAtencionEvocacion();
            form.Show();
            Hide();
        }
    }
}
