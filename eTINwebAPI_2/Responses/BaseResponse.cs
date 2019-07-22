using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.Responses
{
    public class BaseResponse
    {
        public int isError { get; set; }
        public string errorDescription { get; set; }
    }
}
