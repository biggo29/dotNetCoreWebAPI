using eTINwebAPI_2.Helper;
using eTINwebAPI_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTINwebAPI_2.BusinessLayer
{
    public class AuthTrackerBL
    {
        public static NbrWebApiAuthTracker SetAuthTokenHistory(NbrWebApiUser nbrWebApiUser, Utility utility)
        {
            NbrWebApiAuthTracker nbrWebApiAuthTracker = new NbrWebApiAuthTracker();
            nbrWebApiAuthTracker.InsertTime = DateTime.Now;
            nbrWebApiAuthTracker.ExpireTime = DateTime.Now.AddDays(1);
            nbrWebApiAuthTracker.IpAddr = utility.GetRequestIpAddress();
            nbrWebApiAuthTracker.UserNo = nbrWebApiUser.UserNo;
            return nbrWebApiAuthTracker;
        }
    }
}
