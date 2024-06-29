using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Haribhakt
{
    public int Id { get; set; }

    public string UniqueId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual State? State { get; set; }
}
