using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegEditTypes
    {
        public long RegEditTypeNo { get; set; }
        public long RegTypeNo { get; set; }
        public long EditTypeNo { get; set; }
        public bool IsAllowed { get; set; }

        public GenEditTypes EditTypeNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
    }
}
