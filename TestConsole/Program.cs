using RZ.Framework.Logging;
using RZ.Framework.Logging.AbstractFactory;
using System;

namespace TestConsole
{
    class Program
    {
        private const string FILE_NAME = "e:\\logs.json";

        static void Main(string[] args)
        {
            var now = DateTime.UtcNow;
            ILoggerAbstractFactory loggerAbstractFactory = new FileLoggerAbstractFactory(FILE_NAME);
            LogService logService = new LogService(loggerAbstractFactory);

            try
            {
                logService.Log(new Log() { DeploymentID = "1", LoggDate = now, Domain = "Matching", LogType = LogType.Information, Message = "Matching Started", ThreadName = "Matching" });

                try
                {
                    var x = 120;
                    var y = 0;
                    var z = y / x;
                }
                catch (Exception ex)
                {
                    logService.Log(new Log() { DeploymentID = "1", LoggDate = now, Domain = "Matching", LogType = LogType.Error, Message = ex.Message, ThreadName = "Matching" });
                }
                logService.Log(new Log() { DeploymentID = "1", LoggDate = now, Domain = "Matching", LogType = LogType.Information, Message = "Matching Ended", ThreadName = "Matching" });


            }
            catch (Exception ex)
            {
                logService.Log(new Log() { DeploymentID = "1", LoggDate = now, Domain = "Main", LogType = LogType.Error, Message = ex.Message, ThreadName = "Matching" });
            }
        }
    }
}
