using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class ClientDataObject : DataObject
    {
        public override void Register()
        {
           DPDebug.Log("ClientDataObject was registered");
        }

        public override DataObject Copy()
        {
           DPDebug.Log("ClientDataObject was copied");
            return new ClientDataObject();
        }

        public override void Delete()
        {
           DPDebug.Log("ClientDataObject was deleted");
        }
    }
}
