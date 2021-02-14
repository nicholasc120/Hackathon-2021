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

        public DBmanager() {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "..\\..\\.env\\Asynchro-Connect-cc3f69022ee5.json"); 
            this.db = FirestoreDb.Create("asynchro-connect-304800");
        }

        public async Task test() {
            DocumentReference docRef = db.Collection("users").Document("alovelace");
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                { "First", "Ada" },
                { "Last", "Lovelace" },
                { "Born", 1815 }
            };
            await docRef.SetAsync(user);
        }
    }
}
