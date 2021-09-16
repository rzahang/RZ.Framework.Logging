using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RZ.Framework.Logging.AbstractFactory.LogAppenders
{
    public class FileLoggAppender : IDisposable, ILogAppender

    {
        private bool _disposed;
        private readonly ICollection<Log> _logs;
        private string _fileName;

        public FileLoggAppender(string fileName)
        {
            _fileName = fileName;
            try
            {
                string logJson = File.ReadAllText(fileName);
                _logs = JsonSerializer.Deserialize<ICollection<Log>>(logJson);
            }
            catch (FileNotFoundException)
            {
                _logs = new List<Log>();
            }
        }

        public bool Append(Log log)
        {
            if (_disposed)
            {
                throw new Exception("Object is disposed.");
            }

            try
            {
                log.ID = Guid.NewGuid();

                _logs.Add(log);

                string logsJson = JsonSerializer.Serialize(_logs);
                File.WriteAllText(_fileName, logsJson);

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public void Dispose()
        {
            _disposed = true;
            _logs.Clear();

        }
    }
}
