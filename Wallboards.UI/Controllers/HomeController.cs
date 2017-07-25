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
                case Roles.ANALITICA:
                    return RedirectToAction("Index", "Analitica");
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