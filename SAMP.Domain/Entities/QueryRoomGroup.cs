using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class QueryRoomGroup
{
    public int Id { get; set; }

    public int UtsavId { get; set; }

    public int RgtypeId { get; set; }

    public int RoomGroupId { get; set; }

    public string Name { get; set; } = null!;

    public string Sql { get; set; } = null!;

    public int IsActive { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual ICollection<PreAllotment> PreAllotments { get; set; } = new List<PreAllotment>();

    public virtual RoomGroupType Rgtype { get; set; } = null!;

    public virtual RoomGroup RoomGroup { get; set; } = null!;

    public virtual Utsav Utsav { get; set; } = null!;

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
