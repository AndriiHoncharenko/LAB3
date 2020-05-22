using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ChargerEntity
{
    public class USBCharger : ICharge
    {
        public IOutput Output;
        public USBCharger(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            
            Output.WriteLine($"{nameof(USBCharger)} charger");
        }
        
        public override string ToString()
    {
        return nameof(USBCharger);
    }
        public USBCharger()
        {

        }
}
}
