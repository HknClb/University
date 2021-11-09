
namespace _181312025
{
    partial class OldPeronRentelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("KULLANICILAR", System.Windows.Forms.HorizontalAlignment.Center);
            this.listViewActiveRent = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPeronNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBusPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDriverIdentity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEnterTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenancy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnExitTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewActiveRent
            // 
            this.listViewActiveRent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnPeronNumber,
            this.columnBusPlate,
            this.columnDriverIdentity,
            this.columnCompanyName,
            this.columnEnterTime,
            this.columnExitTime,
            this.columnTenancy,
            this.columnPayment});
            this.listViewActiveRent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewActiveRent.FullRowSelect = true;
            this.listViewActiveRent.GridLines = true;
            listViewGroup1.Header = "KULLANICILAR";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewUsersGroup";
            this.listViewActiveRent.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewActiveRent.HideSelection = false;
            this.listViewActiveRent.Location = new System.Drawing.Point(12, 12);
            this.listViewActiveRent.MultiSelect = false;
            this.listViewActiveRent.Name = "listViewActiveRent";
            this.listViewActiveRent.ShowGroups = false;
            this.listViewActiveRent.Size = new System.Drawing.Size(1164, 499);
            this.listViewActiveRent.TabIndex = 14;
            this.listViewActiveRent.UseCompatibleStateImageBehavior = false;
            this.listViewActiveRent.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnPeronNumber
            // 
            this.columnPeronNumber.Text = "Peron";
            this.columnPeronNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPeronNumber.Width = 80;
            // 
            // columnBusPlate
            // 
            this.columnBusPlate.Text = "Otobüs Plakası";
            this.columnBusPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBusPlate.Width = 150;
            // 
            // columnDriverIdentity
            // 
            this.columnDriverIdentity.Text = "Sürücü Kimlik No";
            this.columnDriverIdentity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDriverIdentity.Width = 150;
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Text = "Şirket";
            this.columnCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompanyName.Width = 150;
            // 
            // columnEnterTime
            // 
            this.columnEnterTime.Text = "Giriş Zamanı";
            this.columnEnterTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnEnterTime.Width = 150;
            // 
            // columnTenancy
            // 
            this.columnTenancy.Text = "Kira Süresi";
            this.columnTenancy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTenancy.Width = 120;
            // 
            // columnPayment
            // 
            this.columnPayment.Text = "Ücret";
            this.columnPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPayment.Width = 150;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(1182, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 40);
            this.btnBackToMainForm.TabIndex = 13;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // columnExitTime
            // 
            this.columnExitTime.Text = "Çıkış Zamanı";
            this.columnExitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnExitTime.Width = 150;
            // 
            // OldPeronRentelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 527);
            this.Controls.Add(this.listViewActiveRent);
            this.Controls.Add(this.btnBackToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldPeronRentelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eksi Peron Kiralama Listesi";
            this.Load += new System.EventHandler(this.OldPeronRentelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewActiveRent;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnBusPlate;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader columnDriverIdentity;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ColumnHeader columnEnterTime;
        private System.Windows.Forms.ColumnHeader columnTenancy;
        private System.Windows.Forms.ColumnHeader columnPayment;
        private System.Windows.Forms.ColumnHeader columnPeronNumber;
        private System.Windows.Forms.ColumnHeader columnExitTime;
    }
}