namespace Entidades
{
    public class Persona
    {  
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set;}
        public string PrimerApellido { get; set;}   
        public string SegundoApellido { get;set;} 
        public string NumeroDocumento { get; set;} 
        public DateTime FechaNacimiento { get; set; }
        public Municipio Municipio { get; set; }
        public string Direccion {  get; set;}
        public TipoDocumento TipoDocumento { get; set;}
        public Sexo Sexo { get; set;}

    }
}
