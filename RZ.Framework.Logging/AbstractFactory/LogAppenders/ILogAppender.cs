using System;

namespace RZ.Framework.Logging.AbstractFactory.LogAppenders
{
    public interface ILogAppender : IDisposable
    {
        bool Append(Log log); 
    }
}