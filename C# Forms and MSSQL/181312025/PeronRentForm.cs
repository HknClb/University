using _181312025.CreatedClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025
{
    public partial class PeronRentForm : Form
    {
        public TerminalPanel terminalPanel;
        public byte peronID;
        PeronRentel rent;
        bool onUpdate = false;
        public PeronRentForm()
        {
            InitializeComponent();
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtTenancy, "Kira Süresi");
        }
        public void AddActiveRentToTable()
        {
            listViewActiveRent.Items.Clear();
            SqlDataReader reader = rent.GetActiveRent();
            if (reader != null)
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                rent.RentedPeron.SetByID((int)reader["PeronID"]);
                rent.Bus.SetByPlate((string)reader["BusPlate"]);
                rent.BusDriver.SetByIdentity((string)reader["DriverIdentity"]);
                rent.Company.SetByID((int)reader["CompanyID"]);
                item.SubItems.Add(rent.RentedPeron.Number.ToString());
                item.SubItems.Add(rent.Bus.Plate);
                item.SubItems.Add(rent.BusDriver.Identity);
                item.SubItems.Add(rent.Company.Name);
                DateTime tmp = (DateTime)reader["EnterTime"];
                rent.EnterTime = tmp;
                item.SubItems.Add(rent.EnterTime.ToString("dd.MM.yyyy HH:mm"));
                rent.Tenancy = (byte)reader["Tenancy"];
                item.SubItems.Add(rent.Tenancy.ToString() + " DK");
                rent.Payment = double.Parse(reader["Payment"].ToString());
                item.SubItems.Add(rent.Payment.ToString() + " TL");
                if(rent.RentedPeron.Id.Equals(peronID))
                    listViewActiveRent.Items.Add(item);
                foreach (var i in reader)
                {
                    item = new ListViewItem(reader["ID"].ToString());
                    rent.RentedPeron.SetByID((int)reader["PeronID"]);
                    rent.Bus.SetByPlate((string)reader["BusPlate"]);
                    rent.BusDriver.SetByIdentity((string)reader["DriverIdentity"]);
                    rent.Company.SetByID((int)reader["CompanyID"]);
                    item.SubItems.Add(rent.RentedPeron.Number.ToString());
                    item.SubItems.Add(rent.Bus.Plate);
                    item.SubItems.Add(rent.BusDriver.Identity);
                    item.SubItems.Add(rent.Company.Name);
                    tmp = (DateTime)reader["EnterTime"];
                    rent.EnterTime = tmp;
                    item.SubItems.Add(rent.EnterTime.ToString("dd.MM.yyyy HH:mm"));
                    rent.Tenancy = (byte)reader["Tenancy"];
                    item.SubItems.Add(rent.Tenancy.ToString() + " DK");
                    rent.Payment = double.Parse(reader["Payment"].ToString());
                    item.SubItems.Add(rent.Payment.ToString() + " TL");
                    if (rent.RentedPeron.Id.Equals(peronID))
                        listViewActiveRent.Items.Add(item);
                }

            }
            rent.AllRentel = null;
            rent.Company = new Company();
            rent.BusDriver = new Driver();
            rent.Bus = new Bus();
            rent.RentedPeron = new Peron();
            reader = rent.Company.AllCompanies;
            cmbCompany.Items.Clear();
            cmbCompany.Items.Add(reader["Name"]);
            foreach (var item in reader)
                cmbCompany.Items.Add(reader["Name"]);
            rent.Company.AllCompanies = null;
            cmbCompany.SelectedIndex = 0;
            reader = rent.RentedPeron.AllPerons;
            cmbPeron.Items.Clear();
            cmbPeron.Items.Add(reader["Number"].ToString());
            foreach (var item in reader)
                cmbPeron.Items.Add(reader["Number"].ToString());
            rent.RentedPeron.AllPerons = null;
            cmbPeron.SelectedIndex = 0;
            reader = rent.Bus.AllBuses;
            cmbBus.Items.Clear();
            cmbBus.Items.Add((string)reader["Plate"]);
            foreach (var item in reader)
                cmbBus.Items.Add((string)reader["Plate"]);
            rent.Bus.AllBuses = null;
            cmbBus.SelectedIndex = 0;
            reader = rent.BusDriver.AllDrivers;
            cmbDriver.Items.Clear();
            cmbDriver.Items.Add((string)reader["Identity"]);
            foreach (var item in reader)
                cmbDriver.Items.Add((string)reader["Identity"]);
            rent.BusDriver.AllDrivers = null;
            cmbDriver.SelectedIndex = 0;
        }

        private void PeronRentForm_Load(object sender, EventArgs e)
        {
            rent = new PeronRentel();
            AddActiveRentToTable();
            dtpEnterTime.CustomFormat = "dd.MM.yyyy HH:mm";
            rent = null;
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            terminalPanel.Focus();
            this.Close();
        }

        private void btnAddOrSaveRent_Click(object sender, EventArgs e)
        {
            if (!onUpdate)
                rent = new PeronRentel();
            if (!TextBoxInputController.IsNull(txtTenancy, errorProvider, "Kira Süresi") && !TextBoxInputController.CheckSpace(txtTenancy, errorProvider, "Kira Süresi"))
            {
                rent.RentedPeron.SetByNumber(byte.Parse(cmbPeron.Text));
                rent.Company.SetByName(cmbCompany.Text);
                rent.Bus.SetByPlate(cmbBus.Text);
                rent.BusDriver.SetByIdentity(cmbDriver.Text);
                rent.EnterTime = dtpEnterTime.Value;
                rent.Tenancy = byte.Parse(txtTenancy.Text);
                rent.Payment = int.Parse(txtTenancy.Text) * rent.RentedPeron.UnitPrice;
                if (onUpdate && rent.UpdatePeronRentelFromDatabase())
                {
                    onUpdate = false;
                    AddActiveRentToTable();
                    cmbBus.SelectedIndex = cmbCompany.SelectedIndex = cmbDriver.SelectedIndex = cmbPeron.SelectedIndex = 0; dtpEnterTime.Value = DateTime.Now; txtTenancy.Clear();
                    txtTenancy.Focus();
                    cmbPeron.Focus();
                }
                else if (rent.AddPeronRentelToDatabase())
                {
                    AddActiveRentToTable();
                    cmbBus.SelectedIndex = cmbCompany.SelectedIndex = cmbDriver.SelectedIndex = cmbPeron.SelectedIndex = 0; dtpEnterTime.Value = DateTime.Now; txtTenancy.Clear();
                    txtTenancy.Focus();
                    cmbPeron.Focus();
                }
            }
        }

        private void btnUpdateRent_Click(object sender, EventArgs e)
        {
            if (listViewActiveRent.SelectedItems.Count != 0)
            {
                onUpdate = true;
                ListViewItem item = listViewActiveRent.SelectedItems[0];
                rent = new PeronRentel();
                rent.SetByID(int.Parse(item.Text));
                cmbBus.SelectedItem = rent.Bus.Plate;
                cmbCompany.SelectedItem = rent.Company.Name;
                cmbDriver.SelectedItem = rent.BusDriver.Identity;
                cmbPeron.SelectedItem = rent.RentedPeron;
            }
            else
                MessageBox.Show("Listeden İşlem Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteRent_Click(object sender, EventArgs e)
        {
            if (listViewActiveRent.SelectedItems.Count != 0)
            {
                onUpdate = true;
                ListViewItem item = listViewActiveRent.SelectedItems[0];
                rent = new PeronRentel();
                rent.SetByID(int.Parse(item.Text));
                rent.DeletePeronRentelFromDatabase();
                AddActiveRentToTable();
            }
            else
                MessageBox.Show("Listeden İşlem Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (listViewActiveRent.SelectedItems.Count != 0)
            {
                onUpdate = true;
                ListViewItem item = listViewActiveRent.SelectedItems[0];
                rent = new PeronRentel();
                rent.SetByID(int.Parse(item.Text));
                rent.ExitBus();
                if(DateTime.Compare(rent.EnterTime.AddMinutes(double.Parse(rent.Tenancy.ToString())), rent.ExitTime) < 0)
                {
                    rent.Payment = (rent.RentedPeron.UnitPrice * rent.ExitTime.Subtract(rent.EnterTime).Minutes) + 10;
                    rent.UpdatePeronRentelFromDatabase();
                    MessageBox.Show("Bekleme süresi aşıldığı için ceza olarak 10 TL ve bekleme parası kesilmiştir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AddActiveRentToTable();
            }
            else
                MessageBox.Show("Listeden İşlem Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOldRentelPeron_Click(object sender, EventArgs e)
        {
            OldPeronRentelForm form = new OldPeronRentelForm();
            form.peronID = peronID;
            form.Show();
        }
    }
}
