using System;

namespace DesignPatterns.Observer
{
    public class TimePulseWriter : IObserver<DateTime>
    {
        public void OnNotified(DateTime message)
        {
			DPDebug.Log("Pulse at: "+message);
        }
    }
}