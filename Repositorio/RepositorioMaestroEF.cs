using Entidades;


namespace Repositorio
{
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        private Modelos.DBExamenMental dbExamenMental;

        public RepositorioMaestroEF()
        {
            dbExamenMental = new Modelos.DBExamenMental();
        }

        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = dbExamenMental.Departamentos
                .Select(c => new Departamento() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return departamentos;
        }

        public List<Municipio> ObtenerMunicipios()
        {
            var municipios = dbExamenMental.Municipios
                .Select(c => new Municipio() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return municipios;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = dbExamenMental.TiposDocumento
                .Select(c => new TipoDocumento() { Id = c.Id, Nombre = c.Nombre })
                .OrderBy(c => c.Nombre)
                .ToList();

            return tiposDocumento;
        }
    }
}
