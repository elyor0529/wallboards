using System.Linq;
using System.Threading.Tasks;
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
 
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = MembershipHelper.Users.FirstOrDefault(a =>a.UserName == model.UserName && a.Password== model.Password);
            
            if(user==null)
            {
                ModelState.AddModelError("", "Неверное имя пользователя или пароль");

                return View(model);
            }

            MembershipHelper.SignIn(user);

            await Task.Delay(0);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult LogOff()
        {
            MembershipHelper.SignOut();

            return RedirectToAction("Index", "Home");
        }

    }
}