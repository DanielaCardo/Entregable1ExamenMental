using Repositorio;
using Entidades;

namespace Negocio
{
    public class ServicioPersona : IServicioPersona
    {
        private IRepositorioPersona repositorio; 

        public ServicioPersona(RepositorioPersona repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioPersona()
        {
            repositorio = new RepositorioPersonaEF();
        }

        public void GuardarPersona(Persona persona)
        {
            repositorio.GuardarPersona(persona);
        }
    }
}
