using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Computer
    {
        private ComputerTyp _computerTyp;

        public string MotherBoard { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }
        public string Screen { get; set; }

        public Computer(ComputerTyp computerTyp)
        {
            _computerTyp = computerTyp;
        }

        public void DisplayConfiguration()
        {
            string message;

            message = string.Format("Computer: {0}", _computerTyp);
           DPDebug.Log(message);

            message = string.Format("Motherboard: {0}", MotherBoard);
           DPDebug.Log(message);

            message = string.Format("Processor: {0}", Processor);
           DPDebug.Log(message);

            message = string.Format("Harddisk: {0}", HardDisk);
           DPDebug.Log(message);

            message = string.Format("Screen: {0}", Screen);
           DPDebug.Log(message);

        }
    }

    public enum ComputerTyp
    {
        Laptop,
        Desktop,
        Apple
    }
}
