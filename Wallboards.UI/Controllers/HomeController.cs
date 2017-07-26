using System;
using System.Web.Mvc;
using Wallboards.UI.Helpers;

namespace Wallboards.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            
            switch (MembershipHelper.User.Role)
            {
                case Roles.CENTER:
                    return RedirectToAction("Index", "Center");
                case Roles.IT:
                    return RedirectToAction("Index", "IT");
                case Roles.ANALYTIC:
                    return RedirectToAction("Index", "Analytics");
            }

            return HttpNotFound();
        }

        public ActionResult Error()
        {
            var model=new HandleErrorInfo(Server.GetLastError(), "Home","Error");
            
            return View("Error", model);
        }
    }
}