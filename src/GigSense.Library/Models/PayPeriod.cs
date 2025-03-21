using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class PayPeriod
{
    public required string Id { get; set; }

    public int Year { get; set; }

    // TODO: Use ISO week, not calendar week?
    [Display(Name = "Week Number")]
    public int WeekNumber { get; set; }

    [Display(Name = "Start Date")]
    public DateTime StartDateTime { get; set; }

    [Display(Name = "End Date")]
    public DateTime EndDateTime { get; set; }

    // TODO: TotalMiles Does not update until all shifts in DailyGoal are completed
    [Display(Name = "Total Miles")]
    public int TotalMiles { get; set; }

    [Display(Name = "Goal")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsGoal { get; set; }

    // TODO: EarningsPending Does not update until all shifts in DailyGoal are completed or payout is received
    [Display(Name = "Pending Earnings")]
    public List<GigTaskSummary> EarningsPending = [];

    // TODO: EarningsPendingTotal update when EarningsPending is updated 
    [Display(Name = "Pending Earnings Total")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsPendingTotal { get; set; }

    // TODO: Does not update until all shifts in DailyGoal are completed
    [Display(Name = "Total Earnings")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsActual { get; set; }

    public bool IsGoalAchieved { get; set; }

    public bool IsCompleted { get; set; }
}
