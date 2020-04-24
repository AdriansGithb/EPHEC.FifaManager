﻿namespace BackEnd_UI.Calendrier
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
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            this.gpbxGeneration = new System.Windows.Forms.GroupBox();
            this.rdbtnAllSeason = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSeason1 = new System.Windows.Forms.RadioButton();
            this.btnGnrClndr = new System.Windows.Forms.Button();
            this.lblMchNoDate = new System.Windows.Forms.Label();
            this.lblGnrClndr = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.gpbxGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridResults
            // 
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(28, 212);
            this.gridResults.MultiSelect = false;
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResults.Size = new System.Drawing.Size(436, 315);
            this.gridResults.TabIndex = 14;
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
            // gpbxGeneration
            // 
            this.gpbxGeneration.Controls.Add(this.rdbtnAllSeason);
            this.gpbxGeneration.Controls.Add(this.rdbtnSeason2);
            this.gpbxGeneration.Controls.Add(this.rdbtnSeason1);
            this.gpbxGeneration.Controls.Add(this.boxChampSelection);
            this.gpbxGeneration.Location = new System.Drawing.Point(28, 18);
            this.gpbxGeneration.Name = "gpbxGeneration";
            this.gpbxGeneration.Size = new System.Drawing.Size(436, 123);
            this.gpbxGeneration.TabIndex = 15;
            this.gpbxGeneration.TabStop = false;
            this.gpbxGeneration.Text = "Sélectionner le championnat et la saison ";
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
            // lblMchNoDate
            // 
            this.lblMchNoDate.AutoSize = true;
            this.lblMchNoDate.Location = new System.Drawing.Point(697, 193);
            this.lblMchNoDate.Name = "lblMchNoDate";
            this.lblMchNoDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMchNoDate.Size = new System.Drawing.Size(221, 13);
            this.lblMchNoDate.TabIndex = 18;
            this.lblMchNoDate.Text = "Matchs sans dates, à modifier manuellement :";
            // 
            // lblGnrClndr
            // 
            this.lblGnrClndr.AutoSize = true;
            this.lblGnrClndr.Location = new System.Drawing.Point(29, 193);
            this.lblGnrClndr.Name = "lblGnrClndr";
            this.lblGnrClndr.Size = new System.Drawing.Size(92, 13);
            this.lblGnrClndr.TabIndex = 17;
            this.lblGnrClndr.Text = "Calendrier actuel :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(482, 212);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 315);
            this.dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGnrClndr);
            this.groupBox1.Location = new System.Drawing.Point(553, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 123);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création de calendrier";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(922, 376);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pour modifier, double cliquer sur le match cible";
            // 
            // frmCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.gpbxGeneration);
            this.Controls.Add(this.lblMchNoDate);
            this.Controls.Add(this.lblGnrClndr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCalendrier";
            this.Text = "CalendrierTest";
            this.Load += new System.EventHandler(this.frmCalendrier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.gpbxGeneration.ResumeLayout(false);
            this.gpbxGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGnrClndr;
        private System.Windows.Forms.Label lblMchNoDate;
        private System.Windows.Forms.Label lblGnrClndr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}