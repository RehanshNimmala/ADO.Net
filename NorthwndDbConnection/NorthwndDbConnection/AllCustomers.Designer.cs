﻿namespace NorthwndDbConnection
{
    partial class AllCustomers
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
            this.allCustomersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allCustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allCustomersDataGridView
            // 
            this.allCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCustomersDataGridView.Location = new System.Drawing.Point(12, 24);
            this.allCustomersDataGridView.Name = "allCustomersDataGridView";
            this.allCustomersDataGridView.RowHeadersWidth = 51;
            this.allCustomersDataGridView.RowTemplate.Height = 24;
            this.allCustomersDataGridView.Size = new System.Drawing.Size(746, 369);
            this.allCustomersDataGridView.TabIndex = 0;
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allCustomersDataGridView);
            this.Name = "AllCustomers";
            this.Text = "AllCustomers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllCustomers_FormClosing);
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allCustomersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allCustomersDataGridView;
    }
}