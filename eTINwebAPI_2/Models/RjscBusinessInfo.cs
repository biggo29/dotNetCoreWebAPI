using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class RjscBusinessInfo
    {
        public long RjscBusiNo { get; set; }
        public long RjscIncoprNo { get; set; }
        public long BusiTypeNo { get; set; }
        public string RjscBusiTin { get; set; }
        public string RjscBusiName { get; set; }

        public RjscIncorpInfo RjscIncoprNoNavigation { get; set; }
    }
}
