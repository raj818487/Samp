using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Aitype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int IsActive { get; set; }

    public virtual ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
