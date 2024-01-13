using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ElasticFocus.TinyTools.Uptime.ElastiX.Models;
using ElasticFocus.TinyTools.Uptime.ElastiX.WMI;

namespace ElasticFocus.TinyTools.Uptime.ElastiX
{
    class ServiceLogic
    {
        internal enum FRESULT 
        {
            FAILURE,
            SUCCESS
        };
        internal static TimeSpan GetUptime
        {
            get
            {
                using (var PCResult = new PerformanceCounter("System", "System Up Time"))
                {
                    PCResult.NextValue();
                    return TimeSpan.FromSeconds(PCResult.NextValue());
                }
            }
        }
        public static ServiceReport Result() 
        {
            try
            {
                    TimeSpan RES_GUPTM = GetUptime;
                    string RES = String.Format("{0} | Up: {1} {2}, {3} {4}, {5} {6} and {7} {8}, Active Users: {9}",
                    DateTime.Now.ToString("HH:mm:ss"),
                    RES_GUPTM.Days,
                    (RES_GUPTM.Days == 1) ? "day" : "days",
                    RES_GUPTM.Hours,
                    (RES_GUPTM.Hours == 1) ? "hour" : "hours",
                    RES_GUPTM.Minutes,
                    (RES_GUPTM.Minutes == 1) ? "minute" : "minutes",
                    RES_GUPTM.Seconds,
                    (RES_GUPTM.Minutes == 1) ? "second" : "seconds",
                    ActiveUsers.GetActiveUsers()
                    );
                return new ServiceReport(FRESULT.SUCCESS, RES);
            }
            catch (Exception)
            {
                return new ServiceReport(FRESULT.FAILURE, "Could not proccess command due to unknown error.");
            }
        }
    }
}
