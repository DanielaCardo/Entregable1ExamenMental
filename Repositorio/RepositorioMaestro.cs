using Entidades;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = new List<Departamento>();

            departamentos.Add(new Departamento() { Id = 1, Nombre = "Antioquia" });
            departamentos.Add(new Departamento() { Id = 2, Nombre = "Atlántico" });
            departamentos.Add(new Departamento() { Id = 3, Nombre = "Caldas" });

            return departamentos;
        }
        public List<Municipio> ObtenerMunicipios()
        {
            var municipios = new List<Municipio>();
            municipios.Add(new Municipio() { Id = 1, Nombre = "Medellín" });
            municipios.Add(new Municipio() { Id = 2, Nombre = "Barranquilla" });
            municipios.Add(new Municipio() { Id = 3, Nombre = "Manizales" });

            return municipios;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();

            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "Cédula de Extranhería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Tarjeta de Identidad" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Pasaporte" });

            return tiposDocumento;
        }    
    }
}
