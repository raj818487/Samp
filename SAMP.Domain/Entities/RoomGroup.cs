using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class RoomGroup
{
    public int Id { get; set; }

    public string? UniqueId { get; set; }

    public int UtsavId { get; set; }

    public int RgtypeId { get; set; }

    public string? Name { get; set; }

    public string? NegCheckInTime { get; set; }

    public string? NegCheckOutTime { get; set; }

    public int? MinOccupancyRoomCount { get; set; }

    public decimal? CancellationNoticeHours { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AreaOrMilestone { get; set; }

    public int? CityId { get; set; }

    public string? PostalCode { get; set; }

    public int IsPermanent { get; set; }

    public int? MandirUtsavId { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Long { get; set; }

    public string? LocationUrl { get; set; }

    public double? UtsavDistance { get; set; }

    public int IsActive { get; set; }

    public string? AvailableFrom { get; set; }

    public string? AvailableUpto { get; set; }

    public string? LocationQuality { get; set; }

    public string? Remarks { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public int? IsReadOnly { get; set; }

    public string? DisplayId { get; set; }

    public virtual ICollection<CounterRoomGroup> CounterRoomGroups { get; set; } = new List<CounterRoomGroup>();

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual ICollection<House> Houses { get; set; } = new List<House>();

    public virtual Utsav? MandirUtsav { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual ICollection<QueryRoomGroup> QueryRoomGroups { get; set; } = new List<QueryRoomGroup>();

    public virtual RoomGroupType Rgtype { get; set; } = null!;

    public virtual ICollection<RoomGroupAmenity> RoomGroupAmenities { get; set; } = new List<RoomGroupAmenity>();

    public virtual ICollection<RoomGroupContact> RoomGroupContacts { get; set; } = new List<RoomGroupContact>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual Utsav Utsav { get; set; } = null!;
}
