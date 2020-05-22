using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.MobilePhoneEntity;
using MobilePhone.Messages;
using System.Collections.Generic;

namespace UnitTestMobilePhone.Messages
{
    [TestClass]
    public class MessagesEventsTest
    {

        private Mobile MobilePhone;
          
        [TestMethod]
        public void AddMessage()
        {
            
            MobilePhone = new SimcorpMobile("testMobile");
            var expectedMessages = new List<MobilePhone.Messages.Messages>()
                {
                    new MobilePhone.Messages.Messages("user1","111","Message #1 received",new DateTime()),
                    new MobilePhone.Messages.Messages("user2","222","Message #2 received",new DateTime()),
                    new MobilePhone.Messages.Messages("user3","333","Message #3 received",new DateTime())
                };
            
             
            MobilePhone.MessageStorage.Capacity = expectedMessages.Count;
            MobilePhone.StartMessaging();
            System.Threading.Thread.Sleep(1000);

            
            Assert.AreEqual(expectedMessages.Count, MobilePhone.MessageStorage.Count());
            }
        }
    
}
