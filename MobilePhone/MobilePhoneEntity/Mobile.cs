using MobilePhone.BatteryEntity;
using MobilePhone.Interfaces;
using MobilePhone.Messages;
using MobilePhone.MicrophoneEntity;
using MobilePhone.ScreenEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.MobilePhoneEntity
{
    public abstract class Mobile
    {
        public void Show(IScreenImage screenImage)
        {

            Screen.Show(screenImage);
        }

        public abstract Screen Screen { get; }
        public Microphone Microphone { get; private set; } = new Microphone();

        public Battery Battery { get; private set; } = new Battery();
        public string Name { get; private set; }

       
  
        protected Mobile(string name)
        {
            Name = name;
        }
        protected Mobile()
        {
        }
        public override string ToString()
        {
            //refactor this 

            var descriptionBuilder = new StringBuilder();

            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Microphone Type: {Microphone.ToString()}");

            return descriptionBuilder.ToString();
        }
        public void Play(object data)
        {
            PlayBackComponent.Play(data);
        }

        public void Charge()
        {
            ChargerDevice.Charge();
        }

        public void StartMessaging()
        {
            try
            {
                if (SMSProvider == null)
                {
                    SMSProvider = new MessagesProviderEntity(MessageStorage.Capacity);
                    SMSProvider.SMSReceived += new SMSReceivedDelegate(MessageStorage.AddMessage);
                }
                SMSProvider.StartMessaging();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference");
            }
        }
        public void StopMessaging()
        {
            try
            {
                SMSProvider.StopMessaging();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference");

            }
        }
        public IplayBack PlayBackComponent { get; set; }
        public ICharge ChargerDevice { get; set; }

        public MessagesStorage MessageStorage { get; set; } = new MessagesStorage();
        private MessagesProvider SMSProvider { get; set; }

    }
}
