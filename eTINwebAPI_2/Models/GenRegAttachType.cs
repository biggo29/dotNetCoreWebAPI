using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegAttachType
    {
        public long RegAttachNo { get; set; }
        public long RegTypeNo { get; set; }
        public long AttachTypeNo { get; set; }
        public bool? IsAllowed { get; set; }
        public bool? IsRequired { get; set; }

        public GenAttachType AttachTypeNoNavigation { get; set; }
        public GenRegType RegTypeNoNavigation { get; set; }
    }
}
