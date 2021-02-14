using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asynchro_Connect.Model;

namespace Asynchro_Connect.View
{
    public partial class StudyGroupHomepage : Form
    {
        User theUser;
        StudyGroup theStudyGroup;
        public StudyGroupHomepage(User theUser, StudyGroup theStudyGroup)
        {
            this.theUser = theUser;
            this.theStudyGroup = theStudyGroup;

            InitializeComponent();

            RefreshMemberList();
            RefreshMessages();
            if (theStudyGroup.Admin != theUser)
            {
                kickUserButton.Visible = false;
            }

            string minute = theStudyGroup.MeetingTime.Minute + "";
            if (minute.Length == 1)
            {
                minute = "0" + minute;
            }
            meetingTimeLabel.Text = theStudyGroup.MeetingTime.Hour + ":" + minute;
            meetingLinkLabel.Text = theStudyGroup.JoinUrl;
        }

        private void MemberListBox_Leave(object sender, EventArgs e)
        {
            kickUserButton.Enabled = false;
        }

        private void MemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theUser == theStudyGroup.Admin)
                kickUserButton.Enabled = true;
        }

        private void kickUserButton_Click(object sender, EventArgs e)
        {
            String s = MemberListBox.SelectedItem.ToString(); //does this work?
            foreach (User user in theStudyGroup.Members)
            {
                if (user.DisplayName.Equals(s))
                {
                    user.Groups.Remove(theStudyGroup);
                    theStudyGroup.Members.Remove(user);
                }
            }
            RefreshMemberList();
        }

        private void RefreshMemberList()
        {
            MemberListBox.Items.Clear();
            MemberListBox.Items.Add(theUser.DisplayName + "*");
            foreach (User user in theStudyGroup.Members)
            {
                if (user != theUser)
                {
                    MemberListBox.Items.Add(user.DisplayName);
                }
            }
        }
        
        private void RefreshMessages()
        {
            GroupDiscussionLog.Items.Clear();
            foreach (String message in theStudyGroup.GroupDiscussionBoard.GetListOfMessages())
            {
                GroupDiscussionLog.Items.Add(message);
            }
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            theStudyGroup.GroupDiscussionBoard.SendMessage(messageTextBox.Text, theUser);
            messageTextBox.Text = "";
            RefreshMessages();
        }

        private void meetingLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process newProcess = System.Diagnostics.Process.Start(this.theStudyGroup.JoinUrl);

        }
    }
}
