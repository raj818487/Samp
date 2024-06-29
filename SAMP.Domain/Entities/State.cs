using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class State
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IsActive { get; set; }

    public int CountryId { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Haribhakt> Haribhakts { get; set; } = new List<Haribhakt>();
}
