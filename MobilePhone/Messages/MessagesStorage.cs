using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Messages
{
    
    public class MessagesStorage
    {
        public event SMSReceivedDelegate SMSAdded;
        public event SMSReceivedDelegate SMSRemoved;

        private List<Messages> MessagesList = new List<Messages>();
        public int Capacity { get; set; } = 50;


        public void AddMessage(Messages message)
        {
            MessagesList.Add(message);
            SMSAdded?.Invoke(message);
            
        }
        public void RemoveMessage(Messages message)
        {
            MessagesList.Remove(message);
            SMSRemoved?.Invoke(message);
        }

        public IEnumerable<Messages> GetMessages()
        {
            return MessagesList;
        }
        public int Count()
        {
            return MessagesList.Count;
        }

    }
}
