using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
     class DbFactory : Disposeable, IDbFactory
    {
        TEduShopDbContext dbContext;
        public TEduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TEduShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
