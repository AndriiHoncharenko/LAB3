using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.AudioEntity
{
    public class PhoneSpeaker : IplayBack
    {
        public IOutput Output;
        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine($"{nameof(PhoneSpeaker)} playing -{data.ToString()}");
        }
        public override string ToString()
        {
            return nameof(PhoneSpeaker);
        }
        public PhoneSpeaker(int freq)
        {
            Frequency = freq;
            
        }

        public PhoneSpeaker()
        {

        }

        public float Frequency { get; private set; } = 100;
        
    }
}
