using System.ComponentModel.DataAnnotations;

namespace SkyMoney_Admin_System.Models;

public enum IncomeType
{
    Irregular = 0,
    Regular = 1
}
public class UserAccount
{
    public int UserAccountId { get; set; } //Primary Key for Users

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string EmailAddress { get; set; } = string.Empty;

    [Required]
    [Display(Name = "First Name")]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Last Name")]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Display(Name = "Created At")]
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }

    [Display(Name = "Income Type")]
    public IncomeType IncomeType { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Next Scheduled Pay Date")]
    public DateTime? NextScheduledPayDate { get; set; }

    [Range(1, 60)]
    [Display(Name = "Pay Frequency(days)")]
    public int? PayFrequencyDays { get; set; }

    public bool hasScheduledPay =>
    IncomeType == IncomeType.Regular && NextScheduledPayDate.HasValue;




    public List<BudgetPlan> BudgetPlans { get; set; } = new();

    public List<IncomeRecord> IncomeRecords { get; set; } = new();

    public List<TransactionRecord> TransactionRecords { get; set; } = new();
}