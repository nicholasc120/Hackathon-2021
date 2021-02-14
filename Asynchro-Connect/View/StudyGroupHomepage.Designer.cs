namespace Asynchro_Connect.View
{
    partial class StudyGroupHomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyGroupHomepage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meetingLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GroupDiscussionLog = new System.Windows.Forms.ListBox();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MemberListBox = new System.Windows.Forms.ListBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.kickUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting Link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meeting Time:";
            // 
            // meetingLinkLabel
            // 
            this.meetingLinkLabel.AutoSize = true;
            this.meetingLinkLabel.Location = new System.Drawing.Point(93, 9);
            this.meetingLinkLabel.Name = "meetingLinkLabel";
            this.meetingLinkLabel.Size = new System.Drawing.Size(127, 13);
            this.meetingLinkLabel.TabIndex = 2;
            this.meetingLinkLabel.TabStop = true;
            this.meetingLinkLabel.Text = "Meeting Link Placeholder";
            // 
            // GroupDiscussionLog
            // 
            this.GroupDiscussionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDiscussionLog.BackColor = System.Drawing.Color.LavenderBlush;
            this.GroupDiscussionLog.FormattingEnabled = true;
            this.GroupDiscussionLog.Location = new System.Drawing.Point(12, 82);
            this.GroupDiscussionLog.Name = "GroupDiscussionLog";
            this.GroupDiscussionLog.ScrollAlwaysVisible = true;
            this.GroupDiscussionLog.Size = new System.Drawing.Size(525, 225);
            this.GroupDiscussionLog.TabIndex = 3;
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.AutoSize = true;
            this.meetingTimeLabel.Location = new System.Drawing.Point(93, 37);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(130, 13);
            this.meetingTimeLabel.TabIndex = 4;
            this.meetingTimeLabel.Text = "Meeting Time Placeholder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Group Discussion:";
            // 
            // MemberListBox
            // 
            this.MemberListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberListBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.MemberListBox.FormattingEnabled = true;
            this.MemberListBox.Location = new System.Drawing.Point(543, 82);
            this.MemberListBox.Name = "MemberListBox";
            this.MemberListBox.Size = new System.Drawing.Size(129, 225);
            this.MemberListBox.TabIndex = 6;
            this.MemberListBox.SelectedIndexChanged += new System.EventHandler(this.MemberListBox_SelectedIndexChanged);
            this.MemberListBox.Leave += new System.EventHandler(this.MemberListBox_Leave);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.messageTextBox.Location = new System.Drawing.Point(12, 317);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(444, 20);
            this.messageTextBox.TabIndex = 7;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageButton.BackColor = System.Drawing.Color.Plum;
            this.sendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessageButton.Location = new System.Drawing.Point(462, 315);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 8;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = false;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // kickUserButton
            // 
            this.kickUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kickUserButton.BackColor = System.Drawing.Color.Plum;
            this.kickUserButton.Enabled = false;
            this.kickUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kickUserButton.Location = new System.Drawing.Point(543, 315);
            this.kickUserButton.Name = "kickUserButton";
            this.kickUserButton.Size = new System.Drawing.Size(129, 23);
            this.kickUserButton.TabIndex = 0;
            this.kickUserButton.Text = "Kick User";
            this.kickUserButton.UseVisualStyleBackColor = false;
            this.kickUserButton.Click += new System.EventHandler(this.kickUserButton_Click);
            // 
            // StudyGroupHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(684, 355);
            this.Controls.Add(this.kickUserButton);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.MemberListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meetingTimeLabel);
            this.Controls.Add(this.GroupDiscussionLog);
            this.Controls.Add(this.meetingLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudyGroupHomepage";
            this.Text = "Study Group Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel meetingLinkLabel;
        private System.Windows.Forms.ListBox GroupDiscussionLog;
        private System.Windows.Forms.Label meetingTimeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox MemberListBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button kickUserButton;
    }
}