namespace BackEnd_UI.Joueurs
{
    partial class frmHistoJoueur
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
            this.lstbxJoueursDispo = new System.Windows.Forms.ListBox();
            this.datagridHisto = new System.Windows.Forms.DataGridView();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.lblHisto = new System.Windows.Forms.Label();
            this.lblSlctdJoueur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxJoueursDispo
            // 
            this.lstbxJoueursDispo.FormattingEnabled = true;
            this.lstbxJoueursDispo.Location = new System.Drawing.Point(12, 31);
            this.lstbxJoueursDispo.Name = "lstbxJoueursDispo";
            this.lstbxJoueursDispo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxJoueursDispo.Size = new System.Drawing.Size(225, 407);
            this.lstbxJoueursDispo.TabIndex = 28;
            // 
            // datagridHisto
            // 
            this.datagridHisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridHisto.Location = new System.Drawing.Point(259, 31);
            this.datagridHisto.Name = "datagridHisto";
            this.datagridHisto.ReadOnly = true;
            this.datagridHisto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridHisto.Size = new System.Drawing.Size(529, 407);
            this.datagridHisto.TabIndex = 29;
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(12, 13);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(109, 13);
            this.lblJoueur.TabIndex = 30;
            this.lblJoueur.Text = "Sélectionner le joueur";
            // 
            // lblHisto
            // 
            this.lblHisto.AutoSize = true;
            this.lblHisto.Location = new System.Drawing.Point(404, 13);
            this.lblHisto.Name = "lblHisto";
            this.lblHisto.Size = new System.Drawing.Size(110, 13);
            this.lblHisto.TabIndex = 31;
            this.lblHisto.Text = "Historique du joueur : ";
            // 
            // lblSlctdJoueur
            // 
            this.lblSlctdJoueur.AutoSize = true;
            this.lblSlctdJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlctdJoueur.Location = new System.Drawing.Point(520, 13);
            this.lblSlctdJoueur.Name = "lblSlctdJoueur";
            this.lblSlctdJoueur.Size = new System.Drawing.Size(72, 13);
            this.lblSlctdJoueur.TabIndex = 32;
            this.lblSlctdJoueur.Text = "slctdJoueur";
            // 
            // frmHistoJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSlctdJoueur);
            this.Controls.Add(this.lblHisto);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.datagridHisto);
            this.Controls.Add(this.lstbxJoueursDispo);
            this.Name = "frmHistoJoueur";
            this.Text = "Historique des joueurs";
            ((System.ComponentModel.ISupportInitialize)(this.datagridHisto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxJoueursDispo;
        private System.Windows.Forms.DataGridView datagridHisto;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Label lblHisto;
        private System.Windows.Forms.Label lblSlctdJoueur;
    }
}