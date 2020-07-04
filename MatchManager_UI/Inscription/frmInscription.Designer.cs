namespace MatchManager_UI.Inscription
{
    partial class frmInscription
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lstbxJoueursMatch = new System.Windows.Forms.ListBox();
            this.lstbxJoueursDispo = new System.Windows.Forms.ListBox();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.lblJoueursInscrits = new System.Windows.Forms.Label();
            this.lblJoueursDispos = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEqp = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(633, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 58);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Sauver modifications";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lstbxJoueursMatch
            // 
            this.lstbxJoueursMatch.FormattingEnabled = true;
            this.lstbxJoueursMatch.Location = new System.Drawing.Point(401, 94);
            this.lstbxJoueursMatch.Name = "lstbxJoueursMatch";
            this.lstbxJoueursMatch.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxJoueursMatch.Size = new System.Drawing.Size(225, 251);
            this.lstbxJoueursMatch.TabIndex = 38;
            // 
            // lstbxJoueursDispo
            // 
            this.lstbxJoueursDispo.FormattingEnabled = true;
            this.lstbxJoueursDispo.Location = new System.Drawing.Point(22, 94);
            this.lstbxJoueursDispo.Name = "lstbxJoueursDispo";
            this.lstbxJoueursDispo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxJoueursDispo.Size = new System.Drawing.Size(225, 251);
            this.lstbxJoueursDispo.TabIndex = 37;
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(253, 167);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(142, 67);
            this.btnDesinscrire.TabIndex = 36;
            this.btnDesinscrire.Text = "Désinscrire du match les joueurs sélectionnés \r\n<";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(253, 264);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(142, 58);
            this.btnUncheckAll.TabIndex = 35;
            this.btnUncheckAll.Text = "Désélectionner tout";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(253, 94);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(142, 67);
            this.btnInscrire.TabIndex = 34;
            this.btnInscrire.Text = ">\r\nInscrire les joueurs sélectionnés dans l\'équipe du match";
            this.btnInscrire.UseVisualStyleBackColor = true;
            // 
            // lblJoueursInscrits
            // 
            this.lblJoueursInscrits.AutoSize = true;
            this.lblJoueursInscrits.Location = new System.Drawing.Point(395, 70);
            this.lblJoueursInscrits.Name = "lblJoueursInscrits";
            this.lblJoueursInscrits.Size = new System.Drawing.Size(206, 13);
            this.lblJoueursInscrits.TabIndex = 33;
            this.lblJoueursInscrits.Text = "Joueurs de l\'équipe inscrits pour le match :";
            // 
            // lblJoueursDispos
            // 
            this.lblJoueursDispos.AutoSize = true;
            this.lblJoueursDispos.Location = new System.Drawing.Point(19, 70);
            this.lblJoueursDispos.Name = "lblJoueursDispos";
            this.lblJoueursDispos.Size = new System.Drawing.Size(153, 13);
            this.lblJoueursDispos.TabIndex = 32;
            this.lblJoueursDispos.Text = "Joueurs de l\'équipe disponibles";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(633, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 58);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Annuler modifications";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEqp
            // 
            this.lblEqp.AutoSize = true;
            this.lblEqp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqp.Location = new System.Drawing.Point(19, 9);
            this.lblEqp.Name = "lblEqp";
            this.lblEqp.Size = new System.Drawing.Size(58, 17);
            this.lblEqp.TabIndex = 42;
            this.lblEqp.Text = "Equipe";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(308, 9);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(46, 17);
            this.lblMatch.TabIndex = 43;
            this.lblMatch.Text = "Match";
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 357);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.lblEqp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstbxJoueursMatch);
            this.Controls.Add(this.lstbxJoueursDispo);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.lblJoueursInscrits);
            this.Controls.Add(this.lblJoueursDispos);
            this.Name = "frmInscription";
            this.Text = "Inscrire des joueurs pour le match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstbxJoueursMatch;
        private System.Windows.Forms.ListBox lstbxJoueursDispo;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Label lblJoueursInscrits;
        private System.Windows.Forms.Label lblJoueursDispos;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEqp;
        private System.Windows.Forms.Label lblMatch;
    }
}