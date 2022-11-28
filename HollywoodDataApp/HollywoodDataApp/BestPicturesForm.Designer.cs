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
            this.exitButton = new System.Windows.Forms.Button();
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
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(699, 465);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 43);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BestPicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 540);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bestPicturesDataGridView);
            this.Name = "BestPicturesForm";
            this.Text = "BestPicturesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BestPicturesForm_FormClosing);
            this.Load += new System.EventHandler(this.BestPicturesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bestPicturesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bestPicturesDataGridView;
        private System.Windows.Forms.Button exitButton;
    }
}