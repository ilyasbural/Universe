using Universe.Service;

WebApplicationBuilder Builder = WebApplication.CreateBuilder(args);

Builder.Services.AddControllers();
Builder.Services.LoadServices();
Builder.Services.AddSwaggerGen();
Builder.Services.AddCors(options => options.AddDefaultPolicy(builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
Builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//Builder.Services.AddOpenApi();

var app = Builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//	app.MapOpenApi();
//}

app.UseSwagger();
app.UseSwaggerUI();

//if (app.Environment.IsDevelopment())
//{
//	app.UseSwagger();
//	app.UseSwaggerUI();
//}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseCors();
app.Run();