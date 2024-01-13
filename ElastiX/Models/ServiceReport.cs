using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ElasticFocus.TinyTools.Uptime.ElastiX.ServiceLogic;

namespace ElasticFocus.TinyTools.Uptime.ElastiX.Models
{
    class ServiceReport
    {
        public FRESULT EXEC_RESULT {get; set;}
        public Object CONTAINER { get; set; }

        public ServiceReport(FRESULT eXEC_RESULT, object cONTAINER)
        {
            EXEC_RESULT = eXEC_RESULT;
            CONTAINER = cONTAINER ?? throw new ArgumentNullException(nameof(cONTAINER));
        }
    }
}
