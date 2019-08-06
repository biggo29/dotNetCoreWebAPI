using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public class TinInfoTracker
    {
        public long TrackerId { get; set; }
        public string NewTin { get; set; }
        public long UserNo { get; set; }
        public string AssesName { get; set; }
        public string Mobile { get; set; }
        public string IpAddr { get; set; }
        public long? CircleNo { get; set; }
        public string Nid { get; set; }
    }
}
