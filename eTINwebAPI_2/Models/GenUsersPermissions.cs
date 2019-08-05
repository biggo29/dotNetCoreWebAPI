using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenUsersPermissions
    {
        public long PermitNo { get; set; }
        public long UserTypeNo { get; set; }
        public long ActionNo { get; set; }
        public bool? IsAllowed { get; set; }

        public GenControllerAction ActionNoNavigation { get; set; }
        public GenUserType UserTypeNoNavigation { get; set; }
    }
}
