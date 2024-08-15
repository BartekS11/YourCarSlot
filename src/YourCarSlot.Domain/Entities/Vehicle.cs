using System.ComponentModel.DataAnnotations;
using YourCarSlot.Domain.Common;

namespace YourCarSlot.Domain.Entities;

public class Vehicle : BaseEntity
{
    public Vehicle()
    {
        Id = Guid.NewGuid();
    }

    [Key]
    public string? PlateNumber { get; set; }
    public string MakeOfCar { get; set; } = string.Empty;
    // public Localization CarLocalization { get; set; }
}