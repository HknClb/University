using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class UpdateAuthorizedPersonForm : Form
    {
        public CompanyAuthorizedPersonsForm personForm;
        CompanyAuthorizedPerson person;
        public UpdateAuthorizedPersonForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtName, "Yetkili İsim");
            TextBoxHintEvent.Hint(txtSurname, "Yetkili Soyisim");
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtPhone, "Telefon");
        }

        private void UpdateAuthorizedPersonForm_Load(object sender, EventArgs e)
        {
            person = this.Tag as CompanyAuthorizedPerson;
            txtName.ForeColor = txtSurname.ForeColor = txtPhone.ForeColor = Color.Black;
            txtName.Text = person.AuthorizedPersonName;
            txtSurname.Text = person.AuthorizedPersonSurname;
            txtPhone.Text = person.AuthorizedPersonPhoneNumber;
            lblCompanyName.Text = person.Company.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!TextBoxInputController.IsNull(txtName, errorProvider, "Yetkili İsim") && !TextBoxInputController.IsNull(txtSurname, errorProvider, "Yetkili Soyisim") &&
                !TextBoxInputController.IsNull(txtPhone, errorProvider, "Telefon") && !TextBoxInputController.CheckSpace(txtPhone, errorProvider, "Telefon"))
            {
                bool isDatabaseContainsThisPerson = false;
                if (!txtPhone.Text.Equals(person.AuthorizedPersonPhoneNumber))
                {
                    SqlDataReader reader = person.AllAuthorizedPerson;
                    if (!reader["AuthorizedPersonPhoneNumber"].Equals(txtPhone.Text))
                    {
                        foreach (var item in reader)
                        {
                            if (reader["AuthorizedPersonPhoneNumber"].Equals(txtPhone.Text))
                            {
                                isDatabaseContainsThisPerson = true;
                                break;
                            }
                        }
                    }
                    else
                        isDatabaseContainsThisPerson = true;
                }
                else
                    isDatabaseContainsThisPerson = false;
                if(!isDatabaseContainsThisPerson)
                {
                    person.AuthorizedPersonName = txtName.Text;
                    person.AuthorizedPersonSurname = txtSurname.Text;
                    person.AuthorizedPersonPhoneNumber = txtPhone.Text;
                    person.UpdateAuthorizedPersonFromDatabase();
                    personForm.AddAuthorizedPersonsToTable();
                    personForm.Focus();
                    person.AllAuthorizedPerson = null;
                    this.Close();
                }
                else
                    MessageBox.Show("Telefon Zaten Mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                person.AllAuthorizedPerson = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            personForm.Focus();
            this.Close();
        }
    }
}
