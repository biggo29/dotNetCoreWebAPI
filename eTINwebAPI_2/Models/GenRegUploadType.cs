using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenRegUploadType
    {
        public long RegUploadNo { get; set; }
        public long RegTypeNo { get; set; }
        public long UploadTypeNo { get; set; }
        public bool? IsAllowed { get; set; }

        public GenRegType RegTypeNoNavigation { get; set; }
        public GenUploadType UploadTypeNoNavigation { get; set; }
    }
}
