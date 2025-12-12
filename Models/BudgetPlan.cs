using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace SkyMoney_Admin_System.Models;

public class BudgetPlan
{
    public int BudgetPlanId { get; set; } //Primary Key for Budget Plan

    [Required]
    public int UserAccountId { get; set; } // foreign key for UserAccount

    [Required]
    [StringLength(100)]
    public string PlanName { get; set; } = "Default Budget Plan";

    [Display(Name = "Total Budget")]
    [DataType(DataType.Currency)]
    public decimal TotalBudget { get; set; }

    [DataType(DataType.Currency)]
    [Display(Name = "Funded Amount")]
    public decimal FundedExpenses { get; set; }

    [NotMapped] //not tracked in DB, only calculated
    [DataType(DataType.Currency)]
    [Display(Name = "Available Budget")]
    public decimal AvailableBudget => TotalBudget - FundedExpenses;

    [ValidateNever]
    public UserAccount UserAccount { get; set; } = default!;
    public List<VariableExpense> VariableExpenses { get; set; } = new();
    public List<FixedExpense> FixedExpenses { get; set; } = new();
 
}      