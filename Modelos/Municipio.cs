using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Municipios")]
    public class Municipio
    {
        [Key]
      public int Id { get; set; }
      public string Nombre { get; set; }
      public int IdDepartamento { get; set; }
      public virtual Departamento Departamento { get; set;}
      public virtual ICollection<Persona> Personas { get; set; }

    }
}
