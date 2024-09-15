namespace Exámen_Mental
{
    partial class FormMemoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemoria));
            gbMemoria = new GroupBox();
            lblMemoriaNro = new Label();
            lblMemoriaPuntuación = new Label();
            lblMemoria = new Label();
            lblMemoriaPAcum = new Label();
            gbMemoria2 = new GroupBox();
            cbo3Puntuacion = new ComboBox();
            lblTextoMemoria = new Label();
            lbl3Hasta3 = new Label();
            lbl3 = new Label();
            btnMemoriaGuardar = new Button();
            btnMemoriaCancelar = new Button();
            btnSiguienteMemoria = new Button();
            btnAtrasMemoria = new Button();
            ttpMensajeMemoria = new ToolTip(components);
            gbMemoria.SuspendLayout();
            gbMemoria2.SuspendLayout();
            SuspendLayout();
            // 
            // gbMemoria
            // 
            gbMemoria.BackColor = SystemColors.ActiveCaption;
            gbMemoria.Controls.Add(lblMemoriaNro);
            gbMemoria.Controls.Add(lblMemoriaPuntuación);
            gbMemoria.Controls.Add(lblMemoria);
            gbMemoria.Controls.Add(lblMemoriaPAcum);
            gbMemoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbMemoria.Location = new Point(39, 46);
            gbMemoria.Name = "gbMemoria";
            gbMemoria.Size = new Size(713, 62);
            gbMemoria.TabIndex = 1;
            gbMemoria.TabStop = false;
            // 
            // lblMemoriaNro
            // 
            lblMemoriaNro.AutoSize = true;
            lblMemoriaNro.Location = new Point(6, 19);
            lblMemoriaNro.Name = "lblMemoriaNro";
            lblMemoriaNro.Size = new Size(30, 17);
            lblMemoriaNro.TabIndex = 0;
            lblMemoriaNro.Text = "No.";
            // 
            // lblMemoriaPuntuación
            // 
            lblMemoriaPuntuación.AutoSize = true;
            lblMemoriaPuntuación.Location = new Point(613, 19);
            lblMemoriaPuntuación.Name = "lblMemoriaPuntuación";
            lblMemoriaPuntuación.Size = new Size(78, 17);
            lblMemoriaPuntuación.TabIndex = 3;
            lblMemoriaPuntuación.Text = "Puntuación";
            // 
            // lblMemoria
            // 
            lblMemoria.AutoSize = true;
            lblMemoria.Location = new Point(351, 19);
            lblMemoria.Name = "lblMemoria";
            lblMemoria.Size = new Size(63, 17);
            lblMemoria.TabIndex = 2;
            lblMemoria.Text = "Memoria";
            // 
            // lblMemoriaPAcum
            // 
            lblMemoriaPAcum.AutoSize = true;
            lblMemoriaPAcum.Location = new Point(57, 19);
            lblMemoriaPAcum.Name = "lblMemoriaPAcum";
            lblMemoriaPAcum.Size = new Size(78, 34);
            lblMemoriaPAcum.TabIndex = 1;
            lblMemoriaPAcum.Text = "   Puntaje \r\nAcumulado";
            // 
            // gbMemoria2
            // 
            gbMemoria2.BackColor = SystemColors.GradientInactiveCaption;
            gbMemoria2.Controls.Add(cbo3Puntuacion);
            gbMemoria2.Controls.Add(lblTextoMemoria);
            gbMemoria2.Controls.Add(lbl3Hasta3);
            gbMemoria2.Controls.Add(lbl3);
            gbMemoria2.Location = new Point(39, 114);
            gbMemoria2.Name = "gbMemoria2";
            gbMemoria2.Size = new Size(713, 98);
            gbMemoria2.TabIndex = 2;
            gbMemoria2.TabStop = false;
            // 
            // cbo3Puntuacion
            // 
            cbo3Puntuacion.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3" });
            cbo3Puntuacion.FormattingEnabled = true;
            cbo3Puntuacion.Items.AddRange(new object[] { "0", "1", "2", "3" });
            cbo3Puntuacion.Location = new Point(613, 39);
            cbo3Puntuacion.Name = "cbo3Puntuacion";
            cbo3Puntuacion.Size = new Size(94, 23);
            cbo3Puntuacion.TabIndex = 4;
            // 
            // lblTextoMemoria
            // 
            lblTextoMemoria.AutoSize = true;
            lblTextoMemoria.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTextoMemoria.Location = new Point(169, 19);
            lblTextoMemoria.Name = "lblTextoMemoria";
            lblTextoMemoria.Size = new Size(412, 60);
            lblTextoMemoria.TabIndex = 2;
            lblTextoMemoria.Text = resources.GetString("lblTextoMemoria.Text");
            // 
            // lbl3Hasta3
            // 
            lbl3Hasta3.AutoSize = true;
            lbl3Hasta3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3Hasta3.Location = new Point(85, 45);
            lbl3Hasta3.Name = "lbl3Hasta3";
            lbl3Hasta3.Size = new Size(20, 17);
            lbl3Hasta3.TabIndex = 1;
            lbl3Hasta3.Text = "/3";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(20, 47);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(16, 15);
            lbl3.TabIndex = 0;
            lbl3.Text = "3.";
            // 
            // btnMemoriaGuardar
            // 
            btnMemoriaGuardar.BackColor = Color.FromArgb(255, 224, 192);
            btnMemoriaGuardar.Location = new Point(421, 238);
            btnMemoriaGuardar.Name = "btnMemoriaGuardar";
            btnMemoriaGuardar.Size = new Size(83, 35);
            btnMemoriaGuardar.TabIndex = 4;
            btnMemoriaGuardar.Text = "&Guardar";
            ttpMensajeMemoria.SetToolTip(btnMemoriaGuardar, "Guardar respuesta");
            btnMemoriaGuardar.UseVisualStyleBackColor = false;
            btnMemoriaGuardar.Click += btnMemoriaGuardar_Click;
            // 
            // btnMemoriaCancelar
            // 
            btnMemoriaCancelar.BackColor = SystemColors.ControlLight;
            btnMemoriaCancelar.Location = new Point(309, 238);
            btnMemoriaCancelar.Name = "btnMemoriaCancelar";
            btnMemoriaCancelar.Size = new Size(83, 35);
            btnMemoriaCancelar.TabIndex = 5;
            btnMemoriaCancelar.Text = "&Cancelar";
            ttpMensajeMemoria.SetToolTip(btnMemoriaCancelar, "Cancelar formulario ");
            btnMemoriaCancelar.UseVisualStyleBackColor = false;
            btnMemoriaCancelar.Click += btnMemoriaCancelar_Click;
            // 
            // btnSiguienteMemoria
            // 
            btnSiguienteMemoria.BackColor = SystemColors.Window;
            btnSiguienteMemoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiguienteMemoria.Location = new Point(538, 258);
            btnSiguienteMemoria.Name = "btnSiguienteMemoria";
            btnSiguienteMemoria.Size = new Size(82, 35);
            btnSiguienteMemoria.TabIndex = 17;
            btnSiguienteMemoria.Text = "Siguiente >";
            ttpMensajeMemoria.SetToolTip(btnSiguienteMemoria, "Pasar al siguiente formulario");
            btnSiguienteMemoria.UseVisualStyleBackColor = false;
            btnSiguienteMemoria.Click += btnSiguienteMemoria_Click;
            // 
            // btnAtrasMemoria
            // 
            btnAtrasMemoria.BackColor = SystemColors.Window;
            btnAtrasMemoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtrasMemoria.Location = new Point(190, 258);
            btnAtrasMemoria.Name = "btnAtrasMemoria";
            btnAtrasMemoria.Size = new Size(85, 35);
            btnAtrasMemoria.TabIndex = 18;
            btnAtrasMemoria.Text = "< Atrás";
            ttpMensajeMemoria.SetToolTip(btnAtrasMemoria, "Regresar al formulario anterior");
            btnAtrasMemoria.UseVisualStyleBackColor = false;
            btnAtrasMemoria.Click += btnAtrasMemoria_Click;
            // 
            // FormMemoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtrasMemoria);
            Controls.Add(btnSiguienteMemoria);
            Controls.Add(btnMemoriaCancelar);
            Controls.Add(btnMemoriaGuardar);
            Controls.Add(gbMemoria2);
            Controls.Add(gbMemoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMemoria";
            Text = "Memoria";
            gbMemoria.ResumeLayout(false);
            gbMemoria.PerformLayout();
            gbMemoria2.ResumeLayout(false);
            gbMemoria2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMemoria;
        private Label lblMemoriaNro;
        private Label lblMemoriaPuntuación;
        private Label lblMemoria;
        private Label lblMemoriaPAcum;
        private GroupBox gbMemoria2;
        private Label lblTextoMemoria;
        private Label lbl3Hasta3;
        private Label lbl3;
        private ComboBox cbo3Puntuacion;
        private Button btnMemoriaGuardar;
        private Button btnMemoriaCancelar;
        private Button btnSiguienteMemoria;
        private Button btnAtrasMemoria;
        private ToolTip ttpMensajeMemoria;
    }
}