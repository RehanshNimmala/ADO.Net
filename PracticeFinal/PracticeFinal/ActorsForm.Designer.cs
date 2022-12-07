namespace PracticeFinal
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
            this.dataGridViewActors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActors
            // 
            this.dataGridViewActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActors.Location = new System.Drawing.Point(34, 24);
            this.dataGridViewActors.Name = "dataGridViewActors";
            this.dataGridViewActors.RowHeadersWidth = 51;
            this.dataGridViewActors.RowTemplate.Height = 24;
            this.dataGridViewActors.Size = new System.Drawing.Size(720, 339);
            this.dataGridViewActors.TabIndex = 0;
            // 
            // ActorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewActors);
            this.Name = "ActorsForm";
            this.Text = "ActorsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActorsForm_FormClosing);
            this.Load += new System.EventHandler(this.ActorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActors;
    }
}