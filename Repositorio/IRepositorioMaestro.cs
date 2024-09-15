using Entidades;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Departamento> ObtenerDepartamentos();
        List<Municipio> ObtenerMunicipios();
        List<TipoDocumento> ObtenerTiposDocumento();
    }
}
