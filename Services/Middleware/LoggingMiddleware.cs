using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Services.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"[Middleware] Incoming {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"[Middleware] Response {context.Response.StatusCode}");
        }
    }

    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder app)
            => app.UseMiddleware<LoggingMiddleware>();
    }
}
