using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrInfoEditRequest
    {
        public long RequestNo { get; set; }
        public long EditTypeNo { get; set; }
        public long TinInfoNo { get; set; }
        public bool? IsOldTin { get; set; }
        public string OldTin { get; set; }
        public string AssesName { get; set; }
        public string FathName { get; set; }
        public string MothName { get; set; }
        public DateTime? Dob { get; set; }
        public string SpouseName { get; set; }
        public long? GenderNum { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmailAddr { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public string BoiNumber { get; set; }
        public DateTime? BoiDate { get; set; }
        public string VisaNumber { get; set; }
        public DateTime? VisaDate { get; set; }
        public string RelevantTin { get; set; }
        public string GuardTin { get; set; }
        public string Addr { get; set; }
        public string Addr1 { get; set; }
        public long? AddrCountNo { get; set; }
        public long? AddrDistNo { get; set; }
        public long? AddrUpzaNo { get; set; }
        public long? AddrThanaNo { get; set; }
        public string AddrPostCode { get; set; }
        public string AddrCity { get; set; }
        public string AddrState { get; set; }
        public string AddrZipCode { get; set; }
        public string EditReason { get; set; }
        public long? RequestUserNo { get; set; }
        public long? RequestLogonNo { get; set; }
        public DateTime? RequestTime { get; set; }
        public long? ViewUserNo { get; set; }
        public long? ViewLogonNo { get; set; }
        public DateTime? ViewTime { get; set; }
        public bool? IsView { get; set; }
        public long? EscalateUserNo { get; set; }
        public long? EscalateLogonNo { get; set; }
        public DateTime? EscalateTime { get; set; }
        public bool? IsEscalate { get; set; }
        public long? VerifyUserNo { get; set; }
        public long? VerifyLogonNo { get; set; }
        public DateTime? VerifyTime { get; set; }
        public bool? IsVerify { get; set; }
        public long? ApproveUserNo { get; set; }
        public long? ApproveLogonNo { get; set; }
        public DateTime? ApproveTime { get; set; }
        public bool? IsApprove { get; set; }
        public string EscalateComments { get; set; }
        public string VerifyComments { get; set; }
        public string ApproveComments { get; set; }
        public long? CountNo { get; set; }

        public GenCountry AddrCountNoNavigation { get; set; }
        public GenDistrict AddrDistNoNavigation { get; set; }
        public GenThana AddrThanaNoNavigation { get; set; }
        public GenCountry CountNoNavigation { get; set; }
        public GenEditTypes EditTypeNoNavigation { get; set; }
        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
