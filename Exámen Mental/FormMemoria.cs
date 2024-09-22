using Entidades;


namespace Exámen_Mental
{
    public partial class FormMemoria : System.Windows.Forms.Form
    {
        public static TestMiniMental TestMiniMental = new TestMiniMental();
        public FormMemoria()
        {
            InitializeComponent();
            TestMiniMental.PuntajesPregunta = new List<PuntajePregunta>();
        }

        private bool ValidarDatos() // Validas los campos que deben ser obligatorios
        {
            var punto11 = cbo3Puntuacion.SelectedItem as string;
            erpErrorM.SetError(cbo3Puntuacion, null);
            if (string.IsNullOrEmpty(punto11))
            {
                erpErrorM.SetError(cbo3Puntuacion, " Campo obligatorio");
                return false;
            }
            return true;
        }
        private void btnSiguienteMemoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 11, Puntaje = int.Parse(cbo3Puntuacion.SelectedItem as string) });

                    var form = new FormAtencionEvocacion();
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
        private void btnAtrasMemoria_Click(object sender, EventArgs e)
        {
            var form = new FormOrientacion();
            form.Show();
            Hide();
        }

        private void btnMemoriaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
