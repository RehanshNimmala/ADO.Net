namespace HollywoodPractice
{
    partial class MoviesForm
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
            this.moviesComboBox = new System.Windows.Forms.ComboBox();
            this.showActorsButton = new System.Windows.Forms.Button();
            this.countOfMoviesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.moviesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie ID";
            // 
            // moviesComboBox
            // 
            this.moviesComboBox.FormattingEnabled = true;
            this.moviesComboBox.Location = new System.Drawing.Point(184, 45);
            this.moviesComboBox.Name = "moviesComboBox";
            this.moviesComboBox.Size = new System.Drawing.Size(121, 24);
            this.moviesComboBox.TabIndex = 1;
            // 
            // showActorsButton
            // 
            this.showActorsButton.Location = new System.Drawing.Point(422, 33);
            this.showActorsButton.Name = "showActorsButton";
            this.showActorsButton.Size = new System.Drawing.Size(319, 36);
            this.showActorsButton.TabIndex = 2;
            this.showActorsButton.Text = "Show Actors in the movie";
            this.showActorsButton.UseVisualStyleBackColor = true;
            this.showActorsButton.Click += new System.EventHandler(this.showActorsButton_Click);
            // 
            // countOfMoviesButton
            // 
            this.countOfMoviesButton.Location = new System.Drawing.Point(28, 346);
            this.countOfMoviesButton.Name = "countOfMoviesButton";
            this.countOfMoviesButton.Size = new System.Drawing.Size(251, 36);
            this.countOfMoviesButton.TabIndex = 3;
            this.countOfMoviesButton.Text = "Count Of Movies";
            this.countOfMoviesButton.UseVisualStyleBackColor = true;
            this.countOfMoviesButton.Click += new System.EventHandler(this.countOfMoviesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(28, 436);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(251, 36);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countLabel.Location = new System.Drawing.Point(360, 346);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(381, 28);
            this.countLabel.TabIndex = 5;
            // 
            // moviesGridView
            // 
            this.moviesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGridView.Location = new System.Drawing.Point(28, 107);
            this.moviesGridView.Name = "moviesGridView";
            this.moviesGridView.RowHeadersWidth = 51;
            this.moviesGridView.RowTemplate.Height = 24;
            this.moviesGridView.Size = new System.Drawing.Size(713, 195);
            this.moviesGridView.TabIndex = 6;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.moviesGridView);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countOfMoviesButton);
            this.Controls.Add(this.showActorsButton);
            this.Controls.Add(this.moviesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoviesForm_FormClosing);
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox moviesComboBox;
        private System.Windows.Forms.Button showActorsButton;
        private System.Windows.Forms.Button countOfMoviesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.DataGridView moviesGridView;
    }
}