using System;
using System.Collections.Generic;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUsers
    {
        public NbrUsers()
        {
            NbrFeedBack = new HashSet<NbrFeedBack>();
            NbrMobileHis = new HashSet<NbrMobileHis>();
            NbrMobileRequest = new HashSet<NbrMobileRequest>();
            NbrPassRecovery = new HashSet<NbrPassRecovery>();
            NbrTinInfo = new HashSet<NbrTinInfo>();
            NbrUserAttachment = new HashSet<NbrUserAttachment>();
            NbrUserHistory = new HashSet<NbrUserHistory>();
            NbrUserLogonHis = new HashSet<NbrUserLogonHis>();
            NbrUserPhotos = new HashSet<NbrUserPhotos>();
        }

        public long UserNo { get; set; }
        public long UserTypeNo { get; set; }
        public string LogonName { get; set; }
        public string LogonPass { get; set; }
        public string PassSalt { get; set; }
        public string EmailAddr { get; set; }
        public string Mobile { get; set; }
        public string EmailActivateCode { get; set; }
        public string MobileActivateCode { get; set; }
        public string IpAddr { get; set; }
        public DateTime? RegisterTime { get; set; }
        public DateTime? EmailActivateTime { get; set; }
        public DateTime? MobileActivateTime { get; set; }
        public long? FacCentNo { get; set; }
        public bool? IsEmailActivated { get; set; }
        public bool? IsMobileActivated { get; set; }
        public bool? IsActive { get; set; }
        public string EmailActiveIpAddr { get; set; }
        public string MobileActiveIpAddr { get; set; }
        public long? FacDistNo { get; set; }
        public string FacCentName { get; set; }
        public string FacFullAddr { get; set; }
        public string FacContactPerson { get; set; }
        public string AdmFullName { get; set; }
        public string AdmDesignation { get; set; }
        public string AdmDepartment { get; set; }
        public string AdmOrganization { get; set; }
        public long? ZoneNo { get; set; }
        public long? RangeNo { get; set; }
        public long? CircleNo { get; set; }
        public string SecQuiz { get; set; }
        public string SecAnswer { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserNo { get; set; }
        public long? CreateLogonHisNo { get; set; }
        public string UpdateReason { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonHisNo { get; set; }
        public long? ApplicationQty { get; set; }
        public bool? IsPassChangeReq { get; set; }
        public bool? IsLocked { get; set; }
        public string LockReason { get; set; }
        public string MobPass { get; set; }
        public bool? IsFair { get; set; }
        public long? ClaimUserNo { get; set; }
        public bool? IsImported { get; set; }
        public long? TinInfoNo { get; set; }
        public bool? IsTinRequest { get; set; }
        public bool? IsCancel { get; set; }
        public long? CancelUserNo { get; set; }
        public long? CancelLogonNo { get; set; }
        public DateTime? CancelTime { get; set; }
        public string Nid { get; set; }
        public string NidName { get; set; }
        public DateTime? NidDob { get; set; }
        public string NidBname { get; set; }
        public string NidBfathName { get; set; }
        public string NidBmothName { get; set; }
        public string NidBspouseName { get; set; }
        public string NidBperAddr { get; set; }
        public string NidBpreAddr { get; set; }
        public string Remarks { get; set; }
        public string SmartId { get; set; }
        public bool? IsSmartApply { get; set; }
        public string MobileSub { get; set; }

        public GenCircleInfo CircleNoNavigation { get; set; }
        public GenDistrict FacDistNoNavigation { get; set; }
        public GenRangeInfo RangeNoNavigation { get; set; }
        public GenUserType UserTypeNoNavigation { get; set; }
        public GenZoneInfo ZoneNoNavigation { get; set; }
        public ICollection<NbrFeedBack> NbrFeedBack { get; set; }
        public ICollection<NbrMobileHis> NbrMobileHis { get; set; }
        public ICollection<NbrMobileRequest> NbrMobileRequest { get; set; }
        public ICollection<NbrPassRecovery> NbrPassRecovery { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
        public ICollection<NbrUserAttachment> NbrUserAttachment { get; set; }
        public ICollection<NbrUserHistory> NbrUserHistory { get; set; }
        public ICollection<NbrUserLogonHis> NbrUserLogonHis { get; set; }
        public ICollection<NbrUserPhotos> NbrUserPhotos { get; set; }
    }
}
