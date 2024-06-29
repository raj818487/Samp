using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class RoomGroupType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int IsActive { get; set; }

    public virtual ICollection<QueryRoomGroup> QueryRoomGroups { get; set; } = new List<QueryRoomGroup>();

    public virtual ICollection<RoomGroup> RoomGroups { get; set; } = new List<RoomGroup>();
}
