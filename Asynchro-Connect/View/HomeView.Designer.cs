
using System.Windows.Forms;

namespace Asynchro_Connect.View
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.createGroupsTab = new System.Windows.Forms.TabPage();
            this.findGroupTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.durationFieldLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.meetingTimeFieldLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.joinGroupButton = new System.Windows.Forms.Button();
            this.groupsList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.activeGroupsTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.openGroupButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupChatPreview = new System.Windows.Forms.TextBox();
            this.activeGroupList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.homeTab = new System.Windows.Forms.TabControl();
            this.findGroupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.activeGroupsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // createGroupsTab
            // 
            this.createGroupsTab.BackColor = System.Drawing.Color.Thistle;
            this.createGroupsTab.Location = new System.Drawing.Point(4, 24);
            this.createGroupsTab.Name = "createGroupsTab";
            this.createGroupsTab.Size = new System.Drawing.Size(608, 388);
            this.createGroupsTab.TabIndex = 2;
            this.createGroupsTab.Text = "Create A New Group";
            // 
            // findGroupTab
            // 
            this.findGroupTab.BackColor = System.Drawing.Color.Thistle;
            this.findGroupTab.Controls.Add(this.splitContainer5);
            this.findGroupTab.Location = new System.Drawing.Point(4, 24);
            this.findGroupTab.Name = "findGroupTab";
            this.findGroupTab.Padding = new System.Windows.Forms.Padding(3);
            this.findGroupTab.Size = new System.Drawing.Size(608, 388);
            this.findGroupTab.TabIndex = 1;
            this.findGroupTab.Text = "Find A Group";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.flowLayoutPanel7);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(602, 382);
            this.splitContainer5.SplitterDistance = 32;
            this.splitContainer5.TabIndex = 2;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.flowLayoutPanel8);
            this.splitContainer6.Size = new System.Drawing.Size(602, 346);
            this.splitContainer6.SplitterDistance = 301;
            this.splitContainer6.TabIndex = 0;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Location = new System.Drawing.Point(5, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(592, 34);
            this.flowLayoutPanel8.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.BackColor = System.Drawing.Color.Thistle;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.groupsList);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.joinGroupButton);
            this.splitContainer7.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer7.Panel2.Controls.Add(this.flowLayoutPanel9);
            this.splitContainer7.Size = new System.Drawing.Size(602, 301);
            this.splitContainer7.SplitterDistance = 300;
            this.splitContainer7.TabIndex = 0;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.label3);
            this.flowLayoutPanel9.Controls.Add(this.descriptionTextBox);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(296, 144);
            this.flowLayoutPanel9.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 18);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(289, 122);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group Description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.meetingTimeFieldLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.durationFieldLabel, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(293, 97);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // durationFieldLabel
            // 
            this.durationFieldLabel.AutoSize = true;
            this.durationFieldLabel.Location = new System.Drawing.Point(149, 48);
            this.durationFieldLabel.Name = "durationFieldLabel";
            this.durationFieldLabel.Size = new System.Drawing.Size(0, 15);
            this.durationFieldLabel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Duration";
            // 
            // meetingTimeFieldLabel
            // 
            this.meetingTimeFieldLabel.AutoSize = true;
            this.meetingTimeFieldLabel.Location = new System.Drawing.Point(149, 0);
            this.meetingTimeFieldLabel.Name = "meetingTimeFieldLabel";
            this.meetingTimeFieldLabel.Size = new System.Drawing.Size(0, 15);
            this.meetingTimeFieldLabel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Meeting Time";
            // 
            // joinGroupButton
            // 
            this.joinGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.joinGroupButton.BackColor = System.Drawing.Color.Plum;
            this.joinGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinGroupButton.Location = new System.Drawing.Point(10, 267);
            this.joinGroupButton.Name = "joinGroupButton";
            this.joinGroupButton.Size = new System.Drawing.Size(111, 25);
            this.joinGroupButton.TabIndex = 3;
            this.joinGroupButton.Text = "Join Group";
            this.joinGroupButton.UseVisualStyleBackColor = false;
            // 
            // groupsList
            // 
            this.groupsList.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupsList.FormattingEnabled = true;
            this.groupsList.ItemHeight = 15;
            this.groupsList.Location = new System.Drawing.Point(0, 3);
            this.groupsList.Name = "groupsList";
            this.groupsList.ScrollAlwaysVisible = true;
            this.groupsList.Size = new System.Drawing.Size(294, 289);
            this.groupsList.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.searchTextBox);
            this.flowLayoutPanel7.Controls.Add(this.button3);
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(594, 29);
            this.flowLayoutPanel7.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(302, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(398, 3);
            this.searchTextBox.MinimumSize = new System.Drawing.Size(4, 25);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(193, 25);
            this.searchTextBox.TabIndex = 1;
            // 
            // activeGroupsTab
            // 
            this.activeGroupsTab.BackColor = System.Drawing.Color.Thistle;
            this.activeGroupsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.activeGroupsTab.Controls.Add(this.splitContainer1);
            this.activeGroupsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.activeGroupsTab.Location = new System.Drawing.Point(4, 24);
            this.activeGroupsTab.Name = "activeGroupsTab";
            this.activeGroupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.activeGroupsTab.Size = new System.Drawing.Size(608, 388);
            this.activeGroupsTab.TabIndex = 0;
            this.activeGroupsTab.Text = "Active Groups";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(600, 380);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(600, 344);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.openGroupButton);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(592, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "LeaveGroup";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // openGroupButton
            // 
            this.openGroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGroupButton.BackColor = System.Drawing.Color.Plum;
            this.openGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGroupButton.Location = new System.Drawing.Point(3, 3);
            this.openGroupButton.Name = "openGroupButton";
            this.openGroupButton.Size = new System.Drawing.Size(114, 25);
            this.openGroupButton.TabIndex = 3;
            this.openGroupButton.Text = "Open Group";
            this.openGroupButton.UseVisualStyleBackColor = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Thistle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.activeGroupList);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupChatPreview);
            this.splitContainer3.Size = new System.Drawing.Size(600, 300);
            this.splitContainer3.SplitterDistance = 297;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupChatPreview
            // 
            this.groupChatPreview.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupChatPreview.Location = new System.Drawing.Point(3, 3);
            this.groupChatPreview.Multiline = true;
            this.groupChatPreview.Name = "groupChatPreview";
            this.groupChatPreview.ReadOnly = true;
            this.groupChatPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.groupChatPreview.Size = new System.Drawing.Size(293, 289);
            this.groupChatPreview.TabIndex = 1;
            // 
            // activeGroupList
            // 
            this.activeGroupList.BackColor = System.Drawing.Color.LavenderBlush;
            this.activeGroupList.FormattingEnabled = true;
            this.activeGroupList.ItemHeight = 15;
            this.activeGroupList.Location = new System.Drawing.Point(0, 3);
            this.activeGroupList.Name = "activeGroupList";
            this.activeGroupList.ScrollAlwaysVisible = true;
            this.activeGroupList.Size = new System.Drawing.Size(294, 289);
            this.activeGroupList.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.emailTextBox);
            this.flowLayoutPanel2.Controls.Add(this.searchButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(594, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.Color.Plum;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(302, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 25);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(398, 3);
            this.emailTextBox.MinimumSize = new System.Drawing.Size(4, 25);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(193, 25);
            this.emailTextBox.TabIndex = 1;
            // 
            // homeTab
            // 
            this.homeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeTab.Controls.Add(this.activeGroupsTab);
            this.homeTab.Controls.Add(this.findGroupTab);
            this.homeTab.Controls.Add(this.createGroupsTab);
            this.homeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.ItemSize = new System.Drawing.Size(86, 20);
            this.homeTab.Location = new System.Drawing.Point(-1, -2);
            this.homeTab.Name = "homeTab";
            this.homeTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeTab.SelectedIndex = 0;
            this.homeTab.Size = new System.Drawing.Size(616, 416);
            this.homeTab.TabIndex = 0;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(617, 412);
            this.Controls.Add(this.homeTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.Text = "StudentSync Home";
            this.BackColorChanged += new System.EventHandler(this.HomeView_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.HomeView_ForeColorChanged);
            this.findGroupTab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.activeGroupsTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.homeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage createGroupsTab;
        private TabPage findGroupTab;
        private SplitContainer splitContainer5;
        private FlowLayoutPanel flowLayoutPanel7;
        private TextBox searchTextBox;
        private Button button3;
        private SplitContainer splitContainer6;
        private SplitContainer splitContainer7;
        private ListBox groupsList;
        private Button joinGroupButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label meetingTimeFieldLabel;
        private Label label7;
        private Label durationFieldLabel;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label3;
        private TextBox descriptionTextBox;
        private FlowLayoutPanel flowLayoutPanel8;
        private TabPage activeGroupsTab;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox emailTextBox;
        private Button searchButton;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private ListBox activeGroupList;
        private TextBox groupChatPreview;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button openGroupButton;
        private Button button1;
        private TabControl homeTab;
    }
}