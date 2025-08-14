using Microsoft.AspNetCore.Mvc.Filters;

namespace MIddleware.Filters
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
