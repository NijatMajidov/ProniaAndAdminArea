namespace ProniaWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductPhoto> Photos { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
