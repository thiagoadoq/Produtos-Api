using Corporate.Havan.Schedule.Infra.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Corporate.Havan.Schedule.Infra.Repositories;
using Corporate.Havan.Schedule.Domain.Contracts.Repositories.Base;
using Corporate.Havan.Schedule.Infra.Repositories.Base;
using Microsoft.AspNetCore.Http;
using Corporate.Havan.Schedule.Domain.Entities.Produtos.Repository;

namespace Corporate.Havan.Schedule.Infra.Extensions
{
    public static class HavanInfraExtensions
    {
        public static IServiceCollection AddHavanInfrastructure(this IServiceCollection services)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.{enviroment}.json")
                .Build();

            #region [DbContext]

            var connectionString = configuration.GetConnectionString("Havan");

            services.AddDbContext<HavanDbContext>(options =>
                options.UseNpgsql(connectionString)
                .EnableSensitiveDataLogging());          
            #endregion

            #region [Repositories]
           
            services.AddTransient<IProdutoRepository, ProdutoRepository>();       
            services.AddTransient<IProdutoFamiliaRepository, ProdutoFamiliaRepository>();       

            #endregion

            #region [UnitOfWork]

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion

            #region [HttpContextAccessor]

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #endregion

            return services;
        }
    }
}
