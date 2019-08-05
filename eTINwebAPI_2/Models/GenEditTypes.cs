using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenEditTypes
    {
        public GenEditTypes()
        {
            GenRegEditTypes = new HashSet<GenRegEditTypes>();
            NbrInfoEditRequest = new HashSet<NbrInfoEditRequest>();
        }

        public long EditTypeNo { get; set; }
        public string EditTypes { get; set; }
        public string ActionUrl { get; set; }
        public long? SlNo { get; set; }

        public ICollection<GenRegEditTypes> GenRegEditTypes { get; set; }
        public ICollection<NbrInfoEditRequest> NbrInfoEditRequest { get; set; }
    }
}
