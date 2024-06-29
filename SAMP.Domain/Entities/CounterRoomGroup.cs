using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class CounterRoomGroup
{
    public int UtsavId { get; set; }

    public int CounterId { get; set; }

    public int RoomGroupId { get; set; }

    public virtual Counter Counter { get; set; } = null!;

    public virtual RoomGroup RoomGroup { get; set; } = null!;

    public virtual Utsav Utsav { get; set; } = null!;
}
