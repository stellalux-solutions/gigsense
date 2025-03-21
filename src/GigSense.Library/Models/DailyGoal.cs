using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class DailyGoal
{
    public required string Id { get; set; }
    public DateTime Date { get; set; }
    public List<ShiftSummary> Shifts { get; set; } = [];

    [Display(Name = "Total Miles")]
    public int TotalMiles { get; set; }

    [Display(Name = "Goal")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsGoal { get; set; }

    [Display(Name = "Earnings")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsActual { get; set; }

    public bool IsGoalAchieved { get; set; }

    public bool IsCompleted { get; set; }
}
