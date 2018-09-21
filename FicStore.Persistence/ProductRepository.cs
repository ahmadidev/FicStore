using System.Collections.Generic;
using System.Linq;
using FicStore.Business.Entity;
using FicStore.Business.Repository;
using FicStore.Data;

namespace FicStore.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private AppDbContext DbContext { get; }

        public ProductRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IEnumerable<Product> GetByCategoryId(int categoryId)
        {
            return DbContext.Products.AsNoTracking().Where(x => x.CategoryId == categoryId);
        }
    }
}