using API.Consultas.Application.Services;
using API.Consultas.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace API.Consultas.Application.Microsoft.Extensions.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddAplication(this IServiceCollection services) 
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            //if (applicationConfiguration is null)
            //{
            //    throw new ArgumentNullException(nameof(applicationConfiguration));
            //}

            //services.AddSingleton(applicationConfiguration);

            services.AddScoped<IConsultasService, ConsultasService>();

            return services;
        }

    }
}
