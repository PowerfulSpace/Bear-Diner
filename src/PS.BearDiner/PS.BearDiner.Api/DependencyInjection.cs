using Microsoft.AspNetCore.Mvc.Infrastructure;
using PS.BearDiner.Api.Common.Errors;
using PS.BearDiner.Api.Mapping;

namespace PS.BearDiner.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddMappings();

            services.AddControllers();

            services.AddSingleton<ProblemDetailsFactory, BearDinnerProblemDetailsFactory>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
