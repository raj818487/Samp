using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class House
{
    public int Id { get; set; }

    public string? UniqueId { get; set; }

    public int RoomGroupId { get; set; }

    public int HouseTypeId { get; set; }

    public string AvailableFrom { get; set; } = null!;

    public string AvailableTo { get; set; } = null!;

    public string OccupancyType { get; set; } = null!;

    public int IsClosed { get; set; }

    public int IsSatsangi { get; set; }

    public int IsWholeFamilyInSeva { get; set; }

    public int IsVerified { get; set; }

    public int IsFavourite { get; set; }

    public int IsActive { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AreaOrMilestone { get; set; }

    public int? CityId { get; set; }

    public string? PostalCode { get; set; }

    public decimal? Lat { get; set; }

    public decimal? Long { get; set; }

    public string? LocationUrl { get; set; }

    public double? UtsavDistance { get; set; }

    public string? Remarks { get; set; }

    public string? LocationQuality { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual ICollection<HouseAmenity> HouseAmenities { get; set; } = new List<HouseAmenity>();

    public virtual ICollection<HouseContact> HouseContacts { get; set; } = new List<HouseContact>();

    public virtual ICollection<HouseInventory> HouseInventories { get; set; } = new List<HouseInventory>();

    public virtual HouseType HouseType { get; set; } = null!;

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual RoomGroup RoomGroup { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
