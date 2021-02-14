using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchro_Connect.Model
{
    public class User
    {

        public String School { get; set; }
        public String Email { get; set; }
        public String DisplayName { get; set; }
        public String Password { get; set; }
        public List<StudyGroup> Groups { get; private set; }
        public User()
        {
            Groups = new List<StudyGroup>();
        }
        public void JoinGroup(StudyGroup group)
        {
            Groups.Add(group);
            //update database
        }

        public void SendMessage(StudyGroup group, String message)
        {
            group.GroupDiscussionBoard.SendMessage(message, this);
        }
    }
}
