
using MobilePhone.Interfaces;
using MobilePhone.MobilePhoneEntity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.AudioEntity;
using MobilePhone.ChargerEntity;


namespace MobilePhone
{
    class PlaybackConsoleApp
    {
        

        private static int getInput(int low_val, int high_val)
        {
            int index = 0;
            
            
            try {

                index = Int32.Parse(Console.ReadLine());
                if ((index <= low_val)||(index >= high_val)){
                    Console.WriteLine("Index is out of bounds - default value 1 will be used ");
                    index = 1;
                }

            }   
            catch (Exception) {
                Console.WriteLine("Wrong input");    
            }
            
            return index;
        }
        static IplayBack GetPlaybackItem() {
            IplayBack[] Items = new IplayBack[]
            {
                new IphoneHeadset(),
                new SamsungHeadset(),
                new PhoneSpeaker(),
            };
            for (var i = 0; i < Items.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{Items[i]}");
            }
            int index = getInput(1,3);
            try
            {
                return Items[index - 1];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Wrong index");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot parse input");
            }
            return null;
        }
        static ICharge GetChargeItem() {
            ICharge [] Items = new ICharge[]
        {
                new USBCharger(),
                new WirelessCharge(), 
        };
            for (var i = 0; i < Items.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{Items[i]}");
            }
            int index = getInput(1,2);
            try
            {
                return Items[index - 1];
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong index");
            }
            return null;

        }
        static void Main(string[] args)
        {
            
            SimcorpMobile mobile = new SimcorpMobile();

            Console.WriteLine(mobile);

            var playback = GetPlaybackItem();
            Console.WriteLine($"{playback} component was selected");
            Console.WriteLine("");

            var charger = GetChargeItem();
            Console.WriteLine($"{charger} component was selected");

            mobile.PlayBackComponent = playback;
            Console.WriteLine("Playback component has been set to the mobile. Play sound in mobile:");
            mobile.Play($"{mobile.PlayBackComponent.ToString()} playing");

            mobile.ChargerDevice = charger;
            Console.WriteLine("Charger device has been set to the mobile. Charging the mobile:");
            mobile.Charge();
        }
    }
    

    
}
