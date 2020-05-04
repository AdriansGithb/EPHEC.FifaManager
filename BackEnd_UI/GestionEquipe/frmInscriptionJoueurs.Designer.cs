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
            this.lblJoueursLibres = new System.Windows.Forms.Label();
            this.lblJoueursEqp = new System.Windows.Forms.Label();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.lstbxJoueursDispo = new System.Windows.Forms.ListBox();
            this.lstbxJoueursEqp = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.boxChampSelection.SelectedIndexChanged += new System.EventHandler(this.boxChampSelection_SelectedIndexChanged);
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
            this.boxEqpSelection.SelectedIndexChanged += new System.EventHandler(this.boxEqpSelection_SelectedIndexChanged);
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
            // lblJoueursEqp
            // 
            this.lblJoueursEqp.AutoSize = true;
            this.lblJoueursEqp.Location = new System.Drawing.Point(446, 80);
            this.lblJoueursEqp.Name = "lblJoueursEqp";
            this.lblJoueursEqp.Size = new System.Drawing.Size(150, 13);
            this.lblJoueursEqp.TabIndex = 21;
            this.lblJoueursEqp.Text = "Joueurs inscrits dans l\'équipe :";
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(301, 99);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(142, 58);
            this.btnInscrire.TabIndex = 22;
            this.btnInscrire.Text = ">\r\nInscrire les joueurs sélectionnés dans l\'équipe";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(301, 245);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(142, 58);
            this.btnUncheckAll.TabIndex = 25;
            this.btnUncheckAll.Text = "Décocher tout";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(301, 163);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(142, 58);
            this.btnDesinscrire.TabIndex = 26;
            this.btnDesinscrire.Text = "Désinscrire de l\'équipe les joueurs sélectionnés \r\n<";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // lstbxJoueursDispo
            // 
            this.lstbxJoueursDispo.FormattingEnabled = true;
            this.lstbxJoueursDispo.Location = new System.Drawing.Point(70, 99);
            this.lstbxJoueursDispo.Name = "lstbxJoueursDispo";
            this.lstbxJoueursDispo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxJoueursDispo.Size = new System.Drawing.Size(225, 290);
            this.lstbxJoueursDispo.TabIndex = 27;
            // 
            // lstbxJoueursEqp
            // 
            this.lstbxJoueursEqp.FormattingEnabled = true;
            this.lstbxJoueursEqp.Location = new System.Drawing.Point(449, 99);
            this.lstbxJoueursEqp.Name = "lstbxJoueursEqp";
            this.lstbxJoueursEqp.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxJoueursEqp.Size = new System.Drawing.Size(225, 290);
            this.lstbxJoueursEqp.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(301, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 58);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Sauver modifications";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmInscriptionJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstbxJoueursEqp);
            this.Controls.Add(this.lstbxJoueursDispo);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.lblJoueursEqp);
            this.Controls.Add(this.lblJoueursLibres);
            this.Controls.Add(this.gpbxSlctEqp);
            this.Controls.Add(this.gpbxSlctChamp);
            this.Name = "frmInscriptionJoueurs";
            this.Text = "Inscription joueur(s) à une équipe pour un championnat";
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
        private System.Windows.Forms.Label lblJoueursLibres;
        private System.Windows.Forms.Label lblJoueursEqp;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.ListBox lstbxJoueursDispo;
        private System.Windows.Forms.ListBox lstbxJoueursEqp;
        private System.Windows.Forms.Button btnSave;
    }
}