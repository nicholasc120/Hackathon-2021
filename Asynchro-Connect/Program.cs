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

            DBmanager dbm = new DBmanager();
            //List<Days> d = new List<Days>();
            //d.Add(Days.Sunday);
            //await dbm.CreateNewStudyGroup("alovelace", "G1", "Hackathon", 12, 0, d, 30, Semester.Fall, 2021, "Finish the Hackathon!");
            //await dbm.GetStudyGroup(dbm.SGKEY("G1", "Hackathon", Semester.Fall, 2021));
            Application.Run(new View.LoginView(dbm));

        }
    }
}
