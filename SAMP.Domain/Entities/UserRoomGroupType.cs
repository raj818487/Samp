using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class UserRoomGroupType
{
    public string UserId { get; set; } = null!;

    public int RgtypeId { get; set; }

    public virtual RoomGroupType Rgtype { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
