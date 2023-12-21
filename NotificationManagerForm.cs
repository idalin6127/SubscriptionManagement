using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagerApp
{
    public partial class NotificationManagerForm : Form
    {
       
        private List<SubscriberInfo> subscribers = new List<SubscriberInfo>();

        public NotificationManagerForm()
        {

            InitializeComponent();
            btnPublishNotification.Enabled = false;

        }


        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            // Open the new form
            ManageSubscriptionForm form2 = new ManageSubscriptionForm(this);
            form2.Show();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            PublishNotificationForm form3 = new PublishNotificationForm();
            form3.Show();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            // Email must contain "@" character
            return !string.IsNullOrEmpty(email) && email.Contains("@");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Phone number must have exactly 10 digits
            return !string.IsNullOrEmpty(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        internal void SetData(string validData)
        {
            throw new NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        public class SubscriberInfo
        {
            public string Email { get; set; }
            public string Phone { get; set; }
        }



    }

}

