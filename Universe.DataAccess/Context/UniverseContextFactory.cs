namespace Universe.DataAccess
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;
	using Microsoft.Extensions.Configuration;

	public class UniverseContextFactory : IDesignTimeDbContextFactory<UniverseContext>
	{
		public UniverseContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<UniverseContext>();
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			var connectionString = configuration.GetConnectionString("SqlServer");
			builder.UseSqlServer(connectionString);
			return new UniverseContext(builder.Options);
		}
	}
}