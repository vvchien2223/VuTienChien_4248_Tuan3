using Microsoft.EntityFrameworkCore;

namespace VuTienChien_4248_Tuan3.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
{ }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<ImageProduct> ProductImages { get; set; }

	}
}
