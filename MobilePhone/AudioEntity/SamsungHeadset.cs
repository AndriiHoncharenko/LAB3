using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.AudioEntity
{
    public class SamsungHeadset : IplayBack
    {
        public IOutput Output;
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(SamsungHeadset)} ");
        }
        public override string ToString()
        {
            return nameof(SamsungHeadset);
        }
        public SamsungHeadset()
        {

        }
    }
}
