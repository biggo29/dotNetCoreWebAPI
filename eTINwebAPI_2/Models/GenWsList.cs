using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenWsList
    {
        public GenWsList()
        {
            GenWsUserTypes = new HashSet<GenWsUserTypes>();
        }

        public long WsNo { get; set; }
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string WsName { get; set; }

        public ICollection<GenWsUserTypes> GenWsUserTypes { get; set; }
    }
}
