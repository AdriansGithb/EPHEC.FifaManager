namespace MatchManager_UI
{
    partial class frmInscript_HomePage
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
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            this.boxMatchSelection = new System.Windows.Forms.ComboBox();
            this.rdBtn_Ssn1 = new System.Windows.Forms.RadioButton();
            this.rdBtn_Ssn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn_Ssn12 = new System.Windows.Forms.RadioButton();
            this.btn_InscrireJoueurs = new System.Windows.Forms.Button();
            this.gpBx_Champ = new System.Windows.Forms.GroupBox();
            this.gpBx_Matchs = new System.Windows.Forms.GroupBox();
            this.lblMatchList = new System.Windows.Forms.Label();
            this.gpBx_Champ.SuspendLayout();
            this.gpBx_Matchs.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxChampSelection
            // 
            this.boxChampSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxChampSelection.FormattingEnabled = true;
            this.boxChampSelection.Location = new System.Drawing.Point(10, 17);
            this.boxChampSelection.Name = "boxChampSelection";
            this.boxChampSelection.Size = new System.Drawing.Size(404, 21);
            this.boxChampSelection.TabIndex = 0;
            this.boxChampSelection.SelectedIndexChanged += new System.EventHandler(this.Load_MatchList);
            // 
            // boxMatchSelection
            // 
            this.boxMatchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMatchSelection.FormattingEnabled = true;
            this.boxMatchSelection.Location = new System.Drawing.Point(10, 35);
            this.boxMatchSelection.Name = "boxMatchSelection";
            this.boxMatchSelection.Size = new System.Drawing.Size(404, 21);
            this.boxMatchSelection.TabIndex = 1;
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
            this.rdBtn_Ssn1.Click += new System.EventHandler(this.Load_MatchList);
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
            this.rdBtn_Ssn2.Click += new System.EventHandler(this.Load_MatchList);
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
            this.rdBtn_Ssn12.Click += new System.EventHandler(this.Load_MatchList);
            // 
            // btn_InscrireJoueurs
            // 
            this.btn_InscrireJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InscrireJoueurs.Location = new System.Drawing.Point(23, 200);
            this.btn_InscrireJoueurs.Name = "btn_InscrireJoueurs";
            this.btn_InscrireJoueurs.Size = new System.Drawing.Size(426, 64);
            this.btn_InscrireJoueurs.TabIndex = 5;
            this.btn_InscrireJoueurs.Text = "Inscrire les joueurs pour ce match";
            this.btn_InscrireJoueurs.UseVisualStyleBackColor = true;
            this.btn_InscrireJoueurs.Click += new System.EventHandler(this.btn_InscrireJoueurs_Click);
            // 
            // gpBx_Champ
            // 
            this.gpBx_Champ.Controls.Add(this.rdBtn_Ssn12);
            this.gpBx_Champ.Controls.Add(this.rdBtn_Ssn2);
            this.gpBx_Champ.Controls.Add(this.rdBtn_Ssn1);
            this.gpBx_Champ.Controls.Add(this.boxChampSelection);
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
            this.gpBx_Matchs.Controls.Add(this.lblMatchList);
            this.gpBx_Matchs.Controls.Add(this.boxMatchSelection);
            this.gpBx_Matchs.Location = new System.Drawing.Point(23, 103);
            this.gpBx_Matchs.Name = "gpBx_Matchs";
            this.gpBx_Matchs.Size = new System.Drawing.Size(426, 71);
            this.gpBx_Matchs.TabIndex = 8;
            this.gpBx_Matchs.TabStop = false;
            this.gpBx_Matchs.Text = "2. Sélectionner le match";
            // 
            // lblMatchList
            // 
            this.lblMatchList.AutoSize = true;
            this.lblMatchList.Enabled = false;
            this.lblMatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchList.Location = new System.Drawing.Point(10, 16);
            this.lblMatchList.Name = "lblMatchList";
            this.lblMatchList.Size = new System.Drawing.Size(221, 13);
            this.lblMatchList.TabIndex = 2;
            this.lblMatchList.Text = "Date   | Saison | #Match |   Domicile><Visiteur";
            // 
            // frmInscript_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 290);
            this.Controls.Add(this.gpBx_Champ);
            this.Controls.Add(this.btn_InscrireJoueurs);
            this.Controls.Add(this.gpBx_Matchs);
            this.Name = "frmInscript_HomePage";
            this.Text = "Inscrire des joueurs à un match";
            this.gpBx_Champ.ResumeLayout(false);
            this.gpBx_Champ.PerformLayout();
            this.gpBx_Matchs.ResumeLayout(false);
            this.gpBx_Matchs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.ComboBox boxMatchSelection;
        private System.Windows.Forms.RadioButton rdBtn_Ssn1;
        private System.Windows.Forms.RadioButton rdBtn_Ssn2;
        private System.Windows.Forms.RadioButton rdBtn_Ssn12;
        private System.Windows.Forms.Button btn_InscrireJoueurs;
        private System.Windows.Forms.GroupBox gpBx_Champ;
        private System.Windows.Forms.GroupBox gpBx_Matchs;
        private System.Windows.Forms.Label lblMatchList;
    }
}

