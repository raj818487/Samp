using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class RoomGroupAmenity
{
    public int RoomGroupId { get; set; }

    public int AmenityId { get; set; }

    public int Count { get; set; }

    public string? Remarks { get; set; }

    public virtual Amenity Amenity { get; set; } = null!;

    public virtual RoomGroup RoomGroup { get; set; } = null!;
}
