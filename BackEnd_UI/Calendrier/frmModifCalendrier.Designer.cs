namespace BackEnd_UI
{
    partial class frmModifCalendrier
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
            this.dtTmPckrMatch = new System.Windows.Forms.DateTimePicker();
            this.lblChampionnat = new System.Windows.Forms.Label();
            this.lblEqpDom = new System.Windows.Forms.Label();
            this.lblNomEqpDom = new System.Windows.Forms.Label();
            this.lblEqpVst = new System.Windows.Forms.Label();
            this.lblNomEqpVst = new System.Windows.Forms.Label();
            this.lblSsn = new System.Windows.Forms.Label();
            this.lblPrevDatetxt = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNwDate = new System.Windows.Forms.Label();
            this.lblPrevDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtTmPckrMatch
            // 
            this.dtTmPckrMatch.Location = new System.Drawing.Point(15, 202);
            this.dtTmPckrMatch.Name = "dtTmPckrMatch";
            this.dtTmPckrMatch.Size = new System.Drawing.Size(200, 20);
            this.dtTmPckrMatch.TabIndex = 0;
            // 
            // lblChampionnat
            // 
            this.lblChampionnat.AutoSize = true;
            this.lblChampionnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampionnat.Location = new System.Drawing.Point(12, 9);
            this.lblChampionnat.Name = "lblChampionnat";
            this.lblChampionnat.Size = new System.Drawing.Size(101, 16);
            this.lblChampionnat.TabIndex = 1;
            this.lblChampionnat.Text = "lblChampionnat";
            // 
            // lblEqpDom
            // 
            this.lblEqpDom.AutoSize = true;
            this.lblEqpDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpDom.Location = new System.Drawing.Point(9, 62);
            this.lblEqpDom.Name = "lblEqpDom";
            this.lblEqpDom.Size = new System.Drawing.Size(104, 15);
            this.lblEqpDom.TabIndex = 2;
            this.lblEqpDom.Text = "Equipe Domicile :";
            // 
            // lblNomEqpDom
            // 
            this.lblNomEqpDom.AutoSize = true;
            this.lblNomEqpDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEqpDom.Location = new System.Drawing.Point(12, 77);
            this.lblNomEqpDom.Name = "lblNomEqpDom";
            this.lblNomEqpDom.Size = new System.Drawing.Size(117, 16);
            this.lblNomEqpDom.TabIndex = 3;
            this.lblNomEqpDom.Text = "lblNomEqpDom";
            // 
            // lblEqpVst
            // 
            this.lblEqpVst.AutoSize = true;
            this.lblEqpVst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpVst.Location = new System.Drawing.Point(9, 93);
            this.lblEqpVst.Name = "lblEqpVst";
            this.lblEqpVst.Size = new System.Drawing.Size(104, 15);
            this.lblEqpVst.TabIndex = 4;
            this.lblEqpVst.Text = "Equipe Visiteuse :";
            // 
            // lblNomEqpVst
            // 
            this.lblNomEqpVst.AutoSize = true;
            this.lblNomEqpVst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEqpVst.Location = new System.Drawing.Point(12, 108);
            this.lblNomEqpVst.Name = "lblNomEqpVst";
            this.lblNomEqpVst.Size = new System.Drawing.Size(107, 16);
            this.lblNomEqpVst.TabIndex = 5;
            this.lblNomEqpVst.Text = "lblNomEqpVst";
            // 
            // lblSsn
            // 
            this.lblSsn.AutoSize = true;
            this.lblSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSsn.Location = new System.Drawing.Point(12, 25);
            this.lblSsn.Name = "lblSsn";
            this.lblSsn.Size = new System.Drawing.Size(45, 16);
            this.lblSsn.TabIndex = 6;
            this.lblSsn.Text = "lblSsn";
            // 
            // lblPrevDatetxt
            // 
            this.lblPrevDatetxt.AutoSize = true;
            this.lblPrevDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevDatetxt.Location = new System.Drawing.Point(9, 138);
            this.lblPrevDatetxt.Name = "lblPrevDatetxt";
            this.lblPrevDatetxt.Size = new System.Drawing.Size(85, 15);
            this.lblPrevDatetxt.TabIndex = 7;
            this.lblPrevDatetxt.Text = "Date actuelle :";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(15, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sauver";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblNwDate
            // 
            this.lblNwDate.AutoSize = true;
            this.lblNwDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNwDate.Location = new System.Drawing.Point(9, 184);
            this.lblNwDate.Name = "lblNwDate";
            this.lblNwDate.Size = new System.Drawing.Size(184, 15);
            this.lblNwDate.TabIndex = 9;
            this.lblNwDate.Text = "Sélectionnez une nouvelle date :";
            // 
            // lblPrevDate
            // 
            this.lblPrevDate.AutoSize = true;
            this.lblPrevDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevDate.Location = new System.Drawing.Point(12, 153);
            this.lblPrevDate.Name = "lblPrevDate";
            this.lblPrevDate.Size = new System.Drawing.Size(81, 15);
            this.lblPrevDate.TabIndex = 10;
            this.lblPrevDate.Text = "lblPrevDate";
            // 
            // frmModifCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 291);
            this.Controls.Add(this.lblPrevDate);
            this.Controls.Add(this.lblNwDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPrevDatetxt);
            this.Controls.Add(this.lblSsn);
            this.Controls.Add(this.lblNomEqpVst);
            this.Controls.Add(this.lblEqpVst);
            this.Controls.Add(this.lblNomEqpDom);
            this.Controls.Add(this.lblEqpDom);
            this.Controls.Add(this.lblChampionnat);
            this.Controls.Add(this.dtTmPckrMatch);
            this.Name = "frmModifCalendrier";
            this.Text = "Modification calendrier";
            this.Load += new System.EventHandler(this.frmModifCalendrier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTmPckrMatch;
        private System.Windows.Forms.Label lblChampionnat;
        private System.Windows.Forms.Label lblEqpDom;
        private System.Windows.Forms.Label lblNomEqpDom;
        private System.Windows.Forms.Label lblEqpVst;
        private System.Windows.Forms.Label lblNomEqpVst;
        private System.Windows.Forms.Label lblSsn;
        private System.Windows.Forms.Label lblPrevDatetxt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNwDate;
        private System.Windows.Forms.Label lblPrevDate;
    }
}