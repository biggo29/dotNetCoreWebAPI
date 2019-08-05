using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrTinAttachment
    {
        public long AttachNo { get; set; }
        public long TinInfoNo { get; set; }
        public long AttachTypeNo { get; set; }
        public string AttachName { get; set; }
        public byte[] AttachData { get; set; }
        public string AttachExt { get; set; }
        public bool? IsImported { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateUserNo { get; set; }
        public long? UpdateLogonNo { get; set; }
        public string UpdateReason { get; set; }

        public GenAttachType AttachTypeNoNavigation { get; set; }
        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
