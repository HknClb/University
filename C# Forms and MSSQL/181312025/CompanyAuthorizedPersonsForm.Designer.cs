
namespace _181312025
{
    partial class CompanyAuthorizedPersonsForm
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("KULLANICILAR", System.Windows.Forms.HorizontalAlignment.Center);
            this.listViewAuthorizedPersons = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPersonName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPersonSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewAuthorizedPersons
            // 
            this.listViewAuthorizedPersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnPersonName,
            this.columnPersonSurname,
            this.columnPhone});
            this.listViewAuthorizedPersons.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewAuthorizedPersons.FullRowSelect = true;
            this.listViewAuthorizedPersons.GridLines = true;
            listViewGroup2.Header = "KULLANICILAR";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewUsersGroup";
            this.listViewAuthorizedPersons.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listViewAuthorizedPersons.HideSelection = false;
            this.listViewAuthorizedPersons.Location = new System.Drawing.Point(12, 61);
            this.listViewAuthorizedPersons.MultiSelect = false;
            this.listViewAuthorizedPersons.Name = "listViewAuthorizedPersons";
            this.listViewAuthorizedPersons.ShowGroups = false;
            this.listViewAuthorizedPersons.Size = new System.Drawing.Size(484, 417);
            this.listViewAuthorizedPersons.TabIndex = 3;
            this.listViewAuthorizedPersons.UseCompatibleStateImageBehavior = false;
            this.listViewAuthorizedPersons.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnPersonName
            // 
            this.columnPersonName.Text = "İsim";
            this.columnPersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPersonName.Width = 150;
            // 
            // columnPersonSurname
            // 
            this.columnPersonSurname.Text = "Soyisim";
            this.columnPersonSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPersonSurname.Width = 150;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Telefon";
            this.columnPhone.Width = 120;
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdatePerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdatePerson.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePerson.Location = new System.Drawing.Point(502, 201);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(203, 51);
            this.btnUpdatePerson.TabIndex = 1;
            this.btnUpdatePerson.Text = "GÜNCELLE";
            this.btnUpdatePerson.UseVisualStyleBackColor = false;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletePerson.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePerson.Location = new System.Drawing.Point(502, 258);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(203, 51);
            this.btnDeletePerson.TabIndex = 2;
            this.btnDeletePerson.Text = "SİL";
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(641, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 43);
            this.btnBackToMainForm.TabIndex = 4;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompanyName.Location = new System.Drawing.Point(215, 22);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(61, 22);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "label1";
            // 
            // CompanyAuthorizedPersonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 490);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.listViewAuthorizedPersons);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.btnUpdatePerson);
            this.Controls.Add(this.btnBackToMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyAuthorizedPersonsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirket Yetkilileri";
            this.Load += new System.EventHandler(this.CompanyAuthorizedPersonsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewAuthorizedPersons;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnPersonName;
        private System.Windows.Forms.ColumnHeader columnPersonSurname;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.Label lblCompanyName;
    }
}