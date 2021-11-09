using _181312025.CreatedClass;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class MainForm : Form
    {
        User user;
        Logs log;
        public MainForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtUserName, "Kullanıcı Adı");
            TextBoxHintEvent.Hint(txtPassword, "Parola", true);
        }
        private void btnExam_Click(object sender, EventArgs e)
        {
            switch (user.Authority)
            {
                case User.AuthorityEnum.admin:
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Tag = user;
                    adminPanel.AddOwnedForm(this);
                    adminPanel.mainForm = this;
                    this.Enabled = this.TopMost = this.Visible = false;
                    adminPanel.Show();
                    break;
                case User.AuthorityEnum.terminal:
                    TerminalPanel terminalPanel = new TerminalPanel();
                    terminalPanel.Tag = user;
                    terminalPanel.AddOwnedForm(this);
                    terminalPanel.mainForm = this;
                    this.Enabled = this.TopMost = this.Visible = false;
                    terminalPanel.Show();
                    break;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.IsNull(txtUserName, errorProvider, "Kullanıcı Adı") & !TextBoxInputController.IsNull(txtPassword, errorProvider, "Parola")
                & !TextBoxInputController.CheckSpace(txtUserName, errorProvider, "Kullanıcı Adı") & !TextBoxInputController.CheckSpace(txtPassword, errorProvider, "Parola"))
            {
                user = new User();
                string inputUserName = txtUserName.Text.Trim();
                string inputPassword = txtPassword.Text.Trim();
                if (user.CheckAndSetUser(inputUserName, inputPassword))
                {
                    log = new Logs(user);
                    log.ProcessInformation = string.Format("{0} Yetkisine sahip {1} oturum açtı.", user.Authority.ToString(), user.UserName);
                    log.AddLogToDatabase();
                    lblWelcome.Text = string.Format("Hoşgeldiniz\n{0}", txtUserName.Text.ToUpper());
                    txtPassword.Enabled = txtUserName.Enabled = btnSign.Enabled = false;
                    btnSignOut.Visible = btnExam.Enabled = true;
                    this.AcceptButton = btnExam;
                }
                else
                {
                    user.Id = 0;
                    log = new Logs(user);
                    log.ProcessInformation = string.Format("{0} Kullanıcı Adı ve {1} Parola ile giriş denemesi yapıldı.", txtUserName.Text, txtPassword.Text);
                    log.AddLogToDatabase();
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            log = new Logs(user);
            log.ProcessInformation = string.Format("{0} Yetkisine sahip {1} oturum kapattı.", user.Authority.ToString(), user.UserName);
            log.AddLogToDatabase();
            lblWelcome.Text = "Hoşgeldiniz.\nHenüz Giriş Yapılmadı!";
            txtPassword.Enabled = txtUserName.Enabled = btnSign.Enabled = true;
            btnSignOut.Visible = btnExam.Enabled = false;
            txtPassword.Text = "Parola";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.SelectionStart = txtPassword.SelectionLength + 1; txtPassword.SelectionStart = 0;
            this.AcceptButton = btnSign;
            user = new User();
        }
    }
}