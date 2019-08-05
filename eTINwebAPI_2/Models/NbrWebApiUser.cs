using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class NbrWebApiUser
    {
        public long Id { get; set; }
        public long UserNo { get; set; }
        public string UserRole { get; set; }
        public bool IsActive { get; set; }
    }
}
