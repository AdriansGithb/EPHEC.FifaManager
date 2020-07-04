namespace MatchManager_UI.Inscription
{
    partial class frmInscript_TeamSelection
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
            this.btnEqpDom = new System.Windows.Forms.Button();
            this.btnEqpVisit = new System.Windows.Forms.Button();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblVisit = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEqpDom
            // 
            this.btnEqpDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqpDom.Location = new System.Drawing.Point(12, 90);
            this.btnEqpDom.Name = "btnEqpDom";
            this.btnEqpDom.Size = new System.Drawing.Size(158, 227);
            this.btnEqpDom.TabIndex = 0;
            this.btnEqpDom.Text = "Nom Eqp Domicile";
            this.btnEqpDom.UseVisualStyleBackColor = true;
            this.btnEqpDom.Click += new System.EventHandler(this.btnEqpDom_Click);
            // 
            // btnEqpVisit
            // 
            this.btnEqpVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqpVisit.Location = new System.Drawing.Point(176, 90);
            this.btnEqpVisit.Name = "btnEqpVisit";
            this.btnEqpVisit.Size = new System.Drawing.Size(158, 227);
            this.btnEqpVisit.TabIndex = 1;
            this.btnEqpVisit.Text = "Nom Eqp Visiteuse";
            this.btnEqpVisit.UseVisualStyleBackColor = true;
            this.btnEqpVisit.Click += new System.EventHandler(this.btnEqpVisit_Click);
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDom.Location = new System.Drawing.Point(71, 74);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(47, 13);
            this.lblDom.TabIndex = 2;
            this.lblDom.Text = "Domicile";
            // 
            // lblVisit
            // 
            this.lblVisit.AutoSize = true;
            this.lblVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisit.Location = new System.Drawing.Point(235, 74);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Size = new System.Drawing.Size(41, 13);
            this.lblVisit.TabIndex = 3;
            this.lblVisit.Text = "Visiteur";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(12, 9);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(51, 17);
            this.lblMatch.TabIndex = 4;
            this.lblMatch.Text = "Match";
            // 
            // frmInscript_TeamSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 337);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.lblVisit);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.btnEqpVisit);
            this.Controls.Add(this.btnEqpDom);
            this.Name = "frmInscript_TeamSelection";
            this.Text = "Sélectionner l\'équipe désirée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEqpDom;
        private System.Windows.Forms.Button btnEqpVisit;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblVisit;
        private System.Windows.Forms.Label lblMatch;
    }
}