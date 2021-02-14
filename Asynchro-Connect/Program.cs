using Asynchro_Connect.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asynchro_Connect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String link = System.IO.File.ReadAllText("..\\..\\.env\\awsLink.json");
            Environment.SetEnvironmentVariable("AWS_URL_LINK", link);
            System.Diagnostics.Process newProcess = System.Diagnostics.Process.Start("https://zoom.us/oauth/authorize?response_type=code&client_id=ZBoG2s2JRZSD_FoQZH2Zdg&redirect_uri=https%3A%2F%2Fbyjsxnki07.execute-api.us-west-2.amazonaws.com%2Fdevel%2Fuser");

            // TODO need to check if they actually signed in correctly
            // Wait until person has verified their zoom
            newProcess.WaitForExit();
            DBmanager dbm = new DBmanager();
            //List<Days> d = new List<Days>();
            //d.Add(Days.Sunday);
            //await dbm.CreateNewStudyGroup("alovelace", "G1", "Hackathon", 12, 0, d, 30, Semester.Fall, 2021, "Finish the Hackathon!");
                await dbm.GetStudyGroup(dbm.SGKEY("G1", "Hackathon", Semester.Fall, 2021));
            Application.Run(new View.LoginView(dbm));
            
        }
    }
}
