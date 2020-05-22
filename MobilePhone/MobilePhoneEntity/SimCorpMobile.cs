using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.ScreenEntity;

namespace MobilePhone.MobilePhoneEntity
{
    public class SimcorpMobile : Mobile
    {
        public SimcorpMobile()
        {
        }

        public SimcorpMobile(string name) : base(name)
        {
        }

        public override Screen Screen { get { return vOLEDScreen; } }
        private OLEDScreen vOLEDScreen = new OLEDScreen(100);

    }
}
