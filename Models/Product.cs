using System.ComponentModel.DataAnnotations;

namespace InventoryBillingSystem.Models
{
    public class Product
    {
        public int ProductID { get; set; }   // Primary Key

        [Required]
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Foreign Key
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; } = null!;

        // Navigation
        public ICollection<BillItem> BillItems { get; set; } = new List<BillItem>();

        public string? ImagePath { get; set; }


    }
}
