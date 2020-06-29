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
            this.cmbBx_Champs = new System.Windows.Forms.ComboBox();
            this.cmbBx_Matchs = new System.Windows.Forms.ComboBox();
            this.rdBtn_Ssn1 = new System.Windows.Forms.RadioButton();
            this.rdBtn_Ssn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn_Ssn12 = new System.Windows.Forms.RadioButton();
            this.btn_InscrireJoueurs = new System.Windows.Forms.Button();
            this.btn_FeuilleDeMatch = new System.Windows.Forms.Button();
            this.gpBx_Champ = new System.Windows.Forms.GroupBox();
            this.gpBx_Matchs = new System.Windows.Forms.GroupBox();
            this.gpBx_Champ.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBx_Champs
            // 
            this.cmbBx_Champs.FormattingEnabled = true;
            this.cmbBx_Champs.Location = new System.Drawing.Point(10, 17);
            this.cmbBx_Champs.Name = "cmbBx_Champs";
            this.cmbBx_Champs.Size = new System.Drawing.Size(404, 21);
            this.cmbBx_Champs.TabIndex = 0;
            // 
            // cmbBx_Matchs
            // 
            this.cmbBx_Matchs.FormattingEnabled = true;
            this.cmbBx_Matchs.Location = new System.Drawing.Point(33, 126);
            this.cmbBx_Matchs.Name = "cmbBx_Matchs";
            this.cmbBx_Matchs.Size = new System.Drawing.Size(404, 21);
            this.cmbBx_Matchs.TabIndex = 1;
            // 
            // rdBtn_Ssn1
            // 
            this.rdBtn_Ssn1.AutoSize = true;
            this.rdBtn_Ssn1.Location = new System.Drawing.Point(10, 44);
            this.rdBtn_Ssn1.Name = "rdBtn_Ssn1";
            this.rdBtn_Ssn1.Size = new System.Drawing.Size(66, 17);
            this.rdBtn_Ssn1.TabIndex = 2;
            this.rdBtn_Ssn1.Text = "Saison 1";
            this.rdBtn_Ssn1.UseVisualStyleBackColor = true;
            // 
            // rdBtn_Ssn2
            // 
            this.rdBtn_Ssn2.AutoSize = true;
            this.rdBtn_Ssn2.Location = new System.Drawing.Point(164, 44);
            this.rdBtn_Ssn2.Name = "rdBtn_Ssn2";
            this.rdBtn_Ssn2.Size = new System.Drawing.Size(66, 17);
            this.rdBtn_Ssn2.TabIndex = 3;
            this.rdBtn_Ssn2.Text = "Saison 2";
            this.rdBtn_Ssn2.UseVisualStyleBackColor = true;
            // 
            // rdBtn_Ssn12
            // 
            this.rdBtn_Ssn12.AutoSize = true;
            this.rdBtn_Ssn12.Checked = true;
            this.rdBtn_Ssn12.Location = new System.Drawing.Point(329, 44);
            this.rdBtn_Ssn12.Name = "rdBtn_Ssn12";
            this.rdBtn_Ssn12.Size = new System.Drawing.Size(83, 17);
            this.rdBtn_Ssn12.TabIndex = 4;
            this.rdBtn_Ssn12.TabStop = true;
            this.rdBtn_Ssn12.Text = "Saisons 1+2";
            this.rdBtn_Ssn12.UseVisualStyleBackColor = true;
            // 
            // btn_InscrireJoueurs
            // 
            this.btn_InscrireJoueurs.Enabled = false;
            this.btn_InscrireJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InscrireJoueurs.Location = new System.Drawing.Point(33, 195);
            this.btn_InscrireJoueurs.Name = "btn_InscrireJoueurs";
            this.btn_InscrireJoueurs.Size = new System.Drawing.Size(182, 102);
            this.btn_InscrireJoueurs.TabIndex = 5;
            this.btn_InscrireJoueurs.Text = "Inscrire les joueurs pour le match";
            this.btn_InscrireJoueurs.UseVisualStyleBackColor = true;
            // 
            // btn_FeuilleDeMatch
            // 
            this.btn_FeuilleDeMatch.Enabled = false;
            this.btn_FeuilleDeMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FeuilleDeMatch.Location = new System.Drawing.Point(255, 195);
            this.btn_FeuilleDeMatch.Name = "btn_FeuilleDeMatch";
            this.btn_FeuilleDeMatch.Size = new System.Drawing.Size(182, 102);
            this.btn_FeuilleDeMatch.TabIndex = 6;
            this.btn_FeuilleDeMatch.Text = "Remplir la feuille de match";
            this.btn_FeuilleDeMatch.UseVisualStyleBackColor = true;
            // 
            // gpBx_Champ
            // 
            this.gpBx_Champ.Controls.Add(this.rdBtn_Ssn12);
            this.gpBx_Champ.Controls.Add(this.rdBtn_Ssn2);
            this.gpBx_Champ.Controls.Add(this.rdBtn_Ssn1);
            this.gpBx_Champ.Controls.Add(this.cmbBx_Champs);
            this.gpBx_Champ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBx_Champ.Location = new System.Drawing.Point(23, 26);
            this.gpBx_Champ.Name = "gpBx_Champ";
            this.gpBx_Champ.Size = new System.Drawing.Size(426, 71);
            this.gpBx_Champ.TabIndex = 7;
            this.gpBx_Champ.TabStop = false;
            this.gpBx_Champ.Text = "1. Sélectionner le championnat";
            // 
            // gpBx_Matchs
            // 
            this.gpBx_Matchs.Location = new System.Drawing.Point(23, 103);
            this.gpBx_Matchs.Name = "gpBx_Matchs";
            this.gpBx_Matchs.Size = new System.Drawing.Size(426, 71);
            this.gpBx_Matchs.TabIndex = 8;
            this.gpBx_Matchs.TabStop = false;
            this.gpBx_Matchs.Text = "2. Sélectionner le match";
            // 
            // frmMM_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 323);
            this.Controls.Add(this.gpBx_Champ);
            this.Controls.Add(this.btn_FeuilleDeMatch);
            this.Controls.Add(this.btn_InscrireJoueurs);
            this.Controls.Add(this.cmbBx_Matchs);
            this.Controls.Add(this.gpBx_Matchs);
            this.Name = "frmMM_HomePage";
            this.Text = "MatchManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpBx_Champ.ResumeLayout(false);
            this.gpBx_Champ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBx_Champs;
        private System.Windows.Forms.ComboBox cmbBx_Matchs;
        private System.Windows.Forms.RadioButton rdBtn_Ssn1;
        private System.Windows.Forms.RadioButton rdBtn_Ssn2;
        private System.Windows.Forms.RadioButton rdBtn_Ssn12;
        private System.Windows.Forms.Button btn_InscrireJoueurs;
        private System.Windows.Forms.Button btn_FeuilleDeMatch;
        private System.Windows.Forms.GroupBox gpBx_Champ;
        private System.Windows.Forms.GroupBox gpBx_Matchs;
    }
}

