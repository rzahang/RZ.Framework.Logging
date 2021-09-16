using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RZ.Framework.Logging.AbstractFactory.LogAppenders;

namespace RZ.Framework.Logging.AbstractFactory
{
    public class FileLoggerAbstractFactory : ILoggerAbstractFactory
    {
        private readonly string _fileName;

        public FileLoggerAbstractFactory(string fileName)
        {
            _fileName = fileName;
        }

        public ILogAppender CreateLog()
        {
            return new FileLoggAppender(_fileName);
        }
    }
}
