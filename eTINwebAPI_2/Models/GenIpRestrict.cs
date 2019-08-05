using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenIpRestrict
    {
        public long IpRestrictNo { get; set; }
        public string IpAddr { get; set; }
        public bool? IsBlocked { get; set; }
        public DateTime? InsertTime { get; set; }
    }
}
