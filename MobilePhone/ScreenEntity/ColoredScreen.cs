using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Interfaces;

namespace MobilePhone.ScreenEntity
{
    public class ColoredScreen : Screen
    {
        public ColoredScreen(float diagonal, int numOfColors) : base(diagonal)
        {
            NumOfColors = numOfColors;
        }

        public int NumOfColors { get; private set; }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful screen presentation");
        }
        public override string ToString()
        {
            return "Colorful Screen." + base.ToString();
        }
    }
}
