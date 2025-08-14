using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MIddleware.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
            Console.WriteLine($"[ActionFilter] Starting action: {context.ActionDescriptor.DisplayName}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            Console.WriteLine($"[ActionFilter] Finished action in {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
