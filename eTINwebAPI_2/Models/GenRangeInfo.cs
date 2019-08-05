using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRangeInfo
    {
        public GenRangeInfo()
        {
            GenCircleInfo = new HashSet<GenCircleInfo>();
            NbrUsers = new HashSet<NbrUsers>();
        }

        public long RangeNo { get; set; }
        public long ZoneNo { get; set; }
        public string RangeName { get; set; }
        public string AdmName { get; set; }
        public string AdmAddr { get; set; }
        public string AdmContact { get; set; }

        public GenZoneInfo ZoneNoNavigation { get; set; }
        public ICollection<GenCircleInfo> GenCircleInfo { get; set; }
        public ICollection<NbrUsers> NbrUsers { get; set; }
    }
}
