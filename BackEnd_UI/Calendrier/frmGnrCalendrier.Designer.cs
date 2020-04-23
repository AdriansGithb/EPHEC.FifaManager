namespace BackEnd_UI.Calendrier
{
    partial class frmGnrCalendrier
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
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            this.gpbxGeneration = new System.Windows.Forms.GroupBox();
            this.btnGnrClndr = new System.Windows.Forms.Button();
            this.rdbtnAllSeason = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGnrClndr = new System.Windows.Forms.Label();
            this.lblMchNoDate = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.gpbxGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResults
            // 
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(12, 206);
            this.gridResults.MultiSelect = false;
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResults.Size = new System.Drawing.Size(436, 315);
            this.gridResults.TabIndex = 7;
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
            // 
            // gpbxGeneration
            // 
            this.gpbxGeneration.Controls.Add(this.btnGnrClndr);
            this.gpbxGeneration.Controls.Add(this.rdbtnAllSeason);
            this.gpbxGeneration.Controls.Add(this.rdbtnSeason2);
            this.gpbxGeneration.Controls.Add(this.rdbtnSeason1);
            this.gpbxGeneration.Controls.Add(this.boxChampSelection);
            this.gpbxGeneration.Location = new System.Drawing.Point(12, 12);
            this.gpbxGeneration.Name = "gpbxGeneration";
            this.gpbxGeneration.Size = new System.Drawing.Size(633, 123);
            this.gpbxGeneration.TabIndex = 8;
            this.gpbxGeneration.TabStop = false;
            this.gpbxGeneration.Text = "Sélectionner le championnat et la saison ";
            // 
            // btnGnrClndr
            // 
            this.btnGnrClndr.Enabled = false;
            this.btnGnrClndr.Location = new System.Drawing.Point(443, 30);
            this.btnGnrClndr.Name = "btnGnrClndr";
            this.btnGnrClndr.Size = new System.Drawing.Size(184, 73);
            this.btnGnrClndr.TabIndex = 14;
            this.btnGnrClndr.Text = "Générer un nouveau calendrier";
            this.btnGnrClndr.UseVisualStyleBackColor = true;
            // 
            // rdbtnAllSeason
            // 
            this.rdbtnAllSeason.AutoSize = true;
            this.rdbtnAllSeason.Enabled = false;
            this.rdbtnAllSeason.Location = new System.Drawing.Point(319, 86);
            this.rdbtnAllSeason.Name = "rdbtnAllSeason";
            this.rdbtnAllSeason.Size = new System.Drawing.Size(83, 17);
            this.rdbtnAllSeason.TabIndex = 2;
            this.rdbtnAllSeason.Text = "Saisons 1+2";
            this.rdbtnAllSeason.UseVisualStyleBackColor = true;
            // 
            // rdbtnSeason2
            // 
            this.rdbtnSeason2.AutoSize = true;
            this.rdbtnSeason2.Enabled = false;
            this.rdbtnSeason2.Location = new System.Drawing.Point(174, 86);
            this.rdbtnSeason2.Name = "rdbtnSeason2";
            this.rdbtnSeason2.Size = new System.Drawing.Size(66, 17);
            this.rdbtnSeason2.TabIndex = 1;
            this.rdbtnSeason2.Text = "Saison 2";
            this.rdbtnSeason2.UseVisualStyleBackColor = true;
            // 
            // rdbtnSeason1
            // 
            this.rdbtnSeason1.AutoSize = true;
            this.rdbtnSeason1.Enabled = false;
            this.rdbtnSeason1.Location = new System.Drawing.Point(36, 86);
            this.rdbtnSeason1.Name = "rdbtnSeason1";
            this.rdbtnSeason1.Size = new System.Drawing.Size(66, 17);
            this.rdbtnSeason1.TabIndex = 0;
            this.rdbtnSeason1.Text = "Saison 1";
            this.rdbtnSeason1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(466, 206);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 315);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblGnrClndr
            // 
            this.lblGnrClndr.AutoSize = true;
            this.lblGnrClndr.Location = new System.Drawing.Point(13, 187);
            this.lblGnrClndr.Name = "lblGnrClndr";
            this.lblGnrClndr.Size = new System.Drawing.Size(96, 13);
            this.lblGnrClndr.TabIndex = 10;
            this.lblGnrClndr.Text = "Calendrier généré :";
            // 
            // lblMchNoDate
            // 
            this.lblMchNoDate.AutoSize = true;
            this.lblMchNoDate.Enabled = false;
            this.lblMchNoDate.Location = new System.Drawing.Point(553, 187);
            this.lblMchNoDate.Name = "lblMchNoDate";
            this.lblMchNoDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMchNoDate.Size = new System.Drawing.Size(349, 13);
            this.lblMchNoDate.TabIndex = 11;
            this.lblMchNoDate.Text = "Matchs sans date, à insérer manuellement via la fenêtre de modification :";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Enabled = false;
            this.btnSaveClose.Location = new System.Drawing.Point(707, 12);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(154, 66);
            this.btnSaveClose.TabIndex = 12;
            this.btnSaveClose.Text = "Sauver calendrier et fermer";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            // 
            // btnSaveInsert
            // 
            this.btnSaveInsert.Enabled = false;
            this.btnSaveInsert.Location = new System.Drawing.Point(707, 98);
            this.btnSaveInsert.Name = "btnSaveInsert";
            this.btnSaveInsert.Size = new System.Drawing.Size(154, 66);
            this.btnSaveInsert.TabIndex = 13;
            this.btnSaveInsert.Text = "Sauver calendrier et ouvrir la fenêtre de modification des matchs";
            this.btnSaveInsert.UseVisualStyleBackColor = true;
            // 
            // frmGnrCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 527);
            this.Controls.Add(this.btnSaveInsert);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.lblMchNoDate);
            this.Controls.Add(this.lblGnrClndr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.gpbxGeneration);
            this.Name = "frmGnrCalendrier";
            this.Text = "Génération de calendrier de championnat";
            this.Load += new System.EventHandler(this.frmGnrCalendrier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.gpbxGeneration.ResumeLayout(false);
            this.gpbxGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.GroupBox gpbxGeneration;
        private System.Windows.Forms.RadioButton rdbtnAllSeason;
        private System.Windows.Forms.RadioButton rdbtnSeason2;
        private System.Windows.Forms.RadioButton rdbtnSeason1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGnrClndr;
        private System.Windows.Forms.Label lblMchNoDate;
        private System.Windows.Forms.Button btnGnrClndr;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSaveInsert;
    }
}