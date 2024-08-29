using Microsoft.Extensions.DependencyInjection;
using PS.BearDiner.Application.Common.Interfaces.Authentication;
using PS.BearDiner.Infrastructure.Autentication;


namespace PS.BearDiner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}
