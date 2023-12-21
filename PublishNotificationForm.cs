using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NotificationManagerApp
{
    public partial class PublishNotificationForm : Form
    {
        public string Validmsg { get; private set; } = "";
        public PublishNotificationForm()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            // Implement the notification publishing logic here
            string notificationMessage = txtNotification.Text;

            if (!string.IsNullOrEmpty(notificationMessage))
            {
                MessageBox.Show("You cannot send empty messages.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Message sent successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotificationManagerForm form1 = new NotificationManagerForm();
                this.Close();
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the PublishNotificationForm
            this.Close();
        }
    }
}

