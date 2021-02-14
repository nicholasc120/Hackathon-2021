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
            STUDY_GROUPS_PATH = "Study Groups", SG_NAME_KEY = "Name";

        public DBmanager() {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "..\\..\\.env\\Asynchro-Connect-cc3f69022ee5.json"); 
            this.db = FirestoreDb.Create("asynchro-connect-304800");
        }

        // Returns null if the displayName doesn't exist. Returns a suggested displayName otherwise (displayName + some number that makes it unique)
        public async Task<string> CheckUserExists(string displayName) {
            //var watch = new System.Diagnostics.Stopwatch();

            //watch.Start();
            CollectionReference colRef = db.Collection(USER_PATH);
            DocumentReference docRef = colRef.Document(displayName);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (!snapshot.Exists) {
                //watch.Stop(); 
                //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); 
                //Console.WriteLine("null"); 
                return null;}

            int num = 0;
            while (true)
            {
                docRef = colRef.Document(displayName + num);
                snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    num++;
                }
                else {
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

        public async Task<bool> CheckEmailExists(string email) {
            CollectionReference usersRef = db.Collection(USER_PATH);
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> userDict = document.ToDictionary();
                if (((string)userDict[EMAIL_KEY]).Equals(email)) {
                    return true;
                }
            }
            return false;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            CollectionReference usersRef = db.Collection(USER_PATH);
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> userDict = document.ToDictionary();
                if (((string)userDict[EMAIL_KEY]).Equals(email))
                {
                    User user = new User();
                    user.DisplayName = document.Id;
                    user.Email = (string)userDict[EMAIL_KEY];
                    user.School = (string)userDict[SCHOOL_KEY];
                    user.Password = (string)userDict[PASSWORD_KEY];
                    //user.Groups = userDict[GROUPS_KEY];
                    return user;
                }
            }
            return null;
        }

        public async void CreateNewUser(string displayName, string email, string school, string password) {
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

            if (snapshot.Exists) {
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

        public string SGKEY(string name, string course, Semester sem)
        {
            return name + "_" + course + "_" + sem;
        }

        public async void CreateNewStudyGroup(string name, string course, int tHour, int tMinute, int duration, Semester sem, string desc) {
            string sgKey = SGKEY(name, course, sem);
            DocumentReference docRef = db.Collection(STUDY_GROUPS_PATH).Document(sgKey);
            Dictionary<string, object> group = new Dictionary<string, object> { 
                
            };
        }

        public async Task<bool> CheckStudyGroupExists(string name, string course, Semester sem)
        {

            string sgKey = SGKEY(name, course, sem);
            CollectionReference usersRef = db.Collection(STUDY_GROUPS_PATH);
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                
                if (document.Id.Equals(sgKey))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
