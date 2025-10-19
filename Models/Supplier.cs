using System.ComponentModel.DataAnnotations;

namespace InventoryBillingSystem.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Phone]
        public string ContactNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        // Navigation
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
