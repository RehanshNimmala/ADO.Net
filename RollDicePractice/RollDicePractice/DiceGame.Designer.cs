namespace RollDicePractice
{
    partial class DiceGame
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
            this.dice1Label = new System.Windows.Forms.Label();
            this.dice2Label = new System.Windows.Forms.Label();
            this.sumOfDice = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rolling Dice Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Die 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Die 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sum of Dice";
            // 
            // dice1Label
            // 
            this.dice1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice1Label.Location = new System.Drawing.Point(120, 155);
            this.dice1Label.Name = "dice1Label";
            this.dice1Label.Size = new System.Drawing.Size(69, 57);
            this.dice1Label.TabIndex = 4;
            // 
            // dice2Label
            // 
            this.dice2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dice2Label.Location = new System.Drawing.Point(294, 155);
            this.dice2Label.Name = "dice2Label";
            this.dice2Label.Size = new System.Drawing.Size(69, 57);
            this.dice2Label.TabIndex = 5;
            // 
            // sumOfDice
            // 
            this.sumOfDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumOfDice.Location = new System.Drawing.Point(464, 155);
            this.sumOfDice.Name = "sumOfDice";
            this.sumOfDice.Size = new System.Drawing.Size(69, 57);
            this.sumOfDice.TabIndex = 6;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(184, 260);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(121, 49);
            this.rollButton.TabIndex = 7;
            this.rollButton.Text = "&Roll_Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 260);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 49);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            // 
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.sumOfDice);
            this.Controls.Add(this.dice2Label);
            this.Controls.Add(this.dice1Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiceGame";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dice1Label;
        private System.Windows.Forms.Label dice2Label;
        private System.Windows.Forms.Label sumOfDice;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

