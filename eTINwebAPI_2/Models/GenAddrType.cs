using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenAddrType
    {
        public GenAddrType()
        {
            GenRegAddrType = new HashSet<GenRegAddrType>();
            NbrAddrInfo = new HashSet<NbrAddrInfo>();
        }

        public long AddrTypeNo { get; set; }
        public string AddrType { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<GenRegAddrType> GenRegAddrType { get; set; }
        public ICollection<NbrAddrInfo> NbrAddrInfo { get; set; }
    }
}
