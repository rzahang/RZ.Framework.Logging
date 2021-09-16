using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RZ.Framework.Logging.AbstractFactory.LogAppenders;

namespace RZ.Framework.Logging.AbstractFactory
{
    public class DatabaseLoggerAbstractFactory : ILoggerAbstractFactory
    {
        private readonly string _connectionString;

        public DatabaseLoggerAbstractFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ILogAppender CreateLog()
        {
            return new DatabaseLogAppender(_connectionString);
        }
    }
}
