using Microsoft.AspNetCore.Mvc.Filters;

namespace Services.Filters
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("[Filter] Before executing action");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("[Filter] After executing action");
        }
    }
}
