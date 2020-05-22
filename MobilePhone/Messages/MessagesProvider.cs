using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhone.Messages
{
    public delegate void SMSReceivedDelegate(Messages message);

    abstract class MessagesProvider
    {
        public MessagesProvider()
        {

        }
        public int NumberOfMessages { get; private set; }
        public int TimeInterval { get; set; } = 100;
        public bool IsRunning { get; protected set; } = true;
        public int Counter { get; private set; } = 1;
        public string[] PhoneBook { get; private set; } = new string[5] { "A", "B","BB","C","D" };

        public string[] PhoneBookNumbers { get; private set; } = new string[5] { "1111", "2222","3333", "4444", "5555" };

        public event SMSReceivedDelegate SMSReceived;

        public MessagesProvider(int numberOfMessages)
        {
            NumberOfMessages = numberOfMessages;
        }
        public abstract void StartMessaging();

        public abstract void CloseAllThreadsAndTasks();

        public void SimulateSMS()
        {
            bool simulateOn = true;
            while (simulateOn)
            {
                if (IsRunning )
                {
                    simulateOn = Counter < NumberOfMessages;
                    SMSReceived.Invoke(GenerateMessage());
                }
                Thread.Sleep(TimeInterval);
            }
        }

        private Messages GenerateMessage()
        {
            Random rnd = new Random();
            var index = rnd.Next(0, PhoneBook.Length);
            var userName = PhoneBook[index];
            var userNumber = PhoneBookNumbers[index];
            var text = $"Message #{Counter++} received";
            DateTime time = DateTime.Now;
            return new Messages(userName, userNumber, text, time);
        }

        public void StopMessaging()
        {
            IsRunning = false;
        }
    }
}
