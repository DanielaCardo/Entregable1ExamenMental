using Entidades;

namespace Negocio
{
    public interface IServicioMaestro
    {
        List<Departamento> ObtenerDepartamentos();
        List<Municipio> ObtenerMunicipios();
        List<TipoDocumento> ObtenerTiposDocumento();
    }
}
