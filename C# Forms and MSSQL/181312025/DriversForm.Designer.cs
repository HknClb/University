
namespace _181312025
{
    partial class DriversForm
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
            this.listViewDrivers = new System.Windows.Forms.ListView();
            this.columnIdentity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRelativePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRelativeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRelativeSurame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddOrSaveDriver = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateDriver = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtRelativePhone = new System.Windows.Forms.TextBox();
            this.txtRelativeName = new System.Windows.Forms.TextBox();
            this.txtRelativeSurname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewDrivers
            // 
            this.listViewDrivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdentity,
            this.columnName,
            this.columnSurname,
            this.columnBirthDate,
            this.columnCompanyName,
            this.columnAddress,
            this.columnPhone,
            this.columnRelativePhone,
            this.columnRelativeName,
            this.columnRelativeSurame});
            this.listViewDrivers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewDrivers.FullRowSelect = true;
            this.listViewDrivers.GridLines = true;
            listViewGroup1.Header = "KULLANICILAR";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewUsersGroup";
            this.listViewDrivers.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewDrivers.HideSelection = false;
            this.listViewDrivers.Location = new System.Drawing.Point(12, 12);
            this.listViewDrivers.MultiSelect = false;
            this.listViewDrivers.Name = "listViewDrivers";
            this.listViewDrivers.ShowGroups = false;
            this.listViewDrivers.Size = new System.Drawing.Size(1074, 499);
            this.listViewDrivers.TabIndex = 14;
            this.listViewDrivers.UseCompatibleStateImageBehavior = false;
            this.listViewDrivers.View = System.Windows.Forms.View.Details;
            // 
            // columnIdentity
            // 
            this.columnIdentity.Text = "Kimlik No";
            this.columnIdentity.Width = 120;
            // 
            // columnName
            // 
            this.columnName.Text = "İsim";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 150;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Soyisim";
            this.columnSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSurname.Width = 150;
            // 
            // columnBirthDate
            // 
            this.columnBirthDate.Text = "Doğum Tarihi";
            this.columnBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnBirthDate.Width = 120;
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Text = "Şirket";
            this.columnCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompanyName.Width = 150;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Adres";
            this.columnAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAddress.Width = 250;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Telefon";
            this.columnPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPhone.Width = 120;
            // 
            // columnRelativePhone
            // 
            this.columnRelativePhone.Text = "Yakın Telefon";
            this.columnRelativePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRelativePhone.Width = 120;
            // 
            // columnRelativeName
            // 
            this.columnRelativeName.Text = "Yakın İsim";
            this.columnRelativeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRelativeName.Width = 150;
            // 
            // columnRelativeSurame
            // 
            this.columnRelativeSurame.Text = "Yakın Soyisim";
            this.columnRelativeSurame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnRelativeSurame.Width = 150;
            // 
            // btnAddOrSaveDriver
            // 
            this.btnAddOrSaveDriver.BackColor = System.Drawing.Color.White;
            this.btnAddOrSaveDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrSaveDriver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddOrSaveDriver.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddOrSaveDriver.Location = new System.Drawing.Point(1155, 471);
            this.btnAddOrSaveDriver.Name = "btnAddOrSaveDriver";
            this.btnAddOrSaveDriver.Size = new System.Drawing.Size(185, 40);
            this.btnAddOrSaveDriver.TabIndex = 10;
            this.btnAddOrSaveDriver.Text = "EKLE/KAYDET";
            this.btnAddOrSaveDriver.UseVisualStyleBackColor = false;
            this.btnAddOrSaveDriver.Click += new System.EventHandler(this.btnAddOrSaveDriver_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(1327, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 43);
            this.btnBackToMainForm.TabIndex = 13;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.BackColor = System.Drawing.Color.White;
            this.btnDeleteDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDriver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteDriver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteDriver.Location = new System.Drawing.Point(1124, 64);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(116, 40);
            this.btnDeleteDriver.TabIndex = 12;
            this.btnDeleteDriver.Text = "SİL";
            this.btnDeleteDriver.UseVisualStyleBackColor = false;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // txtIdentity
            // 
            this.txtIdentity.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtIdentity.ForeColor = System.Drawing.Color.Gray;
            this.txtIdentity.Location = new System.Drawing.Point(1099, 110);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(291, 30);
            this.txtIdentity.TabIndex = 0;
            this.txtIdentity.Text = "Kimlik No";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // btnUpdateDriver
            // 
            this.btnUpdateDriver.BackColor = System.Drawing.Color.White;
            this.btnUpdateDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDriver.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateDriver.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateDriver.Location = new System.Drawing.Point(1246, 64);
            this.btnUpdateDriver.Name = "btnUpdateDriver";
            this.btnUpdateDriver.Size = new System.Drawing.Size(116, 40);
            this.btnUpdateDriver.TabIndex = 11;
            this.btnUpdateDriver.Text = "GÜNCELLE";
            this.btnUpdateDriver.UseVisualStyleBackColor = false;
            this.btnUpdateDriver.Click += new System.EventHandler(this.btnUpdateDriver_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(1099, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 30);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "İsim";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSurname.ForeColor = System.Drawing.Color.Gray;
            this.txtSurname.Location = new System.Drawing.Point(1099, 182);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(291, 30);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Text = "Soyisim";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(1099, 254);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(291, 30);
            this.dtpBirthDate.TabIndex = 4;
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(1099, 218);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(291, 30);
            this.cmbCompany.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(1100, 290);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 30);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "Adres";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtPhone.Location = new System.Drawing.Point(1099, 326);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(291, 30);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "Telefon";
            // 
            // txtRelativePhone
            // 
            this.txtRelativePhone.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtRelativePhone.ForeColor = System.Drawing.Color.Gray;
            this.txtRelativePhone.Location = new System.Drawing.Point(1099, 362);
            this.txtRelativePhone.Name = "txtRelativePhone";
            this.txtRelativePhone.Size = new System.Drawing.Size(291, 30);
            this.txtRelativePhone.TabIndex = 7;
            this.txtRelativePhone.Text = "Yakın Telefon";
            // 
            // txtRelativeName
            // 
            this.txtRelativeName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtRelativeName.ForeColor = System.Drawing.Color.Gray;
            this.txtRelativeName.Location = new System.Drawing.Point(1100, 398);
            this.txtRelativeName.Name = "txtRelativeName";
            this.txtRelativeName.Size = new System.Drawing.Size(291, 30);
            this.txtRelativeName.TabIndex = 8;
            this.txtRelativeName.Text = "Yakın İsim";
            // 
            // txtRelativeSurname
            // 
            this.txtRelativeSurname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtRelativeSurname.ForeColor = System.Drawing.Color.Gray;
            this.txtRelativeSurname.Location = new System.Drawing.Point(1100, 434);
            this.txtRelativeSurname.Name = "txtRelativeSurname";
            this.txtRelativeSurname.Size = new System.Drawing.Size(291, 30);
            this.txtRelativeSurname.TabIndex = 9;
            this.txtRelativeSurname.Text = "Yakın Soyisim";
            // 
            // DriversForm
            // 
            this.AcceptButton = this.btnAddOrSaveDriver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 530);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRelativeSurname);
            this.Controls.Add(this.txtRelativeName);
            this.Controls.Add(this.txtRelativePhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.listViewDrivers);
            this.Controls.Add(this.btnDeleteDriver);
            this.Controls.Add(this.btnUpdateDriver);
            this.Controls.Add(this.btnAddOrSaveDriver);
            this.Controls.Add(this.btnBackToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriversForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şoförler";
            this.Load += new System.EventHandler(this.DriversForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewDrivers;
        private System.Windows.Forms.ColumnHeader columnIdentity;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Button btnAddOrSaveDriver;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnUpdateDriver;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnBirthDate;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRelativeSurname;
        private System.Windows.Forms.TextBox txtRelativeName;
        private System.Windows.Forms.TextBox txtRelativePhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnRelativePhone;
        private System.Windows.Forms.ColumnHeader columnRelativeName;
        private System.Windows.Forms.ColumnHeader columnRelativeSurame;
    }
}