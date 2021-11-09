namespace _181312025
{
    partial class AdminPanel
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("KULLANICILAR", System.Windows.Forms.HorizontalAlignment.Center);
            this.btnAddUser = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnShowLogs = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.Location = new System.Drawing.Point(531, 156);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(203, 51);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "YENİ KULLANICI";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnUserName,
            this.columnPassword,
            this.columnAuthority});
            this.listViewUsers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            listViewGroup1.Header = "KULLANICILAR";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewUsersGroup";
            this.listViewUsers.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(12, 12);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.ShowGroups = false;
            this.listViewUsers.Size = new System.Drawing.Size(514, 466);
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnUserName
            // 
            this.columnUserName.Text = "Kullanıcı Adı";
            this.columnUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUserName.Width = 150;
            // 
            // columnPassword
            // 
            this.columnPassword.Text = "Parola";
            this.columnPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPassword.Width = 150;
            // 
            // columnAuthority
            // 
            this.columnAuthority.Text = "Yetki";
            this.columnAuthority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAuthority.Width = 150;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateUser.Location = new System.Drawing.Point(531, 213);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(203, 51);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "GÜNCELLE";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteUser.Location = new System.Drawing.Point(531, 270);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(203, 51);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "SİL";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnShowLogs
            // 
            this.btnShowLogs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnShowLogs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowLogs.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowLogs.Location = new System.Drawing.Point(531, 427);
            this.btnShowLogs.Name = "btnShowLogs";
            this.btnShowLogs.Size = new System.Drawing.Size(203, 51);
            this.btnShowLogs.TabIndex = 3;
            this.btnShowLogs.Text = "LOG GÖRÜNTÜLE";
            this.btnShowLogs.UseVisualStyleBackColor = false;
            this.btnShowLogs.Click += new System.EventHandler(this.btnShowLogs_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(668, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 43);
            this.btnBackToMainForm.TabIndex = 4;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 490);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnShowLogs);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnPassword;
        private System.Windows.Forms.ColumnHeader columnAuthority;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnShowLogs;
        private System.Windows.Forms.Button btnBackToMainForm;
    }
}