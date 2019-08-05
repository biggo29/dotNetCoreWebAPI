using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegBusinessType
    {
        public long RegBusiTypeNo { get; set; }
        public long RegTypeNo { get; set; }
        public long BusiTypeNo { get; set; }
        public bool IsAllowed { get; set; }
        public int MinEntry { get; set; }
        public int MaxEntry { get; set; }

        public GenBusinessType BusiTypeNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
    }
}
