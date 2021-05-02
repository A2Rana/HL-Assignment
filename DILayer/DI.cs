using System;
using BusinessLayer;
using BusinessLayer.Impl;
using DataAccessLayer;
using DataAccessLayer.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace DILayer
{
    public class DI 
    { 
        public static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IHomeDetailRepository, HomeDetailRepository>();
            services.AddScoped<IHomeDetailService, HomeDetailService>();
            services.AddScoped<IUserDetailsService, UserDetailsService>();
            services.AddScoped<IUserDetailsRepository, UserDetailsRepository>();
        }
    }
}
