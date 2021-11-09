using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class UpdateUserForm : Form
    {
        public AdminPanel adminPanelForm;
        User updateUser;
        User user;

        public UpdateUserForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtUserName, "Kullanıcı Adı");
            TextBoxHintEvent.Hint(txtPassword, "Parola");
            TextBoxHintEvent.Hint(txtRePassword, "Parola Tekrar");
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            int id = int.Parse(this.Tag.ToString());
            updateUser = new User();
            user = adminPanelForm.Tag as User;
            updateUser.SetByID(id);
            txtUserName.Text = updateUser.UserName;
            txtPassword.Text = txtRePassword.Text = updateUser.Password;
            txtUserName.ForeColor = txtPassword.ForeColor = txtRePassword.ForeColor = comboBoxAuthority.ForeColor = Color.Black;
            var types = Enum.GetNames(typeof(User.AuthorityEnum));
            for (int i = 1; i < types.Length; i++)
                comboBoxAuthority.Items.Add(types[i]);
            comboBoxAuthority.SelectedItem = updateUser.Authority.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.CheckSpace(txtUserName, errorProvider, "Kullanıcı Adı") && !TextBoxInputController.CheckSpace(txtPassword, errorProvider, "Parola") &&
                !TextBoxInputController.CheckSpace(txtRePassword, errorProvider, "Parola Tekrar") && !TextBoxInputController.IsNull(txtUserName, errorProvider, "Kullanıcı Adı") &&
                !TextBoxInputController.IsNull(txtPassword, errorProvider, "Parola") && !TextBoxInputController.IsNull(txtRePassword, errorProvider, "Parola Tekrar"))
            {
                if (!txtPassword.Text.Trim().Equals(txtRePassword.Text.Trim()))
                {
                    errorProvider.SetError(txtPassword, "Parolalar Eşleşmiyor!");
                    errorProvider.SetError(txtRePassword, "Parolalar Eşleşmiyor!");
                }
                else
                {
                    bool isDatabaseContainsThisUser = false;
                    SqlDataReader reader = user.AllUsers;
                    if (!updateUser.UserName.Equals(txtUserName.Text))
                    {
                        if (!txtUserName.Text.Equals(reader["UserName"].ToString()))
                        {
                            foreach (var item in reader)
                            {
                                if (txtUserName.Text.Equals(reader["UserName"].ToString()))
                                {
                                    isDatabaseContainsThisUser = true;
                                    MessageBox.Show("Kullanıcı Adı Önceden Kullanılmış", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Önceden Kullanılmış", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isDatabaseContainsThisUser = true;
                        }
                    }
                    else
                        isDatabaseContainsThisUser = false;
                    if (!isDatabaseContainsThisUser)
                    {
                        Logs log = new Logs(user);
                        log.ProcessInformation = string.Format("{0} yetkisine sahip {1} kullanıcısı tarafından {2} kullanıcısı güncellendi.", log.AuthorizedUser.Authority.ToString()
                            , log.AuthorizedUser.UserName, txtUserName.Text);
                        updateUser.UserName = txtUserName.Text;
                        updateUser.Password = txtPassword.Text;
                        updateUser.UpdateAuthorityByAdmin(user, (User.AuthorityEnum)Enum.Parse(typeof(User.AuthorityEnum), comboBoxAuthority.Text));
                        updateUser.UpdateUserFromDatabase();
                        adminPanelForm.AddUsersToTable();
                        adminPanelForm.Focus();
                        updateUser.AllUsers = null;
                        this.Close();
                    }
                    updateUser.AllUsers = null;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            adminPanelForm.Focus();
            this.Close();
        }
    }
}
