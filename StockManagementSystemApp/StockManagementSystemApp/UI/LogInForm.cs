using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApp.Manager;
using StockManagementSystemApp.Model;

namespace StockManagementSystemApp.UI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            cancelButton.Enabled = false;
        }

        private UserManager aUserManager= new UserManager();
        private void okButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please Select Your User Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Focus();
                return;
            }
            
            User aUser = new User();
            aUser.UserName = usernameTextBox.Text;
            aUser.UserPassword = passwordTextBox.Text;
            string message = aUserManager.FindUser(aUser);
            if (message == "Grant")
            {
                this.Hide();
                MenuForm aMenu= new MenuForm();
                aMenu.Show();
            }
            else
            {
                MessageBox.Show("You Are Not Authorized To Log In.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }


    }
}
