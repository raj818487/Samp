namespace SAMP.Application.DTOs.AccReqDto
{
    public class AccReqUpdateDto
    {
        public int Id { get; set; }
        public int? UtsavId { get; set; }
        public int? StatusId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public int? CityId { get; set; }
        public string? PrimaryMobile { get; set; }
        public int? IsPriMobWhatsApp { get; set; }
        public int? IsBkpMobWhatsApp { get; set; }
        public int? IsLocalPhoneWhatsApp { get; set; }
        public int? GentsCount { get; set; }
        public int? LadiesCount { get; set; }
        public int? ChildrenCount { get; set; }
        public int? IsKeepingVehicle { get; set; }
        public int? ReqTransModeId { get; set; }
        public string? DeptName { get; set; }
        public string? GuestRemarks { get; set; }

        public string? Reference { get; set; }

        public string? OfficeRemarks { get; set; }
        public decimal? Deposit { get; set; }

        public decimal? PaidRent { get; set; }
        public string? ExpCheckInTime { get; set; }
        public string? ExpCheckOutTime { get; set; }
        public string? ModifiedAt { get; set; }
        public string? CreatedAt { get; set; }

    }
}
