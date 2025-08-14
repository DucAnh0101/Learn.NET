using System.Diagnostics;

namespace MIddleware.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew();
            Console.WriteLine($"[Middleware] Request: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            watch.Stop();
            Console.WriteLine($"[Middleware] Response: {context.Response.StatusCode} in {watch.ElapsedMilliseconds} ms");
        }
    }

    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
