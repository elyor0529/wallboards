using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Wallboards.UI.Helpers;
using Wallboards.UI.Models;

namespace Wallboards.UI.Controllers
{
    public class AccountController : BaseController
    {

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if(model.UserName!="admin" || model.Password!="123456")
            {
                ModelState.AddModelError("", "Неверное имя пользователя или пароль");

                return View(model);
            }

            MembershipHelper.SignIn(new UserData
            {
                FIO = model.UserName
            });

            await Task.Delay(0);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            MembershipHelper.SignOut();

            return RedirectToAction("Index", "Home");
        }

    }
}