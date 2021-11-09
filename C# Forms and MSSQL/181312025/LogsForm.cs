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
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            Logs log = new Logs(this.Tag as User);
            SqlDataReader reader = log.AllLogs;
            int temple;
            listViewLogs.Width = this.Width - (btnBack.Width * 2);
            listViewLogs.Height = this.Height - 100;
            temple = (listViewLogs.Width - 153) / 2;
            foreach (ColumnHeader column in listViewLogs.Columns)
                column.Width = temple;
            listViewLogs.Columns[0].Width = 50;
            listViewLogs.Columns[1].Width = 100;
            btnBack.Location = new Point(this.Width - btnBack.Width - 25, listViewLogs.Location.Y);
            ListViewItem item = new ListViewItem(reader["ID"].ToString());
            item.SubItems.Add(reader["UserID"].ToString());
            item.SubItems.Add(reader["ProcessInformation"].ToString());
            item.SubItems.Add(reader["ProcessTime"].ToString().ToString());
            listViewLogs.Items.Add(item);
            foreach (var logReader in reader)
            {
                item = new ListViewItem(reader["ID"].ToString());
                item.SubItems.Add(reader["UserID"].ToString().ToString());
                item.SubItems.Add(reader["ProcessInformation"].ToString());
                item.SubItems.Add(reader["ProcessTime"].ToString().ToString());
                listViewLogs.Items.Add(item);
            }
            log.AllLogs = null;
        }

        private void LogsForm_SizeChanged(object sender, EventArgs e)
        {
            int temple;
            listViewLogs.Width = this.Width - (btnBack.Width * 2);
            listViewLogs.Height = this.Height - 100;
            temple = (listViewLogs.Width - 153) / 2;
            foreach (ColumnHeader column in listViewLogs.Columns)
                column.Width = temple;
            listViewLogs.Columns[0].Width = 50;
            listViewLogs.Columns[1].Width = 100;
            btnBack.Location = new Point(this.Width - btnBack.Width - 25, listViewLogs.Location.Y);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
