namespace PolymorphismPractice
{
    partial class Polymorphism
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
            this.shapeButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.upcastingButton = new System.Windows.Forms.Button();
            this.upcastingByAssignmentButton = new System.Windows.Forms.Button();
            this.notDowncastingButton = new System.Windows.Forms.Button();
            this.okDowncastingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shapeButton
            // 
            this.shapeButton.Location = new System.Drawing.Point(23, 29);
            this.shapeButton.Name = "shapeButton";
            this.shapeButton.Size = new System.Drawing.Size(99, 59);
            this.shapeButton.TabIndex = 0;
            this.shapeButton.Text = "Shape";
            this.shapeButton.UseVisualStyleBackColor = true;
            this.shapeButton.Click += new System.EventHandler(this.shapeButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(146, 29);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(99, 59);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(279, 29);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(99, 59);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // upcastingButton
            // 
            this.upcastingButton.Location = new System.Drawing.Point(407, 29);
            this.upcastingButton.Name = "upcastingButton";
            this.upcastingButton.Size = new System.Drawing.Size(99, 59);
            this.upcastingButton.TabIndex = 3;
            this.upcastingButton.Text = "Upcasting by object instantiation";
            this.upcastingButton.UseVisualStyleBackColor = true;
            this.upcastingButton.Click += new System.EventHandler(this.upcastingButton_Click);
            // 
            // upcastingByAssignmentButton
            // 
            this.upcastingByAssignmentButton.Location = new System.Drawing.Point(542, 29);
            this.upcastingByAssignmentButton.Name = "upcastingByAssignmentButton";
            this.upcastingByAssignmentButton.Size = new System.Drawing.Size(99, 59);
            this.upcastingByAssignmentButton.TabIndex = 4;
            this.upcastingByAssignmentButton.Text = "Upcasting by Assignment";
            this.upcastingByAssignmentButton.UseVisualStyleBackColor = true;
            this.upcastingByAssignmentButton.Click += new System.EventHandler(this.upcastingByAssignmentButton_Click);
            // 
            // notDowncastingButton
            // 
            this.notDowncastingButton.Location = new System.Drawing.Point(672, 29);
            this.notDowncastingButton.Name = "notDowncastingButton";
            this.notDowncastingButton.Size = new System.Drawing.Size(93, 59);
            this.notDowncastingButton.TabIndex = 5;
            this.notDowncastingButton.Text = "Downcasting(How Not To Downcast)";
            this.notDowncastingButton.UseVisualStyleBackColor = true;
            this.notDowncastingButton.Click += new System.EventHandler(this.notDowncastingButton_Click);
            // 
            // okDowncastingButton
            // 
            this.okDowncastingButton.Location = new System.Drawing.Point(796, 29);
            this.okDowncastingButton.Name = "okDowncastingButton";
            this.okDowncastingButton.Size = new System.Drawing.Size(93, 59);
            this.okDowncastingButton.TabIndex = 6;
            this.okDowncastingButton.Text = "Downcasting that is OK to do";
            this.okDowncastingButton.UseVisualStyleBackColor = true;
            this.okDowncastingButton.Click += new System.EventHandler(this.okDowncastingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(916, 29);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 59);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(23, 137);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(992, 292);
            this.resultTextBox.TabIndex = 8;
            // 
            // Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okDowncastingButton);
            this.Controls.Add(this.notDowncastingButton);
            this.Controls.Add(this.upcastingByAssignmentButton);
            this.Controls.Add(this.upcastingButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.shapeButton);
            this.Name = "Polymorphism";
            this.Text = "Polymorphism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shapeButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button upcastingButton;
        private System.Windows.Forms.Button upcastingByAssignmentButton;
        private System.Windows.Forms.Button notDowncastingButton;
        private System.Windows.Forms.Button okDowncastingButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

