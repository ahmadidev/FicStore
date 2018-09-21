using System.Collections.Generic;

namespace FicStore.Business.Entity
{
    public class Property
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public virtual ICollection<PropertyItem> PropertyItems { get; set; }
    }
}