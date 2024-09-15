namespace Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set;}
        public int IdPersona { get; internal set; }
        public virtual Persona Persona { get; set; }
    }
}
