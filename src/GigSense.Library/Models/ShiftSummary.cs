using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class ShiftSummary
{
    public required string Id { get; set; }

    [Display(Name = "Total Miles")]
    public int TotalMiles { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Earnings { get; set; }

    public bool IsCompleted { get; set; }
}
