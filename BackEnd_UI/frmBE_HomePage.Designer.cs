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
            this.mnItem_VoirClssmnt = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItem_Results = new System.Windows.Forms.ToolStripMenuItem();
            this.calendrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItem_GénérerCalendrier = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDéquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItem_InscrireJoueurs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItem_TransfererJoueur = new System.Windows.Forms.ToolStripMenuItem();
            this.joueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItem_HistoriqueJoueur = new System.Windows.Forms.ToolStripMenuItem();
            this.cartonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItem_Cartons = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnItem_VoirClssmnt});
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.classementToolStripMenuItem.Text = "Classement";
            // 
            // mnItem_VoirClssmnt
            // 
            this.mnItem_VoirClssmnt.Name = "mnItem_VoirClssmnt";
            this.mnItem_VoirClssmnt.Size = new System.Drawing.Size(168, 22);
            this.mnItem_VoirClssmnt.Text = "Voir le classement";
            this.mnItem_VoirClssmnt.Click += new System.EventHandler(this.mn_VoirClassement_Click);
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItem_Results});
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.matchToolStripMenuItem.Text = "Match";
            // 
            // mnItem_Results
            // 
            this.mnItem_Results.Name = "mnItem_Results";
            this.mnItem_Results.Size = new System.Drawing.Size(208, 22);
            this.mnItem_Results.Text = "Voir/Modifier les résultats";
            this.mnItem_Results.Click += new System.EventHandler(this.mn_Results_Click);
            // 
            // calendrierToolStripMenuItem
            // 
            this.calendrierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItem_GénérerCalendrier});
            this.calendrierToolStripMenuItem.Name = "calendrierToolStripMenuItem";
            this.calendrierToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calendrierToolStripMenuItem.Text = "Calendrier";
            // 
            // mnItem_GénérerCalendrier
            // 
            this.mnItem_GénérerCalendrier.Name = "mnItem_GénérerCalendrier";
            this.mnItem_GénérerCalendrier.Size = new System.Drawing.Size(185, 22);
            this.mnItem_GénérerCalendrier.Text = "Gestion de calendrier";
            this.mnItem_GénérerCalendrier.Click += new System.EventHandler(this.mn_GnrClndr_Click);
            // 
            // gestionDéquipesToolStripMenuItem
            // 
            this.gestionDéquipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItem_InscrireJoueurs,
            this.mnItem_TransfererJoueur});
            this.gestionDéquipesToolStripMenuItem.Name = "gestionDéquipesToolStripMenuItem";
            this.gestionDéquipesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.gestionDéquipesToolStripMenuItem.Text = "Gestion d\'équipes";
            // 
            // mnItem_InscrireJoueurs
            // 
            this.mnItem_InscrireJoueurs.Name = "mnItem_InscrireJoueurs";
            this.mnItem_InscrireJoueurs.Size = new System.Drawing.Size(180, 22);
            this.mnItem_InscrireJoueurs.Text = "Inscrire  joueur(s)";
            this.mnItem_InscrireJoueurs.Click += new System.EventHandler(this.mn_InscrireJoueurs_Click);
            // 
            // mnItem_TransfererJoueur
            // 
            this.mnItem_TransfererJoueur.Name = "mnItem_TransfererJoueur";
            this.mnItem_TransfererJoueur.Size = new System.Drawing.Size(180, 22);
            this.mnItem_TransfererJoueur.Text = "Transférer un joueur";
            this.mnItem_TransfererJoueur.Click += new System.EventHandler(this.mn_TransfererJoueur_Click);
            // 
            // joueursToolStripMenuItem
            // 
            this.joueursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItem_HistoriqueJoueur});
            this.joueursToolStripMenuItem.Name = "joueursToolStripMenuItem";
            this.joueursToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.joueursToolStripMenuItem.Text = "Joueurs";
            // 
            // mnItem_HistoriqueJoueur
            // 
            this.mnItem_HistoriqueJoueur.Name = "mnItem_HistoriqueJoueur";
            this.mnItem_HistoriqueJoueur.Size = new System.Drawing.Size(156, 22);
            this.mnItem_HistoriqueJoueur.Text = "Voir l\'historique";
            // 
            // cartonsToolStripMenuItem
            // 
            this.cartonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItem_Cartons});
            this.cartonsToolStripMenuItem.Name = "cartonsToolStripMenuItem";
            this.cartonsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cartonsToolStripMenuItem.Text = "Cartons";
            // 
            // mnItem_Cartons
            // 
            this.mnItem_Cartons.Name = "mnItem_Cartons";
            this.mnItem_Cartons.Size = new System.Drawing.Size(153, 22);
            this.mnItem_Cartons.Text = "Voir les cartons";
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
        private System.Windows.Forms.ToolStripMenuItem mnItem_VoirClssmnt;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnItem_Results;
        private System.Windows.Forms.ToolStripMenuItem calendrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnItem_GénérerCalendrier;
        private System.Windows.Forms.ToolStripMenuItem gestionDéquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnItem_InscrireJoueurs;
        private System.Windows.Forms.ToolStripMenuItem joueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnItem_HistoriqueJoueur;
        private System.Windows.Forms.ToolStripMenuItem cartonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnItem_Cartons;
        private System.Windows.Forms.ToolStripMenuItem mnItem_TransfererJoueur;
    }
}

