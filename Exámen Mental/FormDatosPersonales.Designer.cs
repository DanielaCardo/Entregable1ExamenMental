namespace Exámen_Mental
{
    partial class FormDatosPersonales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblPrimerNombre = new Label();
            txtPrimerNombre = new TextBox();
            lblSegundoNombre = new Label();
            txtSegundoNombre = new TextBox();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            lblTipoDocumento = new Label();
            lblNumeroDocumento = new Label();
            cboTipoDocumento = new ComboBox();
            txtNumeroDocumento = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblGenero = new Label();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            gbSexo = new GroupBox();
            lblDepartamento = new Label();
            gbDatosResidencia = new GroupBox();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            cboMunicipio = new ComboBox();
            lblMunicipio = new Label();
            cboDepartamento = new ComboBox();
            btnDatosPGuardar = new Button();
            btnCancelar = new Button();
            ttpMensaje = new ToolTip(components);
            erpError = new ErrorProvider(components);
            btnDatosMenu = new Button();
            gbSexo.SuspendLayout();
            gbDatosResidencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(52, 41);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(92, 15);
            lblPrimerNombre.TabIndex = 0;
            lblPrimerNombre.Text = "Primer  Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(170, 38);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(169, 23);
            txtPrimerNombre.TabIndex = 1;
            ttpMensaje.SetToolTip(txtPrimerNombre, "Ingrese el primer nombre\r\n\r\n\r\n");
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(380, 41);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(101, 15);
            lblSegundoNombre.TabIndex = 2;
            lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(519, 38);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(178, 23);
            txtSegundoNombre.TabIndex = 3;
            ttpMensaje.SetToolTip(txtSegundoNombre, "Ingrese segundo nombre");
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(52, 80);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(89, 15);
            lblPrimerApellido.TabIndex = 4;
            lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(380, 85);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(101, 15);
            lblSegundoApellido.TabIndex = 5;
            lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(170, 77);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(169, 23);
            txtPrimerApellido.TabIndex = 6;
            ttpMensaje.SetToolTip(txtPrimerApellido, "Ingrese primer apellido");
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(519, 80);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(178, 23);
            txtSegundoApellido.TabIndex = 7;
            ttpMensaje.SetToolTip(txtSegundoApellido, "Ingrese segundo apellido");
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(52, 120);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(96, 15);
            lblTipoDocumento.TabIndex = 8;
            lblTipoDocumento.Text = "Tipo Documento";
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(380, 128);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(117, 15);
            lblNumeroDocumento.TabIndex = 9;
            lblNumeroDocumento.Text = "Numero Documento";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "Cedula de Ciudadania", "Cédula de Extranjería", "Pasaporte", "Tarjeta de Identidad", "Registro Civil", "Otro" });
            cboTipoDocumento.Location = new Point(170, 120);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(169, 23);
            cboTipoDocumento.TabIndex = 10;
            ttpMensaje.SetToolTip(cboTipoDocumento, "Seleccione tipo de documento");
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(519, 120);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(178, 23);
            txtNumeroDocumento.TabIndex = 11;
            ttpMensaje.SetToolTip(txtNumeroDocumento, "Ingrese el numero de documento");
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(52, 189);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(103, 15);
            lblFechaNacimiento.TabIndex = 12;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(170, 187);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(169, 23);
            dtpFechaNacimiento.TabIndex = 13;
            ttpMensaje.SetToolTip(dtpFechaNacimiento, "Seleccione la fecha de nacimiento");
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(380, 195);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(32, 15);
            lblGenero.TabIndex = 14;
            lblGenero.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(35, 15);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 15;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(149, 15);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 16;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            gbSexo.BackColor = SystemColors.GradientInactiveCaption;
            gbSexo.Controls.Add(rdbMasculino);
            gbSexo.Controls.Add(rdbFemenino);
            gbSexo.Location = new Point(437, 178);
            gbSexo.Name = "gbSexo";
            gbSexo.Size = new Size(260, 42);
            gbSexo.TabIndex = 17;
            gbSexo.TabStop = false;
            ttpMensaje.SetToolTip(gbSexo, "Seleccione una de las opciones ");
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(38, 35);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(86, 15);
            lblDepartamento.TabIndex = 18;
            lblDepartamento.Text = "Departamento ";
            // 
            // gbDatosResidencia
            // 
            gbDatosResidencia.BackColor = SystemColors.GradientInactiveCaption;
            gbDatosResidencia.Controls.Add(txtDireccion);
            gbDatosResidencia.Controls.Add(lblDireccion);
            gbDatosResidencia.Controls.Add(cboMunicipio);
            gbDatosResidencia.Controls.Add(lblMunicipio);
            gbDatosResidencia.Controls.Add(cboDepartamento);
            gbDatosResidencia.Controls.Add(lblDepartamento);
            gbDatosResidencia.Location = new Point(52, 245);
            gbDatosResidencia.Name = "gbDatosResidencia";
            gbDatosResidencia.Size = new Size(645, 113);
            gbDatosResidencia.TabIndex = 19;
            gbDatosResidencia.TabStop = false;
            gbDatosResidencia.Text = "Datos de Residencia";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(146, 74);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(468, 23);
            txtDireccion.TabIndex = 23;
            ttpMensaje.SetToolTip(txtDireccion, "Ingrese la direccion de residencia");
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(38, 77);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 22;
            lblDireccion.Text = "Dirección";
            // 
            // cboMunicipio
            // 
            cboMunicipio.FormattingEnabled = true;
            cboMunicipio.Items.AddRange(new object[] { "Medellin", "Barbosa", "Sumapaz", "Funza", "Barranquilla", "Soledad" });
            cboMunicipio.Location = new Point(438, 32);
            cboMunicipio.Name = "cboMunicipio";
            cboMunicipio.Size = new Size(176, 23);
            cboMunicipio.TabIndex = 21;
            ttpMensaje.SetToolTip(cboMunicipio, "Seleccione el municipio de residencia");
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(356, 35);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(61, 15);
            lblMunicipio.TabIndex = 20;
            lblMunicipio.Text = "Municipio";
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Items.AddRange(new object[] { "Antioquia", "Atlántico", "Bogotá" });
            cboDepartamento.Location = new Point(146, 32);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(169, 23);
            cboDepartamento.TabIndex = 19;
            ttpMensaje.SetToolTip(cboDepartamento, "Seleccione el departamento de residencia");
            // 
            // btnDatosPGuardar
            // 
            btnDatosPGuardar.BackColor = Color.FromArgb(255, 224, 192);
            btnDatosPGuardar.Location = new Point(380, 390);
            btnDatosPGuardar.Name = "btnDatosPGuardar";
            btnDatosPGuardar.Size = new Size(86, 38);
            btnDatosPGuardar.TabIndex = 20;
            btnDatosPGuardar.Text = "Gu&ardar";
            ttpMensaje.SetToolTip(btnDatosPGuardar, "Guardar datos personales");
            btnDatosPGuardar.UseVisualStyleBackColor = false;
            btnDatosPGuardar.Click += btnDatosPGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(251, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 38);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Ca&ncelar";
            ttpMensaje.SetToolTip(btnCancelar, "Cancelar el nuevo registro");
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // btnDatosMenu
            // 
            btnDatosMenu.Location = new Point(505, 401);
            btnDatosMenu.Name = "btnDatosMenu";
            btnDatosMenu.Size = new Size(81, 37);
            btnDatosMenu.TabIndex = 22;
            btnDatosMenu.Text = "Menú >>";
            ttpMensaje.SetToolTip(btnDatosMenu, "Regresar al menú principal");
            btnDatosMenu.UseVisualStyleBackColor = true;
            btnDatosMenu.Click += btnDatosMenu_Click;
            // 
            // FormDatosPersonales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(btnDatosMenu);
            Controls.Add(btnCancelar);
            Controls.Add(btnDatosPGuardar);
            Controls.Add(gbDatosResidencia);
            Controls.Add(gbSexo);
            Controls.Add(lblGenero);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(txtSegundoApellido);
            Controls.Add(txtPrimerApellido);
            Controls.Add(lblSegundoApellido);
            Controls.Add(lblPrimerApellido);
            Controls.Add(txtSegundoNombre);
            Controls.Add(lblSegundoNombre);
            Controls.Add(txtPrimerNombre);
            Controls.Add(lblPrimerNombre);
            Name = "FormDatosPersonales";
            Text = "Datos Personales";
            gbSexo.ResumeLayout(false);
            gbSexo.PerformLayout();
            gbDatosResidencia.ResumeLayout(false);
            gbDatosResidencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimerNombre;
        private TextBox txtPrimerNombre;
        private Label lblSegundoNombre;
        private TextBox txtSegundoNombre;
        private Label lblPrimerApellido;
        private Label lblSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label lblTipoDocumento;
        private Label lblNumeroDocumento;
        private ComboBox cboTipoDocumento;
        private TextBox txtNumeroDocumento;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblGenero;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private GroupBox gbSexo;
        private Label lblDepartamento;
        private GroupBox gbDatosResidencia;
        private ComboBox cboDepartamento;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private ComboBox cboMunicipio;
        private Label lblMunicipio;
        private Button btnDatosPGuardar;
        private Button btnCancelar;
        private ToolTip ttpMensaje;
        private ErrorProvider erpError;
        private Button btnDatosMenu;
    }
}