using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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
    }
}