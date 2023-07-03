namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int PhotoUrl { get; set; }
        public string Barcode { get; set; }
    }
}