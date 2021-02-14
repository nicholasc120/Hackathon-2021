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

            if(theStudyGroup.Admin != theUser)
            {
                kickUserButton.Visible = false;
            }
            InitializeComponent();
        }

        private void MemberListBox_Leave(object sender, EventArgs e)
        {
            kickUserButton.Enabled = false;
        }

        private void MemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if user is admin
            kickUserButton.Enabled = true;
        }
    }
}
