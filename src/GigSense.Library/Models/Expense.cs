using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class Expense
{
    public required string Id { get; set; }

    public required string GigId { get; set; }

    public DateTime Date { get; set; }

    public ExpenseCategory Category { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Total { get; set; }

    public string? Description { get; set; }
}

public enum ExpenseCategory
{
    Fuel,
    Supplies,
    Rental,
    [Display(Name = "Auto Repair")] AutoRepair,
    [Display(Name = "Auto Maintence")] AutoMaintence,
    Other
}
