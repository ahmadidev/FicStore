using System;

namespace FicStore.Business.Entity
{
    public class Image
    {
        public Guid Id { get; set; }

        public string Extension { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}