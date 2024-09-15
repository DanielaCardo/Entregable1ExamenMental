using Entidades;

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

        private void btnLengiuajeGuardar_Click(object sender, EventArgs e)
        {
            var punto14 = cbo6Lenguaje.SelectedItem as string;
            var punto15 = cbo7Lenguaje.SelectedItem as string;
            var punto16 = cbo8Lenguaje.SelectedItem as string;
            var punto17 = cbo9Lenguaje.SelectedItem as string;
            var punto18 = cbo10Lenguaje.SelectedItem as string;
            var punto19 = cbo11Lenguaje.SelectedItem as string;

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
    }
}
