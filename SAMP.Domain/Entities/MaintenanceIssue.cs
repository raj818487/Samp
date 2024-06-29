using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class MaintenanceIssue
{
    public int Id { get; set; }

    public int RoomId { get; set; }

    public string Category { get; set; } = null!;

    public string? Status { get; set; }

    public int IsCritical { get; set; }

    public int? LostOrDamagedQuantity { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public int? InventoryId { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual Inventory? Inventory { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual Room Room { get; set; } = null!;
}
