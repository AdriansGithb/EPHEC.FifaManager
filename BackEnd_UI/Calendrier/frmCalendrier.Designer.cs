namespace BackEnd_UI.Calendrier
{
    partial class frmCalendrier
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
            this.gridClndrDated = new System.Windows.Forms.DataGridView();
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            this.gpbxSlctChamp = new System.Windows.Forms.GroupBox();
            this.rdbtnAllSeason = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason1 = new System.Windows.Forms.RadioButton();
            this.btnGnrClndr = new System.Windows.Forms.Button();
            this.lblUndatedClndr = new System.Windows.Forms.Label();
            this.lblDatedClndr = new System.Windows.Forms.Label();
            this.gridClndrUndated = new System.Windows.Forms.DataGridView();
            this.gpbxGnrClndr = new System.Windows.Forms.GroupBox();
            this.gpbxClndrs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrDated)).BeginInit();
            this.gpbxSlctChamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrUndated)).BeginInit();
            this.gpbxGnrClndr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridClndrDated
            // 
            this.gridClndrDated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridClndrDated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClndrDated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClndrDated.Location = new System.Drawing.Point(28, 212);
            this.gridClndrDated.MultiSelect = false;
            this.gridClndrDated.Name = "gridClndrDated";
            this.gridClndrDated.ReadOnly = true;
            this.gridClndrDated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClndrDated.Size = new System.Drawing.Size(436, 315);
            this.gridClndrDated.TabIndex = 14;
            // 
            // boxChampSelection
            // 
            this.boxChampSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxChampSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxChampSelection.FormattingEnabled = true;
            this.boxChampSelection.Location = new System.Drawing.Point(36, 30);
            this.boxChampSelection.Name = "boxChampSelection";
            this.boxChampSelection.Size = new System.Drawing.Size(337, 21);
            this.boxChampSelection.TabIndex = 5;
            this.boxChampSelection.SelectedIndexChanged += new System.EventHandler(this.clndrGrids_Load);
            // 
            // gpbxSlctChamp
            // 
            this.gpbxSlctChamp.Controls.Add(this.rdbtnAllSeason);
            this.gpbxSlctChamp.Controls.Add(this.rdbtnSeason2);
            this.gpbxSlctChamp.Controls.Add(this.rdbtnSeason1);
            this.gpbxSlctChamp.Controls.Add(this.boxChampSelection);
            this.gpbxSlctChamp.Location = new System.Drawing.Point(28, 18);
            this.gpbxSlctChamp.Name = "gpbxSlctChamp";
            this.gpbxSlctChamp.Size = new System.Drawing.Size(436, 123);
            this.gpbxSlctChamp.TabIndex = 15;
            this.gpbxSlctChamp.TabStop = false;
            this.gpbxSlctChamp.Text = "Sélectionner le championnat et la saison ";
            // 
            // rdbtnAllSeason
            // 
            this.rdbtnAllSeason.AutoSize = true;
            this.rdbtnAllSeason.Checked = true;
            this.rdbtnAllSeason.Location = new System.Drawing.Point(319, 86);
            this.rdbtnAllSeason.Name = "rdbtnAllSeason";
            this.rdbtnAllSeason.Size = new System.Drawing.Size(83, 17);
            this.rdbtnAllSeason.TabIndex = 2;
            this.rdbtnAllSeason.TabStop = true;
            this.rdbtnAllSeason.Text = "Saisons 1+2";
            this.rdbtnAllSeason.UseVisualStyleBackColor = true;
            this.rdbtnAllSeason.Click += new System.EventHandler(this.clndrGrids_Load);
            // 
            // rdbtnSeason2
            // 
            this.rdbtnSeason2.AutoSize = true;
            this.rdbtnSeason2.Location = new System.Drawing.Point(174, 86);
            this.rdbtnSeason2.Name = "rdbtnSeason2";
            this.rdbtnSeason2.Size = new System.Drawing.Size(66, 17);
            this.rdbtnSeason2.TabIndex = 1;
            this.rdbtnSeason2.Text = "Saison 2";
            this.rdbtnSeason2.UseVisualStyleBackColor = true;
            this.rdbtnSeason2.Click += new System.EventHandler(this.clndrGrids_Load);
            // 
            // rdbtnSeason1
            // 
            this.rdbtnSeason1.AutoSize = true;
            this.rdbtnSeason1.Location = new System.Drawing.Point(36, 86);
            this.rdbtnSeason1.Name = "rdbtnSeason1";
            this.rdbtnSeason1.Size = new System.Drawing.Size(66, 17);
            this.rdbtnSeason1.TabIndex = 0;
            this.rdbtnSeason1.Text = "Saison 1";
            this.rdbtnSeason1.UseVisualStyleBackColor = true;
            this.rdbtnSeason1.Click += new System.EventHandler(this.clndrGrids_Load);
            // 
            // btnGnrClndr
            // 
            this.btnGnrClndr.Location = new System.Drawing.Point(36, 30);
            this.btnGnrClndr.Name = "btnGnrClndr";
            this.btnGnrClndr.Size = new System.Drawing.Size(188, 73);
            this.btnGnrClndr.TabIndex = 14;
            this.btnGnrClndr.Text = "Générer un nouveau calendrier";
            this.btnGnrClndr.UseVisualStyleBackColor = true;
            this.btnGnrClndr.Click += new System.EventHandler(this.btnGnrClndr_Click);
            // 
            // lblUndatedClndr
            // 
            this.lblUndatedClndr.AutoSize = true;
            this.lblUndatedClndr.Location = new System.Drawing.Point(697, 193);
            this.lblUndatedClndr.Name = "lblUndatedClndr";
            this.lblUndatedClndr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUndatedClndr.Size = new System.Drawing.Size(221, 13);
            this.lblUndatedClndr.TabIndex = 18;
            this.lblUndatedClndr.Text = "Matchs sans dates, à modifier manuellement :";
            // 
            // lblDatedClndr
            // 
            this.lblDatedClndr.AutoSize = true;
            this.lblDatedClndr.Location = new System.Drawing.Point(29, 193);
            this.lblDatedClndr.Name = "lblDatedClndr";
            this.lblDatedClndr.Size = new System.Drawing.Size(92, 13);
            this.lblDatedClndr.TabIndex = 17;
            this.lblDatedClndr.Text = "Calendrier actuel :";
            // 
            // gridClndrUndated
            // 
            this.gridClndrUndated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClndrUndated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClndrUndated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClndrUndated.Location = new System.Drawing.Point(482, 212);
            this.gridClndrUndated.MultiSelect = false;
            this.gridClndrUndated.Name = "gridClndrUndated";
            this.gridClndrUndated.ReadOnly = true;
            this.gridClndrUndated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClndrUndated.Size = new System.Drawing.Size(436, 315);
            this.gridClndrUndated.TabIndex = 16;
            // 
            // gpbxGnrClndr
            // 
            this.gpbxGnrClndr.Controls.Add(this.btnGnrClndr);
            this.gpbxGnrClndr.Location = new System.Drawing.Point(553, 18);
            this.gpbxGnrClndr.Name = "gpbxGnrClndr";
            this.gpbxGnrClndr.Size = new System.Drawing.Size(252, 123);
            this.gpbxGnrClndr.TabIndex = 19;
            this.gpbxGnrClndr.TabStop = false;
            this.gpbxGnrClndr.Text = "Création de calendrier";
            // 
            // gpbxClndrs
            // 
            this.gpbxClndrs.Location = new System.Drawing.Point(12, 165);
            this.gpbxClndrs.Name = "gpbxClndrs";
            this.gpbxClndrs.Size = new System.Drawing.Size(922, 376);
            this.gpbxClndrs.TabIndex = 20;
            this.gpbxClndrs.TabStop = false;
            this.gpbxClndrs.Text = "Pour modifier, double cliquer sur le match cible";
            // 
            // frmCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 544);
            this.Controls.Add(this.gpbxGnrClndr);
            this.Controls.Add(this.gridClndrDated);
            this.Controls.Add(this.gpbxSlctChamp);
            this.Controls.Add(this.lblUndatedClndr);
            this.Controls.Add(this.lblDatedClndr);
            this.Controls.Add(this.gridClndrUndated);
            this.Controls.Add(this.gpbxClndrs);
            this.Name = "frmCalendrier";
            this.Text = "Gestion de calendrier";
            this.Load += new System.EventHandler(this.frmCalendrier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrDated)).EndInit();
            this.gpbxSlctChamp.ResumeLayout(false);
            this.gpbxSlctChamp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrUndated)).EndInit();
            this.gpbxGnrClndr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClndrDated;
        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.GroupBox gpbxSlctChamp;
        private System.Windows.Forms.RadioButton rdbtnAllSeason;
        private System.Windows.Forms.RadioButton rdbtnSeason2;
        private System.Windows.Forms.RadioButton rdbtnSeason1;
        private System.Windows.Forms.Button btnGnrClndr;
        private System.Windows.Forms.Label lblUndatedClndr;
        private System.Windows.Forms.Label lblDatedClndr;
        private System.Windows.Forms.DataGridView gridClndrUndated;
        private System.Windows.Forms.GroupBox gpbxGnrClndr;
        private System.Windows.Forms.GroupBox gpbxClndrs;
    }
}