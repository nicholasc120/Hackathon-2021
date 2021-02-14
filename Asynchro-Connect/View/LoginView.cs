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
    public partial class LoginView : Form
    {
        DBmanager dbManager;
        NewAccount accountWindow = null;
        public LoginView(DBmanager dbManager)
        {
            this.dbManager = dbManager;
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (accountWindow == null)
            {
                accountWindow = new NewAccount(this, dbManager);
            }
            accountWindow.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            tryLogin();
        }

        private async void tryLogin()
        {
            User theUser = await dbManager.GetUser(emailTextBox.Text);

            if (theUser == null || !theUser.Password.Equals(passwordTextBox.Text))
            {
                //give error
                MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //login
                this.Hide();
                HomeView homeView = new HomeView(theUser, dbManager);
                homeView.Show();
            }
        }

    }
}
