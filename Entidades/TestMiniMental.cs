using System.Collections;

namespace Entidades
{
    public class TestMiniMental
    {
        public int Id { get; set; }
        public virtual Persona Persona { get; set; }

        public List<PuntajePregunta> PuntajesPregunta { get; set; } // lo agrego como atributo a la clase ?
        
    }
}
