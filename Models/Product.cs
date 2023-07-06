using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Enter name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Enter Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Enter PhotoUrl")]
        public string PhotoUrl { get; set; }
        [Required(ErrorMessage = "Enter PhotoUrl")]
        public string Barcode { get; set; }
        [Required(ErrorMessage = "Enter Barcode")]
        public string ShortDescription { get; set; }
    }
}