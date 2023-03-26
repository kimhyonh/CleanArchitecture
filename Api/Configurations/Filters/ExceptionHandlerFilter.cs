using Api.Configurations.Envelops;
using Ardalis.GuardClauses;
using Domain.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Configurations.Filters;

public class ExceptionHandlerFilter : ExceptionFilterAttribute
{
    private readonly IHostEnvironment _hostEnvironment;
    private readonly ILogger _logger;

    public ExceptionHandlerFilter(IHostEnvironment hostEnvironment, ILoggerFactory loggerFactory)
    {
        _hostEnvironment = Guard.Against.Null(hostEnvironment, nameof(hostEnvironment));
        _logger = Guard.Against.Null(loggerFactory?.CreateLogger<ExceptionHandlerFilter>()!, nameof(loggerFactory));
    }

    public override void OnException(ExceptionContext context)
    {
        _logger.LogError(context.Exception, context.Exception.Message);

        var response = new JsonResult(new ErrorEnvelop(
            context.Exception.Message, 
            _hostEnvironment.IsDevelopment() 
                ? context.Exception.StackTrace 
                : null
        ));

        response.StatusCode = context.Exception switch {
            DomainException => StatusCodes.Status409Conflict,
            _ => StatusCodes.Status500InternalServerError
        };

        context.Result = response;
    }
}
