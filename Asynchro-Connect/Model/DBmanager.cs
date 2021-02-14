using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Asynchro_Connect.Model
{
    public class DBmanager
    {
        private FirestoreDb db;
        public static string USER_PATH = "Users", EMAIL_KEY = "Email", SCHOOL_KEY = "School", PASSWORD_KEY = "Password", GROUPS_KEY = "Groups",
            STUDY_GROUPS_PATH = "Study Groups", SG_ADMIN_KEY = "Admin", SG_NAME_KEY = "Name", SG_COURSE_KEY = "Course", SG_TIME_HOUR_KEY = "Time_Hour",
            SG_TIME_MINUTE_KEY = "Time_Minute", SG_MEET_DAYS_KEY = "Meeting_Days", SG_DURATION_KEY = "Duration", SG_SEMESTER_KEY = "Semester",
            SG_YEAR_KEY = "Year", SG_DESC_KEY = "Description";

        public DBmanager()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "..\\..\\.env\\Asynchro-Connect-cc3f69022ee5.json");
            this.db = FirestoreDb.Create("asynchro-connect-304800");
        }

        // Returns null if the displayName doesn't exist. Returns a suggested displayName otherwise (displayName + some number that makes it unique)
        public async Task<string> CheckUserExists(string displayName)
        {
            //var watch = new System.Diagnostics.Stopwatch();

            //watch.Start();
            CollectionReference colRef = db.Collection(USER_PATH);
            DocumentReference docRef = colRef.Document(displayName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (!snapshot.Exists)
            {
                //watch.Stop(); 
                //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); 
                //Console.WriteLine("null"); 
                return null;
            }

            int num = 0;
            while (true)
            {
                docRef = colRef.Document(displayName + num);
                snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    num++;
                }
                else
                {
                    //watch.Stop(); 
                    //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
                    //Console.WriteLine(displayName + num);
                    return displayName + num;
                }
            }


            // Old version. Realized the above was more efficient, as we don't have to loop through every single user.
            //CollectionReference usersRef = db.Collection(USER_PATH);
            //QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            //List<string> strList = new List<string>();

            //// get all displayNames
            //foreach (DocumentSnapshot document in snapshot.Documents)
            //{
            //    strList.Add(document.Id);
            //}

            //// sort list
            //strList.Sort();

            //int index = strList.BinarySearch(displayName);
            //if (index < 0) { watch.Stop(); Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); Console.WriteLine("null");  return null; }

            //index++;
            //int num = 0;
            //while (index < strList.Count)
            //{
            //    string current = strList[index];
            //    string currdisplayName = displayName + num;
            //    if (!current.Equals(currdisplayName))
            //    {
            //        watch.Stop(); Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); Console.WriteLine(currdisplayName);
            //        return currdisplayName;
            //    }
            //    index++;
            //    num++;
            //}

            //watch.Stop(); Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); Console.WriteLine(displayName + num);
            //return displayName + num;
        }

        public async Task<bool> CheckEmailExists(string email)
        {
            CollectionReference usersRef = db.Collection(USER_PATH);
            Query query = usersRef.WhereEqualTo(EMAIL_KEY, email);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            if (snapshot.Count == 0) { return false; }
            return true;
            //foreach (DocumentSnapshot document in snapshot.Documents)
            //{
            //    Dictionary<string, object> userDict = document.ToDictionary();
            //    if (((string)userDict[EMAIL_KEY]).Equals(email)) {
            //        return true;
            //    }
            //}
            //return false;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            CollectionReference usersRef = db.Collection(USER_PATH);
            Query query = usersRef.WhereEqualTo(EMAIL_KEY, email);
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> userDict = document.ToDictionary();
                User user = new User();
                user.DisplayName = document.Id;
                user.Email = (string)userDict[EMAIL_KEY];
                user.School = (string)userDict[SCHOOL_KEY];
                user.Password = (string)userDict[PASSWORD_KEY];
                //user.Groups = userDict[GROUPS_KEY];
                return user;
            }
            return null;
        }

        public async void CreateNewUser(string displayName, string email, string school, string password)
        {
            DocumentReference docRef = db.Collection(USER_PATH).Document(displayName);
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                {EMAIL_KEY, email},
                {SCHOOL_KEY, school},
                {PASSWORD_KEY, password}
            };
            await docRef.SetAsync(user);
        }

        public async Task<User> GetUser(string displayName)
        {
            DocumentReference docRef = db.Collection(USER_PATH).Document(displayName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> userDict = snapshot.ToDictionary();
                User user = new User();
                user.DisplayName = snapshot.Id;
                user.Email = (string)userDict[EMAIL_KEY];
                user.School = (string)userDict[SCHOOL_KEY];
                user.Password = (string)userDict[PASSWORD_KEY];
                //user.Groups = userDict[GROUPS_KEY];
                return user;
            }
            return null;
        }

        public string SGKEY(string name, string course, Semester sem, int year)
        {
            return name + "_" + course + "_" + sem + "_" + year;
        }

        public async Task CreateNewStudyGroup(string admin, string name, string course, int tHour, int tMinute, List<Days> meetingDays, int duration, Semester sem, int year, string desc)
        {
            string sgKey = SGKEY(name, course, sem, year);
            DocumentReference docRef = db.Collection(STUDY_GROUPS_PATH).Document(sgKey);
            List<string> days = new List<string>();
            foreach (Days day in meetingDays)
            {
                if (day.Equals(Days.Monday))
                {
                    days.Add("Monday");
                }
                else if (day.Equals(Days.Tuesday))
                {
                    days.Add("Tuesday");
                }
                else if (day.Equals(Days.Wednesday))
                {
                    days.Add("Wednesday");
                }
                else if (day.Equals(Days.Thursday))
                {
                    days.Add("Thursday");
                }
                else if (day.Equals(Days.Friday))
                {
                    days.Add("Friday");
                }
                else if (day.Equals(Days.Saturday))
                {
                    days.Add("Saturday");
                }
                else if (day.Equals(Days.Sunday))
                {
                    days.Add("Sunday");
                }
            }

            Dictionary<string, object> group = new Dictionary<string, object> {
                {SG_ADMIN_KEY , admin},
                {SG_NAME_KEY , name},
                {SG_COURSE_KEY , course},
                {SG_TIME_HOUR_KEY , tHour},
                {SG_TIME_MINUTE_KEY , tMinute},
                {SG_MEET_DAYS_KEY , days},
                {SG_DURATION_KEY , duration},
                {SG_SEMESTER_KEY , sem},
                {SG_YEAR_KEY , year},
                {SG_DESC_KEY , desc}
            };
            await docRef.SetAsync(group);
        }

        public async Task<List<StudyGroup>> GetEveryStudyGroup()
        {
            CollectionReference allStudyGroupsCollection = db.Collection(STUDY_GROUPS_PATH);
            IAsyncEnumerable<DocumentReference> a = allStudyGroupsCollection.ListDocumentsAsync();
            int count = await a.CountAsync();
            
            for(int i = 0; i < count; i++)
            {

            }

            return null;
        }

        public async Task<StudyGroup> GetStudyGroup(string id)
        {
            DocumentReference docRef = db.Collection(STUDY_GROUPS_PATH).Document(id);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> groupDict = snapshot.ToDictionary();
                foreach (KeyValuePair<string, object> pair in groupDict)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }

                List<object> temp = (List<object>)groupDict[SG_MEET_DAYS_KEY];
                List<Days> l = new List<Days>();
                //for (int i = 0; i < temp.Count; i++)
                foreach (object obj in temp)
                {
                    //l.Add((Days)((long)temp[i]));
                    //Console.WriteLine(l[i]);

                    if (((string)obj).Equals("Monday"))
                    {
                        l.Add(Days.Monday);
                    }
                    else if (((string)obj).Equals("Tuesday"))
                    {
                        l.Add(Days.Tuesday);
                    }
                    else if (((string)obj).Equals("Wednesday"))
                    {
                        l.Add(Days.Wednesday);
                    }
                    else if (((string)obj).Equals("Thursday"))
                    {
                        l.Add(Days.Thursday);
                    }
                    else if (((string)obj).Equals("Friday"))
                    {
                        l.Add(Days.Friday);
                    }
                    else if (((string)obj).Equals("Saturday"))
                    {
                        l.Add(Days.Saturday);
                    }
                    else if (((string)obj).Equals("Sunday"))
                    {
                        l.Add(Days.Sunday);
                        Console.WriteLine(l[l.Count - 1]);
                    }
                }

                //foreach(var element in groupDict[SG_MEET_DAYS_KEY]){ } 
                User n = await GetUser((string)groupDict[SG_ADMIN_KEY]);
                StudyGroup group = new StudyGroup(n, (String)groupDict[SG_NAME_KEY], (String)groupDict[SG_COURSE_KEY],
                    Convert.ToInt32((long)groupDict[SG_TIME_HOUR_KEY]), Convert.ToInt32((long)groupDict[SG_TIME_MINUTE_KEY]), l, Convert.ToInt32((long)groupDict[SG_DURATION_KEY]),
                    //(Semester)groupDict[SG_SEMESTER_KEY]
                    Semester.Winter
                    , Convert.ToInt32((long)groupDict[SG_YEAR_KEY]), (String)groupDict[SG_DESC_KEY]);
                return group;
            }
            return null;
        }

        public async Task<bool> CheckStudyGroupExists(string name, string course, Semester sem, int year)
        {
            string sgKey = SGKEY(name, course, sem, year);
            DocumentReference groupsRef = db.Collection(STUDY_GROUPS_PATH).Document(sgKey);
            DocumentSnapshot snapshot = await groupsRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return true;
            }
            return false;
        }

    }
}
