using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class ContactPhone
{
    public int Id { get; set; }

    public int ContactId { get; set; }

    public string? Type { get; set; }

    public string? Number { get; set; }

    public int IsWhatsApp { get; set; }

    public virtual Contact Contact { get; set; } = null!;
}
