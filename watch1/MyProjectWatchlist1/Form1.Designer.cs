namespace MyProjectWatchlist1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hollwoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bollywoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cKDramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.animeToolStripMenuItem,
            this.cKDramaToolStripMenuItem,
            this.hollwoodToolStripMenuItem,
            this.bollywoodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hOMEToolStripMenuItem.Text = "Home";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // animeToolStripMenuItem
            // 
            this.animeToolStripMenuItem.Name = "animeToolStripMenuItem";
            this.animeToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.animeToolStripMenuItem.Text = "Anime";
            this.animeToolStripMenuItem.Click += new System.EventHandler(this.animeToolStripMenuItem_Click);
            // 
            // hollwoodToolStripMenuItem
            // 
            this.hollwoodToolStripMenuItem.Name = "hollwoodToolStripMenuItem";
            this.hollwoodToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.hollwoodToolStripMenuItem.Text = "Hollwood";
            this.hollwoodToolStripMenuItem.Click += new System.EventHandler(this.hollwoodToolStripMenuItem_Click);
            // 
            // bollywoodToolStripMenuItem
            // 
            this.bollywoodToolStripMenuItem.Name = "bollywoodToolStripMenuItem";
            this.bollywoodToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.bollywoodToolStripMenuItem.Text = "Bollywood";
            this.bollywoodToolStripMenuItem.Click += new System.EventHandler(this.bollywoodToolStripMenuItem_Click);
            // 
            // cKDramaToolStripMenuItem
            // 
            this.cKDramaToolStripMenuItem.Name = "cKDramaToolStripMenuItem";
            this.cKDramaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.cKDramaToolStripMenuItem.Text = "C/K Drama";
            this.cKDramaToolStripMenuItem.Click += new System.EventHandler(this.cKDramaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 793);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hollwoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bollywoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cKDramaToolStripMenuItem;
    }
}

