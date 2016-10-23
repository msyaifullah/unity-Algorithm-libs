﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class AudiFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
           DPDebug.Log(GetType().Name + " is slower than "
                + abstractSportsCar.GetType().Name);
        }
    }
}
