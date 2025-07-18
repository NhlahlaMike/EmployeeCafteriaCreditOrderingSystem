﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeCafteriaCreditOrderingSystem.Models
{
	public class MenuItem
	{
		[Key]
		public int Id { get; set; }
		public int RestaurantId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public Restaurant Restaurant { get; set; }
	}
}
