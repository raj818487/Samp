using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IsActive { get; set; }

    public int ContinentId { get; set; }

    public string? CountryCode { get; set; }

    public virtual Continent Continent { get; set; } = null!;

    public virtual ICollection<Haribhakt> Haribhakts { get; set; } = new List<Haribhakt>();

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
