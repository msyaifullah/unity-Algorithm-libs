using System;
using DesignPatterns.Observer;

namespace DesignPatterns
{
    public partial class Program
    {
        public static void Observer()
        {
            var fievSeconds = new TimeSpan(0, 0, 5);
            var pulseObservable = new TimePulseObservable(fievSeconds);
           DPDebug.Log("························ Initialize time pulse with 5 seconds");

            var pulseWriter = new TimePulseWriter();
            pulseObservable.Subscribe(pulseWriter);
           DPDebug.Log("························ Subscribed pulse writer");

            var pulseBeeper = new TimePulseBeeper();
            pulseObservable.Subscribe(pulseBeeper);
           DPDebug.Log("························ Subscribed pulse beeper");

           DPDebug.Log("························ Unmute speakers and wait 5 seconds ...");
        }
    }
}