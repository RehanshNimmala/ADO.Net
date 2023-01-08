namespace HollywoodPractice
{
    partial class ActorsForm
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
            this.actorsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.actorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actorsGridView
            // 
            this.actorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsGridView.Location = new System.Drawing.Point(12, 12);
            this.actorsGridView.Name = "actorsGridView";
            this.actorsGridView.RowHeadersWidth = 51;
            this.actorsGridView.RowTemplate.Height = 24;
            this.actorsGridView.Size = new System.Drawing.Size(776, 426);
            this.actorsGridView.TabIndex = 0;
            // 
            // ActorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.actorsGridView);
            this.Name = "ActorsForm";
            this.Text = "Actors Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActorsForm_FormClosing);
            this.Load += new System.EventHandler(this.ActorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView actorsGridView;
    }
}