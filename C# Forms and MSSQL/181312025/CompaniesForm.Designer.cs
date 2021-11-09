
namespace _181312025
{
    partial class CompaniesForm
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
            this.listViewCompanies = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnAddAuthorizedPerson = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnListAuthorizedPerson = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewCompanies
            // 
            this.listViewCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnCompanyName});
            this.listViewCompanies.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewCompanies.FullRowSelect = true;
            this.listViewCompanies.GridLines = true;
            listViewGroup1.Header = "KULLANICILAR";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewUsersGroup";
            this.listViewCompanies.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewCompanies.HideSelection = false;
            this.listViewCompanies.Location = new System.Drawing.Point(12, 12);
            this.listViewCompanies.MultiSelect = false;
            this.listViewCompanies.Name = "listViewCompanies";
            this.listViewCompanies.ShowGroups = false;
            this.listViewCompanies.Size = new System.Drawing.Size(264, 352);
            this.listViewCompanies.TabIndex = 6;
            this.listViewCompanies.UseCompatibleStateImageBehavior = false;
            this.listViewCompanies.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnCompanyName
            // 
            this.columnCompanyName.Text = "Şirket İsmi";
            this.columnCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompanyName.Width = 200;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.BackColor = System.Drawing.Color.White;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCompany.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddCompany.Location = new System.Drawing.Point(415, 183);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(100, 40);
            this.btnAddCompany.TabIndex = 1;
            this.btnAddCompany.Text = "EKLE";
            this.btnAddCompany.UseVisualStyleBackColor = false;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(571, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 43);
            this.btnBackToMainForm.TabIndex = 5;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.BackColor = System.Drawing.Color.White;
            this.btnDeleteCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompany.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCompany.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCompany.Location = new System.Drawing.Point(282, 12);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(116, 40);
            this.btnDeleteCompany.TabIndex = 4;
            this.btnDeleteCompany.Text = "SİL";
            this.btnDeleteCompany.UseVisualStyleBackColor = false;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnAddAuthorizedPerson
            // 
            this.btnAddAuthorizedPerson.BackColor = System.Drawing.Color.White;
            this.btnAddAuthorizedPerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddAuthorizedPerson.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAuthorizedPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAuthorizedPerson.Location = new System.Drawing.Point(282, 232);
            this.btnAddAuthorizedPerson.Name = "btnAddAuthorizedPerson";
            this.btnAddAuthorizedPerson.Size = new System.Drawing.Size(171, 51);
            this.btnAddAuthorizedPerson.TabIndex = 2;
            this.btnAddAuthorizedPerson.Text = "YETKİLİ EKLE";
            this.btnAddAuthorizedPerson.UseVisualStyleBackColor = false;
            this.btnAddAuthorizedPerson.Click += new System.EventHandler(this.btnAddAuthorizedPerson_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.Gray;
            this.txtCompanyName.Location = new System.Drawing.Point(324, 147);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(291, 30);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.Text = "Şirket İsmi";
            // 
            // btnListAuthorizedPerson
            // 
            this.btnListAuthorizedPerson.BackColor = System.Drawing.Color.White;
            this.btnListAuthorizedPerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListAuthorizedPerson.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListAuthorizedPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListAuthorizedPerson.Location = new System.Drawing.Point(282, 312);
            this.btnListAuthorizedPerson.Name = "btnListAuthorizedPerson";
            this.btnListAuthorizedPerson.Size = new System.Drawing.Size(171, 51);
            this.btnListAuthorizedPerson.TabIndex = 3;
            this.btnListAuthorizedPerson.Text = "YETKİLİ BİLGİLERİ";
            this.btnListAuthorizedPerson.UseVisualStyleBackColor = false;
            this.btnListAuthorizedPerson.Click += new System.EventHandler(this.btnListAuthorizedPerson_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.BackColor = System.Drawing.Color.White;
            this.btnUpdateCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCompany.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCompany.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateCompany.Location = new System.Drawing.Point(282, 58);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(116, 40);
            this.btnUpdateCompany.TabIndex = 1;
            this.btnUpdateCompany.Text = "GÜNCELLE";
            this.btnUpdateCompany.UseVisualStyleBackColor = false;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // CompaniesForm
            // 
            this.AcceptButton = this.btnAddCompany;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 375);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.listViewCompanies);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.btnListAuthorizedPerson);
            this.Controls.Add(this.btnAddAuthorizedPerson);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.btnBackToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompaniesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirketler";
            this.Load += new System.EventHandler(this.CompanyiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewCompanies;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnCompanyName;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnAddAuthorizedPerson;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnListAuthorizedPerson;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnUpdateCompany;
    }
}