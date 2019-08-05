using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegAddrType
    {
        public long RegAddrTypeNo { get; set; }
        public long RegTypeNo { get; set; }
        public long AddrTypeNo { get; set; }
        public bool? IsRequired { get; set; }

        public GenAddrType AddrTypeNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
    }
}
