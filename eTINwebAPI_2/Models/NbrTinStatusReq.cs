using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTinStatusReq
    {
        public NbrTinStatusReq()
        {
            NbrAddrReq = new HashSet<NbrAddrReq>();
            NbrTinBusiReq = new HashSet<NbrTinBusiReq>();
            NbrVatReq = new HashSet<NbrVatReq>();
        }

        public long ReqNo { get; set; }
        public long TinInfoNo { get; set; }
        public long? UserNo { get; set; }
        public long RegTypeNo { get; set; }
        public long? RegJuriTypeNo { get; set; }
        public long? JuriSelectListNo { get; set; }
        public long? JuriSubListNo { get; set; }
        public string JuriListName { get; set; }
        public string JuriSubListName { get; set; }
        public bool IsOldTin { get; set; }
        public string OldTin { get; set; }
        public bool? IsLocal { get; set; }
        public long CountNo { get; set; }
        public long? DistNo { get; set; }
        public long? JuriTypeNo { get; set; }
        public long? JuriSelectTypeNo { get; set; }
        public bool? IsAdminInput { get; set; }
        public string Title { get; set; }
        public string AssesName { get; set; }
        public string FathName { get; set; }
        public string MothName { get; set; }
        public DateTime? Dob { get; set; }
        public string SpouseName { get; set; }
        public long? GenderNum { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmailAddr { get; set; }
        public long? ContactUpdateReasonNo { get; set; }
        public string ContactUpdateReason { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public string BoiNumber { get; set; }
        public DateTime? BoiDate { get; set; }
        public string VisaNumber { get; set; }
        public DateTime? VisaDate { get; set; }
        public string GuardianPpNumber { get; set; }
        public DateTime? GuardianPpIssueDate { get; set; }
        public string GuardianVisaNumber { get; set; }
        public DateTime? GuardianVisaDate { get; set; }
        public string Comments { get; set; }
        public bool? IsTokenVerified { get; set; }
        public string TokenIssued { get; set; }
        public DateTime? TokenDate { get; set; }
        public DateTime? TokenExpiryDate { get; set; }
        public string TokenComments { get; set; }
        public long? TokenUserNo { get; set; }
        public long? TokenLogonHisNo { get; set; }
        public long? VerifyUserNo { get; set; }
        public long? VerifyLogonHisNo { get; set; }
        public DateTime? TokenVerifyDate { get; set; }
        public long? TokenRejectReasonNo { get; set; }
        public string TokenRejectComments { get; set; }
        public long? BloodGroupNo { get; set; }
        public string Nid { get; set; }
        public long? DesigNo { get; set; }
        public string RelevantTin { get; set; }
        public string RelevantNid { get; set; }
        public string RelevantName { get; set; }
        public DateTime? RelevantDob { get; set; }
        public string NidTitle { get; set; }
        public string NidName { get; set; }
        public string NidBname { get; set; }
        public string NidBfathName { get; set; }
        public string NidBmothName { get; set; }
        public string NidBspouseName { get; set; }
        public DateTime? NidDob { get; set; }
        public string NidBperAddr { get; set; }
        public string NidBpreAddr { get; set; }
        public string GuardTin { get; set; }
        public string GuardName { get; set; }
        public string GuardNid { get; set; }
        public string GuardNidTitle { get; set; }
        public string GuardNidName { get; set; }
        public string GuardNidBname { get; set; }
        public string GuardNidBfathName { get; set; }
        public string GuardNidBmothName { get; set; }
        public DateTime? GuardNidDob { get; set; }
        public string GuardNidBperAddr { get; set; }
        public string IncorpNumber { get; set; }
        public DateTime? IncorpDate { get; set; }
        public string RjscName { get; set; }
        public string RjscAddr { get; set; }
        public string NewTin { get; set; }
        public DateTime? TinDate { get; set; }
        public bool? IsTemp { get; set; }
        public string TempTin { get; set; }
        public bool? IsCompleteProfile { get; set; }
        public bool? IsAutoJuri { get; set; }
        public long? CircleNo { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonHisNo { get; set; }
        public long LogonHisNo { get; set; }
        public string UpdateReason { get; set; }
        public long? RefTinInfoNo { get; set; }
        public DateTime? PassportExpDate { get; set; }
        public long? PassportTypeNum { get; set; }
        public bool? IsInvalid { get; set; }
        public long? PrevRegTypeNo { get; set; }
        public string AttachName { get; set; }
        public byte[] AttachData { get; set; }
        public string AttachExt { get; set; }
        public bool? IsImported { get; set; }
        public long? ReqUserNo { get; set; }
        public long? ReqLogonNo { get; set; }
        public DateTime? ReqTime { get; set; }
        public bool? ApproveStatusNum { get; set; }
        public long? ApproveUserNo { get; set; }
        public long? ApproveLogonNo { get; set; }
        public DateTime? ApproveTime { get; set; }
        public string ApproveComments { get; set; }
        public long? StatusReasonNo { get; set; }
        public string SmartId { get; set; }
        public bool? IsSmartApply { get; set; }

        public GenCountry CountNoNavigation { get; set; }
        public GenDesigList DesigNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
        public NbrTinStatusReq ReqNoNavigation { get; set; }
        public GenStatusReason StatusReasonNoNavigation { get; set; }
        public NbrTinInfo TinInfoNoNavigation { get; set; }
        public NbrTinStatusReq InverseReqNoNavigation { get; set; }
        public ICollection<NbrAddrReq> NbrAddrReq { get; set; }
        public ICollection<NbrTinBusiReq> NbrTinBusiReq { get; set; }
        public ICollection<NbrVatReq> NbrVatReq { get; set; }
    }
}
