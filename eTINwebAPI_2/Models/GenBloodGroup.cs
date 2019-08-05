using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenBloodGroup
    {
        public GenBloodGroup()
        {
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long BloodGroupNo { get; set; }
        public string BloodGroupName { get; set; }

        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
