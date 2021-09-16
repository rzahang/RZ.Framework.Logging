using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RZ.Framework.Logging
{
    public class Log
    {
        public Guid ID { get; set; }
        public DateTime LoggDate { get; set; }
        public LogType LogType { get; set; }
        public string Message { get; set; }

        public string Domain { get; set; }
        public string ThreadName { get; set; }
        public string DeploymentID { get; set; }

        //... any other 


        public override string ToString()
        {
            //TBC
            return string.Format("Log ID :{0} - {1} - {2:dd HH:mmss.fff} - {3}", ID, LogType, LoggDate, Message);
        }
    }
}
