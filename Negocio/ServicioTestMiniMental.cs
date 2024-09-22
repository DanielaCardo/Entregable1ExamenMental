using Entidades;
using Repositorio;

namespace Negocio
{
    public class ServicioTestMiniMental : IServicioTestMiniMental
    {
        private IRepositorioTestMiniMental repositorio;

        public ServicioTestMiniMental(RepositorioTestMiniMental repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioTestMiniMental() 
        {
            repositorio = new RepositorioTestMiniMentalEF();
        }
        public void GuardarTestMiniMental(TestMiniMental testMiniMental)
        {
            repositorio.GuardarTestMiniMental(testMiniMental);
        }
    }
}
