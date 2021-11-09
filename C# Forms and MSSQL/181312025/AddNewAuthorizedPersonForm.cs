using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025
{
    public partial class AddNewAuthorizedPersonForm : Form
    {
        public CompaniesForm companiesForm;
        CompanyAuthorizedPerson addPerson;
        public AddNewAuthorizedPersonForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtName, "Yetkili İsim");
            TextBoxHintEvent.Hint(txtSurname, "Yetkili Soyisim");
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtPhone, "Telefon");
        }

        private void AddNewAuthorizedPersonForm_Load(object sender, EventArgs e)
        {
            addPerson = new CompanyAuthorizedPerson();
            addPerson.Company = this.Tag as Company;
            lblCompanyName.Text = "Şirket: " + addPerson.Company.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!TextBoxInputController.CheckSpace(txtName, errorProvider, "Yetkili İsim") && !TextBoxInputController.IsNull(txtName, errorProvider, "Tekili İsim") &&
                !TextBoxInputController.CheckSpace(txtSurname, errorProvider, "Yetkili Soyisim") && !TextBoxInputController.IsNull(txtSurname, errorProvider, "Tekili Soyisim") &&
                !TextBoxInputController.CheckSpace(txtPhone, errorProvider, "Telefon") && !TextBoxInputController.IsNull(txtPhone, errorProvider, "Telefon"))
            {
                bool isDatabaseContainsThisPerson = false;
                SqlDataReader reader = addPerson.AllAuthorizedPerson;
                if (reader != null)
                {
                    if (!txtPhone.Text.Equals(reader["AuthorizedPersonPhoneNumber"].ToString()))
                    {
                        foreach (var item in reader)
                        {
                            if (txtPhone.Text.Equals(reader["AuthorizedPersonPhoneNumber"].ToString()))
                            {
                                isDatabaseContainsThisPerson = true;
                                MessageBox.Show("Telefon Numarası Önceden Kullanılmış", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telefon Numarası Önceden Kullanılmış", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isDatabaseContainsThisPerson = true;
                    }
                }
                else
                    isDatabaseContainsThisPerson = false;
                if (!isDatabaseContainsThisPerson)
                {
                    addPerson.AuthorizedPersonName = txtName.Text;
                    addPerson.AuthorizedPersonSurname = txtSurname.Text;
                    addPerson.AuthorizedPersonPhoneNumber = txtPhone.Text;
                    addPerson.AddAuthorizedPersonToDatabase();
                    companiesForm.AddCompaniesToTable();
                    companiesForm.Focus();
                    addPerson.AllAuthorizedPerson = null;
                    this.Close();
                }
                addPerson.AllAuthorizedPerson = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
