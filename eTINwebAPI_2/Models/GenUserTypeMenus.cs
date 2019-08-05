using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenUserTypeMenus
    {
        public long UserTypeMenuNo { get; set; }
        public long UserTypeNo { get; set; }
        public long? MenuNo { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }

        public GenMenuList MenuNoNavigation { get; set; }
        public GenUserType UserTypeNoNavigation { get; set; }
    }
}
