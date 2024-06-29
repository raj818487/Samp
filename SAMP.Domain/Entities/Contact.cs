using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class Contact
{
    public int Id { get; set; }

    public string? UniqueId { get; set; }

    public int UtsavId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int IsSatsangi { get; set; }

    public string PrimaryMobile { get; set; } = null!;

    public int IsPriMobWhatsApp { get; set; }

    public string? BackupMobile { get; set; }

    public int? IsBkpMobWhatsApp { get; set; }

    public string? Landline1 { get; set; }

    public string? Landline2 { get; set; }

    public string? Email { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AreaOrMilestone { get; set; }

    public int? CityId { get; set; }

    public string? PostalCode { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<ContactPhone> ContactPhones { get; set; } = new List<ContactPhone>();

    public virtual ICollection<HouseContact> HouseContacts { get; set; } = new List<HouseContact>();

    public virtual ICollection<RoomGroupContact> RoomGroupContacts { get; set; } = new List<RoomGroupContact>();

    public virtual Utsav Utsav { get; set; } = null!;
}
