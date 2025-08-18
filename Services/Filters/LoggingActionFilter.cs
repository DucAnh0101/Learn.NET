using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Services.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private Stopwatch _sw;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _sw = Stopwatch.StartNew();
            Console.WriteLine($"[Filter] Action {context.ActionDescriptor.DisplayName} started");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _sw.Stop();
            Console.WriteLine($"[Filter] Action finished in {_sw.ElapsedMilliseconds} ms");
        }
    }
}
