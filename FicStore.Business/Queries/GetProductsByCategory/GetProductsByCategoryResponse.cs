using System.Collections.Generic;

namespace FicStore.Business.Queries.GetProductsByCategory
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IEnumerable<string> Images { get; set; }
        public IEnumerable<PropertyDto> Properties { get; set; }
    }

    public class PropertyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PropertyItemDto> Items { get; set; }
    }

    public class PropertyItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double IncrementRate { get; set; }
    }
}
