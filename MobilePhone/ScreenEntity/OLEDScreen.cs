using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ScreenEntity
{
    class OLEDScreen : Screen
    {
        public OLEDScreen(float diagonal) : base(diagonal)
        {

        }
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Image on OLED screen");
        }
        public override string ToString()
        {
            return "OLED -" + base.ToString();
        }
    }
}
