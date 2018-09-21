using System.Collections.Generic;
using System.Linq;
using FicStore.Business.Repository;

namespace FicStore.Business.Queries.GetAllCategories
{
    public class GetAllCategoriesQuery
    {
        private ICategoryRepository CategoryRepository { get; }

        public GetAllCategoriesQuery(ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }

        public List<CategoryDto> Execute()
        {
            var categories = CategoryRepository.GetAll().ToList();
            var result = new List<CategoryDto>();

            foreach (var rootCategory in categories.Where(x => x.ParentCategory == null))
            {
                var category = GetAllCategoriesFactory.Create(rootCategory);
                category.ChildCategories = categories
                    .Where(x => x.ParentCategoryId == rootCategory.Id)
                    .Select(GetAllCategoriesFactory.Create);

                result.Add(category);
            }

            return result;
        }
    }
}
