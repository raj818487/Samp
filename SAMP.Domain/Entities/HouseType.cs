using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class HouseType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IsActive { get; set; }

    public virtual ICollection<House> Houses { get; set; } = new List<House>();
}
