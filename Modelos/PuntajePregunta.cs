using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("PuntajePreguntas")]
    public class PuntajePregunta
    {
        [Key]
        public int Id { get; set; } 
        public int IdPregunta  { get; set; }
        public virtual Pregunta Pregunta { get; set; }
        public int Puntaje  { get; set; }
        public int IdTestMiniMental { get; set; }   
        public virtual TestMiniMental TestMiniMental { get; set; }
    }

}
