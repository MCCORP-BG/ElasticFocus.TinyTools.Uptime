using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace ElasticFocus.TinyTools.Uptime.ElastiX.WMI
{
    class ActiveUsers
    {
        public static UInt32 GetActiveUsers()
        {
            UInt32 Counted = 0;
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    if (obj["UserName"] != null)
                        Counted++;
                }
                return Counted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when retrieving active users. ");
                return Counted;
            }
        }
    }
}
