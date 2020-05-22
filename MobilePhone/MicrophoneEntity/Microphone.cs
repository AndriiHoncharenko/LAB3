using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MicrophoneEntity
{
    public class Microphone
    {
        public Microphone(string name,float amplitude, float increment )
        {
            Name = name;
            Amplitude = amplitude;
            Increment = increment;
        }

        public Microphone()
        {
        }

        public float Amplitude { get; private set; } = 100;
        public float RecommendedLoud
        {
            get
            {
                return RecommendedLoud;
            }
            private set
            {
                RecommendedLoud = Amplitude * (float)0.7;
            }
        }  

        public float Increment { get; private set; } = 5;
        public string Name { get; set; } = "Default Model1";

        public override string ToString()
        {
            return $"Microphone Name is {Name}";
        }

    }
}
