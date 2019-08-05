using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenTaxArea
    {
        public GenTaxArea()
        {
            GenTaxCircle = new HashSet<GenTaxCircle>();
        }

        public long AreaNo { get; set; }
        public long DistNo { get; set; }
        public string AreaName { get; set; }
        public string AreaAddr { get; set; }
        public string AreaInfo { get; set; }
        public string OldDbZoneName { get; set; }

        public ICollection<GenTaxCircle> GenTaxCircle { get; set; }
    }
}
