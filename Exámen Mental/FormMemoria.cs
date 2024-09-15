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

        private void btnMemoriaGuardar_Click(object sender, EventArgs e)
        {
            var punto11 = cbo3Puntuacion.SelectedItem as string;

            TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 11, Puntaje = int.Parse(cbo3Puntuacion.SelectedItem as string) });
            var form = new FormAtencionEvocacion();
            form.Show();
            Hide();
        }

        private void btnAtrasMemoria_Click(object sender, EventArgs e)
        {
            var form = new FormOrientacion();
            form.Show();
            Hide();
        }

        private void btnSiguienteMemoria_Click(object sender, EventArgs e)
        {
            var form = new FormAtencionEvocacion();
            form.Show();
            Hide();
        }

        private void btnMemoriaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
