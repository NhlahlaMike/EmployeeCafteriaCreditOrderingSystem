using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCafteriaCreditOrderingSystem.Models
{
	[Index(nameof(EmployeeNumber), IsUnique = true)]
	public class Employee
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string EmployeeNumber { get; set; }
		public decimal Balance { get; set; }
		public DateTime LastDepositMonth { get; set; }
	}
}
