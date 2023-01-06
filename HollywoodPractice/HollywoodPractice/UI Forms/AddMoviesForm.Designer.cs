namespace HollywoodPractice
{
    partial class AddMoviesForm
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
            this.movieIDLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.runtimeTextBox = new System.Windows.Forms.TextBox();
            this.addMovieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // movieIDLabel
            // 
            this.movieIDLabel.AutoSize = true;
            this.movieIDLabel.Location = new System.Drawing.Point(44, 36);
            this.movieIDLabel.Name = "movieIDLabel";
            this.movieIDLabel.Size = new System.Drawing.Size(60, 16);
            this.movieIDLabel.TabIndex = 0;
            this.movieIDLabel.Text = "Movie ID";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Location = new System.Drawing.Point(44, 99);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(73, 16);
            this.movieTitleLabel.TabIndex = 1;
            this.movieTitleLabel.Text = "Movie Title";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Location = new System.Drawing.Point(44, 178);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(90, 16);
            this.runningTimeLabel.TabIndex = 2;
            this.runningTimeLabel.Text = "Running Time";
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Location = new System.Drawing.Point(44, 254);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(91, 16);
            this.releaseDateLabel.TabIndex = 3;
            this.releaseDateLabel.Text = "Release Date";
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieIDTextBox.Location = new System.Drawing.Point(232, 33);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.Size = new System.Drawing.Size(382, 22);
            this.movieIDTextBox.TabIndex = 4;
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieTitleTextBox.Location = new System.Drawing.Point(232, 97);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(382, 22);
            this.movieTitleTextBox.TabIndex = 5;
            // 
            // runtimeTextBox
            // 
            this.runtimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runtimeTextBox.Location = new System.Drawing.Point(232, 176);
            this.runtimeTextBox.Name = "runtimeTextBox";
            this.runtimeTextBox.Size = new System.Drawing.Size(382, 22);
            this.runtimeTextBox.TabIndex = 6;
            // 
            // addMovieDateTimePicker
            // 
            this.addMovieDateTimePicker.Location = new System.Drawing.Point(232, 249);
            this.addMovieDateTimePicker.Name = "addMovieDateTimePicker";
            this.addMovieDateTimePicker.Size = new System.Drawing.Size(382, 22);
            this.addMovieDateTimePicker.TabIndex = 7;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(232, 339);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(382, 62);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert Movie";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // AddMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.addMovieDateTimePicker);
            this.Controls.Add(this.runtimeTextBox);
            this.Controls.Add(this.movieTitleTextBox);
            this.Controls.Add(this.movieIDTextBox);
            this.Controls.Add(this.releaseDateLabel);
            this.Controls.Add(this.runningTimeLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.movieIDLabel);
            this.Name = "AddMoviesForm";
            this.Text = "Add Movies Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddMoviesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieIDLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label runningTimeLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.TextBox runtimeTextBox;
        private System.Windows.Forms.DateTimePicker addMovieDateTimePicker;
        private System.Windows.Forms.Button insertButton;
    }
}