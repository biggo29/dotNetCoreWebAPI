using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenControllerAction
    {
        public GenControllerAction()
        {
            GenUsersPermissions = new HashSet<GenUsersPermissions>();
            InverseParentActionNoNavigation = new HashSet<GenControllerAction>();
        }

        public long ActionNo { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAutoInclude { get; set; }
        public bool? IsPublic { get; set; }
        public long? ParentActionNo { get; set; }

        public GenControllerAction ParentActionNoNavigation { get; set; }
        public ICollection<GenUsersPermissions> GenUsersPermissions { get; set; }
        public ICollection<GenControllerAction> InverseParentActionNoNavigation { get; set; }
    }
}
