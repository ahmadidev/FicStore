using System.Collections.Generic;
using FicStore.Business.Entity;

namespace FicStore.Business.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetByCategoryId(int categoryId);
    }
}
