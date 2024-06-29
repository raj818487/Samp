using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Room
{
    public int Id { get; set; }

    public string? UniqueId { get; set; }

    public int RoomGroupId { get; set; }

    public int? HouseId { get; set; }

    public int StatusId { get; set; }

    public string? Grade { get; set; }

    public int? Bhk { get; set; }

    public decimal? Deposit { get; set; }

    public string? Prefix { get; set; }

    public int? RoomNo { get; set; }

    public string? Postfix { get; set; }

    public int? FloorId { get; set; }

    public int Capacity { get; set; }

    public string OccupancyType { get; set; } = null!;

    public int IsDormitory { get; set; }

    public string? Remarks { get; set; }

    public decimal? DefaultRate { get; set; }

    public int? RtisPrivate { get; set; }

    public int RtgentsCount { get; set; }

    public int RtladiesCount { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public int OriginalCapacity { get; set; }

    public virtual ICollection<AccDetail> AccDetails { get; set; } = new List<AccDetail>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual Floor? Floor { get; set; }

    public virtual House? House { get; set; }

    public virtual ICollection<MaintenanceIssue> MaintenanceIssues { get; set; } = new List<MaintenanceIssue>();

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual ICollection<PreAllotmentDetail> PreAllotmentDetails { get; set; } = new List<PreAllotmentDetail>();

    public virtual ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();

    public virtual ICollection<RoomCleaningStatus> RoomCleaningStatuses { get; set; } = new List<RoomCleaningStatus>();

    public virtual RoomGroup RoomGroup { get; set; } = null!;

    public virtual ICollection<RoomInventory> RoomInventories { get; set; } = new List<RoomInventory>();

    public virtual RoomStatus Status { get; set; } = null!;
}
