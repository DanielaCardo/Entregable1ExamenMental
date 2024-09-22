using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set;}
        public string PrimerApellido { get; set;}   
        public string SegundoApellido { get;set;} 
        public string NumeroDocumento { get; set;} 
        public string Direccion {  get; set;}
        public DateTime FechaNacimiento { get; set; }
        public int IdMunicipio { get; set; }
        public virtual Municipio Municipio { get; set; }
        public int IdTipoDocumento { get; set;}
        public virtual TipoDocumento TipoDocumento { get; set;}
        public int IdSexo {  get; set;}
        public virtual Sexo Sexo { get; set;}
        public virtual ICollection<TestMiniMental> TestMiniMental { get; set;}
    }
}
