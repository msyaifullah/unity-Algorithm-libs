using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class ProductDataObject : DataObject
    {
        public override void Register()
        {
           DPDebug.Log("ProductDataObject was registered");
        }

        public override DataObject Copy()
        {
           DPDebug.Log("ProductDataObject was copied");
            return new ProductDataObject();
        }

        public override void Delete()
        {
           DPDebug.Log("ProductDataObject was deleted");
        }
    }
}
