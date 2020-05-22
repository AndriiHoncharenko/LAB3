using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.AudioEntity
{
    public class IphoneHeadset : IplayBack
    {
        public IOutput Output;
        public IphoneHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(IphoneHeadset)} playing ");
        }
        public override string ToString()
        {
            return nameof(IphoneHeadset);
        }
        public IphoneHeadset()
        {

        }
        
    }
}
