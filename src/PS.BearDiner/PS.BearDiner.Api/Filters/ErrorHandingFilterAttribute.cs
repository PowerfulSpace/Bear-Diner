using Microsoft.AspNetCore.Mvc.Filters;

namespace PS.BearDiner.Api.Filters
{
    public class ErrorHandingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
        }


    }
}
