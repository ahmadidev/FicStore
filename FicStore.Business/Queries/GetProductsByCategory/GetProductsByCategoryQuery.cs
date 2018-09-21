using System.Collections.Generic;
using System.Linq;
using FicStore.Business.Entity;
using FicStore.Business.Repository;

namespace FicStore.Business.Queries.GetProductsByCategory
{
    public class GetProductsByCategoryQuery
    {
        private IProductRepository ProductRepository { get; }

        public GetProductsByCategoryQuery(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public IEnumerable<ProductDto> Execute(int categoryId)
        {
            return ProductRepository.GetByCategoryId(categoryId).Select(GetProductsByCategoryFactory.Create);
        }
    }

    public class GetProductsByCategoryFactory
    {
        public static ProductDto Create(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,
                Images = product.Images.Select(x => $"/api/Images/{x.Id}{x.Extension}"),
                Properties = product.Properties.Select(x => new PropertyDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Items = x.PropertyItems.Select(i => new PropertyItemDto
                    {
                        Id = i.Id,
                        Name = i.Name,
                        IncrementRate = i.IncrementRate
                    })
                })
            };
        }
    }
}
