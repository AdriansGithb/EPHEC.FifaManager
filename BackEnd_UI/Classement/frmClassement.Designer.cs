namespace BackEnd_UI
{
    partial class frmClassement
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
            this.gridClassement = new System.Windows.Forms.DataGridView();
            this.boxChampSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridClassement)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClassement
            // 
            this.gridClassement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClassement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridClassement.Location = new System.Drawing.Point(0, 39);
            this.gridClassement.Name = "gridClassement";
            this.gridClassement.ReadOnly = true;
            this.gridClassement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClassement.Size = new System.Drawing.Size(800, 411);
            this.gridClassement.TabIndex = 5;
            //ajout personnel 
            this.gridClassement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // boxChampSelection
            // 
            this.boxChampSelection.BackColor = System.Drawing.SystemColors.Window;
            this.boxChampSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxChampSelection.FormattingEnabled = true;
            this.boxChampSelection.Location = new System.Drawing.Point(242, 6);
            this.boxChampSelection.Name = "boxChampSelection";
            this.boxChampSelection.Size = new System.Drawing.Size(337, 21);
            this.boxChampSelection.TabIndex = 4;
            this.boxChampSelection.SelectedIndexChanged += new System.EventHandler(this.boxChampSelection_SelectedIndexChanged);
            // 
            // frmClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridClassement);
            this.Controls.Add(this.boxChampSelection);
            this.Name = "frmClassement";
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.frmClassement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClassement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClassement;
        private System.Windows.Forms.ComboBox boxChampSelection;
    }
}