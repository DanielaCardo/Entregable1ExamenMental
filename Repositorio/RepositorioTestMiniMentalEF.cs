using Entidades;

namespace Repositorio
{
    public class RepositorioTestMiniMentalEF : IRepositorioTestMiniMental
    {
        private Modelos.DBExamenMental dbExamenMental;

        public RepositorioTestMiniMentalEF()
        {
            dbExamenMental = new Modelos.DBExamenMental();
        }

        public void GuardarTestMiniMental(TestMiniMental testMiniMental)
        {
            var personaActual = dbExamenMental.Personas.FirstOrDefault(p =>
            p.NumeroDocumento == testMiniMental.Persona.NumeroDocumento);

            var testMiniMentalIngresar = new Modelos.TestMiniMental() { IdPersona = personaActual.Id};

            dbExamenMental.TestMiniMental.Add(testMiniMentalIngresar);
            dbExamenMental.SaveChanges();

            if (testMiniMental.PuntajesPregunta != null)
            {
                foreach (var puntajePregunta in testMiniMental.PuntajesPregunta)
                {
                    var puntajePreguntaIngresar = new Modelos.PuntajePregunta()
                    {
                        IdTestMiniMental = testMiniMentalIngresar.Id,
                        IdPregunta= puntajePregunta.IdPregunta,
                        Puntaje = puntajePregunta.Puntaje
                    };

                    dbExamenMental.PuntajePregunta.Add(puntajePreguntaIngresar);
                    dbExamenMental.SaveChanges();
                }
            }

        }
    }
}
          