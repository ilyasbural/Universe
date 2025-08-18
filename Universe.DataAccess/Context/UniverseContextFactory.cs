namespace Universe.DataAccess
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;
	using Microsoft.Extensions.Configuration;

	public class UniverseContextFactory : IDesignTimeDbContextFactory<UniverseContext>
	{
		public UniverseContext CreateDbContext(string[] args)
		{
			IConfigurationRoot Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
			var optionsBuilder = new DbContextOptionsBuilder<UniverseContext>();
			optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
			return new UniverseContext(optionsBuilder.Options);
		}
	}
}