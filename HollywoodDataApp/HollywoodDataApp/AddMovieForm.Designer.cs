namespace HollywoodDataApp
{
    partial class AddMovieForm
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
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.insertMovieButton = new System.Windows.Forms.Button();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.runningTimeTextBox = new System.Windows.Forms.TextBox();
            this.addMovieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Running Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date";
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieIDTextBox.Location = new System.Drawing.Point(257, 59);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.Size = new System.Drawing.Size(289, 22);
            this.movieIDTextBox.TabIndex = 4;
            // 
            // insertMovieButton
            // 
            this.insertMovieButton.Location = new System.Drawing.Point(257, 372);
            this.insertMovieButton.Name = "insertMovieButton";
            this.insertMovieButton.Size = new System.Drawing.Size(109, 35);
            this.insertMovieButton.TabIndex = 5;
            this.insertMovieButton.Text = "Insert Movie";
            this.insertMovieButton.UseVisualStyleBackColor = true;
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movieTitleTextBox.Location = new System.Drawing.Point(257, 129);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(289, 22);
            this.movieTitleTextBox.TabIndex = 6;
            // 
            // runningTimeTextBox
            // 
            this.runningTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runningTimeTextBox.Location = new System.Drawing.Point(257, 191);
            this.runningTimeTextBox.Name = "runningTimeTextBox";
            this.runningTimeTextBox.Size = new System.Drawing.Size(289, 22);
            this.runningTimeTextBox.TabIndex = 7;
            // 
            // addMovieDateTimePicker
            // 
            this.addMovieDateTimePicker.Location = new System.Drawing.Point(257, 262);
            this.addMovieDateTimePicker.Name = "addMovieDateTimePicker";
            this.addMovieDateTimePicker.Size = new System.Drawing.Size(289, 22);
            this.addMovieDateTimePicker.TabIndex = 8;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addMovieDateTimePicker);
            this.Controls.Add(this.runningTimeTextBox);
            this.Controls.Add(this.movieTitleTextBox);
            this.Controls.Add(this.insertMovieButton);
            this.Controls.Add(this.movieIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.Button insertMovieButton;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.TextBox runningTimeTextBox;
        private System.Windows.Forms.DateTimePicker addMovieDateTimePicker;
    }
}