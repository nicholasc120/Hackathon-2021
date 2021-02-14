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
        public List<string> Members { get; private set; }
        public string Admin;
        public String StudyGroupName { get; private set; }
        public String CourseName { get; private set; }
        public int groupID;
        public Time MeetingTime { get; private set; }
        public List<Days> MeetingDays { get; private set; }
        public int Duration { get; set; }
        public Semester CourseSemester { get; set; }
        public String Description { get; set; }
        public DiscussionBoard GroupDiscussionBoard;
        public int Year;
        public String JoinUrl { get; set; }

        public StudyGroup(string admin, String studyGroupName, String courseName, int timeHour, int timeMinute, List<Days> meetingDays, int duration, Semester courseSemester, int year, String description, String joinUrl)

        {
            Members = new List<string>();
            Admin = admin;
            StudyGroupName = studyGroupName;
            CourseName = courseName;
            //groupID = maxGroupID+1;
            MeetingTime = new Time() { Hour = timeHour, Minute = timeMinute };
            MeetingDays = meetingDays;
            Duration = duration;
            CourseSemester = courseSemester;
            Year = year;
            this.JoinUrl = joinUrl;
            Description = description;
            GroupDiscussionBoard = new DiscussionBoard();
            Members.Add(admin);
        }

        public StudyGroup(string admin, String studyGroupName, String courseName, int timeHour, int timeMinute, List<Days> meetingDays, int duration, Semester courseSemester, int year, String description, List<String> memberList, String joinUrl)
        {
            Members = memberList;
            Admin = admin;
            StudyGroupName = studyGroupName;
            CourseName = courseName;
            //groupID = maxGroupID+1;
            MeetingTime = new Time() { Hour = timeHour, Minute = timeMinute };
            MeetingDays = meetingDays;
            Duration = duration;
            CourseSemester = courseSemester;
            Year = year;
            this.JoinUrl = joinUrl;
            Description = description;
            GroupDiscussionBoard = new DiscussionBoard();
        }

        public void AddMember(string member)
        {
            if (!Members.Contains(member))
            {
                Members.Add(member);
            }
            
            //member.JoinGroup(this);
            //update database
        }
    }
}