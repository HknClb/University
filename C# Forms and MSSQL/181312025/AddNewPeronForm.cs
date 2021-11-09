using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _181312025
{
    public partial class AddNewPeronForm : Form
    {
        public TerminalPanel terminalPanel;
        public AddNewPeronForm()
        {
            InitializeComponent();
        }

        private void AddNewPeronForm_Load(object sender, EventArgs e)
        {
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtNumber, "Numara");
            TextBoxHintAndOnlyNumber.HintAndOnlyNumber(txtUnitPrice, "Dakika Fiyatı");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.CheckSpace(txtNumber, errorProvider, "Numara") && !TextBoxInputController.CheckSpace(txtUnitPrice, errorProvider, "Dakika Fiyatı")
                && !TextBoxInputController.IsNull(txtNumber, errorProvider, "Numara") && !TextBoxInputController.IsNull(txtUnitPrice, errorProvider, "Dakika Fiyatı"))
            {
                bool isDatabaseContainsThisPeron = false;
                Peron newPeron = new Peron();
                SqlDataReader reader = newPeron.AllPerons;
                if (reader != null)
                {
                    if (!txtNumber.Text.Equals(reader["Number"].ToString()))
                    {
                        foreach (var item in reader)
                        {
                            if (txtNumber.Text.Equals(reader["Number"].ToString()))
                            {
                                isDatabaseContainsThisPeron = true;
                                MessageBox.Show("Peron Önceden Tanımlanmış!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Peron Önceden Tanımlanmış!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isDatabaseContainsThisPeron = true;
                    }
                }
                else
                    isDatabaseContainsThisPeron = false;
                if (!isDatabaseContainsThisPeron)
                {
                    newPeron.Number = byte.Parse(txtNumber.Text);
                    newPeron.UnitPrice = double.Parse(txtUnitPrice.Text);
                    newPeron.AddPeronToDatabase();
                    terminalPanel.AddPeronsToTable();
                    terminalPanel.Focus();
                    newPeron.AllPerons = null;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            terminalPanel.Focus();
            this.Close();
        }
    }
}
