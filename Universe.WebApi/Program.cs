using Microsoft.EntityFrameworkCore;
using Universe.DataAccess;
using Universe.Service;

WebApplicationBuilder Builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = Builder.Configuration;

Builder.Services.AddControllers().AddApplicationPart(typeof(Universe.Presentation.AssemblyReferance).Assembly);
Builder.Services.AddEndpointsApiExplorer();
Builder.Services.AddOpenApi();
Builder.Services.AddSwaggerGen();
Builder.Services.LoadServices();
Builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
Builder.Services.AddCors(options => options.AddDefaultPolicy(builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
Builder.Services.AddDbContext<UniverseContext>(x => x.UseSqlServer(Configuration.GetConnectionString("SqlServer")!));

var app = Builder.Build();

if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors();
app.Run();