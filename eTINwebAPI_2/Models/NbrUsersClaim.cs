using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUsersClaim
    {
        public long ClaimUserNo { get; set; }
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
        public string SecQuiz { get; set; }
        public string SecAnswer { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? TinInfoNo { get; set; }
        public string NewTin { get; set; }
        public string AssesName { get; set; }
        public long? ApproveTypeNum { get; set; }
        public DateTime? ApproveTime { get; set; }
        public long? ApproveUserNo { get; set; }
        public long? ApproveLogonNo { get; set; }
        public string ApproveComments { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
