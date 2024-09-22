using Entidades;

namespace Repositorio
{
    public class RepositorioPersonaEF : IRepositorioPersona
    {
        private Modelos.DBExamenMental dbExamenMental;

        public RepositorioPersonaEF()
        {
            dbExamenMental = new Modelos.DBExamenMental();
        }
        public void GuardarPersona(Persona persona)
        {
            var personaActual = dbExamenMental.Personas.FirstOrDefault(p => p.IdTipoDocumento == persona.TipoDocumento.Id &&
            p.NumeroDocumento == persona.NumeroDocumento);

            int idPersona = 0;
            if (personaActual != null)
            {
                personaActual.PrimerNombre = persona.PrimerNombre;
                personaActual.SegundoNombre = persona.SegundoNombre;
                personaActual.PrimerApellido = persona.PrimerApellido;
                personaActual.SegundoApellido = persona.SegundoApellido;
                personaActual.FechaNacimiento = persona.FechaNacimiento;
                personaActual.IdSexo = persona.Sexo.Id;
                personaActual.Direccion = persona.Direccion;
                personaActual.IdMunicipio = persona.Municipio.Id;
                idPersona = personaActual.Id;

                dbExamenMental.SaveChanges();
            }
            else
            {
                var personaIngresa = new Modelos.Persona
                {
                    PrimerNombre = persona.PrimerNombre,
                    SegundoNombre = persona.SegundoNombre,
                    PrimerApellido = persona.PrimerApellido,
                    SegundoApellido = persona.SegundoApellido,
                    FechaNacimiento = persona.FechaNacimiento,
                    IdSexo = persona.Sexo.Id,
                    IdTipoDocumento = persona.TipoDocumento.Id,
                    NumeroDocumento = persona.NumeroDocumento,
                    IdMunicipio = persona.Municipio.Id,
                    Direccion = persona.Direccion,
                };
                dbExamenMental.Personas.Add(personaIngresa);
                dbExamenMental.SaveChanges();

            }
        }

    }
}
