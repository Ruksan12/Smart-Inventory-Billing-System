using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryBillingSystem.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be a positive value")]
        public decimal Amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpenseDate { get; set; } = DateTime.Now;

        public string? Category { get; set; } // e.g. Rent, Supplies, Utilities
    }
}
