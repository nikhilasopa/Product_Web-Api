using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products_Web_API.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string ProductName { get; set; } = "";
        public string ProductDescription { get; set; }
         public string ProductType { get; set; }
    }
}
