using System;
using NLog;
using ILogger = Domain.Logging.ILogger;

namespace Infrastructure.Logging
{
    public class NLogLogger : ILogger
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public void Trace(string message)
        {
            Logger.Trace(message);
        }

        public void Debug(string message)
        {
            Logger.Debug(message);
        }

        public void Info(string message)
        {
            Logger.Info(message);
        }

        public void Warn(string message)
        {
            Logger.Warn(message);
        }

        public void Warn(Exception exception)
        {
            Logger.Warn(exception);
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }

        public void Error(Exception exception)
        {
            Logger.Error(exception);
        }

        public void Fatal(string message)
        {
            Logger.Fatal(message);
        }

        public void Fatal(Exception exception)
        {
            Logger.Fatal(exception);
        }
    }
}
