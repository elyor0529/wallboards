using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Wallboards.UI.Controllers
{
    public class HomeController : BaseController
    {
        public async Task<ActionResult> Index()
        {
            //var result1 = await Gz.Database.SqlQuery<decimal?>(@"select count(*) from USER_LIST  where TYPE_CLIENT=2 and trunc(ACCREDITATION_DATE)>=to_date('01.01.2011','dd.mm.yyyy')").FirstOrDefaultAsync();
            //var result2 = await Kz.Database.SqlQuery<decimal?>(@"select count(*) count from USER_LIST  where TYPE_CLIENT=2 and trunc(ACCREDITATION_DATE)>=to_date('01.01.2011','dd.mm.yyyy');").FirstOrDefaultAsync();

            return View();
        }
    }
}