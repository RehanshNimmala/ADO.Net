namespace HotelInformation
{
    partial class HotelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.hotelGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "From(City)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration of stay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bill Amount";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerNameTextBox.Location = new System.Drawing.Point(265, 52);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // fromTextBox
            // 
            this.fromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromTextBox.Location = new System.Drawing.Point(265, 125);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 22);
            this.fromTextBox.TabIndex = 5;
            // 
            // durationTextBox
            // 
            this.durationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationTextBox.Location = new System.Drawing.Point(265, 196);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 22);
            this.durationTextBox.TabIndex = 6;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(69, 327);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(96, 46);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "&Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(265, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 46);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountLabel.Location = new System.Drawing.Point(265, 273);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 23);
            this.amountLabel.TabIndex = 10;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(69, 401);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 37);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(265, 401);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 37);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // hotelGridView
            // 
            this.hotelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelGridView.Location = new System.Drawing.Point(457, 86);
            this.hotelGridView.Name = "hotelGridView";
            this.hotelGridView.RowHeadersWidth = 51;
            this.hotelGridView.RowTemplate.Height = 24;
            this.hotelGridView.Size = new System.Drawing.Size(572, 301);
            this.hotelGridView.TabIndex = 13;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.hotelGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HotelForm";
            this.Text = "Hotel Lucky";
            ((System.ComponentModel.ISupportInitialize)(this.hotelGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView hotelGridView;
    }
}

