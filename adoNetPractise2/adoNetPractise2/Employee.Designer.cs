﻿namespace adoNetPractise2
{
    partial class EmployeeDetails
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(50, 38);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(109, 16);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(50, 103);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 16);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(50, 180);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(103, 16);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Location = new System.Drawing.Point(224, 38);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(228, 22);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Location = new System.Drawing.Point(224, 103);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(228, 22);
            this.txtDepartment.TabIndex = 4;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNumber.Location = new System.Drawing.Point(224, 177);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(228, 22);
            this.txtContactNumber.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(507, 79);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(269, 65);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(12, 228);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.RowHeadersWidth = 51;
            this.employeeGridView.RowTemplate.Height = 24;
            this.employeeGridView.Size = new System.Drawing.Size(764, 196);
            this.employeeGridView.TabIndex = 7;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployeeName);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView employeeGridView;
    }
}

