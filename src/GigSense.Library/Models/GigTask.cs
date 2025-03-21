using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class GigTask
{
    public required string Id { get; set; }

    public required string GigId { get; set; }

    public required string GigName { get; set; }

    public required string PayPeriodId { get; set; }

    public required string ShiftId { get; set; }

    public string? Origin { get; set; }

    [Display(Name = "Start Time")]
    public DateTime StartDateTime { get; set; }

    [Display(Name = "End Time")]
    public DateTime EndDateTime { get; set; }

    public TimeSpan Hours { get; set; }

    [Display(Name = "Base Rate")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal BaseRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Tips { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Earnings { get; set; }

    [Display(Name = "Hourly Rate")]
    public bool IsHourlyRate { get; set; }

    [Display(Name = "Earnings/Hour")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsPerHour { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Fees { get; set; }

    [Display(Name = "Start Miles")]
    public int StartMiles { get; set; }

    [Display(Name = "End Miles")]
    public int EndMiles { get; set; }

    [Display(Name = "Total Miles")]
    public int TotalMiles { get; set; }

    [Display(Name = "Earnings/Mile")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal EarningsPerMile { get; set; }

    [Display(Name = "Route Assigned")]
    public bool WasRouteAssigned { get; set; } = true;

    [Display(Name = "Completed")]
    public bool IsCompleted { get; set; }

    [Display(Name = "Pay Date")]
    public DateTime PayDate { get; set; }


    // TODO: Updates PayPeriod.EarningsPendingTotal when IsPaid is true
    [Display(Name = "Paid")]
    public bool IsPaid { get; set; }

    // TODO: Updates PayPeriod.EarningsPaid when IsPaid is true
    [Display(Name = "Instant Payout")]
    public bool WasInstantPayout { get; set; }


    GigTaskSummary ToSummary()
    {
        return new GigTaskSummary
        {
            Id = Id,
            GigId = GigId,
            GigName = GigName,
            PayPeriodId = PayPeriodId,
            ShiftId = ShiftId,
            Earnings = Earnings,
            IsCompleted = IsCompleted
        };
    }

}

