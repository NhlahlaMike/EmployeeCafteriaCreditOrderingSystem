using System.ComponentModel.DataAnnotations;

namespace EmployeeCafteriaCreditOrderingSystem.Models
{
	public class Restaurant
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string LocationDescription { get; set; }
		public string ContactNumber { get; set; }
		public ICollection<MenuItem> MenuItems { get; set; }
	}
}
