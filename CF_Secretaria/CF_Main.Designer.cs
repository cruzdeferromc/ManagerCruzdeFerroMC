namespace CF_Secretaria
{
    partial class CF_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CF_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gERENCIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNTEGRANTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eVENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEUNIÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gERENCIARToolStripMenuItem,
            this.rEUNIÃOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gERENCIARToolStripMenuItem
            // 
            this.gERENCIARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fACÇÕESToolStripMenuItem,
            this.iNTEGRANTESToolStripMenuItem,
            this.eVENTOSToolStripMenuItem});
            this.gERENCIARToolStripMenuItem.Name = "gERENCIARToolStripMenuItem";
            this.gERENCIARToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.gERENCIARToolStripMenuItem.Text = "GERENCIAR";
            // 
            // fACÇÕESToolStripMenuItem
            // 
            this.fACÇÕESToolStripMenuItem.Name = "fACÇÕESToolStripMenuItem";
            this.fACÇÕESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fACÇÕESToolStripMenuItem.Text = "FACÇÕES";
            // 
            // iNTEGRANTESToolStripMenuItem
            // 
            this.iNTEGRANTESToolStripMenuItem.Name = "iNTEGRANTESToolStripMenuItem";
            this.iNTEGRANTESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iNTEGRANTESToolStripMenuItem.Text = "INTEGRANTES";
            this.iNTEGRANTESToolStripMenuItem.Click += new System.EventHandler(this.iNTEGRANTESToolStripMenuItem_Click);
            // 
            // eVENTOSToolStripMenuItem
            // 
            this.eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            this.eVENTOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eVENTOSToolStripMenuItem.Text = "EVENTOS";
            this.eVENTOSToolStripMenuItem.Click += new System.EventHandler(this.eVENTOSToolStripMenuItem_Click);
            // 
            // rEUNIÃOToolStripMenuItem
            // 
            this.rEUNIÃOToolStripMenuItem.Name = "rEUNIÃOToolStripMenuItem";
            this.rEUNIÃOToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.rEUNIÃOToolStripMenuItem.Text = "ATA";
            // 
            // CF_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 264);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CF_Main";
            this.Text = "Cruz de Ferro - Controle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gERENCIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNTEGRANTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eVENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEUNIÃOToolStripMenuItem;

    }
}

