using Asynchro_Connect.Model;
using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Console.WriteLine("Created Cloud Firestore client with project ID: {0}", "Asynchro-Connect");
            DBmanager dbm = new DBmanager();
            dbm.test();
            Application.Run(new View.LoginView());
            
        }
    }
}
