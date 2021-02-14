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
    public partial class HomeView : Form
    {

        User theUser;
        public HomeView(User theUser)
        {
            InitializeComponent();
            this.homeTab.DrawMode = (TabDrawMode)DrawMode.OwnerDrawFixed;
            this.homeTab.DrawItem += new DrawItemEventHandler(homeView_DrawItem);
            this.theUser = theUser;
            PopulateActiveGroupList();
        }

        private void PopulateActiveGroupList()
        {
            activeGroupList.Items.Clear();
            foreach (StudyGroup sg in theUser.Groups)
            {
                activeGroupList.Items.Add(sg.StudyGroupName);
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
                if (sg.StudyGroupName.Equals(s))
                {
                    stg = sg;
                }
            }
            if (stg == null)
            {
                return;
            }
            //launch StudyGroupHomepage
            StudyGroupHomepage sghp = new StudyGroupHomepage(theUser, stg);
            sghp.Show();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (homeTab.SelectedIndex == 0)
            {
                List<StudyGroup> results = SearchEngine.SearchByStudyGroupName(theUser.Groups, emailTextBox.Text);
                activeGroupList.Items.Clear();
                foreach(StudyGroup sg in results)
                {
                    activeGroupList.Items.Add(sg.StudyGroupName);
                }
            }
        }

        private void activeGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupChatPreview.Items.Clear();
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

            foreach (String message in stg.GroupDiscussionBoard.GetListOfMessages())
            {
                groupChatPreview.Items.Add(message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (homeTab.SelectedIndex == 1)
            {
                List<StudyGroup> results = SearchEngine.SearchByStudyGroupName(theUser.Groups, emailTextBox.Text);
                activeGroupList.Items.Clear();
                foreach (StudyGroup sg in results)
                {
                    groupsList.Items.Add(sg.StudyGroupName);
                }
            }
        }

        private void groupsList_SelectedIndexChanged(object sender, EventArgs e)
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

            descriptionTextBox.Text = stg.Description;
            string minute = stg.MeetingTime.Minute + "";
            if (minute.Length == 0)
            {
                minute = "0" + minute;
            }
            meetingTimeFieldLabel.Text = stg.MeetingTime.Hour + ":" + minute;
            durationFieldLabel.Text = stg.Duration + "";
        }

        private void joinGroupButton_Click(object sender, EventArgs e)
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

            theUser.JoinGroup(stg);
            stg.AddMember(theUser);
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            //generate warning
            List<Days> daysSelected = new List<Days>();

            StudyGroup sg = new StudyGroup(theUser, groupName.Text, courseNameTextBox.Text, );
            //add to database
        }
    }
}
