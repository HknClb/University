using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class DriversForm : Form
    {
        public TerminalPanel terminalPanel;
        bool onUpdate;
        Company company;
        Driver driver;
        public DriversForm()
        {
            InitializeComponent();
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtIdentity, "Kimlik No");
            TextBoxHintEvent.Hint(txtName, "İsim");
            TextBoxHintEvent.Hint(txtSurname, "Soyisim");
            TextBoxHintEvent.Hint(txtAddress, "Adres");
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtPhone, "Telefon");
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtRelativePhone, "Yakın Telefon");
            TextBoxHintEvent.Hint(txtRelativeName, "Yakın İsim");
            TextBoxHintEvent.Hint(txtRelativeSurname, "Yakın Soyisim");
            onUpdate = false;
        }
        public void AddDriversToTable()
        {
            listViewDrivers.Items.Clear();
            SqlDataReader readerDrivers = driver.AllDrivers;
            SqlDataReader readerRelatives = driver.Contact.AllContact;
            if (readerDrivers != null)
            {
                ListViewItem item = new ListViewItem(readerDrivers["Identity"].ToString());
                item.SubItems.Add(readerDrivers["Name"].ToString());
                item.SubItems.Add(readerDrivers["Surname"].ToString());
                DateTime tmp = (DateTime)readerDrivers["BirthDate"];
                item.SubItems.Add(tmp.ToString("yyyy.MM.dd"));
                company.SetByID(int.Parse(readerDrivers["CompanyID"].ToString()));
                item.SubItems.Add(company.Name);
                item.SubItems.Add(readerRelatives["Address"].ToString());
                item.SubItems.Add(readerRelatives["PhoneNumber"].ToString());
                item.SubItems.Add(readerRelatives["RelativePhoneNumber"].ToString());
                item.SubItems.Add(readerRelatives["RelativeName"].ToString());
                item.SubItems.Add(readerRelatives["RelativeSurname"].ToString());
                listViewDrivers.Items.Add(item);
                foreach (var i in readerDrivers)
                {
                    item = new ListViewItem(readerDrivers["Identity"].ToString());
                    item.SubItems.Add(readerDrivers["Name"].ToString());
                    item.SubItems.Add(readerDrivers["Surname"].ToString());
                    tmp = (DateTime)readerDrivers["BirthDate"];
                    item.SubItems.Add(tmp.ToString("yyyy.MM.dd"));
                    company.SetByID(int.Parse(readerDrivers["CompanyID"].ToString()));
                    item.SubItems.Add(company.Name);
                    item.SubItems.Add(readerRelatives["Address"].ToString());
                    item.SubItems.Add(readerRelatives["PhoneNumber"].ToString());
                    item.SubItems.Add(readerRelatives["RelativePhoneNumber"].ToString());
                    item.SubItems.Add(readerRelatives["RelativeName"].ToString());
                    item.SubItems.Add(readerRelatives["RelativeSurname"].ToString());
                    listViewDrivers.Items.Add(item);
                    readerRelatives.NextResult();
                }

            }
            driver.AllDrivers = null;
            readerDrivers = company.AllCompanies;
            cmbCompany.Items.Clear();
            cmbCompany.Items.Add(readerDrivers["Name"]);
            foreach (var item in readerDrivers)
                cmbCompany.Items.Add(readerDrivers["Name"]);
            company.AllCompanies = null;
            cmbCompany.SelectedIndex = 0;
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            driver = new Driver(); company = new Company();
            AddDriversToTable();
            driver = null;
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            terminalPanel.Focus();
            this.Close();
        }

        private void btnAddOrSaveDriver_Click(object sender, EventArgs e)
        {
            if (!onUpdate)
                driver = new Driver();
            if (!TextBoxInputController.IsNull(txtIdentity, errorProvider, "Identity") && !TextBoxInputController.IsNull(txtName, errorProvider, "İsim") &&
                !TextBoxInputController.IsNull(txtSurname, errorProvider, "Soyisim") && !TextBoxInputController.IsNull(txtAddress, errorProvider, "Adres") &&
                !TextBoxInputController.IsNull(txtPhone, errorProvider, "Telefon") && !TextBoxInputController.IsNull(txtRelativePhone, errorProvider, "Yakın Telefon") &&
                !TextBoxInputController.IsNull(txtRelativeName, errorProvider, "Yakın İsim") && !TextBoxInputController.IsNull(txtRelativeSurname, errorProvider, "Yakın Soyisim"))
            {
                driver.Identity = txtIdentity.Text;
                driver.Name = txtName.Text;
                driver.Surname = txtSurname.Text;
                driver.BirthDate = dtpBirthDate.Value;
                driver.Contact.Address = txtAddress.Text;
                driver.Contact.PhoneNumber = txtPhone.Text;
                driver.Contact.RelativeName = txtRelativeName.Text;
                driver.Contact.RelativeSurname = txtRelativeSurname.Text;
                driver.Contact.RelativePhoneNumber = txtRelativePhone.Text;
                company = new Company();
                SqlDataReader reader = company.AllCompanies;
                if (!reader["Name"].Equals(cmbCompany.SelectedItem))
                {
                    foreach (var item in reader)
                    {
                        if (reader["Name"].Equals(cmbCompany.SelectedItem))
                        {
                            company.Id = (int)reader["ID"];
                            break;
                        }
                    }
                }
                else
                    company.Id = (int)reader["ID"];
                company.SetByID(company.Id);
                driver.Company = company;
                if (onUpdate && driver.UpdateDriverFromDatabase())
                {
                    onUpdate = false;
                    AddDriversToTable();
                    txtName.Clear(); txtSurname.Clear(); txtRelativeSurname.Clear(); txtRelativePhone.Clear();txtRelativeName.Clear(); txtPhone.Clear();
                    txtIdentity.Clear(); txtAddress.Clear(); dtpBirthDate.Value = DateTime.Now;
                    txtSurname.Focus(); txtRelativeSurname.Focus(); txtRelativePhone.Focus(); txtRelativeName.Focus(); txtPhone.Focus();
                    txtIdentity.Focus(); txtAddress.Focus(); txtName.Focus(); btnAddOrSaveDriver.Focus(); txtIdentity.Focus();
                }
                else if (driver.AddDriverToDatabase())
                {
                    AddDriversToTable();
                    txtName.Clear(); txtSurname.Clear(); txtRelativeSurname.Clear(); txtRelativePhone.Clear(); txtRelativeName.Clear(); txtPhone.Clear();
                    txtIdentity.Clear(); txtAddress.Clear(); dtpBirthDate.Value = DateTime.Now;
                    txtName.Focus(); txtSurname.Focus(); txtRelativeSurname.Focus(); txtRelativePhone.Focus(); txtRelativeName.Focus(); txtPhone.Focus();
                    txtIdentity.Focus(); txtAddress.Focus(); btnAddOrSaveDriver.Focus(); txtIdentity.Focus();
                }
                company.AllCompanies = null;
            }
        }

        private void btnUpdateDriver_Click(object sender, EventArgs e)
        {
            if (listViewDrivers.SelectedItems.Count != 0)
            {
                onUpdate = true;
                ListViewItem item = listViewDrivers.SelectedItems[0];
                driver = new Driver();
                driver.SetByIdentity(item.Text);
                txtIdentity.Text = driver.Identity;
                txtName.Text = driver.Name;
                txtSurname.Text = driver.Surname;
                dtpBirthDate.Value = driver.BirthDate;
                txtAddress.Text = driver.Contact.Address;
                txtPhone.Text = driver.Contact.PhoneNumber;
                txtRelativeName.Text = driver.Contact.RelativeName;
                txtRelativeSurname.Text = driver.Contact.RelativeSurname;
                txtRelativePhone.Text = driver.Contact.RelativePhoneNumber;
                txtAddress.ForeColor = txtIdentity.ForeColor = txtName.ForeColor = txtPhone.ForeColor = txtRelativeName.ForeColor = txtRelativePhone.ForeColor =
                    txtRelativeSurname.ForeColor = txtSurname.ForeColor = Color.Black;
            }
            else
                MessageBox.Show("Listeden Sürücü Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (listViewDrivers.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewDrivers.SelectedItems[0];
                driver = new Driver();
                driver.SetByIdentity(item.Text);
                driver.DeleteDriverFromDatabase();
                AddDriversToTable();
            }
            else
                MessageBox.Show("Listeden Sürücü Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
