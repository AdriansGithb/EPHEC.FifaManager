namespace MatchManager_UI.FeuilleDeMatch
{
    partial class frmChoixFeuilleMatch
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
            this.gpbxMatchSelection = new System.Windows.Forms.GroupBox();
            this.lblDayMatchs = new System.Windows.Forms.Label();
            this.lblCurrntChamp = new System.Windows.Forms.Label();
            this.lblChampEnCoursTxt = new System.Windows.Forms.Label();
            this.boxMatchSelection = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gpbxMatchSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxMatchSelection
            // 
            this.gpbxMatchSelection.Controls.Add(this.lblDayMatchs);
            this.gpbxMatchSelection.Controls.Add(this.lblCurrntChamp);
            this.gpbxMatchSelection.Controls.Add(this.lblChampEnCoursTxt);
            this.gpbxMatchSelection.Controls.Add(this.boxMatchSelection);
            this.gpbxMatchSelection.Location = new System.Drawing.Point(12, 12);
            this.gpbxMatchSelection.Name = "gpbxMatchSelection";
            this.gpbxMatchSelection.Size = new System.Drawing.Size(294, 100);
            this.gpbxMatchSelection.TabIndex = 0;
            this.gpbxMatchSelection.TabStop = false;
            this.gpbxMatchSelection.Text = "Sélectionner le match à éditer";
            // 
            // lblDayMatchs
            // 
            this.lblDayMatchs.AutoSize = true;
            this.lblDayMatchs.Location = new System.Drawing.Point(6, 48);
            this.lblDayMatchs.Name = "lblDayMatchs";
            this.lblDayMatchs.Size = new System.Drawing.Size(83, 13);
            this.lblDayMatchs.TabIndex = 3;
            this.lblDayMatchs.Text = "Match(s) du jour";
            // 
            // lblCurrntChamp
            // 
            this.lblCurrntChamp.AutoSize = true;
            this.lblCurrntChamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrntChamp.Location = new System.Drawing.Point(107, 31);
            this.lblCurrntChamp.Name = "lblCurrntChamp";
            this.lblCurrntChamp.Size = new System.Drawing.Size(103, 17);
            this.lblCurrntChamp.TabIndex = 2;
            this.lblCurrntChamp.Text = "Current Champ";
            // 
            // lblChampEnCoursTxt
            // 
            this.lblChampEnCoursTxt.AutoSize = true;
            this.lblChampEnCoursTxt.Enabled = false;
            this.lblChampEnCoursTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampEnCoursTxt.Location = new System.Drawing.Point(72, 16);
            this.lblChampEnCoursTxt.Name = "lblChampEnCoursTxt";
            this.lblChampEnCoursTxt.Size = new System.Drawing.Size(127, 13);
            this.lblChampEnCoursTxt.TabIndex = 1;
            this.lblChampEnCoursTxt.Text = "Championnat de l\'année :";
            this.lblChampEnCoursTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxMatchSelection
            // 
            this.boxMatchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMatchSelection.FormattingEnabled = true;
            this.boxMatchSelection.Location = new System.Drawing.Point(6, 64);
            this.boxMatchSelection.Name = "boxMatchSelection";
            this.boxMatchSelection.Size = new System.Drawing.Size(282, 21);
            this.boxMatchSelection.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(33, 152);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(242, 58);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Editer la feuille de match";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmChoixFeuilleMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 222);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gpbxMatchSelection);
            this.Name = "frmChoixFeuilleMatch";
            this.Text = "Sélection du match à éditer";
            this.Load += new System.EventHandler(this.frmChoixFeuilleMatch_Load);
            this.gpbxMatchSelection.ResumeLayout(false);
            this.gpbxMatchSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxMatchSelection;
        private System.Windows.Forms.Label lblDayMatchs;
        private System.Windows.Forms.Label lblCurrntChamp;
        private System.Windows.Forms.Label lblChampEnCoursTxt;
        private System.Windows.Forms.ComboBox boxMatchSelection;
        private System.Windows.Forms.Button btnSelect;
    }
}