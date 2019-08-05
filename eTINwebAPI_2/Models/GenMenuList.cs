using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenMenuList
    {
        public GenMenuList()
        {
            GenMenuUserType = new HashSet<GenMenuUserType>();
            GenUserTypeMenus = new HashSet<GenUserTypeMenus>();
        }

        public long MenuNo { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public string MenuControllerName { get; set; }
        public string MenuActionName { get; set; }
        public string MenuTips { get; set; }
        public long? SlNo { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<GenMenuUserType> GenMenuUserType { get; set; }
        public ICollection<GenUserTypeMenus> GenUserTypeMenus { get; set; }
    }
}
