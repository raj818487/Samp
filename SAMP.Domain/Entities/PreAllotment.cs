using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class PreAllotment
{
    public int AccReqId { get; set; }

    public int QueryRoomGroupId { get; set; }

    public int IsPrivate { get; set; }

    public int AllowPrivateDormitory { get; set; }

    public string ExpCheckInTime { get; set; } = null!;

    public string ExpCheckOutTime { get; set; } = null!;

    public string AllotedAt { get; set; } = null!;

    public string? AllotedById { get; set; }

    public int IsActive { get; set; }

    public int? IsAuto { get; set; }

    public virtual AccReq AccReq { get; set; } = null!;

    public virtual AspNetUser? AllotedBy { get; set; }

    public virtual QueryRoomGroup QueryRoomGroup { get; set; } = null!;
}
