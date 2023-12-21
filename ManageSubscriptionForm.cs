using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace NotificationManagerApp
{
    
    public partial class ManageSubscriptionForm : Form
{
        private NotificationManagerForm form1Instance;

        public string ValidData { get; private set; } = "";
        public ManageSubscriptionForm(NotificationManagerForm form1)
    {
        InitializeComponent();
        form1Instance = form1;
        txtEmail.Enabled = false;
        txtPhone.Enabled = false;

    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {
        string input = txtEmail.Text;
        bool isValidEmail = IsValidEmail(input);

        if (isValidEmail)
        {
            label1.Hide();
            ValidData = input;
        }
        else
        {
            label1.Text = "Invalid email address.";
            label1.Show();
        }

    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }



        private void btnCheckNotificationSentByEmail_CheckedChanged(object sender, EventArgs e)
    {
        txtPhone.Enabled = false;
        txtEmail.Enabled = true;
        btnCheckNotificationSentBySMS.Enabled = false;
        if (!btnCheckNotificationSentByEmail.Checked)
        {
            btnCheckNotificationSentBySMS.Enabled = true;
            txtEmail.Enabled = false;
        }
    }

    private void btnCheckNotificationSentBySMS_CheckedChanged(object sender, EventArgs e)
    {
        txtPhone.Enabled = true;
        txtEmail.Enabled = false;
        btnCheckNotificationSentByEmail.Enabled = false;
        if (!btnCheckNotificationSentBySMS.Checked)
        {
            btnCheckNotificationSentByEmail.Enabled = true;
            txtPhone.Enabled = false;
        }
    }

    private void txtPhone_TextChanged(object sender, EventArgs e)
    {
        string input = txtPhone.Text;

        bool isValidPhoneNumber = IsValidPhoneNumber(input);

        if (!isValidPhoneNumber)
        {
            txtPhone.Text = "Please use the format xxx-xxx-xxxx";
            txtPhone.Show();
        }
        else
        {
            txtPhone.Hide(); // if input correct, l4 hide.
            ValidData = input;
        }
    }
    private bool IsValidPhoneNumber(string phoneNumber)
    {
        return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$");
    }

        ///
   


        private void btnUnsubscribe_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;

        if (!string.IsNullOrEmpty(email))
        {
            // Implement logic to unsubscribe the user
            // Display success or error messages
            MessageBox.Show("Unsubscribed successfully!");
        }
        else
        {
            MessageBox.Show("Please enter a valid email address.");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        txtEmail.Enabled = false;
        txtPhone.Enabled = false;
        btnCheckNotificationSentByEmail.Checked = false;
        btnCheckNotificationSentByEmail.Enabled = true;
        btnCheckNotificationSentBySMS.Checked = false;
        btnCheckNotificationSentBySMS.Enabled = true;
        txtEmail.Text = "";
        txtPhone.Text = "";
        btnCheckNotificationSentByEmail.Text = "";
        btnCheckNotificationSentBySMS.Text = "";
    }

    private void btnSubscribe_Click(object sender, EventArgs e)
    {
        if (IsValidEmail(ValidData) || IsValidPhoneNumber(ValidData))
        {
            this.Close();
            NotificationManagerForm form1 = new NotificationManagerForm();
            form1.Show();

            //form1.Shown += (s, ev) =>
            //{
            //    form1.button2.Enabled = true;
            //    //form1.SetData(ValidData);
            //};
        }
        else
        {
            MessageBox.Show("Invalid data format. Please input valid email or phone number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    internal static string IsValidEmail(object validData)
    {
        throw new NotImplementedException();
    }

    internal static string IsValidPhoneNumber(object validData)
    {
        throw new NotImplementedException();
    }

    }

}
