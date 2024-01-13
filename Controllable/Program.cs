using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ElasticFocus.TinyTools.Uptime.ElastiX;
using ElasticFocus.TinyTools.Uptime.ElastiX.Models;

namespace ElasticFocus.TinyTools.Uptime
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReport Result = ServiceLogic.Result();
            if(Result.EXEC_RESULT == ServiceLogic.FRESULT.SUCCESS)
                Console.WriteLine(Result.CONTAINER);
            if(Result.EXEC_RESULT == ServiceLogic.FRESULT.FAILURE)
                Console.WriteLine(Result.CONTAINER);
            Console.ReadKey();
        }
    }
}
