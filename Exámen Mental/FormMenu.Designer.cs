namespace Exámen_Mental
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            lblExamenMentalAbreviado = new Label();
            lblDescripcionMini = new Label();
            btnIniciarExamen = new Button();
            btnNuevoRegistro = new Button();
            btnMenuSalir = new Button();
            ttpMensajeMenu = new ToolTip(components);
            SuspendLayout();
            // 
            // lblExamenMentalAbreviado
            // 
            lblExamenMentalAbreviado.AutoSize = true;
            lblExamenMentalAbreviado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblExamenMentalAbreviado.Location = new Point(281, 50);
            lblExamenMentalAbreviado.Name = "lblExamenMentalAbreviado";
            lblExamenMentalAbreviado.Size = new Size(272, 30);
            lblExamenMentalAbreviado.TabIndex = 9;
            lblExamenMentalAbreviado.Text = "Exámen Mental Abreviado";
            lblExamenMentalAbreviado.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescripcionMini
            // 
            lblDescripcionMini.AutoSize = true;
            lblDescripcionMini.Font = new Font("MS PGothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcionMini.Location = new Point(64, 114);
            lblDescripcionMini.Name = "lblDescripcionMini";
            lblDescripcionMini.Size = new Size(703, 152);
            lblDescripcionMini.TabIndex = 10;
            lblDescripcionMini.Text = resources.GetString("lblDescripcionMini.Text");
            lblDescripcionMini.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciarExamen
            // 
            btnIniciarExamen.BackColor = SystemColors.ActiveCaption;
            btnIniciarExamen.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIniciarExamen.Location = new Point(261, 291);
            btnIniciarExamen.Name = "btnIniciarExamen";
            btnIniciarExamen.Size = new Size(320, 87);
            btnIniciarExamen.TabIndex = 11;
            btnIniciarExamen.Text = "Iniciar Exámen";
            ttpMensajeMenu.SetToolTip(btnIniciarExamen, "Iniciar test mental");
            btnIniciarExamen.UseVisualStyleBackColor = false;
            btnIniciarExamen.Click += btnIniciarExamen_Click;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = SystemColors.GradientInactiveCaption;
            btnNuevoRegistro.Image = (Image)resources.GetObject("btnNuevoRegistro.Image");
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.Location = new Point(22, 12);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(131, 36);
            btnNuevoRegistro.TabIndex = 12;
            btnNuevoRegistro.Text = "        Nuevo Registro";
            ttpMensajeMenu.SetToolTip(btnNuevoRegistro, "Realizar nuevo registro");
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            btnNuevoRegistro.Click += btnNuevoRegistro_Click;
            // 
            // btnMenuSalir
            // 
            btnMenuSalir.BackColor = SystemColors.ScrollBar;
            btnMenuSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuSalir.Location = new Point(381, 393);
            btnMenuSalir.Name = "btnMenuSalir";
            btnMenuSalir.Size = new Size(84, 34);
            btnMenuSalir.TabIndex = 13;
            btnMenuSalir.Text = "Salir";
            btnMenuSalir.UseVisualStyleBackColor = false;
            btnMenuSalir.Click += btnMenuSalir_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenuSalir);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(btnIniciarExamen);
            Controls.Add(lblDescripcionMini);
            Controls.Add(lblExamenMentalAbreviado);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "Menu Examen Mental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExamenMentalAbreviado;
        private Label lblDescripcionMini;
        private Button btnIniciarExamen;
        private Button btnNuevoRegistro;
        private Button btnMenuSalir;
        private ToolTip ttpMensajeMenu;
    }
}