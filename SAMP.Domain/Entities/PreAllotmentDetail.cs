using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class PreAllotmentDetail
{
    public int AccReqId { get; set; }

    public int RoomId { get; set; }

    public int GentsCount { get; set; }

    public int LadiesCount { get; set; }

    public int IsExplicit { get; set; }

    public int IsActive { get; set; }

    public virtual AccReq AccReq { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
