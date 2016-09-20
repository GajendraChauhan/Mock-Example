using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeDetailsDAL.EmployeeInfoClasses;
using Moq;

namespace EmployeeDetailsTest
{
    [TestClass]
    public class UnitTest1
    {
        IEmployeeProcess employeeProcess;

        public UnitTest1()
        {
            employeeProcess = new EmployeeProcess();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Employees employee = new Employees
            {
                FirstName = "Akriti",
                LastName = "Mehara",
                DateOfBirth = DateTime.Now.AddDays(-5000),
                Designation = "Associate Software Engineer",
                City = "Bangalore",
                Gender = "Female"
            };
            Mock<IEmployeeProcess> emp = new Mock<IEmployeeProcess>();
            emp.Setup(x => x.AddEmployee(employee)).Returns(true);

            Assert.AreEqual(emp.Object.AddEmployee(employee), true);
        }
    }
}
