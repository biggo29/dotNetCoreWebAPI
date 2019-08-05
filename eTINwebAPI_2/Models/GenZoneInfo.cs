using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenZoneInfo
    {
        public GenZoneInfo()
        {
            GenCircleInfo = new HashSet<GenCircleInfo>();
            GenRangeInfo = new HashSet<GenRangeInfo>();
            NbrUsers = new HashSet<NbrUsers>();
        }

        public long ZoneNo { get; set; }
        public string ZoneName { get; set; }
        public long? DistNo { get; set; }
        public string ZoneCode { get; set; }
        public string AdmName { get; set; }
        public string AdmAddr { get; set; }
        public string AdmContact { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentCode1 { get; set; }
        public string PaymentCode2 { get; set; }
        public string PayCodeInd { get; set; }
        public string PayCodeComp { get; set; }
        public string PayCodeOth { get; set; }

        public GenDistrict DistNoNavigation { get; set; }
        public ICollection<GenCircleInfo> GenCircleInfo { get; set; }
        public ICollection<GenRangeInfo> GenRangeInfo { get; set; }
        public ICollection<NbrUsers> NbrUsers { get; set; }
    }
}
