using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PS.BearDiner.Api.Errors;
using PS.BearDiner.Application;
using PS.BearDiner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();
    //builder.Services.AddControllers(x => x.Filters.Add<ErrorHandingFilterAttribute>());

    builder.Services.AddSingleton<ProblemDetailsFactory, BearDinnerProblemDetailsFactory>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    //app.UseMiddleware<ErrorHandlingMiddleware>();

    app.UseExceptionHandler("/error");

    app.Map("/error", (HttpContext httpContext) =>
    {
        Exception? exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        return Results.Problem();
    });

    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

