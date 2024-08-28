using Microsoft.Extensions.DependencyInjection;
using PS.BearDiner.Application.Services.Authentication;

namespace PS.BearDiner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
