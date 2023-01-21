using System.Data.SqlClient;

namespace UsingDependencyInjection.Models
{
    public class SQLServerRepository : IEmployeeRepository
    {
        SqlConnection con;
        SqlCommand com;

        string conString = "Server=(locadb)\\MSSQLLocalDB;Database=EmployeeDB;integrated security=true";
        public List<Employee> GetAllEmployees()
        {
            con = new SqlConnection(conString);
            con.Open();
            com = new SqlCommand("select * from tbl_Employees", con);
            List<Employee> employees = new List<Employee>();
            SqlDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = reader.GetInt32(0);
                employee.EmployeeName = reader.GetString(1);
                employee.Contact = reader.GetInt64(2);
                employee.PersonalEmail = reader.GetString(3);
                employee.OfficialEmail = reader.GetString(4);
                employees.Add(employee);
            }
            reader.Close();
            con.Close();
            return employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return GetAllEmployees().Find(e => e.EmployeeId == employeeId);

        }
    }
}
