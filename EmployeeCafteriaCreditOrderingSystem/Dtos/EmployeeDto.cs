namespace EmployeeCafteriaCreditOrderingSystem.Dtos
{
	public class EmployeeDto
	{
		public string Name { get; set; }
		public string EmployeeNumber { get; set; }
		public decimal Balance { get; set; }
		public DateTime LastDepositMonth { get; set; } = DateTime.Now;
	}
}
