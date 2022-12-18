namespace VehicleFormPractice
{
    partial class Automobiles
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
            this.button1 = new System.Windows.Forms.Button();
            this.sedanButton = new System.Windows.Forms.Button();
            this.raceCarButton = new System.Windows.Forms.Button();
            this.motorcycleButton = new System.Windows.Forms.Button();
            this.truckButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sedanButton
            // 
            this.sedanButton.Location = new System.Drawing.Point(25, 34);
            this.sedanButton.Name = "sedanButton";
            this.sedanButton.Size = new System.Drawing.Size(144, 66);
            this.sedanButton.TabIndex = 1;
            this.sedanButton.Text = "Sedan";
            this.sedanButton.UseVisualStyleBackColor = true;
            // 
            // raceCarButton
            // 
            this.raceCarButton.Location = new System.Drawing.Point(25, 131);
            this.raceCarButton.Name = "raceCarButton";
            this.raceCarButton.Size = new System.Drawing.Size(144, 66);
            this.raceCarButton.TabIndex = 2;
            this.raceCarButton.Text = "Race Car";
            this.raceCarButton.UseVisualStyleBackColor = true;
            // 
            // motorcycleButton
            // 
            this.motorcycleButton.Location = new System.Drawing.Point(25, 230);
            this.motorcycleButton.Name = "motorcycleButton";
            this.motorcycleButton.Size = new System.Drawing.Size(144, 66);
            this.motorcycleButton.TabIndex = 3;
            this.motorcycleButton.Text = "MotorCycle";
            this.motorcycleButton.UseVisualStyleBackColor = true;
            // 
            // truckButton
            // 
            this.truckButton.Location = new System.Drawing.Point(25, 322);
            this.truckButton.Name = "truckButton";
            this.truckButton.Size = new System.Drawing.Size(144, 66);
            this.truckButton.TabIndex = 4;
            this.truckButton.Text = "Truck";
            this.truckButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(25, 425);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 66);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.resultTextBox.Location = new System.Drawing.Point(375, 25);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(778, 457);
            this.resultTextBox.TabIndex = 6;
            // 
            // Automobiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 519);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.truckButton);
            this.Controls.Add(this.motorcycleButton);
            this.Controls.Add(this.raceCarButton);
            this.Controls.Add(this.sedanButton);
            this.Controls.Add(this.button1);
            this.Name = "Automobiles";
            this.Text = "Automobiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sedanButton;
        private System.Windows.Forms.Button raceCarButton;
        private System.Windows.Forms.Button motorcycleButton;
        private System.Windows.Forms.Button truckButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

