using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UltimateQuiz_v0._2.UserManagerForm;

namespace UltimateQuiz_v0._2
{
    public partial class UserManagerForm : Form
    {
        private BindingList<User> users;
        public UserManagerForm()
        {
            InitializeComponent();

            users = new BindingList<User>
            {
                new User { Id = 1, Name = "Example"}
            };
            listBoxUsers.DataSource = users;
            listBoxUsers.DisplayMember = "Name";
            listBoxUsers.ValueMember = "Id";
        }

        public BindingList<User> Users
        {
            get { return users; }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (User)listBoxUsers.SelectedItem;
            idBox.Text = user.Id.ToString();
            nameBox.Text = user.Name;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;

            User user = new User
            {                
                Name = name,
            };

            users.Add(user);
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            User user = (User)listBoxUsers.SelectedItem;
            int selectedIndex = listBoxUsers.SelectedIndex;

            user.Name = nameBox.Text;

            users.Remove(user);
            users.Insert(selectedIndex, user);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            User user = (User)listBoxUsers.SelectedItem;

            users.Remove(user);

            int maxId = users.Max(x => x.Id);

            User.UpdateLastAssignedId(maxId);
        }

        
    }
    public class User
    {
        private static int lastAssignedId = 0;

        public int Id { get; set; }
        public string Name { get; set; }

        public User()
        {
            lastAssignedId++;
            Id = lastAssignedId;
        }

        public static void UpdateLastAssignedId(int newLastAssignedId)
        {
            lastAssignedId = newLastAssignedId;
        }
    }
}
