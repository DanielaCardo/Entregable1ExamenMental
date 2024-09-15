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
    public partial class FormAtencionEvocacion : System.Windows.Forms.Form
    {
        public static TestMiniMental TestMiniMental = new TestMiniMental();
        public FormAtencionEvocacion()
        {
            InitializeComponent();
            TestMiniMental.PuntajesPregunta = new List<PuntajePregunta>();
        }

        private void btnAtencionCEGuardar_Click(object sender, EventArgs e)
        {
            var punto12 = cbo4Puntuacion.SelectedItem as string;
            var punto13 = cbo5Puntuacion.SelectedItem as string;

            TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 12, Puntaje = int.Parse(cbo4Puntuacion.SelectedItem as string) });
            TestMiniMental.PuntajesPregunta.Add(new PuntajePregunta() { IdPregunta = 13, Puntaje = int.Parse(cbo5Puntuacion.SelectedItem as string) });
            var form = new FormLenguaje();
            form.Show();
            Hide();
        }

        private void btnAtrasAtencionCE_Click(object sender, EventArgs e)
        {
            var form = new FormMemoria();
            form.Show();
            Hide();
        }

        private void btnSiguienteAtencion_Click(object sender, EventArgs e)
        {
            var form = new FormLenguaje();
            form.Show();
            Hide();
        }

        private void btnAtencionCECancelar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        
    }
}
