using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class AccDetail
{
    public int AccReqId { get; set; }

    public int RoomId { get; set; }

    public int IsPrivate { get; set; }

    public int GentsCount { get; set; }

    public int LadiesCount { get; set; }

    public string? CounterCheckInTime { get; set; }

    public string? ActCheckInTime { get; set; }

    public string? CounterCheckOutTime { get; set; }

    public string? AllotedById { get; set; }

    public virtual AccReq AccReq { get; set; } = null!;

    public virtual AspNetUser? AllotedBy { get; set; }

    public virtual Room Room { get; set; } = null!;
}
