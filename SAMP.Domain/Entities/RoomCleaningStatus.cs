using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class RoomCleaningStatus
{
    public int Id { get; set; }

    public int RoomId { get; set; }

    public int CleaningStatus { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual Room Room { get; set; } = null!;
}
