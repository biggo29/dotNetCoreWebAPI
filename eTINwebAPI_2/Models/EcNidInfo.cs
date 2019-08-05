using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class EcNidInfo
    {
        public long NidInfoNo { get; set; }
        public string Nid { get; set; }
        public DateTime NidDob { get; set; }
        public string NidName { get; set; }
        public string NidGender { get; set; }
        public string NidBname { get; set; }
        public string NidBfathName { get; set; }
        public string NidBmothName { get; set; }
        public string NidBspouseName { get; set; }
        public string NidBperAddr { get; set; }
        public string NidBpreAddr { get; set; }
        public string NidBloodGroup { get; set; }
        public byte[] NidPhoto { get; set; }
        public string SmartId { get; set; }
    }
}
