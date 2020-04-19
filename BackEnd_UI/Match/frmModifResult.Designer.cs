namespace BackEnd_UI.Match
{
    partial class frmModifResult
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstbxResEqpDom = new System.Windows.Forms.ListBox();
            this.lblEqpDom = new System.Windows.Forms.Label();
            this.lblEqpVis = new System.Windows.Forms.Label();
            this.lstbxResEqpVis = new System.Windows.Forms.ListBox();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblConsigne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Sauver";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstbxResEqpDom
            // 
            this.lstbxResEqpDom.FormattingEnabled = true;
            this.lstbxResEqpDom.Location = new System.Drawing.Point(48, 94);
            this.lstbxResEqpDom.Name = "lstbxResEqpDom";
            this.lstbxResEqpDom.Size = new System.Drawing.Size(120, 95);
            this.lstbxResEqpDom.TabIndex = 2;
            // 
            // lblEqpDom
            // 
            this.lblEqpDom.AutoSize = true;
            this.lblEqpDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpDom.Location = new System.Drawing.Point(44, 71);
            this.lblEqpDom.Name = "lblEqpDom";
            this.lblEqpDom.Size = new System.Drawing.Size(96, 20);
            this.lblEqpDom.TabIndex = 3;
            this.lblEqpDom.Text = "lblEqpDom";
            // 
            // lblEqpVis
            // 
            this.lblEqpVis.AutoSize = true;
            this.lblEqpVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqpVis.Location = new System.Drawing.Point(238, 71);
            this.lblEqpVis.Name = "lblEqpVis";
            this.lblEqpVis.Size = new System.Drawing.Size(84, 20);
            this.lblEqpVis.TabIndex = 4;
            this.lblEqpVis.Text = "lblEqpVis";
            // 
            // lstbxResEqpVis
            // 
            this.lstbxResEqpVis.FormattingEnabled = true;
            this.lstbxResEqpVis.Location = new System.Drawing.Point(242, 94);
            this.lstbxResEqpVis.Name = "lstbxResEqpVis";
            this.lstbxResEqpVis.Size = new System.Drawing.Size(120, 95);
            this.lstbxResEqpVis.TabIndex = 5;
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(12, 9);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(63, 18);
            this.lblMatch.TabIndex = 6;
            this.lblMatch.Text = "lblMatch";
            // 
            // lblConsigne
            // 
            this.lblConsigne.AutoSize = true;
            this.lblConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsigne.Location = new System.Drawing.Point(48, 42);
            this.lblConsigne.Name = "lblConsigne";
            this.lblConsigne.Size = new System.Drawing.Size(212, 16);
            this.lblConsigne.TabIndex = 7;
            this.lblConsigne.Text = "Modifiez les résultats puis sauvez :";
            // 
            // frmModifResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 301);
            this.Controls.Add(this.lblConsigne);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.lstbxResEqpVis);
            this.Controls.Add(this.lblEqpVis);
            this.Controls.Add(this.lblEqpDom);
            this.Controls.Add(this.lstbxResEqpDom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmModifResult";
            this.Text = "frmModifResult";
            this.Load += new System.EventHandler(this.frmModifResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstbxResEqpDom;
        private System.Windows.Forms.Label lblEqpDom;
        private System.Windows.Forms.Label lblEqpVis;
        private System.Windows.Forms.ListBox lstbxResEqpVis;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblConsigne;
    }
}