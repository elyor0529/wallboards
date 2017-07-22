using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wallboards.UI.Controllers
{
    [SessionAuthorize]
    public abstract class BaseController : Controller
    {
        private GzDbContext _gzDbContext;
        private KzDbContext _kzDbContext;
        private ECatalogDbContext _catalog;

        protected BaseController()
        {
            _gzDbContext = new GzDbContext();
            _kzDbContext = new KzDbContext();
            _catalog = new ECatalogDbContext();
        }

        protected GzDbContext Gz
        {
            get
            {
                return _gzDbContext;
            }
        }

        protected KzDbContext Kz
        {
            get
            {
                return _kzDbContext;
            }
        }

        protected ECatalogDbContext Catalog
        {
            get
            {
                return _catalog;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_gzDbContext != null)
                {
                    _gzDbContext.Dispose();
                    _gzDbContext = null;
                }

                if (_kzDbContext != null)
                {
                    _kzDbContext.Dispose();
                    _kzDbContext = null;
                }
            }
             
            base.Dispose(disposing);
        }

    }
}