﻿using System;
using System.Collections.Generic;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTinInfo
    {
        public NbrTinInfo()
        {
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
            NbrAdtBusi = new HashSet<NbrAdtBusi>();
            NbrContactHistory = new HashSet<NbrContactHistory>();
            NbrEcHistory = new HashSet<NbrEcHistory>();
            NbrInfoEditRequest = new HashSet<NbrInfoEditRequest>();
            NbrInfoUpdate = new HashSet<NbrInfoUpdate>();
            NbrJurisdictionTransfer = new HashSet<NbrJurisdictionTransfer>();
            NbrRjscMasterHis = new HashSet<NbrRjscMasterHis>();
            NbrTinAttachment = new HashSet<NbrTinAttachment>();
            NbrTinBusinessInfo = new HashSet<NbrTinBusinessInfo>();
            NbrTinInfoHis = new HashSet<NbrTinInfoHis>();
            NbrTinStatusReq = new HashSet<NbrTinStatusReq>();
            NbrTinUpload = new HashSet<NbrTinUpload>();
            NbrTokenHistory = new HashSet<NbrTokenHistory>();
            NbrUsersClaim = new HashSet<NbrUsersClaim>();
            NbrVatInfo = new HashSet<NbrVatInfo>();
        }

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
        public bool? IsStatusChange { get; set; }
        public bool? IsUserChange { get; set; }
        public long? PrevUserNo { get; set; }
        public bool? IsTokenApproved { get; set; }
        public long? ApproveUserNo { get; set; }
        public long? ApproveLogonHisNo { get; set; }
        public DateTime? TokenApproveDate { get; set; }
        public long? ApproveRejectReasonNo { get; set; }
        public string ApproveRejectComments { get; set; }
        public DateTime? CertificateUpdateDate { get; set; }
        public string RjscToken { get; set; }
        public string SmartId { get; set; }
        public bool? IsSmartApply { get; set; }
        public int? EcReconTry { get; set; }
        public string Nid13 { get; set; }
        public bool? IsDup { get; set; }
        public decimal? PermitAuthorityId { get; set; }
        public string ContactTelephoneSub { get; set; }

        public GenBloodGroup BloodGroupNoNavigation { get; set; }
        public GenCircleInfo CircleNoNavigation { get; set; }
        public GenContactUpdateReason ContactUpdateReasonNoNavigation { get; set; }
        public GenCountry CountNoNavigation { get; set; }
        public GenDesigList DesigNoNavigation { get; set; }
        public GenDistrict DistNoNavigation { get; set; }
        public GenJuriSelectList JuriSelectListNoNavigation { get; set; }
        public GenJuriSelectType JuriSelectTypeNoNavigation { get; set; }
        public GenJuriSubList JuriSubListNoNavigation { get; set; }
        public GenJurisdictionType JuriTypeNoNavigation { get; set; }
        public GenWorkPermitAuthorityList PermitAuthority { get; set; }
        public GenRegJuriType RegJuriTypeNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
        public GenTokenRejectReason TokenRejectReasonNoNavigation { get; set; }
        public NbrUsers UserNoNavigation { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
        public ICollection<NbrAdtBusi> NbrAdtBusi { get; set; }
        public ICollection<NbrContactHistory> NbrContactHistory { get; set; }
        public ICollection<NbrEcHistory> NbrEcHistory { get; set; }
        public ICollection<NbrInfoEditRequest> NbrInfoEditRequest { get; set; }
        public ICollection<NbrInfoUpdate> NbrInfoUpdate { get; set; }
        public ICollection<NbrJurisdictionTransfer> NbrJurisdictionTransfer { get; set; }
        public ICollection<NbrRjscMasterHis> NbrRjscMasterHis { get; set; }
        public ICollection<NbrTinAttachment> NbrTinAttachment { get; set; }
        public ICollection<NbrTinBusinessInfo> NbrTinBusinessInfo { get; set; }
        public ICollection<NbrTinInfoHis> NbrTinInfoHis { get; set; }
        public ICollection<NbrTinStatusReq> NbrTinStatusReq { get; set; }
        public ICollection<NbrTinUpload> NbrTinUpload { get; set; }
        public ICollection<NbrTokenHistory> NbrTokenHistory { get; set; }
        public ICollection<NbrUsersClaim> NbrUsersClaim { get; set; }
        public ICollection<NbrVatInfo> NbrVatInfo { get; set; }
    }
}
