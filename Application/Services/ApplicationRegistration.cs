using AutoMapper;
using Maxishop.Application.Common;
using Maxishop.Application.Services.Interface;
using MaxiShop.Domain.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.Services
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationRegistration( this IServiceCollection services)
        {
            
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<ICategoryService,CategoryService>();
            return services;
        }


    }
}
