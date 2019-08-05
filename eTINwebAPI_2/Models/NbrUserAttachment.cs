using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrUserAttachment
    {
        public long AttachNo { get; set; }
        public long UserNo { get; set; }
        public long? AttachTypeNo { get; set; }
        public string AttachName { get; set; }
        public string DisplayName { get; set; }
        public byte[] AttachData { get; set; }
        public string AttachExt { get; set; }
        public DateTime? InsertTime { get; set; }
        public long? InsertUserNo { get; set; }
        public long? InsertLogonNo { get; set; }

        public GenAttachType AttachTypeNoNavigation { get; set; }
        public NbrUsers UserNoNavigation { get; set; }
    }
}
