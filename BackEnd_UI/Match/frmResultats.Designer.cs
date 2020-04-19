﻿namespace BackEnd_UI.Match
{
    partial class frmResultats
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
            this.gpBoxSaisons = new System.Windows.Forms.GroupBox();
            this.rdbtnAllSeason = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason1 = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.gpBoxSaisons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridResults
            // 
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridResults.Location = new System.Drawing.Point(0, 161);
            this.gridResults.Name = "gridResults";
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridResults.Size = new System.Drawing.Size(800, 289);
            this.gridResults.TabIndex = 0;
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
            this.boxChampSelection.SelectedIndexChanged += new System.EventHandler(this.boxChampSelection_SelectedIndexChanged);
            // 
            // gpBoxSaisons
            // 
            this.gpBoxSaisons.Controls.Add(this.rdbtnAllSeason);
            this.gpBoxSaisons.Controls.Add(this.rdbtnSeason2);
            this.gpBoxSaisons.Controls.Add(this.rdbtnSeason1);
            this.gpBoxSaisons.Controls.Add(this.boxChampSelection);
            this.gpBoxSaisons.Location = new System.Drawing.Point(29, 12);
            this.gpBoxSaisons.Name = "gpBoxSaisons";
            this.gpBoxSaisons.Size = new System.Drawing.Size(424, 123);
            this.gpBoxSaisons.TabIndex = 6;
            this.gpBoxSaisons.TabStop = false;
            this.gpBoxSaisons.Text = "Sélectionner le championnat et la saison à afficher";
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
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(557, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(166, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(557, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sauver changements";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmResultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gpBoxSaisons);
            this.Controls.Add(this.gridResults);
            this.Name = "frmResultats";
            this.Text = "Voir / Modifier les résultats";
            this.Load += new System.EventHandler(this.frmResultats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.gpBoxSaisons.ResumeLayout(false);
            this.gpBoxSaisons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.GroupBox gpBoxSaisons;
        private System.Windows.Forms.RadioButton rdbtnAllSeason;
        private System.Windows.Forms.RadioButton rdbtnSeason2;
        private System.Windows.Forms.RadioButton rdbtnSeason1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
    }
}