﻿using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<DependencyInjection>());
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddValidatorsFromAssemblyContaining<DependencyInjection>();
            return services;
        }
    }
}
