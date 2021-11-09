
namespace _181312025
{
    partial class PeronRentForm
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("KULLANICILAR", System.Windows.Forms.HorizontalAlignment.Center);
            this.listViewActiveRent = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPeronNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBusPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDriverIdentity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEnterTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTenancy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddOrSaveRent = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.txtTenancy = new System.Windows.Forms.TextBox();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.cmbPeron = new System.Windows.Forms.ComboBox();
            this.dtpEnterTime = new System.Windows.Forms.DateTimePicker();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnOldRentelPeron = new System.Windows.Forms.Button();
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
            this.columnTenancy,
            this.columnPayment});
            this.listViewActiveRent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewActiveRent.FullRowSelect = true;
            this.listViewActiveRent.GridLines = true;
            listViewGroup2.Header = "KULLANICILAR";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewUsersGroup";
            this.listViewActiveRent.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewActiveRent.HideSelection = false;
            this.listViewActiveRent.Location = new System.Drawing.Point(12, 12);
            this.listViewActiveRent.MultiSelect = false;
            this.listViewActiveRent.Name = "listViewActiveRent";
            this.listViewActiveRent.ShowGroups = false;
            this.listViewActiveRent.Size = new System.Drawing.Size(1014, 499);
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
            this.columnEnterTime.Text = "Kira Zamanı";
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
            // btnAddOrSaveRent
            // 
            this.btnAddOrSaveRent.BackColor = System.Drawing.Color.White;
            this.btnAddOrSaveRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrSaveRent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddOrSaveRent.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddOrSaveRent.Location = new System.Drawing.Point(1032, 278);
            this.btnAddOrSaveRent.Name = "btnAddOrSaveRent";
            this.btnAddOrSaveRent.Size = new System.Drawing.Size(291, 40);
            this.btnAddOrSaveRent.TabIndex = 10;
            this.btnAddOrSaveRent.Text = "EKLE/KAYDET";
            this.btnAddOrSaveRent.UseVisualStyleBackColor = false;
            this.btnAddOrSaveRent.Click += new System.EventHandler(this.btnAddOrSaveRent_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(1259, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 40);
            this.btnBackToMainForm.TabIndex = 13;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // btnDeleteRent
            // 
            this.btnDeleteRent.BackColor = System.Drawing.Color.White;
            this.btnDeleteRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteRent.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteRent.Location = new System.Drawing.Point(1032, 324);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(142, 40);
            this.btnDeleteRent.TabIndex = 12;
            this.btnDeleteRent.Text = "SİL";
            this.btnDeleteRent.UseVisualStyleBackColor = false;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.BackColor = System.Drawing.Color.White;
            this.btnUpdateRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateRent.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateRent.Location = new System.Drawing.Point(1181, 324);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(142, 40);
            this.btnUpdateRent.TabIndex = 11;
            this.btnUpdateRent.Text = "GÜNCELLE";
            this.btnUpdateRent.UseVisualStyleBackColor = false;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateRent_Click);
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(1032, 170);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(291, 30);
            this.cmbCompany.TabIndex = 3;
            // 
            // txtTenancy
            // 
            this.txtTenancy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenancy.ForeColor = System.Drawing.Color.Gray;
            this.txtTenancy.Location = new System.Drawing.Point(1032, 242);
            this.txtTenancy.Name = "txtTenancy";
            this.txtTenancy.Size = new System.Drawing.Size(291, 30);
            this.txtTenancy.TabIndex = 5;
            this.txtTenancy.Text = "Kira Süresi";
            // 
            // cmbDriver
            // 
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbDriver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(1032, 134);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(291, 30);
            this.cmbDriver.TabIndex = 3;
            // 
            // cmbBus
            // 
            this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBus.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbBus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(1032, 98);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(291, 30);
            this.cmbBus.TabIndex = 3;
            // 
            // cmbPeron
            // 
            this.cmbPeron.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeron.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbPeron.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbPeron.FormattingEnabled = true;
            this.cmbPeron.Location = new System.Drawing.Point(1032, 62);
            this.cmbPeron.Name = "cmbPeron";
            this.cmbPeron.Size = new System.Drawing.Size(291, 30);
            this.cmbPeron.TabIndex = 3;
            // 
            // dtpEnterTime
            // 
            this.dtpEnterTime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpEnterTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnterTime.Location = new System.Drawing.Point(1032, 207);
            this.dtpEnterTime.Name = "dtpEnterTime";
            this.dtpEnterTime.Size = new System.Drawing.Size(291, 30);
            this.dtpEnterTime.TabIndex = 15;
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.White;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOut.ForeColor = System.Drawing.Color.Black;
            this.btnOut.Location = new System.Drawing.Point(1032, 370);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(291, 40);
            this.btnOut.TabIndex = 10;
            this.btnOut.Text = "OTOBÜS ÇIKIŞ YAP";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnOldRentelPeron
            // 
            this.btnOldRentelPeron.BackColor = System.Drawing.Color.White;
            this.btnOldRentelPeron.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOldRentelPeron.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnOldRentelPeron.Location = new System.Drawing.Point(1032, 416);
            this.btnOldRentelPeron.Name = "btnOldRentelPeron";
            this.btnOldRentelPeron.Size = new System.Drawing.Size(291, 40);
            this.btnOldRentelPeron.TabIndex = 10;
            this.btnOldRentelPeron.Text = "ESKİ KAYITLARI LİSTELE";
            this.btnOldRentelPeron.UseVisualStyleBackColor = false;
            this.btnOldRentelPeron.Click += new System.EventHandler(this.btnOldRentelPeron_Click);
            // 
            // PeronRentForm
            // 
            this.AcceptButton = this.btnAddOrSaveRent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 527);
            this.Controls.Add(this.dtpEnterTime);
            this.Controls.Add(this.cmbPeron);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.txtTenancy);
            this.Controls.Add(this.listViewActiveRent);
            this.Controls.Add(this.btnDeleteRent);
            this.Controls.Add(this.btnUpdateRent);
            this.Controls.Add(this.btnOldRentelPeron);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnAddOrSaveRent);
            this.Controls.Add(this.btnBackToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeronRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peron Kiralama";
            this.Load += new System.EventHandler(this.PeronRentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewActiveRent;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnBusPlate;
        private System.Windows.Forms.Button btnAddOrSaveRent;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnDeleteRent;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.ColumnHeader columnDriverIdentity;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ColumnHeader columnEnterTime;
        private System.Windows.Forms.ColumnHeader columnTenancy;
        private System.Windows.Forms.ColumnHeader columnPayment;
        private System.Windows.Forms.ColumnHeader columnPeronNumber;
        private System.Windows.Forms.DateTimePicker dtpEnterTime;
        private System.Windows.Forms.ComboBox cmbPeron;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.TextBox txtTenancy;
        private System.Windows.Forms.Button btnOldRentelPeron;
        private System.Windows.Forms.Button btnOut;
    }
}