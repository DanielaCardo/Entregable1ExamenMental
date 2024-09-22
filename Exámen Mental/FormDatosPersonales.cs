using Entidades;
using Negocio;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace Exámen_Mental
{
    public partial class FormDatosPersonales : System.Windows.Forms.Form
    {

        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnDatosPGuardar_Click(object sender, EventArgs e)

        {
            var persona = new Persona();
            try
            { 
                if (ValidarDatos())

                {
                    // Declaracion de variables 
                    persona.PrimerNombre = txtPrimerNombre.Text.Trim();
                    persona.PrimerApellido = txtPrimerApellido.Text.Trim();
                    persona.SegundoNombre = txtSegundoNombre.Text.Trim();
                    persona.SegundoApellido = txtSegundoApellido.Text.Trim();
                    persona.TipoDocumento = cboTipoDocumento.SelectedItem as TipoDocumento;
                    persona.NumeroDocumento = txtNumeroDocumento.Text.Trim();
                    persona.FechaNacimiento = dtpFechaNacimiento.Value;
                    persona.Sexo = rdbMasculino.Checked ?
                    new Sexo() { Id = (int)Entidades.Enumeraciones.Sexo.Masculino, 
                        Nombre = "Masculino" } :
                    new Sexo()
                    {
                        Id = (int)Entidades.Enumeraciones.Sexo.Femenino,
                        Nombre = "Femenino"
                    };
                    persona.Municipio = cboMunicipio.SelectedItem as Municipio;
                    persona.Direccion = txtDireccion.Text.Trim();
                        
                    IServicioPersona servicioPersona = new ServicioPersona();
                    servicioPersona.GuardarPersona(persona);

                    // Muestra el mensaje con todos los datos ingresados 
                    MessageBox.Show("Los datos se guardaron exitosamente", this.Text,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                }

                else

                {   // Mensaje de error si la condicion anterior no se cumple
                    MessageBox.Show("Por favor, revise los datos ingresados",
                     this.Text,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }

            }
            //Excepciones en la ejecución _ muestra un mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado, no fue possible realizar el registro" + ex.Message,
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos() // Validas los campos que deben ser obligatorios
        {
            erpError.SetError(txtPrimerNombre, null);  // Error provider para la caja de texto primer nombre
            if (string.IsNullOrEmpty(txtPrimerNombre.Text)) // Si se encuntra vacio o nulo
            {
                erpError.SetError(txtPrimerNombre, "El primer nombre es obligatorio");// Mostrar este mensaje
                return false; // Regresar
            }

            erpError.SetError(txtPrimerApellido, null);
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                erpError.SetError(txtPrimerApellido, "El primer apellido es obligatorio");
                return false;
            }

            erpError.SetError(cboTipoDocumento, null);
            if (string.IsNullOrEmpty(cboTipoDocumento.Text))
            {
                erpError.SetError(cboTipoDocumento, "Este campo es obligatorio");
                return false;
            }

            erpError.SetError(txtNumeroDocumento, null);
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                erpError.SetError(txtNumeroDocumento, "El número de documento es obligatorio");
                return false;
            }

            erpError.SetError(dtpFechaNacimiento, null);
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpError.SetError(dtpFechaNacimiento, "La fecha de nacimiento " +
                    "debe ser menor a la fecha actual");
                return false;
            }

            return true;
        }

        private void FormDatosPersonales_Load(object sender, EventArgs e)
        {
            // Asignar los eventos KeyPress a los TextBox correspondientes
            txtPrimerNombre.KeyPress += new KeyPressEventHandler(txtSoloLetras_KeyPress);
            txtSegundoNombre.KeyPress += new KeyPressEventHandler(txtSoloLetras_KeyPress);
            txtPrimerApellido.KeyPress += new KeyPressEventHandler(txtSoloLetras_KeyPress);
            txtSegundoApellido.KeyPress += new KeyPressEventHandler(txtSoloLetras_KeyPress);
            txtNumeroDocumento.KeyPress += new KeyPressEventHandler(txtSoloNumeros_KeyPress);

            ServicioMaestro servicioMaestro = new ServicioMaestro();

            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.DataSource = servicioMaestro.ObtenerTiposDocumento();

            cboDepartamento.DisplayMember = "Nombre";
            cboDepartamento.DataSource = servicioMaestro.ObtenerDepartamentos();

            cboMunicipio.DisplayMember = "Nombre";
            cboMunicipio.DataSource = servicioMaestro.ObtenerMunicipios();
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir letras y la tecla de retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatosMenu_Click(object sender, EventArgs e)
        {
            var form = new FormMenu();
            form.Show();
            Hide();
        }
    }
}


