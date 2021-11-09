using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class BusesForm : Form
    {
        public TerminalPanel terminalPanel;
        Company company;
        Bus bus;
        bool onUpdate;
        public BusesForm()
        {
            InitializeComponent();
            TextBoxHintEvent.Hint(txtPlate, "Plaka");
            TextBoxHintEvent.Hint(txtMark, "Marka");
            TextBoxHintEvent.Hint(txtModel, "Model");
            onUpdate = false;
        }

        public void AddBusesToTable()
        {
            listViewBuses.Items.Clear();
            SqlDataReader reader = bus.AllBuses;
            if (reader != null)
            {
                ListViewItem item = new ListViewItem(reader["Plate"].ToString());
                item.SubItems.Add(reader["Mark"].ToString());
                item.SubItems.Add(reader["Model"].ToString());
                DateTime tmp = (DateTime)reader["YearOfProduction"];
                item.SubItems.Add(tmp.ToString("yyyy.MM.dd"));
                company.SetByID(int.Parse(reader["CompanyID"].ToString()));
                item.SubItems.Add(company.Name);
                listViewBuses.Items.Add(item);
                foreach (var i in reader)
                {
                    item = new ListViewItem(reader["Plate"].ToString());
                    item.SubItems.Add(reader["Mark"].ToString());
                    item.SubItems.Add(reader["Model"].ToString());
                    tmp = (DateTime)reader["YearOfProduction"];
                    item.SubItems.Add(tmp.ToString("yyyy.MM.dd"));
                    company.SetByID(int.Parse(reader["CompanyID"].ToString()));
                    item.SubItems.Add(company.Name);
                    listViewBuses.Items.Add(item);
                }

            }
            bus.AllBuses = null;
            reader = company.AllCompanies;
            cmbCompany.Items.Clear();
            cmbCompany.Items.Add(reader["Name"]);
            foreach (var item in reader)
                cmbCompany.Items.Add(reader["Name"]);
            company.AllCompanies = null;
            cmbCompany.SelectedIndex = 0;
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            terminalPanel.Focus();
            this.Close();
        }

        private void BusesForm_Load(object sender, EventArgs e)
        {
            company = new Company(); bus = new Bus();
            AddBusesToTable();
            bus = null;
        }

        private void btnAddOrSaveBus_Click(object sender, EventArgs e)
        {
            if (!onUpdate)
                bus = new Bus();
            if(!TextBoxInputController.IsNull(txtPlate, errorProvider, "Plaka") && !TextBoxInputController.CheckSpace(txtPlate, errorProvider, "Plaka") && 
                !TextBoxInputController.IsNull(txtMark, errorProvider, "Marka") && !TextBoxInputController.IsNull(txtModel, errorProvider, "Model"))
                {
                bool isDatabaseContainsThisBus = false;
                if (bus.Plate != null && !bus.Plate.Equals(txtPlate.Text))
                {
                    SqlDataReader reader = bus.AllBuses;
                    if (!txtPlate.Text.Equals(reader["Plate"]))
                    {
                        foreach (var item in reader)
                        {
                            if (txtPlate.Text.Equals(reader["Plate"]))
                            {
                                isDatabaseContainsThisBus = true;
                                break;
                            }
                        }
                    }
                    else
                        isDatabaseContainsThisBus = true;
                    bus.AllBuses = null;
                }
                else
                    isDatabaseContainsThisBus = false;
                if (!isDatabaseContainsThisBus)
                {
                    bus.Plate = txtPlate.Text;
                    bus.Mark = txtMark.Text;
                    bus.Model = txtModel.Text;
                    bus.YearOfProduction = dtpProductYear.Value;
                    company = new Company();
                    SqlDataReader reader = company.AllCompanies;
                    if(!reader["Name"].Equals(cmbCompany.SelectedItem))
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
                    bus.OwnedCompany = company;
                    if (onUpdate && bus.UpdateBusFromDatabase())   
                    {
                        onUpdate = false;
                        AddBusesToTable();
                        txtPlate.Clear(); txtMark.Clear(); txtModel.Clear(); dtpProductYear.Value = DateTime.Now;
                        txtMark.Focus(); txtModel.Focus(); txtPlate.Focus(); btnAddOrSaveBus.Focus(); txtPlate.Focus();
                    }
                    else if(bus.AddBusToDatabase())
                    {
                        AddBusesToTable();
                        txtPlate.Clear(); txtMark.Clear(); txtModel.Clear(); dtpProductYear.Value = DateTime.Now;
                        txtMark.Focus(); txtModel.Focus(); txtPlate.Focus(); btnAddOrSaveBus.Focus(); txtPlate.Focus();
                    }
                    company.AllCompanies = null;
                }
                else
                    MessageBox.Show("Plaka Zaten Mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            if(listViewBuses.SelectedItems.Count != 0)
            {
                onUpdate = true;
                ListViewItem item = listViewBuses.SelectedItems[0];
                bus = new Bus();
                bus.SetByPlate(item.Text);
                txtPlate.Text = bus.Plate;
                txtMark.Text = bus.Mark;
                txtModel.Text = bus.Model;
                dtpProductYear.Value = bus.YearOfProduction;
                cmbCompany.SelectedItem = bus.OwnedCompany.Name;
                txtPlate.ForeColor = txtModel.ForeColor = txtMark.ForeColor = Color.Black;
            }
            else
                MessageBox.Show("Listeden Otobüs Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (listViewBuses.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewBuses.SelectedItems[0];
                bus = new Bus();
                bus.SetByPlate(item.Text);
                bus.DeleteBusFromDatabase();
                AddBusesToTable();
            }
            else
                MessageBox.Show("Listeden Otobüs Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
