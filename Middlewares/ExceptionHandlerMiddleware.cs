using System.Net;

namespace Walks.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly ILogger<ExceptionHandlerMiddleware> logger;
    private readonly RequestDelegate next;

    public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger, RequestDelegate next)
    {
        this.logger = logger;
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            // Call the next delegate/middleware in the pipeline
            await next(httpContext);
        }
        catch (Exception ex)
        {
            var errorId = Guid.NewGuid();

            // Logging This Exception
            logger.LogError(ex, $"{errorId} - Exception: {ex.Message}");

            // Return custom error response
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = "application/json";

            var error = new
            {
                Id = errorId,
                Message = "Something went wrong. Please try again later."
            };

            // Write error response
            await httpContext.Response.WriteAsJsonAsync(error);
        }
    }
}