﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Asynchro_Connect.Model;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Asynchro_Connect.View
{
    public partial class HomeView : Form
    {

        User theUser;
        DBmanager dbm;
        public HomeView(User theUser, DBmanager dbm)
        {
            this.dbm = dbm;
            InitializeComponent();
            this.homeTab.DrawMode = (TabDrawMode)DrawMode.OwnerDrawFixed;
            this.homeTab.DrawItem += new DrawItemEventHandler(homeView_DrawItem);
            this.theUser = theUser;
            PopulateActiveGroupList();
            PopulateAllGroupList();
        }


        private async void PopulateAllGroupList()
        {
            List<StudyGroup> everyGroup = await dbm.GetEveryStudyGroup();

            groupsList.Items.Clear();
            foreach (StudyGroup stg in everyGroup)
            {
                groupsList.Items.Add(stg.StudyGroupName);
            }
        }

        private async void PopulateActiveGroupList()
        {
            List<String> userGroups = await dbm.GetUserStudyGroups(theUser.DisplayName);
            //List<StudyGroup> everyGroup = await dbm.GetEveryStudyGroup();

            activeGroupList.Items.Clear();
            theUser.Groups.Clear();

            foreach (String s in userGroups)
            {
                StudyGroup sg = await dbm.GetStudyGroup(s);
                activeGroupList.Items.Add(sg.StudyGroupName);
                theUser.Groups.Add(sg);
            }
        }

        // Method modified from https://stackoverflow.com/questions/30822870/recoloring-tabcontrol
        // and https://stackoverflow.com/questions/11822748/how-to-change-the-background-color-of-unused-space-tab-in-c-sharp-winforms
        private void homeView_DrawItem(object sender, DrawItemEventArgs e)
        {
            // get ref to this page
            TabPage tp = ((TabControl)sender).TabPages[e.Index];
            TabPage selectedTab = ((TabControl)sender).TabPages[this.homeTab.SelectedIndex];
            Color myColor = Color.Thistle;
            if (tp == selectedTab)
            {
                // Use a color slightly darker than Thistle
                myColor = Color.FromArgb(206, 175, 206);
            }
            using (Brush br = new SolidBrush(myColor))
            {
                Rectangle rect = e.Bounds;
                e.Graphics.FillRectangle(br, e.Bounds);

                // Fill in the colour of the space
                Rectangle lasttabrect = this.homeTab.GetTabRect(this.homeTab.TabPages.Count - 1);
                RectangleF emptyspacerect = new RectangleF(
                        lasttabrect.X + lasttabrect.Width + this.homeTab.Left,
                        this.homeTab.Top + lasttabrect.Y,
                        this.homeTab.Width - (lasttabrect.X + lasttabrect.Width),
                        lasttabrect.Height);

                e.Graphics.FillRectangle(br, emptyspacerect);

                rect.Offset(1, 1);
                TextRenderer.DrawText(e.Graphics, tp.Text,
                       tp.Font, rect, tp.ForeColor);

                // draw the border
                rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);

                // ControlDark looks right for the border
                using (Pen p = new Pen(SystemColors.ControlDark))
                {
                    e.Graphics.DrawRectangle(p, rect);
                }

                if (e.State == DrawItemState.Selected) e.DrawFocusRectangle();

            }
        }

        private void openGroupButton_Click(object sender, EventArgs e)
        {
            String s = (String)activeGroupList.SelectedItem;
            StudyGroup stg = null;
            //find the group for the user
            foreach (StudyGroup sg in theUser.Groups)
            {
                Console.WriteLine(sg.StudyGroupName);
                if (sg.StudyGroupName.Equals(s))
                {
                    stg = sg;
                }
            }
            if (stg == null)
            {
                Console.WriteLine("Coldn't find it, the value was " + s);
                return;
            }
            //launch StudyGroupHomepage
            StudyGroupHomepage sghp = new StudyGroupHomepage(theUser, stg, dbm);
            sghp.Show();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (homeTab.SelectedIndex == 0)
            {
                List<StudyGroup> results = SearchEngine.SearchByStudyGroupName(theUser.Groups, emailTextBox.Text);
                activeGroupList.Items.Clear();
                foreach (StudyGroup sg in results)
                {
                    activeGroupList.Items.Add(sg.StudyGroupName);
                }
            }
        }

        private void activeGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = (String)activeGroupList.SelectedItem;
            StudyGroup stg = null;
            //find the group for the user
            foreach (StudyGroup sg in theUser.Groups)
            {
                if (sg.StudyGroupName.Equals(s))
                {
                    stg = sg;
                }
            }

            if (stg == null)
            {
                return;
            }

            RefreshMessages(stg);
        }
        private async void RefreshMessages(StudyGroup theStudyGroup)
        {
            groupChatPreview.Items.Clear();

            theStudyGroup.GroupDiscussionBoard.History = await dbm.GetMessages(dbm.SGKEY(theStudyGroup.StudyGroupName, theStudyGroup.CourseName, theStudyGroup.CourseSemester, theStudyGroup.Year));
            foreach (String message in theStudyGroup.GroupDiscussionBoard.GetListOfMessages())
            {
                groupChatPreview.Items.Add(message);
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (homeTab.SelectedIndex == 1)
            {
                List<StudyGroup> results = SearchEngine.SearchByStudyGroupName(theUser.Groups, emailTextBox.Text);
                groupsList.Items.Clear();
                foreach (StudyGroup sg in results)
                {
                    groupsList.Items.Add(sg.StudyGroupName);
                }
            }
        }

        private async void groupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<StudyGroup> everyGroup = await dbm.GetEveryStudyGroup();
            String s = (String)groupsList.SelectedItem;

            StudyGroup stg = null;
            //find the group for the user
            foreach (StudyGroup sg in everyGroup)
            {
                if (sg.StudyGroupName.Equals(s))
                {
                    stg = sg;
                }
            }

            if (stg == null)
            {
                return;
            }

            descriptionTextBox.Text = stg.Description;
            string minute = stg.MeetingTime.Minute + "";
            if (minute.Length == 1)
            {
                minute = "0" + minute;
            }
            meetingTimeFieldLabel.Text = stg.MeetingTime.Hour + ":" + minute;
            durationFieldLabel.Text = stg.Duration + "";
        }

        private async void joinGroupButton_Click(object sender, EventArgs e)
        {
            List<StudyGroup> everyGroup = await dbm.GetEveryStudyGroup();
            String s = (String)groupsList.SelectedItem;
            StudyGroup stg = null;
            //find the group for the user
            foreach (StudyGroup sg in everyGroup)
            {
                if (sg.StudyGroupName.Equals(s))
                {
                    stg = sg;
                }
            }
            if (stg == null)
            {
                return;
            }

            stg.AddMember(theUser.DisplayName);

            PopulateActiveGroupList();
        }

        private async void createGroupButton_Click(object sender, EventArgs e)
        {
            //generate warning
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to create this group?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                List<Days> daysSelected = new List<Days>();
                foreach (Object listItem in meetingDaysCheckBox.CheckedItems)
                {
                    if (listItem.ToString().Equals("Monday"))
                    {
                        daysSelected.Add(Days.Monday);
                    }
                    if (listItem.ToString().Equals("Tuesday"))
                    {
                        daysSelected.Add(Days.Tuesday);
                    }
                    if (listItem.ToString().Equals("Wednesday"))
                    {
                        daysSelected.Add(Days.Wednesday);
                    }
                    if (listItem.ToString().Equals("Thursday"))
                    {
                        daysSelected.Add(Days.Thursday);
                    }
                    if (listItem.ToString().Equals("Friday"))
                    {
                        daysSelected.Add(Days.Friday);
                    }
                    if (listItem.ToString().Equals("Saturday"))
                    {
                        daysSelected.Add(Days.Saturday);
                    }
                    if (listItem.ToString().Equals("Sunday"))
                    {
                        daysSelected.Add(Days.Sunday);
                    }
                }

                Semester theSemester;
                if (seasonComboBox.Text.Equals("Spring"))
                {
                    theSemester = Semester.Spring;
                }
                else if (seasonComboBox.Text.Equals("Fall"))
                {
                    theSemester = Semester.Fall;
                }
                else if (seasonComboBox.Text.Equals("Winter"))
                {
                    theSemester = Semester.Winter;
                }
                else
                {
                    theSemester = Semester.Summer;
                }

                //StudyGroup sg = new StudyGroup(theUser.DisplayName, groupName.Text, courseNameTextBox.Text, Convert.ToInt32(timeHourScroll.Value), Convert.ToInt32(timeMinutesScroll.Value), daysSelected, Convert.ToInt32(hoursDurationScroll.Value), theSemester, (DateTime.Now).Year, descriptionTextBook.Text);

                System.Diagnostics.Process newProcess = System.Diagnostics.Process.Start("https://zoom.us/oauth/authorize?response_type=code&client_id=ZBoG2s2JRZSD_FoQZH2Zdg&redirect_uri=https%3A%2F%2Fbyjsxnki07.execute-api.us-west-2.amazonaws.com%2Fdevel%2Fuser");

                // TODO need to check if they actually signed in correctly
                // Wait until person has verified their zoom
                newProcess.WaitForExit();
                //while (newProcess != null && !newProcess.HasExited) 
                //{
                //    System.Threading.Thread.Sleep(1000);
                //}

                //TODO send the meeting time and other details
                // request modified from: https://stackoverflow.com/questions/9145667/how-to-post-json-to-a-server-using-c
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Environment.GetEnvironmentVariable("AWS_URL_LINK"));
                request.Method = "POST";
                request.ContentType = "application/json";
                var joinLink = "";
                try
                { 
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        string json = "{\"user\":\"test\"," +
                                      "\"password\":\"bla\"}";

                        streamWriter.Write(json);
                    }
                    string responseContent = null;
                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                         responseContent = streamReader.ReadToEnd();
                    }
                    Console.WriteLine(responseContent);

                    var userObj = JObject.Parse(responseContent);
                    joinLink = Convert.ToString(userObj["join_url"]);
                }
                catch (Exception)
                {
                    joinLink = "No Link Available";
                }

                StudyGroup sg = new StudyGroup(theUser.DisplayName, groupName.Text, courseNameTextBox.Text, Convert.ToInt32(timeHourScroll.Value), Convert.ToInt32(timeMinutesScroll.Value), daysSelected, Convert.ToInt32(hoursDurationScroll.Value), theSemester, (DateTime.Now).Year, descriptionTextBook.Text, joinLink);

                theUser.JoinGroup(sg);
                PopulateActiveGroupList();
                //add to database
                await dbm.CreateNewStudyGroup(theUser.DisplayName, groupName.Text, courseNameTextBox.Text, Convert.ToInt32(timeHourScroll.Value), Convert.ToInt32(timeMinutesScroll.Value), daysSelected, Convert.ToInt32(hoursDurationScroll.Value), theSemester, (DateTime.Now).Year, descriptionTextBook.Text, joinLink);

                MessageBox.Show("Study Group successfully created!", "Group created", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //give warning -- are you sure?
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave this group?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Successfully left study group", "Group Left", MessageBoxButtons.OK);
                String s = (String)activeGroupList.SelectedItem;
                StudyGroup stg = null;
                //find the group for the user
                foreach (StudyGroup sg in theUser.Groups)
                {
                    if (sg.StudyGroupName.Equals(s))
                    {
                        stg = sg;
                    }
                }
                if (stg == null)
                {
                    return;
                }

                stg.Members.Remove(theUser.DisplayName);
                theUser.Groups.Remove(stg);
            }
        }
    }
}
