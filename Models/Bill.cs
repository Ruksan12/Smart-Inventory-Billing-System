using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryBillingSystem.Models
{
    public class Bill
    {
        [Key]
        public int BillID { get; set; }

        [Required]
        public string BillNumber { get; set; } = string.Empty;

        public DateTime BillDate { get; set; } = DateTime.Now;

        // Foreign key: Customer
        public int CustomerID { get; set; }

        [ForeignKey(nameof(CustomerID))]
        public Customer Customer { get; set; } = null!;

        // Navigation
        public ICollection<BillItem> BillItems { get; set; } = new List<BillItem>();
    }
}
