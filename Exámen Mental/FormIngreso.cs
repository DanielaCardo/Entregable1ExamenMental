namespace Exámen_Mental
{
    public partial class FormIngreso : System.Windows.Forms.Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Se deben ingresar ambos campos: Usuario y Contraseña.", "Campos Obligatorios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Abrir el formulario de menú
                var form = new FormMenu();
                form.Show();
                Hide();
            }

        }
    }
}
