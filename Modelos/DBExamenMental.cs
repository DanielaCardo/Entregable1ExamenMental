using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelos
{
    public class DBExamenMental : DbContext
    {   // Colecciones en forma de tabla 
      public DbSet<Departamento> Departamentos { get; set;} 
      public DbSet<Municipio> Municipios { get; set; }
      public DbSet<Persona> Personas { get; set; }
      public DbSet<Sexo> Sexos { get; set; }
      public DbSet<Usuario> Usuarios { get; set; }
      public DbSet<TestMiniMental> TestMiniMental { get; set; }
      public DbSet<PuntajePregunta> PuntajePregunta { get; set; }
      public DbSet<TipoDocumento> TiposDocumento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)  //use sqlserver para conectar 
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["ExamenMental"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
            
            // construccion de cada clave foranea 
            builder.Entity<TipoDocumento>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            builder.Entity<Sexo>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo);

            builder.Entity<Municipio>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.Municipio)
                .HasForeignKey(e => e.IdMunicipio);

            builder.Entity<Departamento>()
                .HasMany(e => e.Municipios)
                .WithOne(e => e.Departamento)
                .HasForeignKey(e => e.IdDepartamento);

            builder.Entity<Persona>()
                .HasMany(e => e.TestMiniMental)
                .WithOne(e => e.Persona)
                .HasForeignKey(e => e.IdPersona);
            
            builder.Entity<TestMiniMental>()
               .HasMany(e => e.PuntajesPregunta)
               .WithOne(e => e.TestMiniMental)
               .HasForeignKey(e => e.IdTestMiniMental);

            builder.Entity<Pregunta>()
                .HasMany(e => e.PuntajesPregunta)
                .WithOne(e => e.Pregunta)
               .HasForeignKey(e => e.IdPregunta);
        }
    }
}
