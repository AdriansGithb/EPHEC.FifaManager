namespace MatchManager_UI
{
    partial class frmMM_HomePage
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
            this.inscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feuillesDeMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionsToolStripMenuItem,
            this.feuillesDeMatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inscriptionsToolStripMenuItem
            // 
            this.inscriptionsToolStripMenuItem.Name = "inscriptionsToolStripMenuItem";
            this.inscriptionsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.inscriptionsToolStripMenuItem.Text = "Inscriptions";
            this.inscriptionsToolStripMenuItem.Click += new System.EventHandler(this.inscriptionsToolStripMenuItem_Click);
            // 
            // feuillesDeMatchToolStripMenuItem
            // 
            this.feuillesDeMatchToolStripMenuItem.Name = "feuillesDeMatchToolStripMenuItem";
            this.feuillesDeMatchToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.feuillesDeMatchToolStripMenuItem.Text = "Feuilles de match";
            this.feuillesDeMatchToolStripMenuItem.Click += new System.EventHandler(this.feuillesDeMatchToolStripMenuItem_Click);
            // 
            // frmMM_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMM_HomePage";
            this.Text = "MatchManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feuillesDeMatchToolStripMenuItem;
    }
}