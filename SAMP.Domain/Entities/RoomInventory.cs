using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class RoomInventory
{
    public int RoomId { get; set; }

    public int InventoryId { get; set; }

    public int ReqOwner { get; set; }

    public int ReqUtara { get; set; }

    public int? Actual { get; set; }

    public int? WindUp { get; set; }

    public virtual Inventory Inventory { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
