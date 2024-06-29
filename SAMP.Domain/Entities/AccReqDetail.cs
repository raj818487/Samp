using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class AccReqDetail
{
    public int Id { get; set; }

    public int AccReqId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public int? RelationId { get; set; }

    public string? MobileNumber { get; set; }

    public string? Remarks { get; set; }

    public virtual AccReq AccReq { get; set; } = null!;

    public virtual Relation? Relation { get; set; }
}
