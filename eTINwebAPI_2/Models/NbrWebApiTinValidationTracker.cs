using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public class NbrWebApiTinValidationTracker
    {
        public long TrackerId { get; set; }
        public string NewTin { get; set; }
        public long UserNo { get; set; }
        public string AssesName { get; set; }
        public string Mobile { get; set; }
        public string IpAddr { get; set; }
        public long? CircleNo { get; set; }
        public string Nid { get; set; }
        public string PassportNumber { get; set; }
        public long AuthId { get; set; }
        public DateTime InsertTime { get; set; }
    }
}
