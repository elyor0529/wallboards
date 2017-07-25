using System.Web.Mvc;

namespace Wallboards.UI.Controllers
{
    public class ITController : BaseController
    { 
        public ActionResult Index()
        {
            return View();
        } 
    }
}