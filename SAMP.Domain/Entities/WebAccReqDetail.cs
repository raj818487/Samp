using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class WebAccReqDetail
{
    public int Id { get; set; }

    public int WebAccReqId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Relation { get; set; }

    public virtual WebAccReq WebAccReq { get; set; } = null!;
}
