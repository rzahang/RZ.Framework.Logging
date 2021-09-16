using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RZ.Framework.Logging
{
    public enum LogType
    {
        None = 1,
        Debug = 1,
        Information= 2 ,
        Warning = 4 ,
        Error = 8 ,
        Fatal = 16
    }
}
