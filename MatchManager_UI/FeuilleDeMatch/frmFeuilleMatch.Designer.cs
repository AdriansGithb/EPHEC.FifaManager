namespace MatchManager_UI.FeuilleDeMatch
{
    partial class frmFeuilleMatch
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
            this.gpbxEvent = new System.Windows.Forms.GroupBox();
            this.lblSelectEvent = new System.Windows.Forms.Label();
            this.gpbxJoueur = new System.Windows.Forms.GroupBox();
            this.boxNbEvent = new System.Windows.Forms.ComboBox();
            this.lblNbEvent = new System.Windows.Forms.Label();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.lblEqp = new System.Windows.Forms.Label();
            this.btnEventSave = new System.Windows.Forms.Button();
            this.boxJoueurs = new System.Windows.Forms.ComboBox();
            this.boxEquipes = new System.Windows.Forms.ComboBox();
            this.boxEvent = new System.Windows.Forms.ComboBox();
            this.gpbxResult = new System.Windows.Forms.GroupBox();
            this.btnResultSave = new System.Windows.Forms.Button();
            this.boxResultVisit = new System.Windows.Forms.ComboBox();
            this.lblNomEqpVisit = new System.Windows.Forms.Label();
            this.lblEqpVisit = new System.Windows.Forms.Label();
            this.boxResultDom = new System.Windows.Forms.ComboBox();
            this.lblGoalsVisit = new System.Windows.Forms.Label();
            this.lblGoalsDom = new System.Windows.Forms.Label();
            this.lblNomEqpDom = new System.Windows.Forms.Label();
            this.lblEqpDom = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.gpbxEvent.SuspendLayout();
            this.gpbxJoueur.SuspendLayout();
            this.gpbxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxEvent
            // 
            this.gpbxEvent.Controls.Add(this.lblSelectEvent);
            this.gpbxEvent.Controls.Add(this.gpbxJoueur);
            this.gpbxEvent.Controls.Add(this.boxEvent);
            this.gpbxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxEvent.Location = new System.Drawing.Point(12, 29);
            this.gpbxEvent.Name = "gpbxEvent";
            this.gpbxEvent.Size = new System.Drawing.Size(776, 164);
            this.gpbxEvent.TabIndex = 0;
            this.gpbxEvent.TabStop = false;
            this.gpbxEvent.Text = "Encoder un événement";
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(261, 14);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(137, 13);
            this.lblSelectEvent.TabIndex = 2;
            this.lblSelectEvent.Text = "Sélectionner un événement";
            // 
            // gpbxJoueur
            // 
            this.gpbxJoueur.Controls.Add(this.boxNbEvent);
            this.gpbxJoueur.Controls.Add(this.lblNbEvent);
            this.gpbxJoueur.Controls.Add(this.lblJoueur);
            this.gpbxJoueur.Controls.Add(this.lblEqp);
            this.gpbxJoueur.Controls.Add(this.btnEventSave);
            this.gpbxJoueur.Controls.Add(this.boxJoueurs);
            this.gpbxJoueur.Controls.Add(this.boxEquipes);
            this.gpbxJoueur.Location = new System.Drawing.Point(6, 57);
            this.gpbxJoueur.Name = "gpbxJoueur";
            this.gpbxJoueur.Size = new System.Drawing.Size(764, 100);
            this.gpbxJoueur.TabIndex = 1;
            this.gpbxJoueur.TabStop = false;
            this.gpbxJoueur.Text = "Sélectionner le joueur lié à l\'événement";
            // 
            // boxNbEvent
            // 
            this.boxNbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxNbEvent.FormattingEnabled = true;
            this.boxNbEvent.Location = new System.Drawing.Point(503, 44);
            this.boxNbEvent.Name = "boxNbEvent";
            this.boxNbEvent.Size = new System.Drawing.Size(56, 21);
            this.boxNbEvent.TabIndex = 9;
            // 
            // lblNbEvent
            // 
            this.lblNbEvent.AutoSize = true;
            this.lblNbEvent.Location = new System.Drawing.Point(500, 28);
            this.lblNbEvent.Name = "lblNbEvent";
            this.lblNbEvent.Size = new System.Drawing.Size(59, 13);
            this.lblNbEvent.TabIndex = 6;
            this.lblNbEvent.Text = "#Nb Event";
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(230, 28);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(63, 13);
            this.lblJoueur.TabIndex = 5;
            this.lblJoueur.Text = "2. Le joueur";
            // 
            // lblEqp
            // 
            this.lblEqp.AutoSize = true;
            this.lblEqp.Location = new System.Drawing.Point(6, 28);
            this.lblEqp.Name = "lblEqp";
            this.lblEqp.Size = new System.Drawing.Size(106, 13);
            this.lblEqp.TabIndex = 4;
            this.lblEqp.Text = "1. L\'équipe du joueur";
            // 
            // btnEventSave
            // 
            this.btnEventSave.Location = new System.Drawing.Point(632, 53);
            this.btnEventSave.Name = "btnEventSave";
            this.btnEventSave.Size = new System.Drawing.Size(126, 40);
            this.btnEventSave.TabIndex = 3;
            this.btnEventSave.Text = "Sauver l\'événement";
            this.btnEventSave.UseVisualStyleBackColor = true;
            this.btnEventSave.Click += new System.EventHandler(this.btnEventSave_Click);
            // 
            // boxJoueurs
            // 
            this.boxJoueurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxJoueurs.FormattingEnabled = true;
            this.boxJoueurs.Location = new System.Drawing.Point(233, 44);
            this.boxJoueurs.Name = "boxJoueurs";
            this.boxJoueurs.Size = new System.Drawing.Size(197, 21);
            this.boxJoueurs.TabIndex = 1;
            // 
            // boxEquipes
            // 
            this.boxEquipes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEquipes.FormattingEnabled = true;
            this.boxEquipes.Location = new System.Drawing.Point(6, 44);
            this.boxEquipes.Name = "boxEquipes";
            this.boxEquipes.Size = new System.Drawing.Size(162, 21);
            this.boxEquipes.TabIndex = 0;
            this.boxEquipes.SelectedIndexChanged += new System.EventHandler(this.boxJoueurs_Load);
            // 
            // boxEvent
            // 
            this.boxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEvent.FormattingEnabled = true;
            this.boxEvent.Location = new System.Drawing.Point(264, 30);
            this.boxEvent.Name = "boxEvent";
            this.boxEvent.Size = new System.Drawing.Size(237, 21);
            this.boxEvent.TabIndex = 0;
            // 
            // gpbxResult
            // 
            this.gpbxResult.Controls.Add(this.btnResultSave);
            this.gpbxResult.Controls.Add(this.boxResultVisit);
            this.gpbxResult.Controls.Add(this.lblNomEqpVisit);
            this.gpbxResult.Controls.Add(this.lblEqpVisit);
            this.gpbxResult.Controls.Add(this.boxResultDom);
            this.gpbxResult.Controls.Add(this.lblGoalsVisit);
            this.gpbxResult.Controls.Add(this.lblGoalsDom);
            this.gpbxResult.Controls.Add(this.lblNomEqpDom);
            this.gpbxResult.Controls.Add(this.lblEqpDom);
            this.gpbxResult.Location = new System.Drawing.Point(12, 199);
            this.gpbxResult.Name = "gpbxResult";
            this.gpbxResult.Size = new System.Drawing.Size(776, 126);
            this.gpbxResult.TabIndex = 1;
            this.gpbxResult.TabStop = false;
            this.gpbxResult.Text = "Encoder les résultats";
            // 
            // btnResultSave
            // 
            this.btnResultSave.Location = new System.Drawing.Point(638, 26);
            this.btnResultSave.Name = "btnResultSave";
            this.btnResultSave.Size = new System.Drawing.Size(126, 64);
            this.btnResultSave.TabIndex = 7;
            this.btnResultSave.Text = "Sauver le résultat et fermer la feuille de match";
            this.btnResultSave.UseVisualStyleBackColor = true;
            this.btnResultSave.Click += new System.EventHandler(this.btnResultSave_Click);
            // 
            // boxResultVisit
            // 
            this.boxResultVisit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxResultVisit.FormattingEnabled = true;
            this.boxResultVisit.Location = new System.Drawing.Point(418, 69);
            this.boxResultVisit.Name = "boxResultVisit";
            this.boxResultVisit.Size = new System.Drawing.Size(135, 21);
            this.boxResultVisit.TabIndex = 8;
            // 
            // lblNomEqpVisit
            // 
            this.lblNomEqpVisit.AutoSize = true;
            this.lblNomEqpVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEqpVisit.Location = new System.Drawing.Point(415, 49);
            this.lblNomEqpVisit.Name = "lblNomEqpVisit";
            this.lblNomEqpVisit.Size = new System.Drawing.Size(136, 17);
            this.lblNomEqpVisit.TabIndex = 7;
            this.lblNomEqpVisit.Text = "Nom Equipe Visiteur";
            // 
            // lblEqpVisit
            // 
            this.lblEqpVisit.AutoSize = true;
            this.lblEqpVisit.Location = new System.Drawing.Point(454, 26);
            this.lblEqpVisit.Name = "lblEqpVisit";
            this.lblEqpVisit.Size = new System.Drawing.Size(41, 13);
            this.lblEqpVisit.TabIndex = 6;
            this.lblEqpVisit.Text = "Visiteur";
            // 
            // boxResultDom
            // 
            this.boxResultDom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxResultDom.FormattingEnabled = true;
            this.boxResultDom.Location = new System.Drawing.Point(51, 69);
            this.boxResultDom.Name = "boxResultDom";
            this.boxResultDom.Size = new System.Drawing.Size(135, 21);
            this.boxResultDom.TabIndex = 5;
            // 
            // lblGoalsVisit
            // 
            this.lblGoalsVisit.AutoSize = true;
            this.lblGoalsVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalsVisit.Location = new System.Drawing.Point(319, 49);
            this.lblGoalsVisit.Name = "lblGoalsVisit";
            this.lblGoalsVisit.Size = new System.Drawing.Size(30, 31);
            this.lblGoalsVisit.TabIndex = 4;
            this.lblGoalsVisit.Text = "0";
            // 
            // lblGoalsDom
            // 
            this.lblGoalsDom.AutoSize = true;
            this.lblGoalsDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalsDom.Location = new System.Drawing.Point(237, 49);
            this.lblGoalsDom.Name = "lblGoalsDom";
            this.lblGoalsDom.Size = new System.Drawing.Size(30, 31);
            this.lblGoalsDom.TabIndex = 2;
            this.lblGoalsDom.Text = "0";
            // 
            // lblNomEqpDom
            // 
            this.lblNomEqpDom.AutoSize = true;
            this.lblNomEqpDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEqpDom.Location = new System.Drawing.Point(48, 49);
            this.lblNomEqpDom.Name = "lblNomEqpDom";
            this.lblNomEqpDom.Size = new System.Drawing.Size(142, 17);
            this.lblNomEqpDom.TabIndex = 1;
            this.lblNomEqpDom.Text = "Nom Equipe Domicile";
            // 
            // lblEqpDom
            // 
            this.lblEqpDom.AutoSize = true;
            this.lblEqpDom.Location = new System.Drawing.Point(83, 26);
            this.lblEqpDom.Name = "lblEqpDom";
            this.lblEqpDom.Size = new System.Drawing.Size(47, 13);
            this.lblEqpDom.TabIndex = 0;
            this.lblEqpDom.Text = "Domicile";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(21, 9);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(51, 17);
            this.lblMatch.TabIndex = 44;
            this.lblMatch.Text = "Match";
            // 
            // frmFeuilleMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.gpbxResult);
            this.Controls.Add(this.gpbxEvent);
            this.Name = "frmFeuilleMatch";
            this.Text = "Feuille de match";
            this.Load += new System.EventHandler(this.frmFeuilleMatch_Load);
            this.gpbxEvent.ResumeLayout(false);
            this.gpbxEvent.PerformLayout();
            this.gpbxJoueur.ResumeLayout(false);
            this.gpbxJoueur.PerformLayout();
            this.gpbxResult.ResumeLayout(false);
            this.gpbxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxEvent;
        private System.Windows.Forms.Label lblSelectEvent;
        private System.Windows.Forms.GroupBox gpbxJoueur;
        private System.Windows.Forms.Label lblNbEvent;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Label lblEqp;
        private System.Windows.Forms.Button btnEventSave;
        private System.Windows.Forms.ComboBox boxJoueurs;
        private System.Windows.Forms.ComboBox boxEquipes;
        private System.Windows.Forms.ComboBox boxEvent;
        private System.Windows.Forms.GroupBox gpbxResult;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblGoalsVisit;
        private System.Windows.Forms.Label lblGoalsDom;
        private System.Windows.Forms.Label lblNomEqpDom;
        private System.Windows.Forms.Label lblEqpDom;
        private System.Windows.Forms.Button btnResultSave;
        private System.Windows.Forms.ComboBox boxResultVisit;
        private System.Windows.Forms.Label lblNomEqpVisit;
        private System.Windows.Forms.Label lblEqpVisit;
        private System.Windows.Forms.ComboBox boxResultDom;
        private System.Windows.Forms.ComboBox boxNbEvent;
    }
}