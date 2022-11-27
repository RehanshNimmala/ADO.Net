namespace HollywoodDataApp
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
            this.actorsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.actorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actorsDataGridView
            // 
            this.actorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.actorsDataGridView.Name = "actorsDataGridView";
            this.actorsDataGridView.RowHeadersWidth = 51;
            this.actorsDataGridView.RowTemplate.Height = 24;
            this.actorsDataGridView.Size = new System.Drawing.Size(707, 360);
            this.actorsDataGridView.TabIndex = 0;
            // 
            // ActorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actorsDataGridView);
            this.Name = "ActorsForm";
            this.Text = "ActorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.actorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView actorsDataGridView;
    }
}