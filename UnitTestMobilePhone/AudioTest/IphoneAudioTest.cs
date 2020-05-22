using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.AudioEntity;
using MobilePhone.MobilePhoneEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMobilePhone.AudioTest
{
   [TestClass]
    public class SamsungHeadsetTestClass
    {
        [TestMethod]
        public void Play() {

            var mb = new SimcorpMobile("test_mobile");
            var output = new MockResult();
            var playback = new IphoneHeadset(output);
            mb.PlayBackComponent = playback;

            mb.Play("data");

            Assert.AreEqual(output.WrittenText, "IphoneHeadset playing ");

        }
            
    }
}
