using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Client.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(maximumLength: 200, ErrorMessage = "Description must be at most 200 characters.")]
        public string Description { get; set; }

        public bool Availability { get; set; } = false;

    }
}
