using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenDataType
    {
        public GenDataType()
        {
            GenConfigType = new HashSet<GenConfigType>();
        }

        public long DataTypeNo { get; set; }
        public string DataType { get; set; }

        public ICollection<GenConfigType> GenConfigType { get; set; }
    }
}
