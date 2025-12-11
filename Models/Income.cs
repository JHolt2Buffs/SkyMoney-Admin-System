using System.ComponentModel.DataAnnotations;

namespace SkyMoney_Admin_System.Models;

public class IncomeRecord
{
    public int IncomeRecordId { get; set; } //Primary Key for Income

    public int UserAccountId { get; set; } // foreign key for UserAccount

    [DataType(DataType.Currency)]
    [Display(Name = "Amount")]
    public decimal Amount { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Date Received")]
    public DateTime DateReceived { get; set; }

    public string? Notes { get; set; }

    public UserAccount UserAccount { get; set; } = default!;
}