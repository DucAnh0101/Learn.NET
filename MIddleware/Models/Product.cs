using System.ComponentModel.DataAnnotations;

namespace MIddleware.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
