using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Utsav
{
    public int Id { get; set; }

    public string? UniqueId { get; set; }

    public string? Name { get; set; }

    public int IsMandir { get; set; }

    public string? Description { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? AreaOrMilestone { get; set; }

    public int? CityId { get; set; }

    public string? PostalCode { get; set; }

    public string StartsOn { get; set; } = null!;

    public string EndsOn { get; set; } = null!;

    public string? DefaultArrivalAt { get; set; }

    public string? DefaultDepartureAt { get; set; }

    public string? WebAccReqPrefix { get; set; }

    public int? LastDownloadedWebAccReqId { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Long { get; set; }

    public string? LocationUrl { get; set; }

    public int IsClosed { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public string? StandardCheckinTime { get; set; }

    public string? StandardCheckoutTime { get; set; }

    public virtual ICollection<AccReq> AccReqs { get; set; } = new List<AccReq>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<CounterRoomGroup> CounterRoomGroups { get; set; } = new List<CounterRoomGroup>();

    public virtual ICollection<Counter> Counters { get; set; } = new List<Counter>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual ICollection<QueryRoomGroup> QueryRoomGroups { get; set; } = new List<QueryRoomGroup>();

    public virtual ICollection<RoomGroup> RoomGroupMandirUtsavs { get; set; } = new List<RoomGroup>();

    public virtual ICollection<RoomGroup> RoomGroupUtsavs { get; set; } = new List<RoomGroup>();

    public virtual ICollection<WebAccReq> WebAccReqs { get; set; } = new List<WebAccReq>();
}
