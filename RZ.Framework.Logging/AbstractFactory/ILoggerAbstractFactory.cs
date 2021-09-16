using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RZ.Framework.Logging.AbstractFactory.LogAppenders;

namespace RZ.Framework.Logging.AbstractFactory
{
    public interface ILoggerAbstractFactory
    {
        ILogAppender CreateLog();
    }
}
