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
    public partial class NewAccount : Form
    {
        DBmanager dbm;
        LoginView parent;
        public NewAccount(LoginView parent, DBmanager dbm)
        {
            this.parent = parent;
            this.dbm = dbm;
            InitializeComponent();

            foreach (String s in Schools.listOfSchools)
            {
                schoolComboBox.Items.Add(s);
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            //check if account exists
            checkDatabaseIfUsernameExistsAndAddItIfItDoesnt();
        }

        private async void checkDatabaseIfUsernameExistsAndAddItIfItDoesnt()
        {
            String result = await dbm.CheckUserExists(displayNameTextBox.Text);
            if (result == null)
            {
                //displayName doesn't exist. add it to the database
                dbm.CreateNewUser(displayNameTextBox.Text, emailTextBox.Text, schoolComboBox.Text, passwordTextBox.Text);
            }
            else
            {
                //displayName does exist and result is suggested name
                MessageBox.Show("Display Name already exists, try: " + result, "Display Name already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Visible = false;
        }

        private void NewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
