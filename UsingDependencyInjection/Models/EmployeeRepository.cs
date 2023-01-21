namespace UsingDependencyInjection.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        static List<Employee> employees = new List<Employee>()
        {

            new Employee(){EmployeeId=1,EmployeeName="John",Contact=7894561236,PersonalEmail="John@gmail.com",OfficialEmail="John@cloudkampus.com"},
            new Employee(){EmployeeId=2,EmployeeName="Aabha",Contact=9994561236,PersonalEmail="Aabha@gmail.com",OfficialEmail="Aabha@cloudkampus.com"},
            new Employee(){EmployeeId=3,EmployeeName="Twinkle",Contact=8874561236,PersonalEmail="Twinkle@gmail.com",OfficialEmail="Twinkle@cloudkampus.com"}

        };

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return employees.Find(e => e.EmployeeId == employeeId);
        }
    }
}
