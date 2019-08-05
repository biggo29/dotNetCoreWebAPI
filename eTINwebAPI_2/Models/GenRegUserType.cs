using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegUserType
    {
        public long RegUserTypeNo { get; set; }
        public long UserTypeNo { get; set; }
        public long RegTypeNo { get; set; }
        public bool IsOld { get; set; }
        public bool? IsAllowed { get; set; }
        public bool? IsNewTin { get; set; }

        public GenRegType RegTypeNoNavigation { get; set; }
        public GenUserType UserTypeNoNavigation { get; set; }
    }
}
