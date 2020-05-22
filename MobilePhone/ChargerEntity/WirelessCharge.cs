using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ChargerEntity
{
    public class WirelessCharge : ICharge
    {
        public IOutput Output;
        public WirelessCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(WirelessCharge)} charger");
        }
        public override string ToString()
        {
            return nameof(USBCharger);
        }
        public WirelessCharge()
        {

        }
    }
}
