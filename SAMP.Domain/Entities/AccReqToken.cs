using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class AccReqToken
{
    public int Id { get; set; }

    public string? InviteeName { get; set; }

    public int InviterCityId { get; set; }

    public string Token { get; set; } = null!;

    public string HashToken { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public string? ModifiedAt { get; set; }

    public string? ModifiedById { get; set; }

    public int IsActive { get; set; }

    public string? LastAccessedAt { get; set; }

    public string? LastAccessedIp { get; set; }

    public int? AccReqId { get; set; }

    public int? InviteeCityId { get; set; }

    public string? InviteePhone { get; set; }

    public string? Reference { get; set; }

    public string? TrackingNumber { get; set; }

    public int? UtsavId { get; set; }

    public virtual AccReq? AccReq { get; set; }

    public virtual City InviterCity { get; set; } = null!;
}
