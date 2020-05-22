using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     class SmsDelegate {
        static void Main(string[] args)
        {
            SmsHandler hand = new SmsHandler(inSmsProcessor);

            smsProcessor(hand);
      
        }
        static void smsProcessor(SmsHandler hand) {
            hand( new Message(), MessageType.inComing);

        }
        static void inSmsProcessor(Message message, MessageType messageType) {
            Console.WriteLine("inSmsProcessor called");
        }

    }
    public enum MessageType {
        inComing,
        outComing
    }
}
