using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Amenity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int IsBoolean { get; set; }

    public int IsActive { get; set; }

    public virtual ICollection<HouseAmenity> HouseAmenities { get; set; } = new List<HouseAmenity>();

    public virtual ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();

    public virtual ICollection<RoomGroupAmenity> RoomGroupAmenities { get; set; } = new List<RoomGroupAmenity>();

    public virtual ICollection<Aitype> Aitypes { get; set; } = new List<Aitype>();
}
