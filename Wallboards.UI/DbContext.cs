using System.Data.Entity;

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
        private const string CONN_NAME = "CallCentre";
        
        public CallCentreDbContext()
            : base(CONN_NAME)
        {
        }

    }

    public class ECatalogDbContext : MainDbContext
    {
        private const string CONN_NAME = "ECatalog";

        public ECatalogDbContext()
            : base(CONN_NAME)
        {
        }
        
    }

    public class VyatDbContext : MainDbContext
    {
        private const string CONN_NAME = "Vyat";
 
        public VyatDbContext()
            : base(CONN_NAME)
        {
        }
        
    }

    public class GzDbContext : MainDbContext
    {
        private const string CONN_NAME = "GZ";

        public GzDbContext()
            : base(CONN_NAME)
        {
        }
        
    }

    public class KzDbContext : MainDbContext
    {
        private const string CONN_NAME = "KZ";
        
        public KzDbContext()
            : base(CONN_NAME)
        {
        }
        
    }

}