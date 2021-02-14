using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchro_Connect.Model
{
    public class Time
    {
        public int Hour;
        public int Minute;
    }

    public enum Semester
    {
        Fall,
        Spring,
        Summer,
        Winter
    };

    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };

    public class StudyGroup
    {
        public List<User> Members { get; private set; }
        public User Admin;
        public String StudyGroupName { get; private set; }
        public String CourseName { get; private set; }
        public int groupID;
        public Time MeetingTime { get; private set; }
        public List<Days> MeetingDays { get; private set; }
        public int Duration { get; set; }
        public Semester CourseSemester;
        public String Description { get; set; }
        public DiscussionBoard GroupDiscussionBoard;
        public int Year;

        public StudyGroup(User admin, String studyGroupName, String courseName, int timeHour, int timeMinute, List<Days> meetingDays, int duration, Semester courseSemester, int year, String description)
        {
            Members = new List<User>();
            Admin = admin;
            StudyGroupName = studyGroupName;
            CourseName = courseName;
            //groupID = maxGroupID+1;
            MeetingTime = new Time() { Hour = timeHour, Minute = timeMinute };
            MeetingDays = meetingDays;
            Duration = duration;
            CourseSemester = courseSemester;
            Year = year;
            Description = description;
            GroupDiscussionBoard = new DiscussionBoard();
        }
        
        public void AddMember(User member)
        {
            Members.Add(member);
            member.JoinGroup(this);
            //update database
        }
    }
}