using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Messages
{
    public class MessagesFormater
    {
        public delegate Messages FormatDelegate(Messages message);
        public MessagesFormater()
        {
            FormaterMethod = NoFormat;
        }

        public FormatDelegate FormaterMethod { get; set; }

        public Messages NoFormat(Messages message)
        {
            return message;
        }

        public Messages StartWithDateTimeFormat(Messages message)
        {
            var text = $"{message.Time.ToString(CultureInfo.InvariantCulture)} {message.Text}";
            return new Messages(message.User, message.Number, text, message.Time);
        }
        public Messages UpperCaseFormat(Messages message)
        {
            var text = message.Text.ToUpper();
            return new Messages(message.User, message.Number, text, message.Time);
        }
    }
}
