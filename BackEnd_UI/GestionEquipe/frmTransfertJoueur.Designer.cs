namespace BackEnd_UI.GestionEquipe
{
    partial class frmTransfertJoueur
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
            this.gpbxSlctEqpOrgn = new System.Windows.Forms.GroupBox();
            this.boxEqpOrgnSelection = new System.Windows.Forms.ComboBox();
            this.gpbxSlctChamp = new System.Windows.Forms.GroupBox();
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            this.gpbxSlctEqpTrnsfrt = new System.Windows.Forms.GroupBox();
            this.boxEqpTrnsfrtSelection = new System.Windows.Forms.ComboBox();
            this.gpbxSlctJoueur = new System.Windows.Forms.GroupBox();
            this.btnTransferer = new System.Windows.Forms.Button();
            this.lstbxJoueursEqpOrgn = new System.Windows.Forms.ListBox();
            this.lstbxJoueursEqpTrnsfrt = new System.Windows.Forms.ListBox();
            this.gpbxSlctEqpOrgn.SuspendLayout();
            this.gpbxSlctChamp.SuspendLayout();
            this.gpbxSlctEqpTrnsfrt.SuspendLayout();
            this.gpbxSlctJoueur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxSlctEqpOrgn
            // 
            this.gpbxSlctEqpOrgn.Controls.Add(this.gpbxSlctJoueur);
            this.gpbxSlctEqpOrgn.Controls.Add(this.boxEqpOrgnSelection);
            this.gpbxSlctEqpOrgn.Location = new System.Drawing.Point(12, 79);
            this.gpbxSlctEqpOrgn.Name = "gpbxSlctEqpOrgn";
            this.gpbxSlctEqpOrgn.Size = new System.Drawing.Size(380, 307);
            this.gpbxSlctEqpOrgn.TabIndex = 19;
            this.gpbxSlctEqpOrgn.TabStop = false;
            this.gpbxSlctEqpOrgn.Text = "2. Sélectionner l\'équipe du joueur à transférer";
            // 
            // boxEqpOrgnSelection
            // 
            this.boxEqpOrgnSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxEqpOrgnSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEqpOrgnSelection.FormattingEnabled = true;
            this.boxEqpOrgnSelection.Location = new System.Drawing.Point(6, 19);
            this.boxEqpOrgnSelection.Name = "boxEqpOrgnSelection";
            this.boxEqpOrgnSelection.Size = new System.Drawing.Size(337, 21);
            this.boxEqpOrgnSelection.TabIndex = 5;
            // 
            // gpbxSlctChamp
            // 
            this.gpbxSlctChamp.Controls.Add(this.boxChampSelection);
            this.gpbxSlctChamp.Location = new System.Drawing.Point(12, 12);
            this.gpbxSlctChamp.Name = "gpbxSlctChamp";
            this.gpbxSlctChamp.Size = new System.Drawing.Size(380, 61);
            this.gpbxSlctChamp.TabIndex = 18;
            this.gpbxSlctChamp.TabStop = false;
            this.gpbxSlctChamp.Text = "1. Sélectionner le championnat";
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
            // gpbxSlctEqpTrnsfrt
            // 
            this.gpbxSlctEqpTrnsfrt.Controls.Add(this.lstbxJoueursEqpTrnsfrt);
            this.gpbxSlctEqpTrnsfrt.Controls.Add(this.boxEqpTrnsfrtSelection);
            this.gpbxSlctEqpTrnsfrt.Location = new System.Drawing.Point(423, 79);
            this.gpbxSlctEqpTrnsfrt.Name = "gpbxSlctEqpTrnsfrt";
            this.gpbxSlctEqpTrnsfrt.Size = new System.Drawing.Size(365, 307);
            this.gpbxSlctEqpTrnsfrt.TabIndex = 20;
            this.gpbxSlctEqpTrnsfrt.TabStop = false;
            this.gpbxSlctEqpTrnsfrt.Text = "3. Sélectionner l\'équipe du joueur à transférer";
            // 
            // boxEqpTrnsfrtSelection
            // 
            this.boxEqpTrnsfrtSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxEqpTrnsfrtSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEqpTrnsfrtSelection.FormattingEnabled = true;
            this.boxEqpTrnsfrtSelection.Location = new System.Drawing.Point(6, 19);
            this.boxEqpTrnsfrtSelection.Name = "boxEqpTrnsfrtSelection";
            this.boxEqpTrnsfrtSelection.Size = new System.Drawing.Size(337, 21);
            this.boxEqpTrnsfrtSelection.TabIndex = 5;
            // 
            // gpbxSlctJoueur
            // 
            this.gpbxSlctJoueur.Controls.Add(this.lstbxJoueursEqpOrgn);
            this.gpbxSlctJoueur.Location = new System.Drawing.Point(6, 46);
            this.gpbxSlctJoueur.Name = "gpbxSlctJoueur";
            this.gpbxSlctJoueur.Size = new System.Drawing.Size(240, 255);
            this.gpbxSlctJoueur.TabIndex = 20;
            this.gpbxSlctJoueur.TabStop = false;
            this.gpbxSlctJoueur.Text = "Sélectionner le joueur à transférer";
            // 
            // btnTransferer
            // 
            this.btnTransferer.Location = new System.Drawing.Point(485, 21);
            this.btnTransferer.Name = "btnTransferer";
            this.btnTransferer.Size = new System.Drawing.Size(257, 39);
            this.btnTransferer.TabIndex = 21;
            this.btnTransferer.Text = "Transférer";
            this.btnTransferer.UseVisualStyleBackColor = true;
            // 
            // lstbxJoueursEqpOrgn
            // 
            this.lstbxJoueursEqpOrgn.FormattingEnabled = true;
            this.lstbxJoueursEqpOrgn.Location = new System.Drawing.Point(6, 19);
            this.lstbxJoueursEqpOrgn.Name = "lstbxJoueursEqpOrgn";
            this.lstbxJoueursEqpOrgn.Size = new System.Drawing.Size(225, 212);
            this.lstbxJoueursEqpOrgn.TabIndex = 28;
            // 
            // lstbxJoueursEqpTrnsfrt
            // 
            this.lstbxJoueursEqpTrnsfrt.FormattingEnabled = true;
            this.lstbxJoueursEqpTrnsfrt.Location = new System.Drawing.Point(62, 65);
            this.lstbxJoueursEqpTrnsfrt.Name = "lstbxJoueursEqpTrnsfrt";
            this.lstbxJoueursEqpTrnsfrt.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbxJoueursEqpTrnsfrt.Size = new System.Drawing.Size(225, 212);
            this.lstbxJoueursEqpTrnsfrt.TabIndex = 29;
            // 
            // frmTransfertJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnTransferer);
            this.Controls.Add(this.gpbxSlctEqpTrnsfrt);
            this.Controls.Add(this.gpbxSlctEqpOrgn);
            this.Controls.Add(this.gpbxSlctChamp);
            this.Name = "frmTransfertJoueur";
            this.Text = "Transfert de joueur";
            this.Load += new System.EventHandler(this.frmTransfertJoueur_Load);
            this.gpbxSlctEqpOrgn.ResumeLayout(false);
            this.gpbxSlctChamp.ResumeLayout(false);
            this.gpbxSlctEqpTrnsfrt.ResumeLayout(false);
            this.gpbxSlctJoueur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxSlctEqpOrgn;
        private System.Windows.Forms.ComboBox boxEqpOrgnSelection;
        private System.Windows.Forms.GroupBox gpbxSlctChamp;
        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.GroupBox gpbxSlctJoueur;
        private System.Windows.Forms.GroupBox gpbxSlctEqpTrnsfrt;
        private System.Windows.Forms.ComboBox boxEqpTrnsfrtSelection;
        private System.Windows.Forms.Button btnTransferer;
        private System.Windows.Forms.ListBox lstbxJoueursEqpOrgn;
        private System.Windows.Forms.ListBox lstbxJoueursEqpTrnsfrt;
    }
}