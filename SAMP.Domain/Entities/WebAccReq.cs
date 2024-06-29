using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class WebAccReq
{
    public int Id { get; set; }

    public int UtsavId { get; set; }

    public string WebReqId { get; set; } = null!;

    public string? Honorific { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public int Age { get; set; }

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? NativePlace { get; set; }

    public string Email { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string? WhatsApp { get; set; }

    public string? LocalPhone { get; set; }

    public int? GentsCount { get; set; }

    public int? LadiesCount { get; set; }

    public int? ChildrenCount { get; set; }

    public string? ArrivalDate { get; set; }

    public string? ArrivalTime { get; set; }

    public string? DepatureDate { get; set; }

    public string? DepatureTime { get; set; }

    public string? TransportMode { get; set; }

    public int IsKeepingVehicle { get; set; }

    public string? Remarks { get; set; }

    public string? RequestedAt { get; set; }

    public string? DownloadedAt { get; set; }

    public string? ImportedAt { get; set; }

    public virtual Utsav Utsav { get; set; } = null!;

    public virtual ICollection<WebAccReqDetail> WebAccReqDetails { get; set; } = new List<WebAccReqDetail>();
}
