using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitWork : IUnitWork
    {
        private readonly IDbFactory dbFactory;
        private TEduShopDbContext dbContext;
        public UnitWork(IDbFactory _dbFactory)
        {
            dbFactory = _dbFactory;
        }
        public TEduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
