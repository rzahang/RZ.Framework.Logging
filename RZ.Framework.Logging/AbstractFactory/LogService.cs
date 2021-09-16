using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RZ.Framework.Logging.AbstractFactory.LogAppenders;

namespace RZ.Framework.Logging.AbstractFactory
{
    public class LogService
    {
        private readonly ILoggerAbstractFactory _loggerAbstractFactory;

        public LogService(ILoggerAbstractFactory loggerAbstractFactory)
        {
            _loggerAbstractFactory = loggerAbstractFactory;
        }
        public bool Log(Log log)
        {
            log.ID = Guid.NewGuid();
            using (ILogAppender appender = _loggerAbstractFactory.CreateLog())
            {
                return appender.Append(log);
            }
        }
    }
}
