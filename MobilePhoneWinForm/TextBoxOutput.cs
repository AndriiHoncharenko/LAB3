using System;
using System.Windows.Forms;
using MobilePhone.Interfaces;

namespace MobilePhoneWinForm
{
    internal class TextBoxOutput : IOutput
    {
        private TextBox OutText;
        private bool isBoxEmpty = true;

        public TextBoxOutput(TextBox outputText)
        {
            this.OutText = outputText;
        }

        public void Write(string text)
        {
            OutText.AppendText(text);
            isBoxEmpty = false;
        }


        public void WriteLine(string text)
        {
            if (!isBoxEmpty)
            {
                OutText.AppendText(Environment.NewLine);
            }
            OutText.AppendText(text);
            isBoxEmpty = false;
        }
        public void Clear()
        {
            OutText.Clear();
            
        }
    }
}