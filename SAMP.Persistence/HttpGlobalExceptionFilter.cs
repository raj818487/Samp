using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Net;


namespace SAMP.Persistence;

public class HttpGlobalExceptionFilter : IExceptionFilter
{
    private readonly ILogger<HttpGlobalExceptionFilter> _logger;
    private readonly ProblemDetailsFactory _problemDetailsFactory;

    public HttpGlobalExceptionFilter(ILogger<HttpGlobalExceptionFilter> logger, ProblemDetailsFactory problemDetailsFactory)
    {
        _logger = logger;
        _problemDetailsFactory = problemDetailsFactory;
    }

    public void OnException(ExceptionContext context)
    {
        string corelationId = Guid.NewGuid().ToString();
        _logger.LogError(new EventId(context.Exception.HResult),
            context.Exception,
            $"Corelation Id:{corelationId} => {context.Exception.Message}");

        ProblemDetails problemDetails = _problemDetailsFactory.CreateProblemDetails(
            httpContext: context.HttpContext,
            statusCode: (int)HttpStatusCode.InternalServerError,
            title: "Sorry, something went wrong.",
            detail: $"Corelation Id:{corelationId} => {context.Exception}"
            );

        context.Result = new ObjectResult(problemDetails);
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.ExceptionHandled = true;
    }
}
