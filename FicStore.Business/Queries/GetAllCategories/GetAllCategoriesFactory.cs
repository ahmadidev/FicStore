using FicStore.Business.Entity;

namespace FicStore.Business.Queries.GetAllCategories
{
    public class GetAllCategoriesFactory
    {
        public static CategoryDto Create(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
