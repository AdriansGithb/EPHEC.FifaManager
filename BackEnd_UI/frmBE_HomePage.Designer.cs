namespace BackEnd_UI
{
    partial class frmBE_HomePage
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
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVoirClssmnt = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnResults = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.générerUnCalendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDéquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrireTransférerUnJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLhistoriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesCartonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classementToolStripMenuItem,
            this.matchToolStripMenuItem,
            this.calendrierToolStripMenuItem,
            this.gestionDéquipesToolStripMenuItem,
            this.joueursToolStripMenuItem,
            this.cartonsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnVoirClssmnt});
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.classementToolStripMenuItem.Text = "Classement";
            // 
            // mnVoirClssmnt
            // 
            this.mnVoirClssmnt.Name = "mnVoirClssmnt";
            this.mnVoirClssmnt.Size = new System.Drawing.Size(168, 22);
            this.mnVoirClssmnt.Text = "Voir le classement";
            this.mnVoirClssmnt.Click += new System.EventHandler(this.mn_VoirClassement_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnResults});
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.matchToolStripMenuItem.Text = "Match";
            // 
            // mnResults
            // 
            this.mnResults.Name = "mnResults";
            this.mnResults.Size = new System.Drawing.Size(208, 22);
            this.mnResults.Text = "Voir/Modifier les résultats";
            this.mnResults.Click += new System.EventHandler(this.mnResults_Click);
            // 
            // calendrierToolStripMenuItem
            // 
            this.calendrierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.générerUnCalendrierToolStripMenuItem});
            this.calendrierToolStripMenuItem.Name = "calendrierToolStripMenuItem";
            this.calendrierToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calendrierToolStripMenuItem.Text = "Calendrier";
            // 
            // générerUnCalendrierToolStripMenuItem
            // 
            this.générerUnCalendrierToolStripMenuItem.Name = "générerUnCalendrierToolStripMenuItem";
            this.générerUnCalendrierToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.générerUnCalendrierToolStripMenuItem.Text = "Gestion de calendrier";
            this.générerUnCalendrierToolStripMenuItem.Click += new System.EventHandler(this.mn_gnrClndr_Click);
            // 
            // gestionDéquipesToolStripMenuItem
            // 
            this.gestionDéquipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscrireTransférerUnJoueurToolStripMenuItem});
            this.gestionDéquipesToolStripMenuItem.Name = "gestionDéquipesToolStripMenuItem";
            this.gestionDéquipesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.gestionDéquipesToolStripMenuItem.Text = "Gestion d\'équipes";
            // 
            // inscrireTransférerUnJoueurToolStripMenuItem
            // 
            this.inscrireTransférerUnJoueurToolStripMenuItem.Name = "inscrireTransférerUnJoueurToolStripMenuItem";
            this.inscrireTransférerUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.inscrireTransférerUnJoueurToolStripMenuItem.Text = "Inscrire/Transférer un joueur";
            // 
            // joueursToolStripMenuItem
            // 
            this.joueursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLhistoriqueToolStripMenuItem});
            this.joueursToolStripMenuItem.Name = "joueursToolStripMenuItem";
            this.joueursToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.joueursToolStripMenuItem.Text = "Joueurs";
            // 
            // voirLhistoriqueToolStripMenuItem
            // 
            this.voirLhistoriqueToolStripMenuItem.Name = "voirLhistoriqueToolStripMenuItem";
            this.voirLhistoriqueToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.voirLhistoriqueToolStripMenuItem.Text = "Voir l\'historique";
            // 
            // cartonsToolStripMenuItem
            // 
            this.cartonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesCartonsToolStripMenuItem});
            this.cartonsToolStripMenuItem.Name = "cartonsToolStripMenuItem";
            this.cartonsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cartonsToolStripMenuItem.Text = "Cartons";
            // 
            // voirLesCartonsToolStripMenuItem
            // 
            this.voirLesCartonsToolStripMenuItem.Name = "voirLesCartonsToolStripMenuItem";
            this.voirLesCartonsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.voirLesCartonsToolStripMenuItem.Text = "Voir les cartons";
            // 
            // frmBE_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 432);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBE_HomePage";
            this.Text = "BackEnd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnVoirClssmnt;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnResults;
        private System.Windows.Forms.ToolStripMenuItem calendrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem générerUnCalendrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDéquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrireTransférerUnJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLhistoriqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesCartonsToolStripMenuItem;
    }
}

