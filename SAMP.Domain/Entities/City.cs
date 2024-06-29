using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IsActive { get; set; }

    public int StateId { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<AccReqToken> AccReqTokens { get; set; } = new List<AccReqToken>();

    public virtual ICollection<AccReq> AccReqs { get; set; } = new List<AccReq>();

    public virtual State State { get; set; } = null!;
}
