using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenUserType
    {
        public GenUserType()
        {
            GenMenuUserType = new HashSet<GenMenuUserType>();
            GenRegUserType = new HashSet<GenRegUserType>();
            GenUserTypeMenus = new HashSet<GenUserTypeMenus>();
            GenUsersPermissions = new HashSet<GenUsersPermissions>();
            GenWsUserTypes = new HashSet<GenWsUserTypes>();
            NbrUsers = new HashSet<NbrUsers>();
        }

        public long UserTypeNo { get; set; }
        public string UserType { get; set; }
        public long MaxApplication { get; set; }
        public bool? IsLocked { get; set; }

        public ICollection<GenMenuUserType> GenMenuUserType { get; set; }
        public ICollection<GenRegUserType> GenRegUserType { get; set; }
        public ICollection<GenUserTypeMenus> GenUserTypeMenus { get; set; }
        public ICollection<GenUsersPermissions> GenUsersPermissions { get; set; }
        public ICollection<GenWsUserTypes> GenWsUserTypes { get; set; }
        public ICollection<NbrUsers> NbrUsers { get; set; }
    }
}
