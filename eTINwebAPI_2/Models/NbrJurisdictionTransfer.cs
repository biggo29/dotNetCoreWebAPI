using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrJurisdictionTransfer
    {
        public long TrasferNo { get; set; }
        public long TinInfoNo { get; set; }
        public long? JuriTypeNo { get; set; }
        public long? RegJuriTypeNo { get; set; }
        public long? JuriSelectTypeNo { get; set; }
        public long? JuriSelectListNo { get; set; }
        public long? JuriSubListNo { get; set; }
        public string JuriListName { get; set; }
        public string JuriSubListName { get; set; }
        public bool? IsRaisedByApplicant { get; set; }
        public string RaiseComments { get; set; }
        public DateTime? RaiseTime { get; set; }
        public long? RaiseUserNo { get; set; }
        public long? RaiseLogonHisNo { get; set; }
        public long SrcCircleNo { get; set; }
        public bool? SrcIsNoc { get; set; }
        public string SrcComments { get; set; }
        public DateTime? SrcTime { get; set; }
        public long? SrcUserNo { get; set; }
        public long? SrcLogonHisNo { get; set; }
        public long? DestCircleNo { get; set; }
        public bool? DestIsAccept { get; set; }
        public string DestComments { get; set; }
        public DateTime? DestTime { get; set; }
        public long? DestUserNo { get; set; }
        public long? DestLogonHisNo { get; set; }
        public bool? IsApproved { get; set; }
        public string ApproveComments { get; set; }
        public DateTime? ApproveTime { get; set; }
        public long? ApproveUserNo { get; set; }
        public long? ApproveLogonHisNo { get; set; }
        public bool? IsFinalChanged { get; set; }
        public string FinalComments { get; set; }
        public DateTime? FinalTime { get; set; }
        public long? FinalUserNo { get; set; }
        public long? FinalLogonHisNo { get; set; }
        public bool? IsLocked { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
