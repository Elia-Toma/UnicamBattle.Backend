using Microsoft.EntityFrameworkCore;
using Pcsnet.Web.Rapportini.Application.Options;
using Personal.Web.UnicamBattle.API.Extensions;
using Personal.Web.UnicamBattle.Application.Extensions;
using Personal.Web.UnicamBattle.Domain.Abstractions.Repositories;
using Personal.Web.UnicamBattle.Infrastructure.Context;
using Personal.Web.UnicamBattle.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
	.AddWebServices(builder.Configuration)
	.AddApplicationServices(builder.Configuration);

builder.Services.AddDbContext<MyContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("MyContext"));
});

builder.Services
	.AddScoped<IPersonaggioRepository, PersonaggioRepository>()
	.AddScoped<IMossaRepository, MossaRepository>();

var corsOptions = new CorsOption();
builder.Configuration.GetSection("Cors").Bind(corsOptions);

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "CORS_POLICY",
	   builder =>
	   {
		   builder.WithOrigins(corsOptions.Origins.ToArray())
							   .AllowAnyHeader()
							   .AllowAnyMethod()
							   .AllowCredentials();
	   });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{

app.UseSwagger();
app.UseSwaggerUI();

app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("CORS_POLICY");
//app.UseAuthorization();
app.MapControllers();
//app.MapRazorPages();

app.Run();