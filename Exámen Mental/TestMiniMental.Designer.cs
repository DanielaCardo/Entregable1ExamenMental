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
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            atenciónYCálculoToolStripMenuItem = new ToolStripMenuItem();
            evocaciónToolStripMenuItem = new ToolStripMenuItem();
            lenguajeToolStripMenuItem = new ToolStripMenuItem();
            sección1ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, atenciónYCálculoToolStripMenuItem, lenguajeToolStripMenuItem, evocaciónToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(766, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { sección1ToolStripMenuItem });
            fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(81, 20);
            fileMenu.Text = "Orientación";
            // 
            // editMenu
            // 
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(67, 20);
            editMenu.Text = "Memoria";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1 });
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
            // atenciónYCálculoToolStripMenuItem
            // 
            atenciónYCálculoToolStripMenuItem.Name = "atenciónYCálculoToolStripMenuItem";
            atenciónYCálculoToolStripMenuItem.Size = new Size(119, 20);
            atenciónYCálculoToolStripMenuItem.Text = "Atención y Cálculo";
            // 
            // evocaciónToolStripMenuItem
            // 
            evocaciónToolStripMenuItem.Name = "evocaciónToolStripMenuItem";
            evocaciónToolStripMenuItem.Size = new Size(73, 20);
            evocaciónToolStripMenuItem.Text = "Evocación";
            // 
            // lenguajeToolStripMenuItem
            // 
            lenguajeToolStripMenuItem.Name = "lenguajeToolStripMenuItem";
            lenguajeToolStripMenuItem.Size = new Size(67, 20);
            lenguajeToolStripMenuItem.Text = "Lenguaje";
            // 
            // sección1ToolStripMenuItem
            // 
            sección1ToolStripMenuItem.Name = "sección1ToolStripMenuItem";
            sección1ToolStripMenuItem.Size = new Size(180, 22);
            sección1ToolStripMenuItem.Text = "Sección1";
            // 
            // TestMiniMental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 523);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem sección1ToolStripMenuItem;
        private ToolStripMenuItem atenciónYCálculoToolStripMenuItem;
        private ToolStripMenuItem evocaciónToolStripMenuItem;
        private ToolStripMenuItem lenguajeToolStripMenuItem;
    }
}



