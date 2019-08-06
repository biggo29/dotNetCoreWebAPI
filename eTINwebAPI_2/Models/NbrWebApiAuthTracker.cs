using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public class NbrWebApiAuthTracker
    {
        public long AuthId { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime ExpireTime { get; set; }
        public string IpAddr { get; set; }
        public long UserNo { get; set; }
    }
}
