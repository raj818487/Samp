using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Relation
{

    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int IsActive { get; set; }

    public virtual ICollection<AccReqDetail> AccReqDetails { get; set; } = new List<AccReqDetail>();
}
