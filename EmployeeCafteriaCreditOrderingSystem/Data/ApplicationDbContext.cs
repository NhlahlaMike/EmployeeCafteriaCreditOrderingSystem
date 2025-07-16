using EmployeeCafteriaCreditOrderingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCafteriaCreditOrderingSystem.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		protected ApplicationDbContext()
		{
		}

		public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Restaurant>()
				.HasMany(r => r.MenuItems)
				.WithOne(m => m.Restaurant)
				.HasForeignKey(m => m.RestaurantId);
		}
	}
}
