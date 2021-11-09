using _181312025.CreatedClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181312025
{
    public partial class AdminPanel : Form
    {
        public MainForm mainForm;
        User user;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            AddUsersToTable();
        }
        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(mainForm);
            mainForm.Enabled = mainForm.TopMost = mainForm.Visible = true;
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm addNewUser = new AddNewUserForm();
            addNewUser.adminPanelForm = this;
            addNewUser.Show();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if(listViewUsers.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsers.SelectedItems[0];
                UpdateUserForm updateUser = new UpdateUserForm();
                updateUser.adminPanelForm = this;
                updateUser.Tag = item.Text;
                updateUser.Show();
            }
            else
                MessageBox.Show("Listeden Kullanıcı Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewUsers.SelectedItems[0];
                User deletingUser = new User();
                deletingUser.SetByID(int.Parse(item.Text));
                Logs log = new Logs(user);
                log.ProcessInformation = string.Format("{0} yetkisine sahip {1} kullanıcısı tarafından {2} kullanıcısı silindi.", log.AuthorizedUser.Authority.ToString()
                        , log.AuthorizedUser.UserName, deletingUser.UserName);
                log.AddLogToDatabase();
                deletingUser.DeleteUserFromDatabase();
                AddUsersToTable();
            }
            else
                MessageBox.Show("Listeden Kullanıcı Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AddUsersToTable()
        {
            listViewUsers.Items.Clear();
            user = this.Tag as User;
            SqlDataReader reader = user.AllUsers;
            ListViewItem item = new ListViewItem(reader["ID"].ToString());
            item.SubItems.Add(reader["UserName"].ToString());
            item.SubItems.Add(reader["Password"].ToString());
            item.SubItems.Add(reader["Authority"].ToString());
            listViewUsers.Items.Add(item);
            foreach (var i in reader)
            {
                item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["UserName"].ToString());
                item.SubItems.Add(reader["Password"].ToString());
                item.SubItems.Add(reader["Authority"].ToString());
                listViewUsers.Items.Add(item);
            }
            user.AllUsers = null;
        }

        private void btnShowLogs_Click(object sender, EventArgs e)
        {
            LogsForm logsForm = new LogsForm();
            logsForm.Tag = user;
            logsForm.Show();
        }
    }
}
