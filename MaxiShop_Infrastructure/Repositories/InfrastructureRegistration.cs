using MaxiShop.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop_Infrastructure.Repositories
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
           

            services.AddScoped(typeof(IGenericRepository<>) ,typeof(GenericRepository<>));
            services.AddScoped<IcategoryRepository, CategoryRepository>(); 


            return services;


        }

    }
}
