using System.Collections.Generic;

namespace FicStore.Business.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Property> Properties { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}