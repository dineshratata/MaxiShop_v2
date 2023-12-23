using MaxiShop.Domain.Contracts;
using MaxiShop_Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MaxiShop_Infrastructure
{
    public static class InfrastructreRegistration
    {

        public static IServiceCollection AddInfraStuctureServices(this IServiceCollection services) {
           

            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

            services.AddScoped<IcategoryRepository, CategoryRepository>();

            return services;
        
        }
    }
}
