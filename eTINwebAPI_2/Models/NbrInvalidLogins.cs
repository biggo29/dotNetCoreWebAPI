using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrInvalidLogins
    {
        public long InvalidLoginNo { get; set; }
        public string LogonName { get; set; }
        public string LogonPass { get; set; }
        public string IpAddr { get; set; }
        public DateTime AccessTime { get; set; }
    }
}
