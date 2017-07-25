using System.Web.Mvc;

namespace Wallboards.UI.Controllers
{
    [SessionAuthorize]
    public abstract class BaseController : Controller
    {
        protected BaseController()
        {
            Gz = new GzDbContext();
            Kz = new KzDbContext();
            Catalog = new ECatalogDbContext();
        }

        protected GzDbContext Gz { get; private set; }

        protected KzDbContext Kz { get; private set; }

        protected ECatalogDbContext Catalog { get; }

        protected override void Dispose(bool disposing)
        {
            
            if (disposing)
            {
                if (Gz != null)
                {
                    Gz.Dispose();
                    Gz = null;
                }

                if (Kz != null)
                {
                    Kz.Dispose();
                    Kz = null;
                }
            }
             
            base.Dispose(disposing);
        }

    }
}