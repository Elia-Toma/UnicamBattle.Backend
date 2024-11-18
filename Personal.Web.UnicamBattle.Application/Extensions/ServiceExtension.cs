using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Personal.Web.UnicamBattle.Application.Abstractions.Services;
using Personal.Web.UnicamBattle.Application.Services;

namespace Personal.Web.UnicamBattle.Application.Extensions
{
	public static class ServiceExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
		{
			services
				.AddScoped<IPersonaggioService, PersonaggioService>()
				.AddScoped<IMossaService, MossaService>();

			return services;
		}
	}
}