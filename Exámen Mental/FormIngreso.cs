using Negocio;

namespace Exámen_Mental
{
    public partial class FormIngreso : System.Windows.Forms.Form
    {
        IServicioSeguridad servicioSeguridad = new ServicioSeguridad();
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo Usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar las credenciales ingresadas 
            if (servicioSeguridad.ValidarUsuario(new Entidades.Usuario { Clave = txtContraseña.Text, NombreUsuario = txtUsuario.Text }))
            {
                MessageBox.Show("Ingreso exitoso", "Bienvenido a Examen Mental ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // abrir el formulario de menú

                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
