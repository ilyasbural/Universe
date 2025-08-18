namespace Universe.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;

	public class UniverseContext : DbContext
	{
		public virtual DbSet<Ability> Abilities { get; set; }
		public virtual DbSet<Announce> Announces { get; set; }
		public virtual DbSet<AnnounceDetail> AnnounceDetails { get; set; }
		public virtual DbSet<AnnounceLog> AnnounceLogs { get; set; }
		public virtual DbSet<Certificate> Certificates { get; set; }
		public virtual DbSet<College> Colleges { get; set; }
		public virtual DbSet<Company> Companies { get; set; }
		public virtual DbSet<CompanyAbout> CompanyAbouts { get; set; }
		public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }
		public virtual DbSet<CompanyFollower> CompanyFollowers { get; set; }
		public virtual DbSet<CompanySettings> CompanySettings { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public virtual DbSet<Emoji> Emojis { get; set; }
		public virtual DbSet<Language> Languages { get; set; }
		public virtual DbSet<Management> Managements { get; set; }
		public virtual DbSet<ManagementContact> ManagementContacts { get; set; }
		public virtual DbSet<ManagementDetail> ManagementDetails { get; set; }
		public virtual DbSet<ManagementEmail> ManagementEmails { get; set; }
		public virtual DbSet<MessageBox> MessageBoxes { get; set; }
		public virtual DbSet<Network> Networks { get; set; }
		public virtual DbSet<NetworkAction> NetworkActions { get; set; }
		public virtual DbSet<NetworkComment> NetworkComents { get; set; }
		public virtual DbSet<NetworkDetail> NetworkDetails { get; set; }
		public virtual DbSet<Occupation> Occupations { get; set; }
		public virtual DbSet<Position> Positions { get; set; }
		public virtual DbSet<Region> Regions { get; set; }
		public virtual DbSet<Survey> Surveys { get; set; }
		public virtual DbSet<SurveyDetail> SurveyDetails { get; set; }
		public virtual DbSet<SurveyHistory> SurveyHistories { get; set; }
		public virtual DbSet<SurveyLog> SurveyLogs { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<UserAbility> UserAbilities { get; set; }
		public virtual DbSet<UserAbout> UserAbouts { get; set; }
		public virtual DbSet<UserCertificate> UserCertificates { get; set; }
		public virtual DbSet<UserCountry> UserCountries { get; set; }
		public virtual DbSet<UserDetail> UserDetails { get; set; }
		public virtual DbSet<UserEducation> UserEducations { get; set; }
		public virtual DbSet<UserExperience> UserExperiences { get; set; }
		public virtual DbSet<UserFollower> UserFollowers { get; set; }
		public virtual DbSet<UserLanguage> UserLanguages { get; set; }
		public virtual DbSet<UserNetwork> UserNetworks { get; set; }
		public virtual DbSet<UserProject> UserProjects { get; set; }
		public virtual DbSet<UserPublish> UserPublishes { get; set; }
		public virtual DbSet<UserReferance> UserReferances { get; set; }
		public virtual DbSet<UserSettings> UserSettings { get; set; }
		public virtual DbSet<UserType> UserTypes { get; set; }
		public virtual DbSet<UserVideo> UserVideos { get; set; }

		public UniverseContext() { }
		public UniverseContext(DbContextOptions<UniverseContext> options) : base(options) { }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	IConfigurationRoot Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
		//	optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServer"), options =>
		//	{
		//		options.MigrationsAssembly("Universe.WebApi");
		//		options.MigrationsHistoryTable("MigrationHistories");
		//		options.CommandTimeout(5000);
		//		options.EnableRetryOnFailure(maxRetryCount: 5);
		//	});
		//}

		protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReferance).Assembly);
	}
}