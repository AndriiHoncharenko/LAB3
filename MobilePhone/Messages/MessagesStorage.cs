using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Messages
{

    public class MessagesStorage : IEnumerable
    {
        public event SMSReceivedDelegate SMSAdded;
        public event SMSReceivedDelegate SMSRemoved;

        private List<Messages> MessagesList = new List<Messages>();
        public int Capacity { get; set; } = 50;
        private string FilterByUser = "No filter";
        private string FilterByTxt = "";
        private DateTime FromDateFilter = DateTime.MinValue;
        private DateTime ToDateFilter = DateTime.MaxValue;


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

        public IEnumerator GetEnumerator()
        {
            return MessagesList.GetEnumerator();
        }

        public bool FilterByDate(Messages m)
        {
            return (DateTime.Compare(FromDateFilter, m.Time) <= 0) &&
                   (DateTime.Compare(m.Time, ToDateFilter) <= 0);
        }
        public bool FilterByText(Messages m)
        {
            return m.Text.Contains(FilterByTxt);
        }
        public bool FilterByUsers(Messages m)
        {
            return (FilterByUser == "No filter") || (m.User == FilterByUser);
        }
        public void SetFilter(string user, string text, DateTime from, DateTime to)
        {
            FilterByUser = user;
            FilterByTxt = text;
            FromDateFilter = from;
            ToDateFilter = to;

        }
       
        public IEnumerable<Messages> GetFilteredMessages()
        {
            return MessagesList.Where(m => Filter(m));
        }

        private bool Filter(Messages m)
        {
            bool filterPick = FilterByDate(m)||FilterByText(m);
            filterPick = filterPick && FilterByUsers(m);
            return filterPick;
        }
    }
}
