using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class WebSiteScanner
    {
        public void Scan()
        {
           DPDebug.Log("Web sites scanned.");
        }
    }
}
