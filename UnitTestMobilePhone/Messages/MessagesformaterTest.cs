using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Messages;
using System.Globalization;

namespace UnitTestMobilePhone.Messages
{
    [TestClass]
    public class MessagesformaterTest
    {
        [TestMethod]
        public void MessagesNoFormatTest()
        {
            var messageFormater = new MessagesFormater();
            var message = new MobilePhone.Messages.Messages("Test message!");

            var actualMessage = messageFormater.FormaterMethod(message);

            Assert.AreEqual(message, actualMessage);
        }
        [TestMethod]
        public void MessagesStartWithDateTimeFormatTest()
        {
            
            var messageFormater = new MessagesFormater();
            messageFormater.FormaterMethod = messageFormater.StartWithDateTimeFormat;

            var message = messageFormater.FormaterMethod(new MobilePhone.Messages.Messages("Test message"));

            Assert.AreEqual(message.Time.ToString(CultureInfo.InvariantCulture) + " Test message", message.Text);
        }
        [TestMethod]
        public void MessagesUpperCaseTest()
        {

            var messageFormater = new MessagesFormater();
            messageFormater.FormaterMethod = messageFormater.UpperCaseFormat;

            var message = new MobilePhone.Messages.Messages("TEST MESSAGE");

            
            var actualMessage = messageFormater.FormaterMethod(new MobilePhone.Messages.Messages("Test message"));

            Assert.AreEqual(message.ToString(), actualMessage.ToString());
        }
    }
}
