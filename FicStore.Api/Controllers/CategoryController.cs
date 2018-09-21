using System.Web.Http;
using FicStore.Business.Queries.GetAllCategories;
using FicStore.Business.Queries.GetProductsByCategory;

namespace FicStore.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private GetAllCategoriesQuery GetAllCategoriesQuery { get; }
        public GetProductsByCategoryQuery GetProductsByCategoryQuery { get; }

        public CategoryController(
            GetAllCategoriesQuery getAllCategoriesQuery,
            GetProductsByCategoryQuery getProductsByCategoryQuery)
        {
            GetAllCategoriesQuery = getAllCategoriesQuery;
            GetProductsByCategoryQuery = getProductsByCategoryQuery;
        }

        public IHttpActionResult GetAll()
        {
            var categories = GetAllCategoriesQuery.Execute();

            return Ok(categories);
        }

        public IHttpActionResult GetProducts(int id)
        {
            var products = GetProductsByCategoryQuery.Execute(id);

            return Ok(products);
        }
    }
}
