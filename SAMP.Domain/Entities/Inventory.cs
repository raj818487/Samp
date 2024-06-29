using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Inventory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int IsActive { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<HouseInventory> HouseInventories { get; set; } = new List<HouseInventory>();

    public virtual ICollection<MaintenanceIssue> MaintenanceIssues { get; set; } = new List<MaintenanceIssue>();

    public virtual ICollection<RoomInventory> RoomInventories { get; set; } = new List<RoomInventory>();

    public virtual ICollection<Aitype> Aitypes { get; set; } = new List<Aitype>();
}
