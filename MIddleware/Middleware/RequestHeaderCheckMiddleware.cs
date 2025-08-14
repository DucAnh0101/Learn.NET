namespace MIddleware.Middleware
{
    public class RequestHeaderCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestHeaderCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.ContainsKey("API-KEY"))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Missing API-KEY header");
                return;
            }

            await _next(context);
        }
    }

    public static class RequestHeaderCheckMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestHeaderCheckMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestHeaderCheckMiddleware>();
        }
    }
}
