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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var form = new  FormMenu();
            form.Show();
            Hide();
        }
    }
}
