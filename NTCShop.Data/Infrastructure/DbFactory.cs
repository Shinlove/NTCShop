using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        NTCShopDbContext dbContext;
        public NTCShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NTCShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
