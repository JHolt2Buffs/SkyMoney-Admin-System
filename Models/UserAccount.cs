using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyMoney_Admin_System.Models;

public enum IncomeType
{
    Irregular = 0,
    Regular = 1
}

public enum PayFrequencyType
{
    Weekly = 1,
    BiWeekly = 2,
    Monthly = 3
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

    [Display(Name = "Pay Frequency")]
    public PayFrequencyType? PayFrequency { get; set; }

    
    public bool hasScheduledPay =>
    IncomeType == IncomeType.Regular && NextScheduledPayDate.HasValue;

    [NotMapped]
    [Display(Name = "Pay Frequency")]
    public string PayFrequencyLabel =>
        IncomeType == IncomeType.Irregular || !PayFrequency.HasValue
            ? "N/A"
            : PayFrequency.Value switch
            {
               PayFrequencyType.Weekly => "Weekly",
                PayFrequencyType.BiWeekly => "Biweekly",
                PayFrequencyType.Monthly => "Monthly",
                _ => PayFrequency.Value.ToString()

            };




    public List<BudgetPlan> BudgetPlans { get; set; } = new();

    public List<IncomeRecord> IncomeRecords { get; set; } = new();

    public List<TransactionRecord> TransactionRecords { get; set; } = new();
}