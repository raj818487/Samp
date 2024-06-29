using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Continent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IsActive { get; set; }

    
    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
