using Microsoft.EntityFrameworkCore;

namespace CoffeeCampus
{
	public class coffeeCampus : DbContext
	{
		public coffeeCampus(DbContextOptions<coffeeCampus> options)
			: base(options)
		{
		}

		// Definer dine DbSets her
		public DbSet<> YourEntities { get; set; }
	}
}
