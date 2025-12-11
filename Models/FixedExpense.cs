using System.ComponentModel.DataAnnotations;

namespace SkyMoney_Admin_System.Models;

public class FixedExpense
{
    public int FixedExpenseId { get; set; } //Primary Key for FixedExpense

    [Required]
    public int BudgetPlanId { get; set; } //foreign key for BudgetPlan

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Display(Name = "Amount Due")]
    [DataType(DataType.Currency)]
    public decimal Amount { get; set; }

    [Display(Name = "Funded Amount")]
    [DataType(DataType.Currency)]
    public decimal FundedAmount { get; set; }

    [Display(Name = "Due Date")]
    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; }

    [Display(Name = "Is Financed")]
    public bool IsFinanced { get; set; }

    public BudgetPlan BudgetPlan { get; set; } = default!;
}