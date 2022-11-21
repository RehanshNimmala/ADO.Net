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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showActorsButton = new System.Windows.Forms.Button();
            this.countMoviesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 195);
            this.dataGridView1.TabIndex = 2;
            // 
            // showActorsButton
            // 
            this.showActorsButton.Location = new System.Drawing.Point(449, 53);
            this.showActorsButton.Name = "showActorsButton";
            this.showActorsButton.Size = new System.Drawing.Size(226, 37);
            this.showActorsButton.TabIndex = 3;
            this.showActorsButton.Text = "Show Actors in the Movie";
            this.showActorsButton.UseVisualStyleBackColor = true;
            // 
            // countMoviesButton
            // 
            this.countMoviesButton.Location = new System.Drawing.Point(66, 375);
            this.countMoviesButton.Name = "countMoviesButton";
            this.countMoviesButton.Size = new System.Drawing.Size(148, 37);
            this.countMoviesButton.TabIndex = 4;
            this.countMoviesButton.Text = "Count of Movies";
            this.countMoviesButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(293, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 37);
            this.label2.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(66, 445);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 37);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countMoviesButton);
            this.Controls.Add(this.showActorsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showActorsButton;
        private System.Windows.Forms.Button countMoviesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
    }
}