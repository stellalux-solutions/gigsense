using System.ComponentModel.DataAnnotations;

namespace GigSense.Library.Models;

public class Location
{
    public required string Id { get; set; }

    public required string GigId { get; set; }

    public string? Code { get; set; }

    public required string Name { get; set; }

    [Display(Name = "Station Type")]
    public required StationType StationType { get; set; }
    public string? Address { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string? Notes { get; set; }
}

public enum StationType
{
    [Display(Name = "Delivery Station")] DeliveryStation,
    [Display(Name = "Sub/Same-Day")] SubSameDay,
    [Display(Name = "Community Delivery")] CommunityDelivery,
    Grocery,
    Retail,
    Other
}
