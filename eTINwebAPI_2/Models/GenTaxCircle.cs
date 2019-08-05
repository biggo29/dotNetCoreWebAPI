using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenTaxCircle
    {
        public long CircleNo { get; set; }
        public long AreaNo { get; set; }
        public string CircleName { get; set; }
        public string CircleAddr { get; set; }
        public string CircleInfo { get; set; }
        public string OldDbCircleName { get; set; }

        public GenTaxArea AreaNoNavigation { get; set; }
    }
}
