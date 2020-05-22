using MobilePhone.Messages;
using MobilePhone.MobilePhoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MobilePhone.Messages.MessagesFormater;

namespace MessagesForm
{
    public partial class Messages : Form
    {
        private readonly Mobile MobilePhone;
        private readonly MessagesFormater MessagesFormater = new MessagesFormater();

        private void OnMessageReceivedHandler(MobilePhone.Messages.Messages message)
        {
            if (this.messageslistView.InvokeRequired)
            {
                this.messageslistView.Invoke(new SMSReceivedDelegate(OnMessageReceivedHandler), message);
            }
            else
            {
                string[] row = new string[] { message.User + message.Number, MessagesFormater.FormaterMethod(message).ToString() };
                var item = new ListViewItem(row);
                messageslistView.Items.Add(item);
            }

        }
        public Messages()
        {
            MobilePhone = new SimcorpMobile("Samsung");

            InitializeComponent();
            formatingComboBox.SelectedIndex = 0;

            MobilePhone.MessageStorage.SMSAdded += new SMSReceivedDelegate(OnMessageReceivedHandler);
            MobilePhone.StartMessaging();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageslistView.Items.Clear();
            //foreach (var message in MobilePhone.MessageStorage.GetMessages())
            //{
            //    string[] row = new string[] { message.User + message.Number, MessagesFormater.FormaterMethod(message).ToString() };
            //    var item = new ListViewItem(row);
            //    messageslistView.Items.Add(item);
                
            //}
        }

        //private void disableButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (disableButton.Checked)
        //    {
        //        MobilePhone.StopMessaging();
        //    }
        //    else if (enableButton.Checked)
        //    {
        //        MobilePhone.StartMessaging();
        //    }
        //}

        private void enableButton_CheckedChanged(object sender, EventArgs e)
        {
            if (disableButton.Checked)
            {
                MobilePhone.StopMessaging();
            }
            else if (enableButton.Checked)
            {
                MobilePhone.StartMessaging();
            }
        }

        private void formatingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatDelegate[] formatDelegates = new FormatDelegate[]
            {
                MessagesFormater.NoFormat,
                MessagesFormater.StartWithDateTimeFormat,
                MessagesFormater.UpperCaseFormat
            };
            MessagesFormater.FormaterMethod = formatDelegates[formatingComboBox.SelectedIndex];
        }
    }
}
