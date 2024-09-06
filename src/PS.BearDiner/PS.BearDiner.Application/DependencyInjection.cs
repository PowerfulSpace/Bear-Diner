using Microsoft.Extensions.DependencyInjection;
using PS.BearDiner.Application.Services.Authentication.Commands;
using PS.BearDiner.Application.Services.Authentication.Queries;

namespace PS.BearDiner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationCommandService, AuthenticationCommandService>();
            services.AddScoped<IAuthenticationQueryService, AuthenticationQueryService>();

            return services;
        }
    }
}