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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGnrClndr = new System.Windows.Forms.Button();
            this.gridClndrDated = new System.Windows.Forms.DataGridView();
            this.lblUndatedClndr = new System.Windows.Forms.Label();
            this.gridClndrUndated = new System.Windows.Forms.DataGridView();
            this.lblDatedClndr = new System.Windows.Forms.Label();
            this.lblChampSsn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrDated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrUndated)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(554, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(184, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Sauver";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGnrClndr
            // 
            this.btnGnrClndr.Location = new System.Drawing.Point(342, 16);
            this.btnGnrClndr.Name = "btnGnrClndr";
            this.btnGnrClndr.Size = new System.Drawing.Size(263, 55);
            this.btnGnrClndr.TabIndex = 30;
            this.btnGnrClndr.Text = "(Re)Générer un calendrier";
            this.btnGnrClndr.UseVisualStyleBackColor = true;
            this.btnGnrClndr.Click += new System.EventHandler(this.btnGnrClndr_Click);
            // 
            // gridClndrDated
            // 
            this.gridClndrDated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridClndrDated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClndrDated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClndrDated.Location = new System.Drawing.Point(27, 92);
            this.gridClndrDated.MultiSelect = false;
            this.gridClndrDated.Name = "gridClndrDated";
            this.gridClndrDated.ReadOnly = true;
            this.gridClndrDated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClndrDated.Size = new System.Drawing.Size(436, 315);
            this.gridClndrDated.TabIndex = 26;
            // 
            // lblUndatedClndr
            // 
            this.lblUndatedClndr.AutoSize = true;
            this.lblUndatedClndr.Location = new System.Drawing.Point(696, 73);
            this.lblUndatedClndr.Name = "lblUndatedClndr";
            this.lblUndatedClndr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUndatedClndr.Size = new System.Drawing.Size(222, 13);
            this.lblUndatedClndr.TabIndex = 29;
            this.lblUndatedClndr.Text = "Matchs sans dates, à modifier ultérieurement :";
            // 
            // gridClndrUndated
            // 
            this.gridClndrUndated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClndrUndated.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClndrUndated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClndrUndated.Location = new System.Drawing.Point(481, 92);
            this.gridClndrUndated.MultiSelect = false;
            this.gridClndrUndated.Name = "gridClndrUndated";
            this.gridClndrUndated.ReadOnly = true;
            this.gridClndrUndated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClndrUndated.Size = new System.Drawing.Size(436, 315);
            this.gridClndrUndated.TabIndex = 27;
            // 
            // lblDatedClndr
            // 
            this.lblDatedClndr.AutoSize = true;
            this.lblDatedClndr.Location = new System.Drawing.Point(28, 73);
            this.lblDatedClndr.Name = "lblDatedClndr";
            this.lblDatedClndr.Size = new System.Drawing.Size(101, 13);
            this.lblDatedClndr.TabIndex = 28;
            this.lblDatedClndr.Text = "Calendrier proposé :";
            // 
            // lblChampSsn
            // 
            this.lblChampSsn.AutoSize = true;
            this.lblChampSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampSsn.Location = new System.Drawing.Point(12, 9);
            this.lblChampSsn.Name = "lblChampSsn";
            this.lblChampSsn.Size = new System.Drawing.Size(138, 16);
            this.lblChampSsn.TabIndex = 31;
            this.lblChampSsn.Text = "Nom_Championnat";
            // 
            // frmGnrCalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 511);
            this.Controls.Add(this.lblChampSsn);
            this.Controls.Add(this.btnGnrClndr);
            this.Controls.Add(this.gridClndrDated);
            this.Controls.Add(this.lblUndatedClndr);
            this.Controls.Add(this.gridClndrUndated);
            this.Controls.Add(this.lblDatedClndr);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "frmGnrCalendrier";
            this.Text = "Génération de calendrier";
            this.Load += new System.EventHandler(this.frmGnrCalendrier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrDated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClndrUndated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGnrClndr;
        private System.Windows.Forms.DataGridView gridClndrDated;
        private System.Windows.Forms.Label lblUndatedClndr;
        private System.Windows.Forms.DataGridView gridClndrUndated;
        private System.Windows.Forms.Label lblDatedClndr;
        private System.Windows.Forms.Label lblChampSsn;
    }
}