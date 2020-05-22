using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Interfaces;

namespace UnitTestMobilePhone
{
    [TestClass]
    public class MockResult:IOutput
    {
        public string WrittenText { get; private set; }

        public void Write(string text)
        {
            WrittenText = text;
        }

        public void WriteLine(string text)
        {
            WrittenText = text;
        }

    }
}
