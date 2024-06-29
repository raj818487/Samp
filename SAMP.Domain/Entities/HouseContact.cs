using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class HouseContact
{
    public int HouseId { get; set; }

    public int ContactTypeId { get; set; }

    public int ContactId { get; set; }

    public int IsDefault { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactType ContactType { get; set; } = null!;

    public virtual House House { get; set; } = null!;
}
