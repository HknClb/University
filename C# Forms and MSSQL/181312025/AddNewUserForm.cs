using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025
{
    public partial class AddNewUserForm : Form
    {
        public AdminPanel adminPanelForm;
        Logs log;
        public AddNewUserForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtUserName, "Kullanıcı Adı");
            TextBoxHintEvent.Hint(txtPassword, "Parola");
            TextBoxHintEvent.Hint(txtRePassword, "Parola Tekrar");
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            var types = Enum.GetNames(typeof(User.AuthorityEnum));
            for (int i = 1; i < types.Length; i++)
                comboBoxAuthority.Items.Add(types[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.CheckSpace(txtUserName, errorProvider, "Kullanıcı Adı") && !TextBoxInputController.CheckSpace(txtPassword, errorProvider, "Parola") &&
                !TextBoxInputController.CheckSpace(txtRePassword, errorProvider, "Parola Tekrar") && !TextBoxInputController.IsNull(txtUserName, errorProvider, "Kullanıcı Adı") &&
                !TextBoxInputController.IsNull(txtPassword, errorProvider, "Parola") && !TextBoxInputController.IsNull(txtRePassword, errorProvider, "Parola Tekrar"))
            {
                if(!txtPassword.Text.Trim().Equals(txtRePassword.Text.Trim()))
                {
                    errorProvider.SetError(txtPassword, "Parolalar Eşleşmiyor!");
                    errorProvider.SetError(txtRePassword, "Parolalar Eşleşmiyor!");
                }
                else if (!comboBoxAuthority.Text.Equals("Yetki"))
                {
                    bool isDatabaseContainsThisUser = false;
                    User newUser = new User();
                    SqlDataReader reader = newUser.AllUsers;
                    if (reader != null)
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
                    if(!isDatabaseContainsThisUser)
                    {
                        newUser.UserName = txtUserName.Text;
                        newUser.Password = txtPassword.Text;
                        newUser.Authority = (User.AuthorityEnum)Enum.Parse(typeof(User.AuthorityEnum), comboBoxAuthority.SelectedItem.ToString());
                        newUser.AddUserToDatabase();
                        adminPanelForm.AddUsersToTable();
                        adminPanelForm.Focus();
                        newUser.AllUsers = null;
                        log = new Logs(adminPanelForm.Tag as User);
                        log.ProcessInformation = string.Format("{0} Yetkisine sahip {1} kullanıcı, {2} yetkisine sahip {3} kullanıcısını ekledi.",
                            log.AuthorizedUser.Authority.ToString(), log.AuthorizedUser.UserName, newUser.Authority.ToString(), newUser.UserName);
                        log.AddLogToDatabase();
                        this.Close();
                    }
                    newUser.AllUsers = null;
                }
                else
                    errorProvider.SetError(comboBoxAuthority, "Yetki Seçilmedi!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            adminPanelForm.Focus();
            this.Close();
        }
    }
}
