using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.MobilePhoneEntity;
using MobilePhone.AudioEntity;
using MobilePhone.ChargerEntity;

namespace UnitTestMobilePhone.ChargeTest
{
    [TestClass]
    public class WirelessChargeTest
    {
        [TestMethod]
        public void WirelessChargeCharge()
        {
            var mb = new SimcorpMobile("test_mobile");
            var output = new MockResult();
            var chargeDevice = new WirelessCharge(output);
            mb.ChargerDevice = chargeDevice;

            mb.Charge();

            //Assert
            Assert.AreEqual(output.WrittenText, "WirelessCharge charger");
        }
    }
}
