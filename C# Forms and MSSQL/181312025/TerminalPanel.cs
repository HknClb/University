using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025
{
    public partial class TerminalPanel : Form
    {
        public MainForm mainForm;
        User user;
        public TerminalPanel()
        {
            InitializeComponent();
        }

        public void AddPeronsToTable()
        {
            Peron peron = new Peron();
            listViewPerons.Items.Clear();
            user = this.Tag as User;
            SqlDataReader reader = peron.AllPerons;
            if (reader != null)
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["Number"].ToString());
                item.SubItems.Add(reader["UnitPrice"].ToString());
                listViewPerons.Items.Add(item);
                foreach (var i in reader)
                {
                    item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["Number"].ToString());
                    item.SubItems.Add(reader["UnitPrice"].ToString());
                    listViewPerons.Items.Add(item);
                }
            }
            peron.AllPerons = null;
        }

        private void TerminalPanel_Load(object sender, EventArgs e)
        {
            AddPeronsToTable();
        }

        private void btnAddPeron_Click(object sender, EventArgs e)
        {
            AddNewPeronForm addNewPeron = new AddNewPeronForm();
            addNewPeron.terminalPanel = this;
            addNewPeron.Show();
        }

        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.RemoveOwnedForm(mainForm);
            mainForm.Enabled = mainForm.TopMost = mainForm.Visible = true;
            this.Close();
        }

        private void btnUpdatePeron_Click(object sender, EventArgs e)
        {
            if (listViewPerons.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewPerons.SelectedItems[0];
                UpdatePeronForm updatePeron = new UpdatePeronForm();
                updatePeron.terminalPanel = this;
                updatePeron.Tag = item.Text;
                updatePeron.Show();
            }
            else
                MessageBox.Show("Listeden Peron Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeletePeron_Click(object sender, EventArgs e)
        {
            if (listViewPerons.SelectedItems.Count != 0)
            {
                ListViewItem item = listViewPerons.SelectedItems[0];
                Peron deletingPeron = new Peron();
                deletingPeron.SetByID(int.Parse(item.Text));
                deletingPeron.DeletePeronFromDatabase();
                AddPeronsToTable();
            }
            else
                MessageBox.Show("Listeden Peron Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGoCompany_Click(object sender, EventArgs e)
        {
            CompaniesForm companiesForm = new CompaniesForm();
            companiesForm.Show();
        }

        private void btnGoBuses_Click(object sender, EventArgs e)
        {
            BusesForm form = new BusesForm();
            form.terminalPanel = this;
            form.Show();
        }

        private void btnGoDrivers_Click(object sender, EventArgs e)
        {
            DriversForm form = new DriversForm();
            form.terminalPanel = this;
            form.Show();
        }

        private void btnRentPeron_Click(object sender, EventArgs e)
        {
            if (listViewPerons.SelectedItems.Count != 0)
            {
                PeronRentForm form = new PeronRentForm();
                form.peronID = byte.Parse(listViewPerons.SelectedItems[0].Text);
                form.terminalPanel = this;
                form.Show();
            }
            else
                MessageBox.Show("Listeden Peron Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}