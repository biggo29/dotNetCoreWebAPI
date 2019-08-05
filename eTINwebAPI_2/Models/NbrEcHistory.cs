using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrEcHistory
    {
        public long EcHisNo { get; set; }
        public long TinInfoNo { get; set; }
        public string NidTitle { get; set; }
        public string NidName { get; set; }
        public string NidBname { get; set; }
        public string NidBfathName { get; set; }
        public string NidBmothName { get; set; }
        public string NidBspouseName { get; set; }
        public DateTime? NidDob { get; set; }
        public string NidBperAddr { get; set; }
        public string NidBpreAddr { get; set; }
        public byte[] NidPhoto { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateUserNo { get; set; }
        public long? CreateLogonHisNo { get; set; }
        public string SmartId { get; set; }
        public bool? IsSmartApply { get; set; }

        public NbrTinInfo TinInfoNoNavigation { get; set; }
    }
}
