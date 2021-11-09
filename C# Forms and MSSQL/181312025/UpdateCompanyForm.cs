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
    public partial class UpdateCompanyForm : Form
    {
        public CompaniesForm companiesForm;
        Company updateCompany;
        public UpdateCompanyForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtCompanyName, "Şirket İsmi");
        }

        private void UpdateCompanyForm_Load(object sender, EventArgs e)
        {
            updateCompany = new Company();
            updateCompany.SetByID(int.Parse(this.Tag.ToString()));
            txtCompanyName.Text = updateCompany.Name;
            txtCompanyName.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.IsNull(txtCompanyName, errorProvider, "Şirket İsmi"))
            {
                SqlDataReader reader = updateCompany.AllCompanies;
                bool isDatabaseContainsThisCompany = false;
                if (!updateCompany.Name.Equals(txtCompanyName.Text))
                {
                    if (!reader["Name"].Equals(txtCompanyName.Text))
                    {
                        foreach (var item in reader)
                        {
                            if (reader["Name"].Equals(txtCompanyName.Text))
                            {
                                isDatabaseContainsThisCompany = true;
                                break;
                            }
                        }
                    }
                    else
                        isDatabaseContainsThisCompany = true;
                }
                else
                    isDatabaseContainsThisCompany = false;
                if (!isDatabaseContainsThisCompany)
                {
                    updateCompany.Name = txtCompanyName.Text;
                    updateCompany.UpdateCompanyFromDatabase();
                    companiesForm.AddCompaniesToTable();
                    companiesForm.Focus();
                    updateCompany.AllCompanies = null;
                    this.Close();
                }
                else
                    MessageBox.Show("Şirket Zaten Mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateCompany.AllCompanies = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            companiesForm.Focus();
            this.Close();
        }
    }
}
