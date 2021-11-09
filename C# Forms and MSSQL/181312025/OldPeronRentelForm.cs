using System;
using _181312025.CreatedClass;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025
{
    public partial class OldPeronRentelForm : Form
    {
        public byte peronID;
        PeronRentel rent;
        public OldPeronRentelForm()
        {
            InitializeComponent();
        }
        public void AddPasiveRentToTable()
        {
            listViewActiveRent.Items.Clear();
            SqlDataReader reader = rent.GetPasiveRent();
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
                tmp = (DateTime)reader["ExitTime"];
                rent.ExitTime = tmp;
                item.SubItems.Add(rent.ExitTime.ToString("dd.MM.yyyy HH:mm"));
                rent.Tenancy = (byte)reader["Tenancy"];
                item.SubItems.Add(rent.Tenancy.ToString() + " DK");
                rent.Payment = double.Parse(reader["Payment"].ToString());
                item.SubItems.Add(rent.Payment.ToString() + " TL");
                if (rent.RentedPeron.Id.Equals(peronID))
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
                    tmp = (DateTime)reader["ExitTime"];
                    rent.ExitTime = tmp;
                    item.SubItems.Add(rent.ExitTime.ToString("dd.MM.yyyy HH:mm"));
                    rent.Tenancy = (byte)reader["Tenancy"];
                    item.SubItems.Add(rent.Tenancy.ToString() + " DK");
                    rent.Payment = double.Parse(reader["Payment"].ToString());
                    item.SubItems.Add(rent.Payment.ToString() + " TL");
                    if (rent.RentedPeron.Id.Equals(peronID))
                        listViewActiveRent.Items.Add(item);
                }

            }
            rent.AllRentel = null;
        }
        private void btnBackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OldPeronRentelForm_Load(object sender, EventArgs e)
        {
            rent = new PeronRentel();
            AddPasiveRentToTable();
        }
    }
}
