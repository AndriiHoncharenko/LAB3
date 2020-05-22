using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SmsHandler( Message message, MessageType messageType);

    class MessageProcessor
    {
        public event SmsHandler messagesRead;
        public event EventHandler workCompleted;
        public void processMessage(Message message, MessageType messageType) {
            Console.WriteLine("Message"+Message.id+message.userFrom+"is processed");
            //something we do when message reading is in progress 
            OnMessagesRead(message,messageType);
            //on completion of read event 
            OnWorkCompleted();
        }

        protected virtual void OnWorkCompleted() {
            var del = workCompleted as EventHandler;
            if (del != null)
            {
                del(this,EventArgs.Empty);
            }
        }
        protected virtual void OnMessagesRead(Message message, MessageType messageType) {
            var del = messagesRead as SmsHandler;
            if (del != null)
            {
                del(message, messageType);
            }
        }


    }

}
