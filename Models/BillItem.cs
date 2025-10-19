using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryBillingSystem.Models
{
    public class BillItem
    {
        [Key]
        public int BillItemID { get; set; }

        public int BillID { get; set; }

        [ForeignKey(nameof(BillID))]
        public Bill Bill { get; set; } = null!;

        public int ProductID { get; set; }

        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
