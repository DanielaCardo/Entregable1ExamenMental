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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngreso));
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            picIngreso = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIngreso).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(408, 112);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "&Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(408, 168);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "&Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(512, 112);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(153, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(512, 168);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(153, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Location = new Point(436, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 224, 192);
            btnAceptar.Location = new Point(556, 227);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(92, 36);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += BtnAceptar_Click;
            // 
            // picIngreso
            // 
            picIngreso.Image = (Image)resources.GetObject("picIngreso.Image");
            picIngreso.Location = new Point(146, 73);
            picIngreso.Name = "picIngreso";
            picIngreso.Size = new Size(242, 212);
            picIngreso.TabIndex = 6;
            picIngreso.TabStop = false;
            // 
            // FormIngreso
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 373);
            Controls.Add(picIngreso);
            Controls.Add(btnAceptar);
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
        private Button btnAceptar;
        private PictureBox picIngreso;
    }
}
