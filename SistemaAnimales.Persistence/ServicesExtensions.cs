using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaAnimales.Application.Interface.Persistence;
using SistemaAnimales.Persistence.Context;
using SistemaAnimales.Persistence.Repository;

namespace SistemaAnimales.Persistence
{
    public static class ServicesExtensions
    {
        public static void AddPersistenceInfraestructure(
           this IServiceCollection services,
           IConfiguration configuration)
        {

            services.AddDbContext<SistemaAnimalesContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("SistemaAnimalesDbConnection") 
            ));
            services.AddTransient<IZonaRepository, ZonaRepository>();


        }
    }
}
