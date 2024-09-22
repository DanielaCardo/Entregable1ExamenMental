using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Sexos")]
    public class Sexo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get;}
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
