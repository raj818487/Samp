using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; } = new List<AspNetRoleClaim>();

    public virtual ICollection<QueryRoomGroup> QueryRoomGroups { get; set; } = new List<QueryRoomGroup>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<AspNetUser> Users { get; set; } = new List<AspNetUser>();
}
