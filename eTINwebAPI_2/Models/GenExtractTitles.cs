using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Models
{
    public partial class GenExtractTitles
    {
        public long ExtractNo { get; set; }
        public string ExtractTitle { get; set; }
        public long? Slno { get; set; }
    }
}
