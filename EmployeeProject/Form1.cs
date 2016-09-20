using System;
using System.Windows.Forms;
using EmployeeDetailsDAL.EmployeeInfoClasses;

namespace EmployeeProject
{
    public partial class Form1 : Form
    {
        IEmployeeProcess employeeProcess;
        public Form1()
        {
            InitializeComponent();
            employeeProcess = new EmployeeProcess();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.FirstName = FirstName.Text;
            employee.LastName = LastName.Text;
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth.Value);
            employee.Designation = Designation.Text;
            employee.City = City.Text;
            employee.Gender = Gender.Text;

            if (employeeProcess.AddEmployee(employee))
            {
                MessageBox.Show("Employee has been added successfully.");
            }
            else
            {
                MessageBox.Show("Saala nahi hua add...");
            }
        }
    }
}
