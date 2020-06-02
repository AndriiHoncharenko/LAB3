using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Messages;
using MobilePhone.MobilePhoneEntity;
using System.Collections.Generic;

namespace UnitTestMobilePhone.Messages
{
    [TestClass]
    public class FilterMessageTest
    {
        private MessagesStorage Storage;
        private Mobile MobilePhone;
        [TestMethod]
        public void FilteredMessageTest()
        {
            Storage = new MessagesStorage();

            Storage.AddMessage(new MobilePhone.Messages.Messages("A", "1", "Message1", new DateTime(2001, 01, 01)));
            Storage.AddMessage(new MobilePhone.Messages.Messages("B", "11", "Mes", new DateTime(2001, 01, 03)));
            Storage.AddMessage(new MobilePhone.Messages.Messages("A", "22", "sage", new DateTime(2002, 01, 01)));
            Storage.AddMessage(new MobilePhone.Messages.Messages("C", "33", "ssa", new DateTime(2002, 05, 02)));
            Storage.AddMessage(new MobilePhone.Messages.Messages("D", "34", "Mage", new DateTime(2003, 03, 01)));
            Storage.AddMessage(new MobilePhone.Messages.Messages("B", "44", "1", new DateTime(2003, 03, 01)));

            Storage.SetFilter("A","Message",new DateTime(2010, 01, 01), new DateTime(2000, 01, 01));

            var expectedMessages = new List<MobilePhone.Messages.Messages>();
            expectedMessages.Add(new MobilePhone.Messages.Messages("A", "1", "Message1", new DateTime(2001, 01, 01)));
            expectedMessages.Add(new MobilePhone.Messages.Messages("A", "22", "sage", new DateTime(2002, 01, 01)));

            var actualMessages =Storage.GetFilteredMessages();

            var actual = actualMessages.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();

            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }

        }
    }
}
