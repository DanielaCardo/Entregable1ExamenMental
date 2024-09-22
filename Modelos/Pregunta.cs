using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Preguntas")]
    public class Pregunta
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; }
        public virtual ICollection<PuntajePregunta> PuntajesPregunta { get; set; }
    }
}
