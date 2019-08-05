using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUsersHis
    {
        public long UserHisNo { get; set; }
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
    }
}
