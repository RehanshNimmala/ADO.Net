namespace dbinsertconnection
{
    partial class StudentMarksSheet
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblTeluguMarks = new System.Windows.Forms.Label();
            this.lblEnglishMarks = new System.Windows.Forms.Label();
            this.txtTeluguMarks = new System.Windows.Forms.TextBox();
            this.txtEnglishMarks = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(76, 64);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(92, 16);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Location = new System.Drawing.Point(188, 64);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(211, 22);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblTeluguMarks
            // 
            this.lblTeluguMarks.AutoSize = true;
            this.lblTeluguMarks.Location = new System.Drawing.Point(76, 135);
            this.lblTeluguMarks.Name = "lblTeluguMarks";
            this.lblTeluguMarks.Size = new System.Drawing.Size(89, 16);
            this.lblTeluguMarks.TabIndex = 2;
            this.lblTeluguMarks.Text = "Telugu Marks";
            // 
            // lblEnglishMarks
            // 
            this.lblEnglishMarks.AutoSize = true;
            this.lblEnglishMarks.Location = new System.Drawing.Point(76, 207);
            this.lblEnglishMarks.Name = "lblEnglishMarks";
            this.lblEnglishMarks.Size = new System.Drawing.Size(91, 16);
            this.lblEnglishMarks.TabIndex = 3;
            this.lblEnglishMarks.Text = "English Marks";
            // 
            // txtTeluguMarks
            // 
            this.txtTeluguMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeluguMarks.Location = new System.Drawing.Point(188, 135);
            this.txtTeluguMarks.Name = "txtTeluguMarks";
            this.txtTeluguMarks.Size = new System.Drawing.Size(211, 22);
            this.txtTeluguMarks.TabIndex = 5;
            // 
            // txtEnglishMarks
            // 
            this.txtEnglishMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnglishMarks.Location = new System.Drawing.Point(188, 201);
            this.txtEnglishMarks.Name = "txtEnglishMarks";
            this.txtEnglishMarks.Size = new System.Drawing.Size(211, 22);
            this.txtEnglishMarks.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(188, 273);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(211, 53);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(576, 64);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.RowTemplate.Height = 24;
            this.studentGridView.Size = new System.Drawing.Size(796, 374);
            this.studentGridView.TabIndex = 9;
            // 
            // StudentMarksSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 450);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEnglishMarks);
            this.Controls.Add(this.txtTeluguMarks);
            this.Controls.Add(this.lblEnglishMarks);
            this.Controls.Add(this.lblTeluguMarks);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Name = "StudentMarksSheet";
            this.Text = "Student Marks Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblTeluguMarks;
        private System.Windows.Forms.Label lblEnglishMarks;
        private System.Windows.Forms.TextBox txtTeluguMarks;
        private System.Windows.Forms.TextBox txtEnglishMarks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView studentGridView;
    }
}

