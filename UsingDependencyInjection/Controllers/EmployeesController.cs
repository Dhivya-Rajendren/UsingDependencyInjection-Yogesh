using Microsoft.AspNetCore.Mvc;
using UsingDependencyInjection.Models;

namespace UsingDependencyInjection.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository repo1;
        private readonly ILoggingBuilder logging;

        //The instance creation of the class will be taken core by the underlying .Net Core.
        public EmployeesController(IEmployeeRepository repo,ILoggingBuilder logging)
        {
            this.repo1 = repo;
            this.logging = logging;
        }
       
        public IActionResult Index()
        {
             return View(repo1.GetAllEmployees()); ;
        }

        public IActionResult GetEmployee(int employeeId)
        {
            return View(repo1.GetEmployeeById(employeeId));
        }
    }
}
