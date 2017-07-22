using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Wallboards.UI
{
    public abstract class MainDbContext : DbContext
    {
        private void ReConfigure()
        {
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.UseDatabaseNullSemantics = true;
            Configuration.LazyLoadingEnabled = false;
        }

        protected MainDbContext()  
        {
            ReConfigure();
        }

        protected MainDbContext(string connectionStringName) : base("name=" + connectionStringName)
        {
            ReConfigure();
        }

    }

    public class CallCentreDbContext : MainDbContext
    {

        public CallCentreDbContext()
            : base("CallCentre")
        {
        }

    }

    public class ECatalogDbContext : MainDbContext
    {
        public ECatalogDbContext()
            : base("ECatalog")
        {
        }
    }

    public class VyatDbContext : MainDbContext
    {
        public VyatDbContext()
            : base("Vyat")
        {
        }
    }

    public class GzDbContext : MainDbContext
    {
        public GzDbContext()
            : base("GZ")
        {
        }
    }

    public class KzDbContext : MainDbContext
    {
        public KzDbContext()
            : base("KZ")
        {
        }
    }

}