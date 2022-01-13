using Corporate.Havan.Schedule.Application.Contracts.Applications;
using Corporate.Havan.Schedule.Application.Contracts.Implements;
using Corporate.Havan.Schedule.Application.MappingProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace Corporate.Havan.Schedule.Application.Extensions
{
    public static class HavanAppExtensions
    {
        public static IServiceCollection AddHavanApplications(this IServiceCollection services)
        {
            #region [Application Services]
            
            services.AddScoped<IProdutoApplication, ProdutoApplication>();    
            services.AddScoped<IProdutoFamiliaApplication, ProdutoFamiliaApplication>();    

            #endregion

            #region [Automapper]

            services.AddAutomapper();

            #endregion

            return services;
        }
    }
}
