using Entidades;
using Repositorio;

namespace Negocio
{
    public class ServicioMaestro : IServicioMaestro
    {
        private IRepositorioMaestro repositorio;

        public ServicioMaestro(IRepositorioMaestro repositorio)
        {
            this.repositorio = repositorio;
        }

        public ServicioMaestro()
        {
            repositorio = new RepositorioMaestroEF();
        }
        public List<Departamento> ObtenerDepartamentos()
        => repositorio.ObtenerDepartamentos();
        public List<Municipio> ObtenerMunicipios()
        => repositorio.ObtenerMunicipios();

        public List<TipoDocumento> ObtenerTiposDocumento()
        => repositorio.ObtenerTiposDocumento();
    }
}
