namespace BackEnd_UI.Cartons
{
    partial class frmCartons
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
            this.dtgrdCartons = new System.Windows.Forms.DataGridView();
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            this.boxCartSelection = new System.Windows.Forms.ComboBox();
            this.lblChampSelect = new System.Windows.Forms.Label();
            this.lblCartSelect = new System.Windows.Forms.Label();
            this.gpbxFiltrer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCartons)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdCartons
            // 
            this.dtgrdCartons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdCartons.Location = new System.Drawing.Point(12, 123);
            this.dtgrdCartons.Name = "dtgrdCartons";
            this.dtgrdCartons.Size = new System.Drawing.Size(776, 315);
            this.dtgrdCartons.TabIndex = 0;
            // 
            // boxChampSelection
            // 
            this.boxChampSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxChampSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxChampSelection.FormattingEnabled = true;
            this.boxChampSelection.Location = new System.Drawing.Point(200, 35);
            this.boxChampSelection.Name = "boxChampSelection";
            this.boxChampSelection.Size = new System.Drawing.Size(400, 21);
            this.boxChampSelection.TabIndex = 5;
            // 
            // boxCartSelection
            // 
            this.boxCartSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCartSelection.FormattingEnabled = true;
            this.boxCartSelection.Location = new System.Drawing.Point(340, 80);
            this.boxCartSelection.Name = "boxCartSelection";
            this.boxCartSelection.Size = new System.Drawing.Size(120, 21);
            this.boxCartSelection.TabIndex = 6;
            // 
            // lblChampSelect
            // 
            this.lblChampSelect.AutoSize = true;
            this.lblChampSelect.Location = new System.Drawing.Point(101, 38);
            this.lblChampSelect.Name = "lblChampSelect";
            this.lblChampSelect.Size = new System.Drawing.Size(93, 13);
            this.lblChampSelect.TabIndex = 7;
            this.lblChampSelect.Text = "Par championnat :";
            // 
            // lblCartSelect
            // 
            this.lblCartSelect.AutoSize = true;
            this.lblCartSelect.Location = new System.Drawing.Point(203, 83);
            this.lblCartSelect.Name = "lblCartSelect";
            this.lblCartSelect.Size = new System.Drawing.Size(131, 13);
            this.lblCartSelect.TabIndex = 8;
            this.lblCartSelect.Text = "Et/Ou par type de carton :";
            // 
            // gpbxFiltrer
            // 
            this.gpbxFiltrer.Location = new System.Drawing.Point(12, 12);
            this.gpbxFiltrer.Name = "gpbxFiltrer";
            this.gpbxFiltrer.Size = new System.Drawing.Size(776, 100);
            this.gpbxFiltrer.TabIndex = 9;
            this.gpbxFiltrer.TabStop = false;
            this.gpbxFiltrer.Text = "Filtrer";
            // 
            // frmCartons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCartSelect);
            this.Controls.Add(this.lblChampSelect);
            this.Controls.Add(this.boxCartSelection);
            this.Controls.Add(this.boxChampSelection);
            this.Controls.Add(this.dtgrdCartons);
            this.Controls.Add(this.gpbxFiltrer);
            this.Name = "frmCartons";
            this.Text = "Liste des cartons";
            this.Load += new System.EventHandler(this.frmCartons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCartons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdCartons;
        private System.Windows.Forms.ComboBox boxChampSelection;
        private System.Windows.Forms.ComboBox boxCartSelection;
        private System.Windows.Forms.Label lblChampSelect;
        private System.Windows.Forms.Label lblCartSelect;
        private System.Windows.Forms.GroupBox gpbxFiltrer;
    }
}