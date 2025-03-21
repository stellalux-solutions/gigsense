using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class Shift
{
    public required string Id { get; set; }

    public List<GigTaskSummary> GigTasks { get; set; } = [];

    [Display(Name = "Start Time")]
    public DateTime StartDateTime { get; set; }

    [Display(Name = "End Time")]
    public DateTime EndDateTime { get; set; }

    public TimeSpan Hours { get; set; }

    [Display(Name = "Start Miles")]
    public int StartMiles { get; set; }

    [Display(Name = "End Miles")]
    public int EndMiles { get; set; }

    [Display(Name = "Total Miles")]
    public int TotalMiles { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Earnings { get; set; }

    [Display(Name = "Rental Used")]
    public bool WasRentalUsed { get; set; } = true;

    public bool IsCompleted { get; set; }


    ShiftSummary ToSummary()
    {
        return new ShiftSummary
        {
            Id = Id,
            TotalMiles = TotalMiles,
            Earnings = Earnings,
            IsCompleted = IsCompleted
        };
    }
}
