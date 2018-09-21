using System.Collections.Generic;

namespace FicStore.Business.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public int? ParentCategoryId { get; set; }
        public virtual Category ParentCategory { get; set; }
    }
}