using System.Data.Entity;
using FicStore.Business.Entity;

namespace FicStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Image>().Property(x => x.Extension).IsUnicode(false).IsRequired().HasMaxLength(10);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyItem> PropertyItems { get; set; }
    }
}
