using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.BatteryEntity
{
    public class Battery : Charger
    {
        public override void Charge(int capacity,int increment)
        {
            try
            {
                capacity += increment;
            }
            catch (ArgumentNullException) {
                Console.WriteLine($"Wrong argument in {capacity.ToString()}");
            }
        }
        public Battery(string model) {
            this._model = model;
        }

        public Battery()
        {
            this._model = "battery default model AA";
            this._capacity = 20;
        }

        private int _capacity;
        private string _model;

        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set {
                _model = value;
            }

            
        }
        public override string ToString()
        {
            string result = "";
            try
            {
                result+= $"Battery module is {Model} and volume - {Capacity}";
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Empty constructor has been used ");
            }
            
                return result;
            
        }
    }
}
