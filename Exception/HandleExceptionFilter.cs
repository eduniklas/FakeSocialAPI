using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FakeSocialAPI.Exception
{
    public class HandleExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            context.Result = new ObjectResult(new 
            {
                message = "An error occurred",
                details = exception.Message,
            })
            {
                StatusCode = 500,
            };
            context.ExceptionHandled = true;
        }
    }
}