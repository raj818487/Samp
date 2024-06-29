using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMP.Application.DTOs.AccReqDto
{
    public class AccReqResponseDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int BookingRefId { get; set; }

        public string BookingRefNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string FullName => FirstName + " " + MiddleName + " " + LastName;
        public string NativePlace { get; set; }
        public string Email { get; set; }
        public string PrimaryMobile { get; set; }
        public bool IsPriMobWhatsApp { get; set; }
        public string BackupMobile { get; set; }
        public bool IsBkpMobWhatsApp { get; set; }
        public string LocalPhone { get; set; }
        public bool IsLocalPhoneWhatsApp { get; set; }
        public int GentsCount { get; set; }
        public int LadiesCount { get; set; }
        public int ChildrenCount { get; set; }
        public int TotalCount => GentsCount + LadiesCount + ChildrenCount;
        public string? DeptName { get; set; }
        public bool IsDeptReq
        {
            get { return !String.IsNullOrWhiteSpace(DeptName); }
        }
        public int ReqTransModeId { get; set; }
        public string TransportMode { get; set; }
        public bool IsKeepingVehicle { get; set; }
        public string GuestRemarks { get; set; }
        public string Reference { get; set; }
        public string OfficeRemarks { get; set; }
        public DateTime ExpCheckInTime { get; set; }
        public DateTime ExpCheckOutTime { get; set; }
        public decimal Deposit { get; set; }
        public decimal? PaidRent { get; set; }
        public decimal? ReturnedDeposit { get; set; }
        public string PaRoomGroup { get; set; }




        // Add other properties as needed
    }

}
