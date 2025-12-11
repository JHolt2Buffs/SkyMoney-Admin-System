using System.ComponentModel.DataAnnotations;


namespace SkyMoney_Admin_System.Models;

public class TransactionRecord
{
    public int TransactionRecordId { get; set; } //primary key for TransactionRecord

    [Required]
    public int UserAccountId { get; set; } //foreign key for UserAccount

    [Display(Name = "Transaction Date")]
    [DataType(DataType.Date)]
    public DateTime TransactionDate { get; set; } = DateTime.Today;

    [Display(Name = "Amount")]
    [DataType(DataType.Currency)]
    public decimal Amount { get; set; }

    [StringLength(100)]
    public string Category { get; set; } = string.Empty;

    [StringLength(200)]
    public string Description { get; set; } = string.Empty;

    public UserAccount UserAccount { get; set; } = default!;
}
