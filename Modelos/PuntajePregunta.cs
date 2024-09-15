using Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("PuntajePreguntas")]
    public class PuntajePregunta
    {
        public int Id { get; set; } 
        public int IdPregunta  { get; set; }
        public int Puntaje  { get; set; }
        public int IdTestMiniMental { get; set; }   
        public virtual TestMiniMental TestMiniMental { get; set; }
    }

}
