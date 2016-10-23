using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class DatabaseHelper
    {
        public void QueryForChanges()
        {
           DPDebug.Log("Database queried.");
        }
    }
}
