using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SkyMoney_Admin_System.Models;

public class VariableExpense
{
    public int VariableExpenseId { get; set; } //Primary Key for VariableExpense

    [Required]
    public int BudgetPlanId { get; set; } //Forgein Key for BudetPlan

    [Required]
    [StringLength(100)]
    [Display(Name = "Category Name")]
    public string CategoryName { get; set; } = string.Empty;

    [Range(0, 100)]
    [Display(Name = "% of Available Budget")]
    public decimal PercentOfAvailableBudget { get; set; }

    [DataType(DataType.Currency)]
    [Display(Name = "Category Balance")]
    public decimal CategoryBalance { get; set; }

    [ValidateNever]
    public BudgetPlan BudgetPlan { get; set; } = default!;
    

}