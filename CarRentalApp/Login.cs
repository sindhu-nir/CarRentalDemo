using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                var username = tbUserName.Text.Trim();
                var password = tbPassword.Text;

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++) 
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }
                var hashed_passowrd = stringBuilder.ToString();

                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_passowrd);
                if (user == null)
                {
                    MessageBox.Show("Please provide a valid credentials");
                }
                else
                {
                    var role = user.UserRoles.FirstOrDefault();
                    var roleShortName = role.Role.shortname;
                    var mainWindow = new MainWIndow(this, roleShortName);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, please try again");
            }
        }
    }
}
