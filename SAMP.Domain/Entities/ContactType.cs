using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class ContactType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int IsActive { get; set; }

    public virtual ICollection<HouseContact> HouseContacts { get; set; } = new List<HouseContact>();

    public virtual ICollection<RoomGroupContact> RoomGroupContacts { get; set; } = new List<RoomGroupContact>();
}
