using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegJuriType
    {
        public GenRegJuriType()
        {
            NbrTinInfo = new HashSet<NbrTinInfo>();
        }

        public long RegJuriTypeNo { get; set; }
        public long RegTypeNo { get; set; }
        public long JuriTypeNo { get; set; }
        public bool? IsActive { get; set; }

        public GenJurisdictionType JuriTypeNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
        public ICollection<NbrTinInfo> NbrTinInfo { get; set; }
    }
}
