using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wallboards.UI.Controllers
{
    public class CenterController : BaseController
    { 
        public ActionResult Panel1()
        {
            return View();
        }

        public ActionResult Panel2()
        {
            return View();
        }

        public ActionResult Panel3()
        {
            return View();
        }

        public ActionResult Panel4()
        {
             return View( );
        }

    }
}