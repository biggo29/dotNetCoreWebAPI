using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class OldCircleLocation
    {
        public long PkNo { get; set; }
        public long DistNo { get; set; }
        public string DistName { get; set; }
        public long ZoneNo { get; set; }
        public string ZoneCode { get; set; }
        public string ZoneName { get; set; }
        public long CircleNo { get; set; }
        public string CircleCode { get; set; }
        public string CircleName { get; set; }
        public string Location { get; set; }
    }
}
