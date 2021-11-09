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
    public partial class CompanyAuthorizedPersonsForm : Form
    {
        Company company;
        public CompanyAuthorizedPersonsForm()
        {
            InitializeComponent();
        }

        public void AddAuthorizedPersonsToTable()
        {
            listViewAuthorizedPersons.Items.Clear();
            CompanyAuthorizedPerson person = new CompanyAuthorizedPerson();
            company = this.Tag as Company;
            SqlDataReader reader = person.AllAuthorizedPerson;
            if (reader != null)
            {
                ListViewItem item;
                if (reader["CompanyID"].Equals(company.Id))
                {
                    item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["AuthorizedPersonName"].ToString());
                    item.SubItems.Add(reader["AuthorizedPersonSurname"].ToString());
                    item.SubItems.Add(reader["AuthorizedPersonPhoneNumber"].ToString());
                    listViewAuthorizedPersons.Items.Add(item);
                }
                lblCompanyName.Text = company.Name;
                foreach (var i in reader)
                { 
                    if (reader["CompanyID"].Equals(company.Id))
                    {
                        item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["AuthorizedPersonName"].ToString());
                        item.SubItems.Add(reader["AuthorizedPersonSurname"].ToString());
                        item.SubItems.Add(reader["AuthorizedPersonPhoneNumber"].ToString());
                        listViewAuthorizedPersons.Items.Add(item);
                    }
                }
            }
            person.AllAuthorizedPerson = null;
        }

        private void CompanyAuthorizedPersonsForm_Load(object sender, EventArgs e)
        {
            AddAuthorizedPersonsToTable();
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            if(listViewAuthorizedPersons.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewAuthorizedPersons.SelectedItems[0];
                CompanyAuthorizedPerson person = new CompanyAuthorizedPerson();
                person.SetByID(int.Parse(item.Text));
                UpdateAuthorizedPersonForm form = new UpdateAuthorizedPersonForm();
                form.Tag = person;
                form.personForm = this;
                form.Show();
            }
            else
                MessageBox.Show("Listeden Yetkili Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            if (listViewAuthorizedPersons.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewAuthorizedPersons.SelectedItems[0];
                CompanyAuthorizedPerson person = new CompanyAuthorizedPerson();
                person.SetByID(int.Parse(item.Text));
                person.DeleteAuthorizedPersonFromDatabase();
                AddAuthorizedPersonsToTable();
            }
            else
                MessageBox.Show("Listeden Yetkili Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
