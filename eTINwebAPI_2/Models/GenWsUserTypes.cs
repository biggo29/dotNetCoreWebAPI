using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenWsUserTypes
    {
        public long WsUserTypeNo { get; set; }
        public long WsNo { get; set; }
        public long UserTypeNo { get; set; }
        public bool? IsActive { get; set; }

        public GenUserType UserTypeNoNavigation { get; set; }
        public GenWsList WsNoNavigation { get; set; }
    }
}
