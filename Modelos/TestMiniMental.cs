using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("TestsMiniMental")]
    public class TestMiniMental
    {
        [Key]
        public int Id { get; set; } 
        public int IdPersona { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual List<PuntajePregunta> PuntajesPregunta { get; set; }
        
    }
}
