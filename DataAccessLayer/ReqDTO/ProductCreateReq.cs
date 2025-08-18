using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.ReqDTO
{
    public class ProductCreateReq
    {
        [Required]
        public string Name { get; set; }
        [Range(1, 10000)]
        public decimal Price { get; set; }
    }
}
