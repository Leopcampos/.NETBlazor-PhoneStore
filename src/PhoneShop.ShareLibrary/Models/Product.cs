using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PhoneShop.ShareLibrary.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Description { get; set; }
    [Required, Range(0.1, 99999.99)]
    public decimal Price { get; set; }
    [Required, DisplayName("Product Image")]
    public string? Base64Img { get; set; }
    public int Quantity { get; set; }
    public DateTime DateUploades { get; set; } = DateTime.Now;
    public bool Featured { get; set; }
}