namespace NorthwndDbConnection
{
    partial class Individual_Customers
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
            this.individualDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.individualDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // individualDataGridView
            // 
            this.individualDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.individualDataGridView.Location = new System.Drawing.Point(27, 21);
            this.individualDataGridView.Name = "individualDataGridView";
            this.individualDataGridView.RowHeadersWidth = 51;
            this.individualDataGridView.RowTemplate.Height = 24;
            this.individualDataGridView.Size = new System.Drawing.Size(709, 389);
            this.individualDataGridView.TabIndex = 0;
            // 
            // Individual_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.individualDataGridView);
            this.Name = "Individual_Customers";
            this.Text = "Individual_Customers";
            ((System.ComponentModel.ISupportInitialize)(this.individualDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView individualDataGridView;
    }
}