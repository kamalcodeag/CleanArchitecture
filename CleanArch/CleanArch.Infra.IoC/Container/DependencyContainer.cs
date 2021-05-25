using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.IoC.Container
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application layer
            services.AddScoped<ISingerService, SingerService>();
            services.AddScoped<ITrackService, TrackService>();

            //Domain and Infra.Data layer
            services.AddScoped<ISingerRepository, SingerRepository>();
            services.AddScoped<ITrackRepository, TrackRepository>();
        }
    }
}
