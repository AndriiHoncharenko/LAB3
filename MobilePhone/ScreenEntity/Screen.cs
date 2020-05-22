using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ScreenEntity
{
    public abstract class Screen
    {
        protected Screen(float diagonal)
        {
            Diagonal = diagonal;
        }

        public abstract void Show(IScreenImage screenImage);
        
        public override string ToString()
        {
            return $"Screen diagonal is {Diagonal}";
        }

        public float Diagonal { get; protected set; }
        public bool TouchEnabled{ get; protected set; }
        
    }
}

