using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class UserRoomGroup
{
    public string UserId { get; set; } = null!;

    public int RoomGroupId { get; set; }

    public virtual RoomGroup RoomGroup { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
