
namespace _181312025
{
    partial class BusesForm
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
            this.listViewBuses = new System.Windows.Forms.ListView();
            this.columnPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProductYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddOrSaveBus = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateBus = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dtpProductYear = new System.Windows.Forms.DateTimePicker();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewBuses
            // 
            this.listViewBuses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPlate,
            this.columnMark,
            this.columnModel,
            this.columnProductYear,
            this.columnCompanyName});
            this.listViewBuses.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewBuses.FullRowSelect = true;
            this.listViewBuses.GridLines = true;
            listViewGroup2.Header = "KULLANICILAR";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewUsersGroup";
            this.listViewBuses.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewBuses.HideSelection = false;
            this.listViewBuses.Location = new System.Drawing.Point(12, 12);
            this.listViewBuses.MultiSelect = false;
            this.listViewBuses.Name = "listViewBuses";
            this.listViewBuses.ShowGroups = false;
            this.listViewBuses.Size = new System.Drawing.Size(654, 499);
            this.listViewBuses.TabIndex = 9;
            this.listViewBuses.UseCompatibleStateImageBehavior = false;
            this.listViewBuses.View = System.Windows.Forms.View.Details;
            // 
            // columnPlate
            // 
            this.columnPlate.Text = "Plaka";
            this.columnPlate.Width = 80;
            // 
            // columnMark
            // 
            this.columnMark.Text = "Marka";
            this.columnMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnMark.Width = 150;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model";
            this.columnModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnModel.Width = 150;
            // 
            // columnProductYear
            // 
            this.columnProductYear.Text = "Üretim Yılı";
            this.columnProductYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnProductYear.Width = 120;
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Text = "Şirket";
            this.columnCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompanyName.Width = 150;
            // 
            // btnAddOrSaveBus
            // 
            this.btnAddOrSaveBus.BackColor = System.Drawing.Color.White;
            this.btnAddOrSaveBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrSaveBus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddOrSaveBus.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddOrSaveBus.Location = new System.Drawing.Point(735, 343);
            this.btnAddOrSaveBus.Name = "btnAddOrSaveBus";
            this.btnAddOrSaveBus.Size = new System.Drawing.Size(185, 40);
            this.btnAddOrSaveBus.TabIndex = 5;
            this.btnAddOrSaveBus.Text = "EKLE/KAYDET";
            this.btnAddOrSaveBus.UseVisualStyleBackColor = false;
            this.btnAddOrSaveBus.Click += new System.EventHandler(this.btnAddOrSaveBus_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(906, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 43);
            this.btnBackToMainForm.TabIndex = 8;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.BackColor = System.Drawing.Color.White;
            this.btnDeleteBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBus.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteBus.Location = new System.Drawing.Point(704, 97);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(116, 40);
            this.btnDeleteBus.TabIndex = 7;
            this.btnDeleteBus.Text = "SİL";
            this.btnDeleteBus.UseVisualStyleBackColor = false;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPlate.ForeColor = System.Drawing.Color.Gray;
            this.txtPlate.Location = new System.Drawing.Point(679, 156);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(291, 30);
            this.txtPlate.TabIndex = 0;
            this.txtPlate.Text = "Plaka";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.BackColor = System.Drawing.Color.White;
            this.btnUpdateBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBus.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateBus.Location = new System.Drawing.Point(826, 97);
            this.btnUpdateBus.Name = "btnUpdateBus";
            this.btnUpdateBus.Size = new System.Drawing.Size(116, 40);
            this.btnUpdateBus.TabIndex = 6;
            this.btnUpdateBus.Text = "GÜNCELLE";
            this.btnUpdateBus.UseVisualStyleBackColor = false;
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMark.ForeColor = System.Drawing.Color.Gray;
            this.txtMark.Location = new System.Drawing.Point(679, 192);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(291, 30);
            this.txtMark.TabIndex = 1;
            this.txtMark.Text = "Marka";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtModel.ForeColor = System.Drawing.Color.Gray;
            this.txtModel.Location = new System.Drawing.Point(679, 228);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(291, 30);
            this.txtModel.TabIndex = 2;
            this.txtModel.Text = "Model";
            // 
            // dtpProductYear
            // 
            this.dtpProductYear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpProductYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductYear.Location = new System.Drawing.Point(679, 264);
            this.dtpProductYear.Name = "dtpProductYear";
            this.dtpProductYear.Size = new System.Drawing.Size(291, 30);
            this.dtpProductYear.TabIndex = 3;
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(679, 300);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(291, 30);
            this.cmbCompany.TabIndex = 4;
            // 
            // BusesForm
            // 
            this.AcceptButton = this.btnAddOrSaveBus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 523);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.dtpProductYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.listViewBuses);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnUpdateBus);
            this.Controls.Add(this.btnAddOrSaveBus);
            this.Controls.Add(this.btnBackToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüsler";
            this.Load += new System.EventHandler(this.BusesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewBuses;
        private System.Windows.Forms.ColumnHeader columnPlate;
        private System.Windows.Forms.ColumnHeader columnMark;
        private System.Windows.Forms.Button btnAddOrSaveBus;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnUpdateBus;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnProductYear;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DateTimePicker dtpProductYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMark;
    }
}