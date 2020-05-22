using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BatteryEntity
{
    public abstract class Charger
    {
        public abstract void Charge(int cap, int increment);
    }
}
