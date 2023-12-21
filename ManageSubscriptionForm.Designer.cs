using System;

namespace NotificationManagerApp
{
    partial class ManageSubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //////private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //////protected override void Dispose(bool disposing)
        //////{
        //////    if (disposing && (components != null))
        //////    {
        //////        components.Dispose();
        //////    }
        //////    base.Dispose(disposing);
        //////}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCheckNotificationSentBySMS = new System.Windows.Forms.CheckBox();
            this.btnCheckNotificationSentByEmail = new System.Windows.Forms.CheckBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnCheckNotificationSentBySMS);
            this.groupBox1.Controls.Add(this.btnCheckNotificationSentByEmail);
            this.groupBox1.Location = new System.Drawing.Point(96, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notification Preferences";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(229, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(229, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // btnCheckNotificationSentBySMS
            // 
            this.btnCheckNotificationSentBySMS.AutoSize = true;
            this.btnCheckNotificationSentBySMS.Location = new System.Drawing.Point(31, 114);
            this.btnCheckNotificationSentBySMS.Name = "btnCheckNotificationSentBySMS";
            this.btnCheckNotificationSentBySMS.Size = new System.Drawing.Size(175, 20);
            this.btnCheckNotificationSentBySMS.TabIndex = 1;
            this.btnCheckNotificationSentBySMS.Text = "Notification Sent by SMS";
            this.btnCheckNotificationSentBySMS.UseVisualStyleBackColor = true;
            // 
            // btnCheckNotificationSentByEmail
            // 
            this.btnCheckNotificationSentByEmail.AutoSize = true;
            this.btnCheckNotificationSentByEmail.Location = new System.Drawing.Point(31, 22);
            this.btnCheckNotificationSentByEmail.Name = "btnCheckNotificationSentByEmail";
            this.btnCheckNotificationSentByEmail.Size = new System.Drawing.Size(180, 20);
            this.btnCheckNotificationSentByEmail.TabIndex = 0;
            this.btnCheckNotificationSentByEmail.Text = "Notification Sent by Email";
            this.btnCheckNotificationSentByEmail.UseVisualStyleBackColor = true;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(80, 331);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(111, 33);
            this.btnSubscribe.TabIndex = 1;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(247, 331);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(130, 33);
            this.btnUnsubscribe.TabIndex = 2;
            this.btnUnsubscribe.Text = "Unsubscribe";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(419, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(233, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invalid email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(220, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please follow xxx-xxx-xxxx";
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageSubscriptionForm";
            this.Text = "Manage Subscription";
            this.Load += new System.EventHandler(this.ManageSubscriptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ManageSubscriptionForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox btnCheckNotificationSentBySMS;
        private System.Windows.Forms.CheckBox btnCheckNotificationSentByEmail;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnsubscribe;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}