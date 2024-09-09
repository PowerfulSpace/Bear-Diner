using ErrorOr;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PS.BearDiner.Application.Authentication.Commands.Register;
using PS.BearDiner.Application.Authentication.Common;
using PS.BearDiner.Application.Common.Behaviors;

namespace PS.BearDiner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            services.AddScoped<
                IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>,
                ValidationRegisterCommandBehavior>();

            return services;
        }
    }
}