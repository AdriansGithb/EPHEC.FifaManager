namespace BackEnd_UI.Match
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
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResults
            // 
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridResults.Location = new System.Drawing.Point(0, 161);
            this.gridResults.Name = "gridResults";
            this.gridResults.Size = new System.Drawing.Size(800, 289);
            this.gridResults.TabIndex = 0;
            // 
            // frmResultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridResults);
            this.Name = "frmResultats";
            this.Text = "Voir / Modifier les résultats";
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResults;
    }
}