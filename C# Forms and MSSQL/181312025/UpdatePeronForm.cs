using _181312025.CreatedClass;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _181312025
{
    public partial class UpdatePeronForm : Form
    {
        public TerminalPanel terminalPanel;
        Peron updatePeron;

        public UpdatePeronForm()
        {
            InitializeComponent();
        }

        private void UpdatePeronForm_Load(object sender, EventArgs e)
        {
            int id = int.Parse(this.Tag.ToString());
            updatePeron = new Peron();
            updatePeron.SetByID(id);
            txtNumber.Text = updatePeron.Number.ToString();
            txtUnitPrice.Text = updatePeron.UnitPrice.ToString();
            txtNumber.ForeColor = txtUnitPrice.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!TextBoxInputController.CheckSpace(txtNumber, errorProvider, "Numara") && !TextBoxInputController.CheckSpace(txtUnitPrice, errorProvider, "Dakika Fiyatı") &&
                !TextBoxInputController.IsNull(txtNumber, errorProvider, "Numara") && !TextBoxInputController.IsNull(txtUnitPrice, errorProvider, "Dakika Fiyatı"))
            {
                bool isDatabaseContainsThisPeron = false;
                SqlDataReader reader = updatePeron.AllPerons;
                if (!updatePeron.Number.Equals(byte.Parse(txtNumber.Text)))
                {
                    if (!txtNumber.Text.Equals(reader["Number"].ToString()))
                    {
                        foreach (var item in reader)
                        {
                            if (txtNumber.Text.Equals(reader["Number"].ToString()))
                            {
                                isDatabaseContainsThisPeron = true;
                                MessageBox.Show("Numara zaten mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numara zaten mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isDatabaseContainsThisPeron = true;
                    }
                }
                else
                    isDatabaseContainsThisPeron = false;
                if (!isDatabaseContainsThisPeron)
                {
                    updatePeron.Number = byte.Parse(txtNumber.Text);
                    updatePeron.UnitPrice = double.Parse(txtUnitPrice.Text);
                    updatePeron.UpdatePeronFromDatabase();
                    terminalPanel.AddPeronsToTable();
                    terminalPanel.Focus();
                    updatePeron.AllPerons = null;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
