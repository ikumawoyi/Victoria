using Microsoft.EntityFrameworkCore;
using VictorianPlumbing.Models;

namespace VictorianPlumbing.Context
{
	public class VictoriaPlumbingDbContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public VictoriaPlumbingDbContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			// in memory database used for simplicity, change to a real db for production applications
			options.UseInMemoryDatabase("VictoriaPlumbingDb");
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
	}
}
