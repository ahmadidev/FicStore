using System.Collections.Generic;

namespace FicStore.Business.Queries.GetAllCategories
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<CategoryDto> ChildCategories { get; set; }
    }
}