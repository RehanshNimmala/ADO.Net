﻿namespace Branson
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.rideLabel = new System.Windows.Forms.Label();
            this.rideComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(33, 399);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(33, 351);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(235, 68);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(102, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(102, 133);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(32, 16);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTextBox.Location = new System.Drawing.Point(235, 133);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(196, 22);
            this.ageTextBox.TabIndex = 5;
            // 
            // rideLabel
            // 
            this.rideLabel.Location = new System.Drawing.Point(102, 207);
            this.rideLabel.Name = "rideLabel";
            this.rideLabel.Size = new System.Drawing.Size(62, 16);
            this.rideLabel.TabIndex = 6;
            this.rideLabel.Text = "Ride";
            // 
            // rideComboBox
            // 
            this.rideComboBox.FormattingEnabled = true;
            this.rideComboBox.Items.AddRange(new object[] {
            "Wild Fire-Roller caster",
            "Time Traveller-Roller Caster",
            "Gaint Swing",
            "Train",
            "Puppy jump",
            "swing Junior"});
            this.rideComboBox.Location = new System.Drawing.Point(235, 198);
            this.rideComboBox.Name = "rideComboBox";
            this.rideComboBox.Size = new System.Drawing.Size(196, 24);
            this.rideComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rideComboBox);
            this.Controls.Add(this.rideLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label rideLabel;
        private System.Windows.Forms.ComboBox rideComboBox;
    }
}

