namespace Laba11.Filters
{
    using Laba11.Controllers;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;

    public class LogActionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as HomeController;
            if (controller != null)
            {
                controller.LogAction(context.ActionDescriptor.DisplayName);
            }
            base.OnActionExecuting(context);
        }
    }
}
