namespace BackEnd_UI.GestionEquipe
{
    partial class frmInscriptionJoueurs
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
            this.gpbxSlctChamp = new System.Windows.Forms.GroupBox();
            this.gpbxSlctEqp = new System.Windows.Forms.GroupBox();
            this.boxEqpSelection = new System.Windows.Forms.ComboBox();
            this.chckdlstbxJoueursDispo = new System.Windows.Forms.CheckedListBox();
            this.chckdlstbxJoueursEqp = new System.Windows.Forms.CheckedListBox();
            this.lblJoueursLibres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.gpbxSlctChamp.SuspendLayout();
            this.gpbxSlctEqp.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxChampSelection
            // 
            this.boxChampSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxChampSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxChampSelection.FormattingEnabled = true;
            this.boxChampSelection.Location = new System.Drawing.Point(6, 19);
            this.boxChampSelection.Name = "boxChampSelection";
            this.boxChampSelection.Size = new System.Drawing.Size(337, 21);
            this.boxChampSelection.TabIndex = 5;
            // 
            // gpbxSlctChamp
            // 
            this.gpbxSlctChamp.Controls.Add(this.boxChampSelection);
            this.gpbxSlctChamp.Location = new System.Drawing.Point(12, 12);
            this.gpbxSlctChamp.Name = "gpbxSlctChamp";
            this.gpbxSlctChamp.Size = new System.Drawing.Size(365, 61);
            this.gpbxSlctChamp.TabIndex = 16;
            this.gpbxSlctChamp.TabStop = false;
            this.gpbxSlctChamp.Text = "1. Sélectionner le championnat";
            // 
            // gpbxSlctEqp
            // 
            this.gpbxSlctEqp.Controls.Add(this.boxEqpSelection);
            this.gpbxSlctEqp.Location = new System.Drawing.Point(423, 12);
            this.gpbxSlctEqp.Name = "gpbxSlctEqp";
            this.gpbxSlctEqp.Size = new System.Drawing.Size(365, 61);
            this.gpbxSlctEqp.TabIndex = 17;
            this.gpbxSlctEqp.TabStop = false;
            this.gpbxSlctEqp.Text = "2. Sélectionner l\'équipe";
            // 
            // boxEqpSelection
            // 
            this.boxEqpSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxEqpSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEqpSelection.FormattingEnabled = true;
            this.boxEqpSelection.Location = new System.Drawing.Point(6, 19);
            this.boxEqpSelection.Name = "boxEqpSelection";
            this.boxEqpSelection.Size = new System.Drawing.Size(337, 21);
            this.boxEqpSelection.TabIndex = 5;
            // 
            // chckdlstbxJoueursDispo
            // 
            this.chckdlstbxJoueursDispo.FormattingEnabled = true;
            this.chckdlstbxJoueursDispo.Location = new System.Drawing.Point(70, 99);
            this.chckdlstbxJoueursDispo.Name = "chckdlstbxJoueursDispo";
            this.chckdlstbxJoueursDispo.Size = new System.Drawing.Size(225, 289);
            this.chckdlstbxJoueursDispo.TabIndex = 18;
            // 
            // chckdlstbxJoueursEqp
            // 
            this.chckdlstbxJoueursEqp.FormattingEnabled = true;
            this.chckdlstbxJoueursEqp.Location = new System.Drawing.Point(359, 99);
            this.chckdlstbxJoueursEqp.Name = "chckdlstbxJoueursEqp";
            this.chckdlstbxJoueursEqp.Size = new System.Drawing.Size(225, 289);
            this.chckdlstbxJoueursEqp.TabIndex = 19;
            // 
            // lblJoueursLibres
            // 
            this.lblJoueursLibres.AutoSize = true;
            this.lblJoueursLibres.Location = new System.Drawing.Point(70, 80);
            this.lblJoueursLibres.Name = "lblJoueursLibres";
            this.lblJoueursLibres.Size = new System.Drawing.Size(99, 13);
            this.lblJoueursLibres.TabIndex = 20;
            this.lblJoueursLibres.Text = "Joueurs disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Equipe : ";
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(70, 394);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(225, 38);
            this.btnInscrire.TabIndex = 22;
            this.btnInscrire.Text = "Inscrire les joueurs sélectionnés dans l\'équipe";
            this.btnInscrire.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(624, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 101);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Sauver";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(624, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 101);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(359, 394);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(225, 38);
            this.btnDesinscrire.TabIndex = 26;
            this.btnDesinscrire.Text = "Désinscrire de l\'équipe les joueurs sélectionnés ";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            // 
            // frmInscriptionJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJoueursLibres);
            this.Controls.Add(this.chckdlstbxJoueursEqp);
            this.Controls.Add(this.chckdlstbxJoueursDispo);
            this.Controls.Add(this.gpbxSlctEqp);
            this.Controls.Add(this.gpbxSlctChamp);
            this.Name = "frmInscriptionJoueurs";
            this.Text = "Inscription joueur(s)";
            this.Load += new System.EventHandler(this.frmInscriptionJoueurs_Load);
            this.gpbxSlctChamp.ResumeLayout(false);
            this.gpbxSlctEqp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.GroupBox gpbxSlctChamp;
        private System.Windows.Forms.GroupBox gpbxSlctEqp;
        private System.Windows.Forms.ComboBox boxEqpSelection;
        private System.Windows.Forms.CheckedListBox chckdlstbxJoueursDispo;
        private System.Windows.Forms.CheckedListBox chckdlstbxJoueursEqp;
        private System.Windows.Forms.Label lblJoueursLibres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDesinscrire;
    }
}