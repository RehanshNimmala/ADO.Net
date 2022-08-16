namespace SPDatabaseConnection
{
    partial class SPConnection
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.spGridView = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStudentId.Location = new System.Drawing.Point(26, 75);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(66, 16);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student Id";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFirstName.Location = new System.Drawing.Point(26, 125);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLastName.Location = new System.Drawing.Point(26, 182);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCountry.Location = new System.Drawing.Point(26, 237);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(52, 16);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblContactNumber.Location = new System.Drawing.Point(26, 296);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(103, 16);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentId.Location = new System.Drawing.Point(183, 69);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(195, 22);
            this.txtStudentId.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Location = new System.Drawing.Point(183, 234);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(195, 22);
            this.txtCountry.TabIndex = 6;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNumber.Location = new System.Drawing.Point(183, 296);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(195, 22);
            this.txtContactNumber.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(183, 176);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 22);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(183, 125);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 22);
            this.txtFirstName.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(29, 357);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(349, 59);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // spGridView
            // 
            this.spGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spGridView.Location = new System.Drawing.Point(468, 69);
            this.spGridView.Name = "spGridView";
            this.spGridView.RowHeadersWidth = 51;
            this.spGridView.RowTemplate.Height = 24;
            this.spGridView.Size = new System.Drawing.Size(640, 347);
            this.spGridView.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(29, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(349, 59);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SPConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 573);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.spGridView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStudentId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SPConnection";
            this.Text = "SP Database Connection";
            ((System.ComponentModel.ISupportInitialize)(this.spGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView spGridView;
        private System.Windows.Forms.Button btnReset;
    }
}

