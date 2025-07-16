using EmployeeCafteriaCreditOrderingSystem.Data;
using EmployeeCafteriaCreditOrderingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeCafteriaCreditOrderingSystem.Pages.Employees
{
    public class IndexModel : PageModel
    {
		private readonly ApplicationDbContext context;
		public List<Employee> employeeList = new();

		public IndexModel(ApplicationDbContext context)
		{
			this.context = context;
		}
		public void OnGet()
        {
			employeeList = context.Employees.OrderByDescending(i => i.Id).ToList();
        }
    }
}
