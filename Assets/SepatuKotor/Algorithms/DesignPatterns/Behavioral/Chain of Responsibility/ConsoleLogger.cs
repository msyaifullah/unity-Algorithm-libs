using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ConsoleLogger : BaseLogger
    {
        public ConsoleLogger(LogLevel mask)
            : base(mask)
        {
        }

        protected override void PerformLog(string message)
        {
           DPDebug.Log(message);
        }
    }
}