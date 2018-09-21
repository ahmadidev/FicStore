using System.Collections.Generic;
using FicStore.Business.Entity;
using FicStore.Business.Repository;
using FicStore.Data;

namespace FicStore.Persistence
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext DbContext { get; }

        public CategoryRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IEnumerable<Category> GetAll()
        {
            return DbContext.Categories.AsNoTracking();
        }
    }
}
