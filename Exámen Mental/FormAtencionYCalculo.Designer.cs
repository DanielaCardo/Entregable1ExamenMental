namespace Exámen_Mental
{
    partial class FormAtencionEvocacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtencionEvocacion));
            btnAtencionCECancelar = new Button();
            btnAtencionCEGuardar = new Button();
            gbAtencionC2 = new GroupBox();
            cbo4Puntuacion = new ComboBox();
            lblTextoAtencionC = new Label();
            lbl4Hasta5 = new Label();
            lbl4 = new Label();
            gbAtencionC = new GroupBox();
            lblAtencionCNro = new Label();
            lblAtencionCPuntuación = new Label();
            lblAtencionC = new Label();
            lblAtencionCPAcum = new Label();
            gbEvocacion = new GroupBox();
            lblEvocacionNro = new Label();
            lblEvocacionPuntuacion = new Label();
            lblEvocacion = new Label();
            lblEvocacionPAcum = new Label();
            groupBox1 = new GroupBox();
            cbo5Puntuacion = new ComboBox();
            lblTextoEvocacion = new Label();
            lbl5Hasta3 = new Label();
            lbl5 = new Label();
            btnSiguienteAtencion = new Button();
            btnAtrasAtencionCE = new Button();
            ttpMensajeAtencionCE = new ToolTip(components);
            gbAtencionC2.SuspendLayout();
            gbAtencionC.SuspendLayout();
            gbEvocacion.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtencionCECancelar
            // 
            btnAtencionCECancelar.BackColor = SystemColors.ControlLight;
            btnAtencionCECancelar.Location = new Point(311, 355);
            btnAtencionCECancelar.Name = "btnAtencionCECancelar";
            btnAtencionCECancelar.Size = new Size(74, 33);
            btnAtencionCECancelar.TabIndex = 9;
            btnAtencionCECancelar.Text = "&Cancelar";
            ttpMensajeAtencionCE.SetToolTip(btnAtencionCECancelar, "Cancelar formulario");
            btnAtencionCECancelar.UseVisualStyleBackColor = false;
            btnAtencionCECancelar.Click += btnAtencionCECancelar_Click;
            // 
            // btnAtencionCEGuardar
            // 
            btnAtencionCEGuardar.BackColor = Color.FromArgb(255, 224, 192);
            btnAtencionCEGuardar.Location = new Point(419, 355);
            btnAtencionCEGuardar.Name = "btnAtencionCEGuardar";
            btnAtencionCEGuardar.Size = new Size(75, 33);
            btnAtencionCEGuardar.TabIndex = 8;
            btnAtencionCEGuardar.Text = "&Guardar";
            ttpMensajeAtencionCE.SetToolTip(btnAtencionCEGuardar, "Guardar respuestas");
            btnAtencionCEGuardar.UseVisualStyleBackColor = false;
            btnAtencionCEGuardar.Click += btnAtencionCEGuardar_Click;
            // 
            // gbAtencionC2
            // 
            gbAtencionC2.BackColor = SystemColors.GradientInactiveCaption;
            gbAtencionC2.Controls.Add(cbo4Puntuacion);
            gbAtencionC2.Controls.Add(lblTextoAtencionC);
            gbAtencionC2.Controls.Add(lbl4Hasta5);
            gbAtencionC2.Controls.Add(lbl4);
            gbAtencionC2.Location = new Point(44, 103);
            gbAtencionC2.Name = "gbAtencionC2";
            gbAtencionC2.Size = new Size(713, 97);
            gbAtencionC2.TabIndex = 7;
            gbAtencionC2.TabStop = false;
            // 
            // cbo4Puntuacion
            // 
            cbo4Puntuacion.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5" });
            cbo4Puntuacion.FormattingEnabled = true;
            cbo4Puntuacion.Location = new Point(613, 38);
            cbo4Puntuacion.Name = "cbo4Puntuacion";
            cbo4Puntuacion.Size = new Size(94, 23);
            cbo4Puntuacion.TabIndex = 4;
            // 
            // lblTextoAtencionC
            // 
            lblTextoAtencionC.AutoSize = true;
            lblTextoAtencionC.Location = new Point(167, 19);
            lblTextoAtencionC.Name = "lblTextoAtencionC";
            lblTextoAtencionC.Size = new Size(429, 75);
            lblTextoAtencionC.TabIndex = 2;
            lblTextoAtencionC.Text = resources.GetString("lblTextoAtencionC.Text");
            // 
            // lbl4Hasta5
            // 
            lbl4Hasta5.AutoSize = true;
            lbl4Hasta5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4Hasta5.Location = new Point(100, 41);
            lbl4Hasta5.Name = "lbl4Hasta5";
            lbl4Hasta5.Size = new Size(19, 15);
            lbl4Hasta5.TabIndex = 1;
            lbl4Hasta5.Text = "/5";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(20, 41);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(16, 15);
            lbl4.TabIndex = 0;
            lbl4.Text = "4.";
            // 
            // gbAtencionC
            // 
            gbAtencionC.BackColor = SystemColors.ActiveCaption;
            gbAtencionC.Controls.Add(lblAtencionCNro);
            gbAtencionC.Controls.Add(lblAtencionCPuntuación);
            gbAtencionC.Controls.Add(lblAtencionC);
            gbAtencionC.Controls.Add(lblAtencionCPAcum);
            gbAtencionC.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbAtencionC.Location = new Point(44, 36);
            gbAtencionC.Name = "gbAtencionC";
            gbAtencionC.Size = new Size(713, 61);
            gbAtencionC.TabIndex = 6;
            gbAtencionC.TabStop = false;
            // 
            // lblAtencionCNro
            // 
            lblAtencionCNro.AutoSize = true;
            lblAtencionCNro.Location = new Point(6, 21);
            lblAtencionCNro.Name = "lblAtencionCNro";
            lblAtencionCNro.Size = new Size(30, 17);
            lblAtencionCNro.TabIndex = 0;
            lblAtencionCNro.Text = "No.";
            // 
            // lblAtencionCPuntuación
            // 
            lblAtencionCPuntuación.AutoSize = true;
            lblAtencionCPuntuación.Location = new Point(613, 19);
            lblAtencionCPuntuación.Name = "lblAtencionCPuntuación";
            lblAtencionCPuntuación.Size = new Size(78, 17);
            lblAtencionCPuntuación.TabIndex = 3;
            lblAtencionCPuntuación.Text = "Puntuación";
            // 
            // lblAtencionC
            // 
            lblAtencionC.AutoSize = true;
            lblAtencionC.Location = new Point(327, 19);
            lblAtencionC.Name = "lblAtencionC";
            lblAtencionC.Size = new Size(123, 17);
            lblAtencionC.TabIndex = 2;
            lblAtencionC.Text = "Atención y Cálculo";
            // 
            // lblAtencionCPAcum
            // 
            lblAtencionCPAcum.AutoSize = true;
            lblAtencionCPAcum.Location = new Point(72, 19);
            lblAtencionCPAcum.Name = "lblAtencionCPAcum";
            lblAtencionCPAcum.Size = new Size(78, 34);
            lblAtencionCPAcum.TabIndex = 1;
            lblAtencionCPAcum.Text = "   Puntaje \r\nAcumulado";
            // 
            // gbEvocacion
            // 
            gbEvocacion.BackColor = SystemColors.ActiveCaption;
            gbEvocacion.Controls.Add(lblEvocacionNro);
            gbEvocacion.Controls.Add(lblEvocacionPuntuacion);
            gbEvocacion.Controls.Add(lblEvocacion);
            gbEvocacion.Controls.Add(lblEvocacionPAcum);
            gbEvocacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbEvocacion.Location = new Point(44, 206);
            gbEvocacion.Name = "gbEvocacion";
            gbEvocacion.Size = new Size(713, 63);
            gbEvocacion.TabIndex = 10;
            gbEvocacion.TabStop = false;
            // 
            // lblEvocacionNro
            // 
            lblEvocacionNro.AutoSize = true;
            lblEvocacionNro.Location = new Point(6, 21);
            lblEvocacionNro.Name = "lblEvocacionNro";
            lblEvocacionNro.Size = new Size(30, 17);
            lblEvocacionNro.TabIndex = 0;
            lblEvocacionNro.Text = "No.";
            // 
            // lblEvocacionPuntuacion
            // 
            lblEvocacionPuntuacion.AutoSize = true;
            lblEvocacionPuntuacion.Location = new Point(613, 19);
            lblEvocacionPuntuacion.Name = "lblEvocacionPuntuacion";
            lblEvocacionPuntuacion.Size = new Size(78, 17);
            lblEvocacionPuntuacion.TabIndex = 3;
            lblEvocacionPuntuacion.Text = "Puntuación";
            // 
            // lblEvocacion
            // 
            lblEvocacion.AutoSize = true;
            lblEvocacion.Location = new Point(355, 19);
            lblEvocacion.Name = "lblEvocacion";
            lblEvocacion.Size = new Size(69, 17);
            lblEvocacion.TabIndex = 2;
            lblEvocacion.Text = "Evocación";
            // 
            // lblEvocacionPAcum
            // 
            lblEvocacionPAcum.AutoSize = true;
            lblEvocacionPAcum.Location = new Point(72, 19);
            lblEvocacionPAcum.Name = "lblEvocacionPAcum";
            lblEvocacionPAcum.Size = new Size(78, 34);
            lblEvocacionPAcum.TabIndex = 1;
            lblEvocacionPAcum.Text = "   Puntaje \r\nAcumulado";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(cbo5Puntuacion);
            groupBox1.Controls.Add(lblTextoEvocacion);
            groupBox1.Controls.Add(lbl5Hasta3);
            groupBox1.Controls.Add(lbl5);
            groupBox1.Location = new Point(44, 275);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 53);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // cbo5Puntuacion
            // 
            cbo5Puntuacion.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5" });
            cbo5Puntuacion.FormattingEnabled = true;
            cbo5Puntuacion.Items.AddRange(new object[] { "1", "2", "3" });
            cbo5Puntuacion.Location = new Point(613, 16);
            cbo5Puntuacion.Name = "cbo5Puntuacion";
            cbo5Puntuacion.Size = new Size(94, 23);
            cbo5Puntuacion.TabIndex = 4;
            // 
            // lblTextoEvocacion
            // 
            lblTextoEvocacion.AutoSize = true;
            lblTextoEvocacion.Location = new Point(167, 19);
            lblTextoEvocacion.Name = "lblTextoEvocacion";
            lblTextoEvocacion.Size = new Size(405, 30);
            lblTextoEvocacion.TabIndex = 2;
            lblTextoEvocacion.Text = "De las palabras enteriormente mencionadas, diga las palabras que recuerde.\r\n\r\n";
            // 
            // lbl5Hasta3
            // 
            lbl5Hasta3.AutoSize = true;
            lbl5Hasta3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5Hasta3.Location = new Point(100, 19);
            lbl5Hasta3.Name = "lbl5Hasta3";
            lbl5Hasta3.Size = new Size(19, 15);
            lbl5Hasta3.TabIndex = 1;
            lbl5Hasta3.Text = "/3";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(20, 19);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(16, 15);
            lbl5.TabIndex = 0;
            lbl5.Text = "5.";
            // 
            // btnSiguienteAtencion
            // 
            btnSiguienteAtencion.BackColor = SystemColors.Window;
            btnSiguienteAtencion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguienteAtencion.Location = new Point(533, 365);
            btnSiguienteAtencion.Name = "btnSiguienteAtencion";
            btnSiguienteAtencion.Size = new Size(83, 35);
            btnSiguienteAtencion.TabIndex = 18;
            btnSiguienteAtencion.Text = "Siguiente >";
            ttpMensajeAtencionCE.SetToolTip(btnSiguienteAtencion, "Pasar al siguiente formulario");
            btnSiguienteAtencion.UseVisualStyleBackColor = false;
            btnSiguienteAtencion.Click += btnSiguienteAtencion_Click;
            // 
            // btnAtrasAtencionCE
            // 
            btnAtrasAtencionCE.BackColor = SystemColors.Window;
            btnAtrasAtencionCE.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasAtencionCE.Location = new Point(190, 367);
            btnAtrasAtencionCE.Name = "btnAtrasAtencionCE";
            btnAtrasAtencionCE.Size = new Size(78, 33);
            btnAtrasAtencionCE.TabIndex = 19;
            btnAtrasAtencionCE.Text = "< Atrás";
            ttpMensajeAtencionCE.SetToolTip(btnAtrasAtencionCE, "Regresar al formulario anterior");
            btnAtrasAtencionCE.UseVisualStyleBackColor = false;
            btnAtrasAtencionCE.Click += btnAtrasAtencionCE_Click;
            // 
            // FormAtencionEvocacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(btnAtrasAtencionCE);
            Controls.Add(btnSiguienteAtencion);
            Controls.Add(groupBox1);
            Controls.Add(gbEvocacion);
            Controls.Add(btnAtencionCECancelar);
            Controls.Add(btnAtencionCEGuardar);
            Controls.Add(gbAtencionC2);
            Controls.Add(gbAtencionC);
            Name = "FormAtencionEvocacion";
            Text = "Atención-Cálculo y Evocación";
            gbAtencionC2.ResumeLayout(false);
            gbAtencionC2.PerformLayout();
            gbAtencionC.ResumeLayout(false);
            gbAtencionC.PerformLayout();
            gbEvocacion.ResumeLayout(false);
            gbEvocacion.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtencionCECancelar;
        private Button btnAtencionCEGuardar;
        private GroupBox gbAtencionC2;
        private ComboBox cbo4Puntuacion;
        private Label lblTextoAtencionC;
        private Label lbl4Hasta5;
        private Label lbl4;
        private GroupBox gbAtencionC;
        private Label lblAtencionCNro;
        private Label lblAtencionCPuntuación;
        private Label lblAtencionC;
        private Label lblAtencionCPAcum;
        private GroupBox gbEvocacion;
        private Label lblEvocacionNro;
        private Label lblEvocacionPuntuacion;
        private Label lblEvocacion;
        private Label lblEvocacionPAcum;
        private GroupBox groupBox1;
        private ComboBox cbo5Puntuacion;
        private Label lblTextoEvocacion;
        private Label lbl5Hasta3;
        private Label lbl5;
        private Button btnSiguienteAtencion;
        private Button btnAtrasAtencionCE;
        private ToolTip ttpMensajeAtencionCE;
    }
}