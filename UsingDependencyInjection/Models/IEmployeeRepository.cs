namespace UsingDependencyInjection.Models
{
    public interface IEmployeeRepository
    {
        //CRUD 
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);

    }
}
