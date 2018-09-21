namespace FicStore.Business.Entity
{
    public class PropertyItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Rate of product price increment.
        /// </summary>
        public double IncrementRate { get; set; }

        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
    }
}