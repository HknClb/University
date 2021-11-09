using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class CompaniesForm : Form
    {
        public CompaniesForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtCompanyName, "Şirket İsmi");
        }

        public void AddCompaniesToTable()
        {
            Company company = new Company();
            listViewCompanies.Items.Clear();
            SqlDataReader reader = company.AllCompanies;
            if (reader != null)
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Name"].ToString());
                listViewCompanies.Items.Add(item);
                foreach (var i in reader)
                {
                    item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    listViewCompanies.Items.Add(item);
                }
            }
            company.AllCompanies = null;
        }
        private void CompanyiesForm_Load(object sender, EventArgs e)
        {
            AddCompaniesToTable();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.IsNull(txtCompanyName, errorProvider, "Şirket İsmi"))
            {
                Company company = new Company();
                SqlDataReader reader = company.AllCompanies;
                bool isDatabaseContainsThisCompany = false;
                if (!reader["Name"].Equals(txtCompanyName.Text))
                {
                    foreach (var item in reader)
                    {
                        if(reader["Name"].Equals(txtCompanyName.Text))
                        {
                            isDatabaseContainsThisCompany = true;
                            break;
                        }
                    }
                }
                else
                    isDatabaseContainsThisCompany = true;
                if (!isDatabaseContainsThisCompany)
                {
                    company.Name = txtCompanyName.Text;
                    company.AddCompanyToDatabase();
                    AddCompaniesToTable();
                }
                else
                    MessageBox.Show("Şirket Zaten Mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompanyName.Text = "Şirket İsmi";
                txtCompanyName.ForeColor = Color.Gray;
                company.AllCompanies = null;
                txtCompanyName.Focus();
            }
        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            if (listViewCompanies.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewCompanies.SelectedItems[0];
                UpdateCompanyForm updateCompany = new UpdateCompanyForm();
                updateCompany.Tag = item.Text;
                updateCompany.companiesForm = this;
                updateCompany.Show();
            }
            else
                MessageBox.Show("Listeden Şirket Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            if (listViewCompanies.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewCompanies.SelectedItems[0];
                Company deleteCompany = new Company();
                int companyID = int.Parse(item.Text);
                deleteCompany.SetByID(companyID);
                deleteCompany.DeleteCompanyFromDatabase();
                AddCompaniesToTable();
            }
            else
                MessageBox.Show("Listeden Şirket Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAuthorizedPerson_Click(object sender, EventArgs e)
        {
            if (listViewCompanies.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewCompanies.SelectedItems[0];
                AddNewAuthorizedPersonForm newAuthorizedPersonForm = new AddNewAuthorizedPersonForm();
                newAuthorizedPersonForm.companiesForm = this;
                Company company = new Company();
                int companyID = int.Parse(item.Text);
                company.SetByID(companyID);
                newAuthorizedPersonForm.Tag = company;
                newAuthorizedPersonForm.Show();
            }
            else
                MessageBox.Show("Listeden Şirket Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnListAuthorizedPerson_Click(object sender, EventArgs e)
        {
            if (listViewCompanies.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewCompanies.SelectedItems[0];
                CompanyAuthorizedPersonsForm form = new CompanyAuthorizedPersonsForm();
                Company company = new Company();
                int companyID = int.Parse(item.Text);
                company.SetByID(companyID);
                form.Tag = company;
                form.Show();
            }
            else
                MessageBox.Show("Listeden Şirket Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
