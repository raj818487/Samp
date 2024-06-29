using System;
using System.Collections.Generic;

namespace SAMP.Domain.Entities;

public partial class AccReq
{
    public int Id { get; set; }

    public int UtsavId { get; set; }

    public int BookingRefId { get; set; }
    public string? BookingRefNo { get; set; }


    public int StatusId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string Gender { get; set; } = null!;

    public int Age { get; set; }

    public int? CityId { get; set; }

    public string? NativePlace { get; set; }

    public string? Email { get; set; }

    public string PrimaryMobile { get; set; } = null!;

    public int IsPriMobWhatsApp { get; set; }

    public string? BackupMobile { get; set; }

    public int IsBkpMobWhatsApp { get; set; }

    public string? LocalPhone { get; set; }

    public int IsLocalPhoneWhatsApp { get; set; }

    public int GentsCount { get; set; }

    public int LadiesCount { get; set; }

    public int ChildrenCount { get; set; }

    public string? DeptName { get; set; }

    public int? ReqTransModeId { get; set; }

    public int IsKeepingVehicle { get; set; }

    public string? GuestRemarks { get; set; }

    public string? Reference { get; set; }

    public string? OfficeRemarks { get; set; }

    public string ExpCheckInTime { get; set; } = null!;

    public string ExpCheckOutTime { get; set; } = null!;

    public decimal? Deposit { get; set; }

    public decimal? PaidRent { get; set; }

    public decimal? ReturnedDeposit { get; set; }

    public string ModifiedAt { get; set; } = null!;

    public string? ModifiedById { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string? CreatedById { get; set; }

    public string? ConsentedAt { get; set; }

    public string? Category { get; set; }

    public int? HaribhaktId { get; set; }

    public virtual ICollection<AccDetail> AccDetails { get; set; } = new List<AccDetail>();

    public virtual ICollection<AccReqDetail> AccReqDetails { get; set; } = new List<AccReqDetail>();

    public virtual ICollection<AccReqToken> AccReqTokens { get; set; } = new List<AccReqToken>();

    public virtual City? City { get; set; }

    public virtual AspNetUser? CreatedBy { get; set; }

    public virtual AspNetUser? ModifiedBy { get; set; }

    public virtual PreAllotment? PreAllotment { get; set; }

    public virtual ICollection<PreAllotmentDetail> PreAllotmentDetails { get; set; } = new List<PreAllotmentDetail>();

    public virtual ReqTransMode? ReqTransMode { get; set; }

    public virtual AccReqStatus Status { get; set; } = null!;

    public virtual Utsav Utsav { get; set; } = null!;
}
