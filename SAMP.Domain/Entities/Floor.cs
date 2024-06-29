using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Floor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int IsActive { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
