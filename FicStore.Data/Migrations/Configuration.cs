using System;
using FicStore.Business.Entity;

namespace FicStore.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDbContext context)
        {
            var categories = new[]
            {
                new Category {Id = 1, Name = "Digital", ParentCategoryId = null},
                new Category {Id = 2, Name = "Mobile", ParentCategoryId = 1},
                new Category {Id = 3, Name = "PC", ParentCategoryId = 1},

                new Category {Id = 4, Name = "Book", ParentCategoryId = null},
                new Category {Id = 5, Name = "Romance", ParentCategoryId = 4},
                new Category {Id = 6, Name = "SciFi", ParentCategoryId = 4}
            };
            context.Categories.AddOrUpdate(x => x.Id, categories);

            var products = new[]
            {
                new Product { Id = 1, Title = "Honor6", Price = 1100 * 1000, CategoryId = 2},
                new Product { Id = 2, Title = "Nexus 5X", Price = 1300 * 1000, CategoryId = 2}
            };
            context.Products.AddOrUpdate(x => x.Id, products);

            var honorImages = new[]
            {
                new Image{ Id = Guid.Parse("71b9ff13-478e-4c20-9f74-10c4675adc6b"), ProductId = 1, Extension = ".jpg"},
                new Image{ Id = Guid.Parse("4c1da37d-0383-42a8-a9ab-6399a24bcc5a"), ProductId = 1, Extension = ".jpg"},
            };
            context.Images.AddOrUpdate(x => x.Id, honorImages);

            var honorProperties = new[]
            {
                new Property { Id = 1, Name = "Color", ProductId = 1},
                new Property { Id = 2, Name = "Guarantee", ProductId = 1}
            };
            context.Properties.AddOrUpdate(x => x.Id, honorProperties);

            var honorPropertiesItems = new[]
            {
                new PropertyItem { Id = 1, Name = "Black", IncrementRate = 20, PropertyId = 1 },
                new PropertyItem { Id = 2, Name = "White", IncrementRate = 10, PropertyId = 1 },

                new PropertyItem { Id = 3, Name = "Without Guarantee", IncrementRate = 0, PropertyId = 2 },
                new PropertyItem { Id = 4, Name = "Madiraan", IncrementRate = 30, PropertyId = 2 }
            };
            context.PropertyItems.AddOrUpdate(x => x.Id, honorPropertiesItems);
        }
    }
}
