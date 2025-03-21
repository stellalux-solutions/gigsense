using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigSense.Library.Models;

public class Gig
{
    public required string Id { get; set; }

    public required string Name { get; set; }

    [Display(Name = "Pay Days")]
    public List<DateTime> PayDays { get; set; } = [];

    [Display(Name = "Instant Pay Available")]
    public bool HasInstantPayOption { get; set; } = true;

    [Display(Name = "Instant Pay Fee")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal InstantPayFee { get; set; }

    [Phone]
    [Display(Name = "Support Number")]
    public string? SupportPhone { get; set; }

    [EmailAddress]
    [Display(Name = "Support Email")]
    public string? SupportEmail { get; set; }

    public string? Notes { get; set; }

}
