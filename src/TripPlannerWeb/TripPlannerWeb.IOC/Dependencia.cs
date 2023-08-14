using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TripPlannerWeb.Data.DatabaseContext;

namespace TripPlannerWeb.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TripPlannerWebDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlString_Local_Test"));
            });
        }
    }
}