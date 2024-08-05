namespace Exámen_Mental
{
    partial class FormIngreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnCancelar = new Button();
            btnIngresar = new Button();
            picIngreso = new PictureBox();
            ttpMensajeIngreso = new ToolTip(components);
            lblAsteriscoFNacimiento = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picIngreso).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(423, 112);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "&Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(423, 168);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "&Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ButtonHighlight;
            txtUsuario.Location = new Point(512, 112);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(153, 23);
            txtUsuario.TabIndex = 1;
            ttpMensajeIngreso.SetToolTip(txtUsuario, "Ingrese su usuario");
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(512, 168);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(153, 23);
            txtContraseña.TabIndex = 3;
            ttpMensajeIngreso.SetToolTip(txtContraseña, "Ingrese su contraseña");
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Location = new Point(436, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            ttpMensajeIngreso.SetToolTip(btnCancelar, "Cancelar inicio de sesión");
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(255, 224, 192);
            btnIngresar.Location = new Point(556, 227);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(82, 36);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "&Ingresar\r\n";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // picIngreso
            // 
            picIngreso.Image = (Image)resources.GetObject("picIngreso.Image");
            picIngreso.Location = new Point(141, 60);
            picIngreso.Name = "picIngreso";
            picIngreso.Size = new Size(242, 212);
            picIngreso.TabIndex = 6;
            picIngreso.TabStop = false;
            // 
            // lblAsteriscoFNacimiento
            // 
            lblAsteriscoFNacimiento.AutoSize = true;
            lblAsteriscoFNacimiento.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsteriscoFNacimiento.ForeColor = Color.Crimson;
            lblAsteriscoFNacimiento.Location = new Point(403, 112);
            lblAsteriscoFNacimiento.Name = "lblAsteriscoFNacimiento";
            lblAsteriscoFNacimiento.Size = new Size(14, 17);
            lblAsteriscoFNacimiento.TabIndex = 27;
            lblAsteriscoFNacimiento.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(403, 168);
            label1.Name = "label1";
            label1.Size = new Size(14, 17);
            label1.TabIndex = 28;
            label1.Text = "*";
            // 
            // FormIngreso
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 373);
            Controls.Add(label1);
            Controls.Add(lblAsteriscoFNacimiento);
            Controls.Add(picIngreso);
            Controls.Add(btnIngresar);
            Controls.Add(btnCancelar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            ((System.ComponentModel.ISupportInitialize)picIngreso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnCancelar;
        private Button btnIngresar;
        private PictureBox picIngreso;
        private ToolTip ttpMensajeIngreso;
        private Label label1;
        private Label lblAsteriscoFNacimiento;
    }
}
