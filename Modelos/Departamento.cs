using Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{ 
    [Table("Departamentos")]
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
