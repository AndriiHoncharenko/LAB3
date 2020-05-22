using System;

namespace Delegates
{
    public class Message
    {
        internal static int id = 0;
        public Message() {
            generateId();
        }

        public string userFrom { get; internal set; }

        private void generateId()
        {
            id++;
        }
    }
}