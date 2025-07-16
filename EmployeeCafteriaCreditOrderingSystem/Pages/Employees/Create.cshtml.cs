using EmployeeCafteriaCreditOrderingSystem.Data;
using EmployeeCafteriaCreditOrderingSystem.Dtos;
using EmployeeCafteriaCreditOrderingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeCafteriaCreditOrderingSystem.Pages.Employees
{
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext context;

		[BindProperty]
        public EmployeeDto EmployeeDto { get; set; } = new();

		public CreateModel(ApplicationDbContext context)
		{
			this.context = context;
		}
		public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var employee = new Employee
            {
                Name = EmployeeDto.Name,
				EmployeeNumber = EmployeeDto.EmployeeNumber,
                Balance = EmployeeDto.Balance,
                LastDepositMonth = EmployeeDto.LastDepositMonth,
			};

            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToPage("/Employees/Index");
        }

    }
}
