using System;
using System.Collections.Generic;

namespace eTINwebAPI_2.Models
{
    public partial class NbrFeedBack
    {
        public long FeedBackNo { get; set; }
        public long UserNo { get; set; }
        public long LogonHisNo { get; set; }
        public string FSubject { get; set; }
        public string FComments { get; set; }
        public DateTime InsertTime { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? ReadTime { get; set; }
        public long? ReadUserNo { get; set; }
        public long? ReadLogonHisNo { get; set; }

        public NbrUsers UserNoNavigation { get; set; }
    }
}
