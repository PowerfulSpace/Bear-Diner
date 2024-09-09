using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PS.BearDiner.Application.Common.Behaviors;
using System.Reflection;

namespace PS.BearDiner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
// запустить приложение !!! проверить дебаг