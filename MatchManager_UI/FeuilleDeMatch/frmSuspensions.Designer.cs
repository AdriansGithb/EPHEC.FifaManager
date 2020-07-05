namespace MatchManager_UI.FeuilleDeMatch
{
    partial class frmSuspensions
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
            this.lbljoueur = new System.Windows.Forms.Label();
            this.lblCarton = new System.Windows.Forms.Label();
            this.lblnbMatchText = new System.Windows.Forms.Label();
            this.lblNbMatchTotal = new System.Windows.Forms.Label();
            this.lstbxMatchsRestant = new System.Windows.Forms.ListBox();
            this.lblSelMatchs = new System.Windows.Forms.Label();
            this.lblMatchRestantTxt = new System.Windows.Forms.Label();
            this.lblNbMatchsRestant = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbljoueur
            // 
            this.lbljoueur.AutoSize = true;
            this.lbljoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoueur.Location = new System.Drawing.Point(12, 9);
            this.lbljoueur.Name = "lbljoueur";
            this.lbljoueur.Size = new System.Drawing.Size(115, 17);
            this.lbljoueur.TabIndex = 0;
            this.lbljoueur.Text = "Joueur concerné";
            // 
            // lblCarton
            // 
            this.lblCarton.AutoSize = true;
            this.lblCarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarton.Location = new System.Drawing.Point(12, 37);
            this.lblCarton.Name = "lblCarton";
            this.lblCarton.Size = new System.Drawing.Size(103, 17);
            this.lblCarton.TabIndex = 1;
            this.lblCarton.Text = "Couleur Carton";
            // 
            // lblnbMatchText
            // 
            this.lblnbMatchText.AutoSize = true;
            this.lblnbMatchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnbMatchText.Location = new System.Drawing.Point(319, 9);
            this.lblnbMatchText.Name = "lblnbMatchText";
            this.lblnbMatchText.Size = new System.Drawing.Size(179, 17);
            this.lblnbMatchText.TabIndex = 2;
            this.lblnbMatchText.Text = "Nb matchs de suspension :";
            // 
            // lblNbMatchTotal
            // 
            this.lblNbMatchTotal.AutoSize = true;
            this.lblNbMatchTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbMatchTotal.Location = new System.Drawing.Point(389, 37);
            this.lblNbMatchTotal.Name = "lblNbMatchTotal";
            this.lblNbMatchTotal.Size = new System.Drawing.Size(26, 17);
            this.lblNbMatchTotal.TabIndex = 3;
            this.lblNbMatchTotal.Text = "##";
            // 
            // lstbxMatchsRestant
            // 
            this.lstbxMatchsRestant.FormattingEnabled = true;
            this.lstbxMatchsRestant.Location = new System.Drawing.Point(70, 94);
            this.lstbxMatchsRestant.Name = "lstbxMatchsRestant";
            this.lstbxMatchsRestant.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxMatchsRestant.Size = new System.Drawing.Size(345, 238);
            this.lstbxMatchsRestant.TabIndex = 4;
            this.lstbxMatchsRestant.SelectedIndexChanged += new System.EventHandler(this.lstbxMatchsRestant_SelectedIndexChanged);
            // 
            // lblSelMatchs
            // 
            this.lblSelMatchs.AutoSize = true;
            this.lblSelMatchs.Location = new System.Drawing.Point(67, 78);
            this.lblSelMatchs.Name = "lblSelMatchs";
            this.lblSelMatchs.Size = new System.Drawing.Size(231, 13);
            this.lblSelMatchs.TabIndex = 5;
            this.lblSelMatchs.Text = "Sélectionner les matchs de suspension choisis :";
            // 
            // lblMatchRestantTxt
            // 
            this.lblMatchRestantTxt.AutoSize = true;
            this.lblMatchRestantTxt.Location = new System.Drawing.Point(67, 347);
            this.lblMatchRestantTxt.Name = "lblMatchRestantTxt";
            this.lblMatchRestantTxt.Size = new System.Drawing.Size(165, 13);
            this.lblMatchRestantTxt.TabIndex = 6;
            this.lblMatchRestantTxt.Text = "# Matchs restant à sélectionner : ";
            // 
            // lblNbMatchsRestant
            // 
            this.lblNbMatchsRestant.AutoSize = true;
            this.lblNbMatchsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbMatchsRestant.Location = new System.Drawing.Point(263, 347);
            this.lblNbMatchsRestant.Name = "lblNbMatchsRestant";
            this.lblNbMatchsRestant.Size = new System.Drawing.Size(23, 13);
            this.lblNbMatchsRestant.TabIndex = 7;
            this.lblNbMatchsRestant.Text = "##";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(70, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(345, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sauvegarder le choix des matchs de suspension effective";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSuspensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 459);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNbMatchsRestant);
            this.Controls.Add(this.lblMatchRestantTxt);
            this.Controls.Add(this.lblSelMatchs);
            this.Controls.Add(this.lstbxMatchsRestant);
            this.Controls.Add(this.lblNbMatchTotal);
            this.Controls.Add(this.lblnbMatchText);
            this.Controls.Add(this.lblCarton);
            this.Controls.Add(this.lbljoueur);
            this.Name = "frmSuspensions";
            this.Text = "Choix des matchs suspendus";
            this.Load += new System.EventHandler(this.frmSuspensions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbljoueur;
        private System.Windows.Forms.Label lblCarton;
        private System.Windows.Forms.Label lblnbMatchText;
        private System.Windows.Forms.Label lblNbMatchTotal;
        private System.Windows.Forms.ListBox lstbxMatchsRestant;
        private System.Windows.Forms.Label lblSelMatchs;
        private System.Windows.Forms.Label lblMatchRestantTxt;
        private System.Windows.Forms.Label lblNbMatchsRestant;
        private System.Windows.Forms.Button btnSave;
    }
}