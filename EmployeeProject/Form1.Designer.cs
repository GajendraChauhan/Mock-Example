namespace EmployeeProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Designation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(209, 37);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(187, 20);
            this.FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(209, 87);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(187, 20);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // Designation
            // 
            this.Designation.Location = new System.Drawing.Point(209, 171);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(187, 20);
            this.Designation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Designation";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(209, 223);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(187, 20);
            this.City.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(209, 270);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(187, 20);
            this.Gender.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(209, 128);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 11;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(209, 310);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(187, 23);
            this.AddEmployee.TabIndex = 12;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 374);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Button AddEmployee;
    }
}

