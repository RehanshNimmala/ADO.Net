﻿namespace PracticeFinal
{
    partial class GetBestPictures
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
            this.dataGridViewGetBestPictures = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetBestPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGetBestPictures
            // 
            this.dataGridViewGetBestPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGetBestPictures.Location = new System.Drawing.Point(59, 56);
            this.dataGridViewGetBestPictures.Name = "dataGridViewGetBestPictures";
            this.dataGridViewGetBestPictures.RowHeadersWidth = 51;
            this.dataGridViewGetBestPictures.RowTemplate.Height = 24;
            this.dataGridViewGetBestPictures.Size = new System.Drawing.Size(697, 280);
            this.dataGridViewGetBestPictures.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(409, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // GetBestPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridViewGetBestPictures);
            this.Name = "GetBestPictures";
            this.Text = "GetBestPictures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetBestPictures_FormClosing);
            this.Load += new System.EventHandler(this.GetBestPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGetBestPictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGetBestPictures;
        private System.Windows.Forms.Button exitButton;
    }
}