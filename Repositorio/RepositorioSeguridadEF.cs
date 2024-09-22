using Entidades;

namespace Repositorio
{
    public class RepositorioSeguridadEF : IRepositorioSeguridad
    {
        private Modelos.DBExamenMental dbExamenMental;

        public RepositorioSeguridadEF()
        {
            dbExamenMental = new Modelos.DBExamenMental();
        }

        public Usuario ObtenerUsuario(string nombreUsuario)
        {
            var usuarioActual = dbExamenMental.Usuarios.FirstOrDefault(u=>u.NombreUsuario == nombreUsuario);
            if (usuarioActual != null)
            {
                return new Usuario() { NombreUsuario = usuarioActual.NombreUsuario, Clave = usuarioActual.Clave };
            }

            return null;
        }
    }
}
