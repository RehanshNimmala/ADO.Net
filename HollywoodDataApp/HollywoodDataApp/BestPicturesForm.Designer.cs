namespace HollywoodDataApp
{
    partial class BestPicturesForm
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
            this.bestPicturesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bestPicturesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bestPicturesDataGridView
            // 
            this.bestPicturesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestPicturesDataGridView.Location = new System.Drawing.Point(12, 22);
            this.bestPicturesDataGridView.Name = "bestPicturesDataGridView";
            this.bestPicturesDataGridView.RowHeadersWidth = 51;
            this.bestPicturesDataGridView.RowTemplate.Height = 24;
            this.bestPicturesDataGridView.Size = new System.Drawing.Size(759, 384);
            this.bestPicturesDataGridView.TabIndex = 0;
            // 
            // BestPicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bestPicturesDataGridView);
            this.Name = "BestPicturesForm";
            this.Text = "BestPicturesForm";
            ((System.ComponentModel.ISupportInitialize)(this.bestPicturesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bestPicturesDataGridView;
    }
}