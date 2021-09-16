using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RZ.Framework.Logging.AbstractFactory.LogAppenders
{
    public class DatabaseLogAppender : IDisposable, ILogAppender
    {
        private bool _disposed;
        private string connestionString;

        public DatabaseLogAppender(string connestionString)
        {
            this.connestionString = connestionString;
        }

        public bool Append(Log log)
        {
            // Implementation of logging in DB 


            return true;
        }

        public void Dispose()
        {
            _disposed = true;
        }
    }
}
