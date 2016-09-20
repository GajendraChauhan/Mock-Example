using System.Data.SqlClient;

namespace EmployeeDetailsDAL.EmployeeInfoClasses
{
    public class EmployeeProcess : IEmployeeProcess
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool AddEmployee(Employees employee)
        {
            //throw new NotImplementedException();

            int isInserted = 0;
            SqlConnection con = new SqlConnection("Server=GAJENDRA;Initial Catalog=SampleDatabase;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [SampleDatabase].[dbo].[EmployeeInforation](FirstName,LastName,DOB,Designation,City,Gender)VALUES('" + employee.FirstName + "','" + employee.LastName + "','" + employee.DateOfBirth + "','" + employee.Designation + "','" + employee.City + "','" + employee.Gender + "')", con);
            isInserted = cmd.ExecuteNonQuery();
            con.Close();

            return isInserted == 1 ? true : false;
        }
    }
}
