using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Tenon.Backend.Api.Repositories.Contracts;
using Tenon.Backend.Api.Repositories.Implementation;
using Tenon.Backend.Api.Services.Contracts;
using Tenon.Backend.Api.Services.Implementation;

namespace Tenon.Backend.Api.Hosts.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServicesDependency(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddTransient<IImagesService, ImagesService>();
        }

        public static void AddRepositoriesDependency(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddDbContext<TenonDatabaseContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString(nameof(TenonDatabaseContext))));

            serviceDescriptors.AddTransient<IImagesRepository, ImagesRepository>();
        }

        public static void AddSwagger(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(ComonConsts.API.Version, new OpenApiInfo
                {
                    Title = ComonConsts.API.Title,
                    Version = ComonConsts.API.Version
                });
            });
        }

        public static void AddMappings(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
