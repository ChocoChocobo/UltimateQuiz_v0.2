using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateQuiz_v0._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();   
        }

        private void buttonToUsersManager_Click(object sender, EventArgs e)
        {
            UserManagerForm userManagerForm = new UserManagerForm();
            userManagerForm.FormClosed += UserManagerForm_FormClosed;
            userManagerForm.ShowDialog();

            BindingList<User> userList = userManagerForm.Users;

            listBoxUsersMainForm.DataSource = userList;
            listBoxUsersMainForm.DisplayMember = "Name";
            listBoxUsersMainForm.ValueMember = "Id";
        }
        private void UserManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserManagerForm userManagerForm = (UserManagerForm)sender;
            BindingList<User> userList = userManagerForm.Users;

            listBoxUsersMainForm.DataSource = userList;
            listBoxUsersMainForm.DisplayMember = "Name";
            listBoxUsersMainForm.ValueMember = "Id";
        }

        private void buttonVideoGames_Click(object sender, EventArgs e)
        {
            VideoGamesForm videoGamesForm = new VideoGamesForm();
            this.Hide();
            videoGamesForm.ShowDialog();
            this.Show();
        }        
    }
}
