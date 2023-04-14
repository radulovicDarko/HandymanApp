using Application;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        { 
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IHandymanDbContext, HandymanDbContext>();

            services.AddDbContext<HandymanDbContext>(options =>
            {
                options.UseMySQL(configuration.GetConnectionString("Db")!);
            });

            return services;
        }
    }
}
