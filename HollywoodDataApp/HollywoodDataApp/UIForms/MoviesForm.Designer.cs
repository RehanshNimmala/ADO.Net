namespace HollywoodDataApp
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
            this.actorsGridView = new System.Windows.Forms.DataGridView();
            this.showActorsButton = new System.Windows.Forms.Button();
            this.countMoviesButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.actorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie ID";
            // 
            // moviesComboBox
            // 
            this.moviesComboBox.FormattingEnabled = true;
            this.moviesComboBox.Location = new System.Drawing.Point(171, 53);
            this.moviesComboBox.Name = "moviesComboBox";
            this.moviesComboBox.Size = new System.Drawing.Size(145, 24);
            this.moviesComboBox.TabIndex = 1;
            // 
            // actorsGridView
            // 
            this.actorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsGridView.Location = new System.Drawing.Point(66, 138);
            this.actorsGridView.Name = "actorsGridView";
            this.actorsGridView.RowHeadersWidth = 51;
            this.actorsGridView.RowTemplate.Height = 24;
            this.actorsGridView.Size = new System.Drawing.Size(609, 195);
            this.actorsGridView.TabIndex = 2;
            // 
            // showActorsButton
            // 
            this.showActorsButton.Location = new System.Drawing.Point(449, 53);
            this.showActorsButton.Name = "showActorsButton";
            this.showActorsButton.Size = new System.Drawing.Size(226, 37);
            this.showActorsButton.TabIndex = 3;
            this.showActorsButton.Text = "Show Actors in the Movie";
            this.showActorsButton.UseVisualStyleBackColor = true;
            this.showActorsButton.Click += new System.EventHandler(this.showActorsButton_Click);
            // 
            // countMoviesButton
            // 
            this.countMoviesButton.Location = new System.Drawing.Point(66, 375);
            this.countMoviesButton.Name = "countMoviesButton";
            this.countMoviesButton.Size = new System.Drawing.Size(148, 37);
            this.countMoviesButton.TabIndex = 4;
            this.countMoviesButton.Text = "Count of Movies";
            this.countMoviesButton.UseVisualStyleBackColor = true;
            this.countMoviesButton.Click += new System.EventHandler(this.countMoviesButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countLabel.Location = new System.Drawing.Point(293, 375);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(382, 37);
            this.countLabel.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(66, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 37);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countMoviesButton);
            this.Controls.Add(this.showActorsButton);
            this.Controls.Add(this.actorsGridView);
            this.Controls.Add(this.moviesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoviesForm_FormClosing);
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox moviesComboBox;
        private System.Windows.Forms.DataGridView actorsGridView;
        private System.Windows.Forms.Button showActorsButton;
        private System.Windows.Forms.Button countMoviesButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button exitButton;
    }
}