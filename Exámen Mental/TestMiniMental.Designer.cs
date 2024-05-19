namespace Exámen_Mental
{
    partial class TestMiniMental
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMiniMental));
            menuStrip = new MenuStrip();
            examenFísicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            BtnIniciarExamen = new Button();
            lblDescripcionMiniMental = new Label();
            lblDescripcionMini = new Label();
            lblExamenMentalAbreviado = new Label();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { examenFísicoToolStripMenuItem, verToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(766, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // examenFísicoToolStripMenuItem
            // 
            examenFísicoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            examenFísicoToolStripMenuItem.Name = "examenFísicoToolStripMenuItem";
            examenFísicoToolStripMenuItem.Size = new Size(94, 20);
            examenFísicoToolStripMenuItem.Text = "&Examen Físico";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(155, 22);
            toolStripMenuItem1.Text = "Nuevo Registro";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "&Ver";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripButton1 });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(766, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(766, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Estado";
            // 
            // BtnIniciarExamen
            // 
            BtnIniciarExamen.BackColor = SystemColors.GradientActiveCaption;
            BtnIniciarExamen.Font = new Font("Arial", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            BtnIniciarExamen.ForeColor = SystemColors.ActiveCaptionText;
            BtnIniciarExamen.Location = new Point(31, 274);
            BtnIniciarExamen.Name = "BtnIniciarExamen";
            BtnIniciarExamen.Size = new Size(712, 181);
            BtnIniciarExamen.TabIndex = 4;
            BtnIniciarExamen.Text = "Iniciar Exámen";
            BtnIniciarExamen.UseVisualStyleBackColor = false;
            BtnIniciarExamen.Click += btnIniciarExamen_Click_1;
            // 
            // lblDescripcionMiniMental
            // 
            lblDescripcionMiniMental.AutoSize = true;
            lblDescripcionMiniMental.Location = new Point(259, 141);
            lblDescripcionMiniMental.Name = "lblDescripcionMiniMental";
            lblDescripcionMiniMental.Size = new Size(0, 15);
            lblDescripcionMiniMental.TabIndex = 5;
            // 
            // lblDescripcionMini
            // 
            lblDescripcionMini.AutoSize = true;
            lblDescripcionMini.Font = new Font("MS PGothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcionMini.Location = new Point(31, 110);
            lblDescripcionMini.Name = "lblDescripcionMini";
            lblDescripcionMini.Size = new Size(703, 152);
            lblDescripcionMini.TabIndex = 7;
            lblDescripcionMini.Text = resources.GetString("lblDescripcionMini.Text");
            lblDescripcionMini.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExamenMentalAbreviado
            // 
            lblExamenMentalAbreviado.AutoSize = true;
            lblExamenMentalAbreviado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblExamenMentalAbreviado.Location = new Point(259, 59);
            lblExamenMentalAbreviado.Name = "lblExamenMentalAbreviado";
            lblExamenMentalAbreviado.Size = new Size(272, 30);
            lblExamenMentalAbreviado.TabIndex = 8;
            lblExamenMentalAbreviado.Text = "Exámen Mental Abreviado";
            lblExamenMentalAbreviado.TextAlign = ContentAlignment.TopCenter;
            // 
            // TestMiniMental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 523);
            Controls.Add(lblExamenMentalAbreviado);
            Controls.Add(lblDescripcionMini);
            Controls.Add(lblDescripcionMiniMental);
            Controls.Add(BtnIniciarExamen);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            ImeMode = ImeMode.Hiragana;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TestMiniMental";
            Text = "ExamenMental";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private Button BtnIniciarExamen;
        private ToolStripMenuItem examenFísicoToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label lblDescripcionMiniMental;
        private ToolStripButton toolStripButton1;
        private Label lblDescripcionMini;
        private Label lblExamenMentalAbreviado;
    }
}



