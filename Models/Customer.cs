using System.ComponentModel.DataAnnotations;

namespace InventoryBillingSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Phone]
        public string ContactNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // Navigation
        public ICollection<Bill> Bills { get; set; } = new List<Bill>();
    }
}
