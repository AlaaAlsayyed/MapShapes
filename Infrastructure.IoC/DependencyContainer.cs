using Application.Common;
using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Domain.Interfaces;
using Domain.Interfaces.RepositoryInterfaces;
using Infrastructure.Data;
using Infrastructure.Data.Context;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<MapTaskContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MapTaskContext"));
                options.UseLazyLoadingProxies(true);
            });

            services.AddAutoMapper(typeof(AutoMapping));

            services.AddScoped<ILineRepository, LineRepository>();
            services.AddScoped<ITriangleRepository, TriangleRepository>();
            services.AddScoped<IRectangleRepository, RectangleRepository>();
            services.AddScoped<IRegionShapeRepository, RegionShapeRepository>();
            services.AddScoped<ICircleRepository, CircleRepository>();
            services.AddScoped<IPolygonRepository, PolygonRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IRegionShapeService, RegionShapeService>();
        }
    }
}