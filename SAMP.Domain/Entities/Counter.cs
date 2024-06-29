using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Counter
{
    public int Id { get; set; }

    public int UtsavId { get; set; }

    public string? Name { get; set; }

    public string? Alias { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public virtual ICollection<CounterRoomGroup> CounterRoomGroups { get; set; } = new List<CounterRoomGroup>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual Utsav Utsav { get; set; } = null!;
}
