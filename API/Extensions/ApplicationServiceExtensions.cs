using API.Data;
using API.Interface;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(opt => 
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}