using Microsoft.OpenApi.Models;

namespace Personal.Web.UnicamBattle.API.Extensions
{
	public static class ServiceExtension
	{
		public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllers();

			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "UnicamBattle",
					Version = "v1"
				});
			});

			return services;
		}
	}
}