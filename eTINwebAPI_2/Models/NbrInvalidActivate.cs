using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrInvalidActivate
    {
        public long InvalidNo { get; set; }
        public string LogonName { get; set; }
        public string ActivationType { get; set; }
        public string EmailActivateCode { get; set; }
        public DateTime? EmailActivateTime { get; set; }
        public string EmailActiveIpAddr { get; set; }
        public string MobileActivateCode { get; set; }
        public DateTime? MobileActivateTime { get; set; }
        public string MobileActiveIpAddr { get; set; }
    }
}
