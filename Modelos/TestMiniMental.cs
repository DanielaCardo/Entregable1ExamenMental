namespace Modelos
{
    public class TestMiniMental
    {
        public int Id { get; set; } 
        public int IdPersona { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<PuntajePregunta> PuntajesPregunta { get; set; }
        
    }
}
