namespace ShobBlaze.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
        public List<Product_Prop> ProductProperties { get; set; } = new();
    }
}
