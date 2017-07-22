using System;
using System.Web.Mvc;
using System.Web.Routing;
using Wallboards.UI.Helpers;

namespace Wallboards.UI
{
    public class SessionAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            // Don't check for authorization as AllowAnonymous filter is applied to the action or controller
            if (filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)
                || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true))
            {
                return;
            }

            // Check for authorization
            if (MembershipHelper.IsAuthorize())
                return;

            filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
            {
                controller = "Account",
                action = "Login",
                returnUrl = filterContext.HttpContext.Request.Url?.GetComponents(UriComponents.PathAndQuery, UriFormat.SafeUnescaped)
            }));
        }
    }
}