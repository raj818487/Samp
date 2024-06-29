using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public int EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public int PhoneNumberConfirmed { get; set; }

    public int TwoFactorEnabled { get; set; }

    public string? LockoutEnd { get; set; }

    public int LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? CounterId { get; set; }

    public string FirstName { get; set; } = null!;

    public int IsActive { get; set; }

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public int? UtsavId { get; set; }

    public string? Address { get; set; }

    public int? CityId { get; set; }

    public string? ConsentedAt { get; set; }

    public string? SevaDepartment { get; set; }

    public int EnforceChangePassword { get; set; }

    public string? BookingPrefix { get; set; }

    public virtual ICollection<AccDetail> AccDetails { get; set; } = new List<AccDetail>();

    public virtual ICollection<AccReq> AccReqCreatedBies { get; set; } = new List<AccReq>();

    public virtual ICollection<AccReq> AccReqModifiedBies { get; set; } = new List<AccReq>();

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } = new List<AspNetUserLogin>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; } = new List<AspNetUserToken>();

    public virtual ICollection<Counter> CounterCreatedBies { get; set; } = new List<Counter>();

    public virtual ICollection<Counter> CounterModifiedBies { get; set; } = new List<Counter>();

    public virtual ICollection<House> HouseCreatedBies { get; set; } = new List<House>();

    public virtual ICollection<House> HouseModifiedBies { get; set; } = new List<House>();

    public virtual ICollection<MaintenanceIssue> MaintenanceIssueCreatedBies { get; set; } = new List<MaintenanceIssue>();

    public virtual ICollection<MaintenanceIssue> MaintenanceIssueModifiedBies { get; set; } = new List<MaintenanceIssue>();

    public virtual ICollection<PreAllotment> PreAllotments { get; set; } = new List<PreAllotment>();

    public virtual ICollection<QueryRoomGroup> QueryRoomGroupCreatedBies { get; set; } = new List<QueryRoomGroup>();

    public virtual ICollection<QueryRoomGroup> QueryRoomGroupModifiedBies { get; set; } = new List<QueryRoomGroup>();

    public virtual ICollection<RoomCleaningStatus> RoomCleaningStatusCreatedBies { get; set; } = new List<RoomCleaningStatus>();

    public virtual ICollection<RoomCleaningStatus> RoomCleaningStatusModifiedBies { get; set; } = new List<RoomCleaningStatus>();

    public virtual ICollection<Room> RoomCreatedBies { get; set; } = new List<Room>();

    public virtual ICollection<RoomGroup> RoomGroupCreatedBies { get; set; } = new List<RoomGroup>();

    public virtual ICollection<RoomGroup> RoomGroupModifiedBies { get; set; } = new List<RoomGroup>();

    public virtual ICollection<Room> RoomModifiedBies { get; set; } = new List<Room>();

    public virtual ICollection<Utsav> UtsavCreatedBies { get; set; } = new List<Utsav>();

    public virtual ICollection<Utsav> UtsavModifiedBies { get; set; } = new List<Utsav>();

    public virtual ICollection<AspNetRole> Roles { get; set; } = new List<AspNetRole>();
}
