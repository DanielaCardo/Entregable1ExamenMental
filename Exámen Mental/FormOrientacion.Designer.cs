namespace Exámen_Mental
{
    partial class FormOrientacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrientacion));
            gbOrientacion = new GroupBox();
            lblOrientaNro = new Label();
            lblOrientaPuntuación = new Label();
            lblOrientacion = new Label();
            lblOrientaPuntajeAcum = new Label();
            gbOrientacion2 = new GroupBox();
            cbo1Punt5 = new ComboBox();
            cbo1Punt4 = new ComboBox();
            cbo1Punt3 = new ComboBox();
            cbo1Punt2 = new ComboBox();
            cbo1Punt1 = new ComboBox();
            lbl1DigaEnQue = new Label();
            lbl5Hora = new Label();
            lbl4FechaHoy = new Label();
            lbl3Dia = new Label();
            lbl2Mes = new Label();
            lbl1Año = new Label();
            lbl1 = new Label();
            lbl1Hasta5 = new Label();
            groupBox1 = new GroupBox();
            cbo2Punt5 = new ComboBox();
            cbo2Punt4 = new ComboBox();
            cbo2Punt3 = new ComboBox();
            cbo2Punt2 = new ComboBox();
            cbo2Punt1 = new ComboBox();
            lbl2DigaEnQue = new Label();
            lblPisoBarrioVereda = new Label();
            lblSitioLugar = new Label();
            lbl2Departamento = new Label();
            lblCiudad = new Label();
            lblPais = new Label();
            lbl2 = new Label();
            lbl2Hasta5 = new Label();
            btnOrientaCancelar = new Button();
            btnOrientaGuardar = new Button();
            btnOrientaSiguiente = new Button();
            btnOrientaVolverMenu = new Button();
            ttpMensajeOrientacion = new ToolTip(components);
            gbOrientacion.SuspendLayout();
            gbOrientacion2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrientacion
            // 
            gbOrientacion.BackColor = SystemColors.ActiveCaption;
            gbOrientacion.Controls.Add(lblOrientaNro);
            gbOrientacion.Controls.Add(lblOrientaPuntuación);
            gbOrientacion.Controls.Add(lblOrientacion);
            gbOrientacion.Controls.Add(lblOrientaPuntajeAcum);
            gbOrientacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbOrientacion.Location = new Point(40, 28);
            gbOrientacion.Name = "gbOrientacion";
            gbOrientacion.Size = new Size(713, 61);
            gbOrientacion.TabIndex = 0;
            gbOrientacion.TabStop = false;
            // 
            // lblOrientaNro
            // 
            lblOrientaNro.AutoSize = true;
            lblOrientaNro.Location = new Point(18, 21);
            lblOrientaNro.Name = "lblOrientaNro";
            lblOrientaNro.Size = new Size(30, 17);
            lblOrientaNro.TabIndex = 0;
            lblOrientaNro.Text = "No.";
            // 
            // lblOrientaPuntuación
            // 
            lblOrientaPuntuación.AutoSize = true;
            lblOrientaPuntuación.Location = new Point(613, 19);
            lblOrientaPuntuación.Name = "lblOrientaPuntuación";
            lblOrientaPuntuación.Size = new Size(78, 17);
            lblOrientaPuntuación.TabIndex = 3;
            lblOrientaPuntuación.Text = "Puntuación";
            // 
            // lblOrientacion
            // 
            lblOrientacion.AutoSize = true;
            lblOrientacion.Location = new Point(305, 19);
            lblOrientacion.Name = "lblOrientacion";
            lblOrientacion.Size = new Size(80, 17);
            lblOrientacion.TabIndex = 2;
            lblOrientacion.Text = "Orientación";
            // 
            // lblOrientaPuntajeAcum
            // 
            lblOrientaPuntajeAcum.AutoSize = true;
            lblOrientaPuntajeAcum.Location = new Point(82, 19);
            lblOrientaPuntajeAcum.Name = "lblOrientaPuntajeAcum";
            lblOrientaPuntajeAcum.Size = new Size(78, 34);
            lblOrientaPuntajeAcum.TabIndex = 1;
            lblOrientaPuntajeAcum.Text = "   Puntaje \r\nAcumulado";
            // 
            // gbOrientacion2
            // 
            gbOrientacion2.BackColor = SystemColors.GradientInactiveCaption;
            gbOrientacion2.Controls.Add(cbo1Punt5);
            gbOrientacion2.Controls.Add(cbo1Punt4);
            gbOrientacion2.Controls.Add(cbo1Punt3);
            gbOrientacion2.Controls.Add(cbo1Punt2);
            gbOrientacion2.Controls.Add(cbo1Punt1);
            gbOrientacion2.Controls.Add(lbl1DigaEnQue);
            gbOrientacion2.Controls.Add(lbl5Hora);
            gbOrientacion2.Controls.Add(lbl4FechaHoy);
            gbOrientacion2.Controls.Add(lbl3Dia);
            gbOrientacion2.Controls.Add(lbl2Mes);
            gbOrientacion2.Controls.Add(lbl1Año);
            gbOrientacion2.Controls.Add(lbl1);
            gbOrientacion2.Controls.Add(lbl1Hasta5);
            gbOrientacion2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbOrientacion2.Location = new Point(40, 95);
            gbOrientacion2.Name = "gbOrientacion2";
            gbOrientacion2.Size = new Size(713, 153);
            gbOrientacion2.TabIndex = 1;
            gbOrientacion2.TabStop = false;
            // 
            // cbo1Punt5
            // 
            cbo1Punt5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo1Punt5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo1Punt5.FormattingEnabled = true;
            cbo1Punt5.Items.AddRange(new object[] { "0", "1" });
            cbo1Punt5.Location = new Point(592, 125);
            cbo1Punt5.Name = "cbo1Punt5";
            cbo1Punt5.Size = new Size(115, 23);
            cbo1Punt5.TabIndex = 12;
            // 
            // cbo1Punt4
            // 
            cbo1Punt4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo1Punt4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo1Punt4.FormattingEnabled = true;
            cbo1Punt4.Items.AddRange(new object[] { "0", "1" });
            cbo1Punt4.Location = new Point(592, 96);
            cbo1Punt4.Name = "cbo1Punt4";
            cbo1Punt4.Size = new Size(115, 23);
            cbo1Punt4.TabIndex = 11;
            // 
            // cbo1Punt3
            // 
            cbo1Punt3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo1Punt3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo1Punt3.FormattingEnabled = true;
            cbo1Punt3.Items.AddRange(new object[] { "0", "1" });
            cbo1Punt3.Location = new Point(592, 70);
            cbo1Punt3.Name = "cbo1Punt3";
            cbo1Punt3.Size = new Size(115, 23);
            cbo1Punt3.TabIndex = 10;
            // 
            // cbo1Punt2
            // 
            cbo1Punt2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo1Punt2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo1Punt2.FormattingEnabled = true;
            cbo1Punt2.Items.AddRange(new object[] { "0", "1" });
            cbo1Punt2.Location = new Point(592, 43);
            cbo1Punt2.Name = "cbo1Punt2";
            cbo1Punt2.Size = new Size(115, 23);
            cbo1Punt2.TabIndex = 9;
            // 
            // cbo1Punt1
            // 
            cbo1Punt1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo1Punt1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo1Punt1.FormattingEnabled = true;
            cbo1Punt1.Items.AddRange(new object[] { "0", "1" });
            cbo1Punt1.Location = new Point(592, 14);
            cbo1Punt1.Name = "cbo1Punt1";
            cbo1Punt1.Size = new Size(115, 23);
            cbo1Punt1.TabIndex = 8;
            // 
            // lbl1DigaEnQue
            // 
            lbl1DigaEnQue.AutoSize = true;
            lbl1DigaEnQue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1DigaEnQue.Location = new Point(222, 74);
            lbl1DigaEnQue.Name = "lbl1DigaEnQue";
            lbl1DigaEnQue.Size = new Size(70, 15);
            lbl1DigaEnQue.TabIndex = 7;
            lbl1DigaEnQue.Text = "Diga en qué";
            // 
            // lbl5Hora
            // 
            lbl5Hora.AutoSize = true;
            lbl5Hora.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5Hora.Location = new Point(328, 133);
            lbl5Hora.Name = "lbl5Hora";
            lbl5Hora.Size = new Size(45, 15);
            lbl5Hora.TabIndex = 6;
            lbl5Hora.Text = "5. Hora";
            // 
            // lbl4FechaHoy
            // 
            lbl4FechaHoy.AutoSize = true;
            lbl4FechaHoy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4FechaHoy.Location = new Point(328, 104);
            lbl4FechaHoy.Name = "lbl4FechaHoy";
            lbl4FechaHoy.Size = new Size(191, 15);
            lbl4FechaHoy.TabIndex = 5;
            lbl4FechaHoy.Text = "4. Fecha de hoy ( día de la semana)";
            // 
            // lbl3Dia
            // 
            lbl3Dia.AutoSize = true;
            lbl3Dia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3Dia.Location = new Point(328, 78);
            lbl3Dia.Name = "lbl3Dia";
            lbl3Dia.Size = new Size(36, 15);
            lbl3Dia.TabIndex = 4;
            lbl3Dia.Text = "3. Día";
            // 
            // lbl2Mes
            // 
            lbl2Mes.AutoSize = true;
            lbl2Mes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2Mes.Location = new Point(328, 51);
            lbl2Mes.Name = "lbl2Mes";
            lbl2Mes.Size = new Size(41, 15);
            lbl2Mes.TabIndex = 3;
            lbl2Mes.Text = "2. Mes";
            // 
            // lbl1Año
            // 
            lbl1Año.AutoSize = true;
            lbl1Año.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1Año.Location = new Point(328, 22);
            lbl1Año.Name = "lbl1Año";
            lbl1Año.Size = new Size(41, 15);
            lbl1Año.TabIndex = 2;
            lbl1Año.Text = "1. Año";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(32, 70);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(16, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "1.";
            // 
            // lbl1Hasta5
            // 
            lbl1Hasta5.AutoSize = true;
            lbl1Hasta5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1Hasta5.Location = new Point(111, 68);
            lbl1Hasta5.Name = "lbl1Hasta5";
            lbl1Hasta5.Size = new Size(19, 15);
            lbl1Hasta5.TabIndex = 1;
            lbl1Hasta5.Text = "/5";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(cbo2Punt5);
            groupBox1.Controls.Add(cbo2Punt4);
            groupBox1.Controls.Add(cbo2Punt3);
            groupBox1.Controls.Add(cbo2Punt2);
            groupBox1.Controls.Add(cbo2Punt1);
            groupBox1.Controls.Add(lbl2DigaEnQue);
            groupBox1.Controls.Add(lblPisoBarrioVereda);
            groupBox1.Controls.Add(lblSitioLugar);
            groupBox1.Controls.Add(lbl2Departamento);
            groupBox1.Controls.Add(lblCiudad);
            groupBox1.Controls.Add(lblPais);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(lbl2Hasta5);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(40, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 153);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // cbo2Punt5
            // 
            cbo2Punt5.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo2Punt5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo2Punt5.FormattingEnabled = true;
            cbo2Punt5.Items.AddRange(new object[] { "0", "1" });
            cbo2Punt5.Location = new Point(592, 124);
            cbo2Punt5.Name = "cbo2Punt5";
            cbo2Punt5.Size = new Size(115, 23);
            cbo2Punt5.TabIndex = 12;
            // 
            // cbo2Punt4
            // 
            cbo2Punt4.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo2Punt4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo2Punt4.FormattingEnabled = true;
            cbo2Punt4.Items.AddRange(new object[] { "0", "1" });
            cbo2Punt4.Location = new Point(592, 95);
            cbo2Punt4.Name = "cbo2Punt4";
            cbo2Punt4.Size = new Size(115, 23);
            cbo2Punt4.TabIndex = 11;
            // 
            // cbo2Punt3
            // 
            cbo2Punt3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo2Punt3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo2Punt3.FormattingEnabled = true;
            cbo2Punt3.Items.AddRange(new object[] { "0", "1" });
            cbo2Punt3.Location = new Point(592, 66);
            cbo2Punt3.Name = "cbo2Punt3";
            cbo2Punt3.Size = new Size(115, 23);
            cbo2Punt3.TabIndex = 10;
            // 
            // cbo2Punt2
            // 
            cbo2Punt2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo2Punt2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo2Punt2.FormattingEnabled = true;
            cbo2Punt2.Items.AddRange(new object[] { "0", "1" });
            cbo2Punt2.Location = new Point(592, 37);
            cbo2Punt2.Name = "cbo2Punt2";
            cbo2Punt2.Size = new Size(115, 23);
            cbo2Punt2.TabIndex = 9;
            // 
            // cbo2Punt1
            // 
            cbo2Punt1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo2Punt1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbo2Punt1.FormattingEnabled = true;
            cbo2Punt1.Items.AddRange(new object[] { "0", "1" });
            cbo2Punt1.Location = new Point(592, 9);
            cbo2Punt1.Name = "cbo2Punt1";
            cbo2Punt1.Size = new Size(115, 23);
            cbo2Punt1.TabIndex = 8;
            // 
            // lbl2DigaEnQue
            // 
            lbl2DigaEnQue.AutoSize = true;
            lbl2DigaEnQue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2DigaEnQue.Location = new Point(222, 74);
            lbl2DigaEnQue.Name = "lbl2DigaEnQue";
            lbl2DigaEnQue.Size = new Size(70, 15);
            lbl2DigaEnQue.TabIndex = 7;
            lbl2DigaEnQue.Text = "Diga en qué";
            // 
            // lblPisoBarrioVereda
            // 
            lblPisoBarrioVereda.AutoSize = true;
            lblPisoBarrioVereda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPisoBarrioVereda.Location = new Point(328, 130);
            lblPisoBarrioVereda.Name = "lblPisoBarrioVereda";
            lblPisoBarrioVereda.Size = new Size(135, 15);
            lblPisoBarrioVereda.TabIndex = 6;
            lblPisoBarrioVereda.Text = "10. Piso / Barrio / Vereda";
            // 
            // lblSitioLugar
            // 
            lblSitioLugar.AutoSize = true;
            lblSitioLugar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSitioLugar.Location = new Point(328, 101);
            lblSitioLugar.Name = "lblSitioLugar";
            lblSitioLugar.Size = new Size(85, 15);
            lblSitioLugar.TabIndex = 5;
            lblSitioLugar.Text = "9. Sitio o Lugar";
            // 
            // lbl2Departamento
            // 
            lbl2Departamento.AutoSize = true;
            lbl2Departamento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2Departamento.Location = new Point(328, 72);
            lbl2Departamento.Name = "lbl2Departamento";
            lbl2Departamento.Size = new Size(95, 15);
            lbl2Departamento.TabIndex = 4;
            lbl2Departamento.Text = "8. Departamento";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudad.Location = new Point(328, 43);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(57, 15);
            lblCiudad.TabIndex = 3;
            lblCiudad.Text = "7. Ciudad";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPais.Location = new Point(328, 15);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(40, 15);
            lblPais.TabIndex = 2;
            lblPais.Text = "6. Pais";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(32, 70);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(16, 15);
            lbl2.TabIndex = 0;
            lbl2.Text = "2.";
            // 
            // lbl2Hasta5
            // 
            lbl2Hasta5.AutoSize = true;
            lbl2Hasta5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2Hasta5.Location = new Point(113, 72);
            lbl2Hasta5.Name = "lbl2Hasta5";
            lbl2Hasta5.Size = new Size(19, 15);
            lbl2Hasta5.TabIndex = 1;
            lbl2Hasta5.Text = "/5";
            // 
            // btnOrientaCancelar
            // 
            btnOrientaCancelar.BackColor = SystemColors.ControlLight;
            btnOrientaCancelar.Location = new Point(262, 430);
            btnOrientaCancelar.Name = "btnOrientaCancelar";
            btnOrientaCancelar.Size = new Size(83, 32);
            btnOrientaCancelar.TabIndex = 14;
            btnOrientaCancelar.Text = "&Cancelar";
            ttpMensajeOrientacion.SetToolTip(btnOrientaCancelar, "Cancelar formulario");
            btnOrientaCancelar.UseVisualStyleBackColor = false;
            btnOrientaCancelar.Click += btnOrientaCancelar_Click;
            // 
            // btnOrientaGuardar
            // 
            btnOrientaGuardar.BackColor = Color.FromArgb(255, 224, 192);
            btnOrientaGuardar.Location = new Point(368, 430);
            btnOrientaGuardar.Name = "btnOrientaGuardar";
            btnOrientaGuardar.Size = new Size(83, 32);
            btnOrientaGuardar.TabIndex = 15;
            btnOrientaGuardar.Text = "&Guardar";
            ttpMensajeOrientacion.SetToolTip(btnOrientaGuardar, "Guardar respuestas");
            btnOrientaGuardar.UseVisualStyleBackColor = false;
            btnOrientaGuardar.Click += btnOrientaGuardar_Click;
            // 
            // btnOrientaSiguiente
            // 
            btnOrientaSiguiente.BackColor = SystemColors.Window;
            btnOrientaSiguiente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrientaSiguiente.Location = new Point(482, 446);
            btnOrientaSiguiente.Name = "btnOrientaSiguiente";
            btnOrientaSiguiente.Size = new Size(90, 35);
            btnOrientaSiguiente.TabIndex = 16;
            btnOrientaSiguiente.Text = "Siguiente >";
            ttpMensajeOrientacion.SetToolTip(btnOrientaSiguiente, "Pasar al siguiente formulario");
            btnOrientaSiguiente.UseVisualStyleBackColor = false;
            btnOrientaSiguiente.Click += btnOrientaSiguiente_Click_1;
            // 
            // btnOrientaVolverMenu
            // 
            btnOrientaVolverMenu.BackColor = SystemColors.Window;
            btnOrientaVolverMenu.Location = new Point(151, 446);
            btnOrientaVolverMenu.Name = "btnOrientaVolverMenu";
            btnOrientaVolverMenu.Size = new Size(86, 35);
            btnOrientaVolverMenu.TabIndex = 20;
            btnOrientaVolverMenu.Text = "<< Menu ";
            ttpMensajeOrientacion.SetToolTip(btnOrientaVolverMenu, "Regresar a menu principal");
            btnOrientaVolverMenu.UseVisualStyleBackColor = false;
            btnOrientaVolverMenu.Click += btnOrientaVolverMenu_Click;
            // 
            // FormOrientacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(btnOrientaVolverMenu);
            Controls.Add(btnOrientaSiguiente);
            Controls.Add(btnOrientaGuardar);
            Controls.Add(btnOrientaCancelar);
            Controls.Add(groupBox1);
            Controls.Add(gbOrientacion2);
            Controls.Add(gbOrientacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOrientacion";
            Text = "Orientación";
            gbOrientacion.ResumeLayout(false);
            gbOrientacion.PerformLayout();
            gbOrientacion2.ResumeLayout(false);
            gbOrientacion2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbOrientacion;
        private Label lblOrientaNro;
        private Label lblOrientaPuntajeAcum;
        private GroupBox gbOrientacion2;
        private Label lblOrientaPuntuación;
        private Label lblOrientacion;
        private Label lbl1Hasta5;
        private Label lbl5Hora;
        private Label lbl4FechaHoy;
        private Label lbl3Dia;
        private Label lbl2Mes;
        private Label lbl1Año;
        private Label lbl1;
        private ComboBox cbo1Punt1;
        private Label lbl1DigaEnQue;
        private ComboBox cbo1Punt5;
        private ComboBox cbo1Punt4;
        private ComboBox cbo1Punt3;
        private ComboBox cbo1Punt2;
        private GroupBox groupBox1;
        private ComboBox cbo2Punt5;
        private ComboBox cbo2Punt4;
        private ComboBox cbo2Punt3;
        private ComboBox cbo2Punt2;
        private Label lbl2DigaEnQue;
        private Label lblPisoBarrioVereda;
        private Label lblSitioLugar;
        private Label lbl2Departamento;
        private Label lblCiudad;
        private Label lblPais;
        private Label lbl2;
        private Label lbl2Hasta5;
        private ComboBox cbo2Punt1;
        private Button btnOrientaCancelar;
        private Button btnOrientaGuardar;
        private Button btnOrientaSiguiente;
        private Button btnOrientaVolverMenu;
        private ToolTip ttpMensajeOrientacion;
    }
}