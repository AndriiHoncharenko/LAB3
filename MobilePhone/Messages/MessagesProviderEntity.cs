using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Messages
{
    class MessagesProviderEntity:MessagesProvider
    {
        public MessagesProviderEntity()
        {

        }
        public MessagesProviderEntity(int numberOfMessages) : base(numberOfMessages)
        {         
        }

        public override void CloseAllThreadsAndTasks()
        {
           
        }

        public override async void StartMessaging()
        {
            IsRunning = true;
            await SMSTask();

        }

        private async Task SMSTask()
        {
            await Task.Run(() => SimulateSMS());
        }
    }
    
}
