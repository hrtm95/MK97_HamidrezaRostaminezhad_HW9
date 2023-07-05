using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string PhotoUrl { get; set; }
        [Required]
        public string Barcode { get; set; }
        [Required]
        public string ShortDescription { get; set; }
    }
}