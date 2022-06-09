using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_AndreasNeocleous
{

    public partial class Login : Form
    {
        private const string DefaultUsername = "Admin";
        private const string DefaultPassword = "Admin";
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == DefaultUsername
                && passwordTextBox.Text == DefaultPassword)
            {
                Hide();
                new MainMenu().ShowDialog();
                Show();

                usernameTextBox.Clear();
                passwordTextBox.Clear();

                usernameTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Please enter valid username/password", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
