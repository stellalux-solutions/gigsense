using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class GigTaskSummary
{
    public required string Id { get; set; }

    public required string GigId { get; set; }

    public required string GigName { get; set; }

    public required string PayPeriodId { get; set; }

    public required string ShiftId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Earnings { get; set; }

    public bool IsCompleted { get; set; }
}
