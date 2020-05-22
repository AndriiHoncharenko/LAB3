using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Messages
{
    public class Messages
    {
        public string User { get; private set; }
        public string Number { get; private set; }
        public string Text { get; set; }
        public DateTime Time { get; private set; }

        public Messages(string user, string number, string text, DateTime time)
        {
            User = user;
            Number = number;
            Text = text;
            Time = time;
        }

        public Messages(string text)
        {
            User = "X";
            Number = "111-000";
            Text = text;
            Time = new DateTime();
        }
        public override string ToString()
        {
            return Text+" "+Time;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null))
            {
                return false;
            }
            else
            {
                Messages m = (Messages)obj;
                return (User == m.User) && (Number == m.Number) && (Text == m.Text) && (Time.Equals(m.Time));
            }
            }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        


    }
}
