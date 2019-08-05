using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class RjscIncorpInfo
    {
        public RjscIncorpInfo()
        {
            RjscBusinessInfo = new HashSet<RjscBusinessInfo>();
        }

        public long RjscIncoprNo { get; set; }
        public string IncorpNumber { get; set; }
        public DateTime IncorpDate { get; set; }

        public ICollection<RjscBusinessInfo> RjscBusinessInfo { get; set; }
    }
}
