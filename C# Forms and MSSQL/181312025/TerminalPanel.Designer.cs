
namespace _181312025
{
    partial class TerminalPanel
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
            this.btnAddPeron = new System.Windows.Forms.Button();
            this.listViewPerons = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdatePeron = new System.Windows.Forms.Button();
            this.btnGoDrivers = new System.Windows.Forms.Button();
            this.btnGoBuses = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnRentPeron = new System.Windows.Forms.Button();
            this.btnDeletePeron = new System.Windows.Forms.Button();
            this.btnGoCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPeron
            // 
            this.btnAddPeron.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddPeron.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddPeron.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPeron.Location = new System.Drawing.Point(298, 46);
            this.btnAddPeron.Name = "btnAddPeron";
            this.btnAddPeron.Size = new System.Drawing.Size(203, 51);
            this.btnAddPeron.TabIndex = 0;
            this.btnAddPeron.Text = "PERON EKLE";
            this.btnAddPeron.UseVisualStyleBackColor = false;
            this.btnAddPeron.Click += new System.EventHandler(this.btnAddPeron_Click);
            // 
            // listViewPerons
            // 
            this.listViewPerons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNumber,
            this.columnUnitPrice});
            this.listViewPerons.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewPerons.FullRowSelect = true;
            this.listViewPerons.GridLines = true;
            listViewGroup1.Header = "KULLANICILAR";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewUsersGroup";
            this.listViewPerons.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewPerons.HideSelection = false;
            this.listViewPerons.Location = new System.Drawing.Point(12, 12);
            this.listViewPerons.MultiSelect = false;
            this.listViewPerons.Name = "listViewPerons";
            this.listViewPerons.ShowGroups = false;
            this.listViewPerons.Size = new System.Drawing.Size(280, 466);
            this.listViewPerons.TabIndex = 3;
            this.listViewPerons.UseCompatibleStateImageBehavior = false;
            this.listViewPerons.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "Numara";
            this.columnNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNumber.Width = 75;
            // 
            // columnUnitPrice
            // 
            this.columnUnitPrice.Text = "Fiyat (Dakikada)";
            this.columnUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUnitPrice.Width = 140;
            // 
            // btnUpdatePeron
            // 
            this.btnUpdatePeron.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdatePeron.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdatePeron.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePeron.Location = new System.Drawing.Point(298, 103);
            this.btnUpdatePeron.Name = "btnUpdatePeron";
            this.btnUpdatePeron.Size = new System.Drawing.Size(203, 51);
            this.btnUpdatePeron.TabIndex = 2;
            this.btnUpdatePeron.Text = "PERON GÜNCELLE";
            this.btnUpdatePeron.UseVisualStyleBackColor = false;
            this.btnUpdatePeron.Click += new System.EventHandler(this.btnUpdatePeron_Click);
            // 
            // btnGoDrivers
            // 
            this.btnGoDrivers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGoDrivers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGoDrivers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoDrivers.Location = new System.Drawing.Point(298, 427);
            this.btnGoDrivers.Name = "btnGoDrivers";
            this.btnGoDrivers.Size = new System.Drawing.Size(203, 51);
            this.btnGoDrivers.TabIndex = 5;
            this.btnGoDrivers.Text = "ŞOFÖRLER";
            this.btnGoDrivers.UseVisualStyleBackColor = false;
            this.btnGoDrivers.Click += new System.EventHandler(this.btnGoDrivers_Click);
            // 
            // btnGoBuses
            // 
            this.btnGoBuses.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGoBuses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGoBuses.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoBuses.Location = new System.Drawing.Point(298, 370);
            this.btnGoBuses.Name = "btnGoBuses";
            this.btnGoBuses.Size = new System.Drawing.Size(203, 51);
            this.btnGoBuses.TabIndex = 6;
            this.btnGoBuses.Text = "OTOBÜSLER";
            this.btnGoBuses.UseVisualStyleBackColor = false;
            this.btnGoBuses.Click += new System.EventHandler(this.btnGoBuses_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.BackColor = System.Drawing.Color.Maroon;
            this.btnBackToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackToMainForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackToMainForm.Location = new System.Drawing.Point(543, 12);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(64, 43);
            this.btnBackToMainForm.TabIndex = 7;
            this.btnBackToMainForm.Text = "GERİ";
            this.btnBackToMainForm.UseVisualStyleBackColor = false;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // btnRentPeron
            // 
            this.btnRentPeron.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRentPeron.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRentPeron.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRentPeron.Location = new System.Drawing.Point(298, 217);
            this.btnRentPeron.Name = "btnRentPeron";
            this.btnRentPeron.Size = new System.Drawing.Size(203, 51);
            this.btnRentPeron.TabIndex = 1;
            this.btnRentPeron.Text = "PERON KİRALAMA";
            this.btnRentPeron.UseVisualStyleBackColor = false;
            this.btnRentPeron.Click += new System.EventHandler(this.btnRentPeron_Click);
            // 
            // btnDeletePeron
            // 
            this.btnDeletePeron.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDeletePeron.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletePeron.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePeron.Location = new System.Drawing.Point(298, 160);
            this.btnDeletePeron.Name = "btnDeletePeron";
            this.btnDeletePeron.Size = new System.Drawing.Size(203, 51);
            this.btnDeletePeron.TabIndex = 3;
            this.btnDeletePeron.Text = "PERON SİL";
            this.btnDeletePeron.UseVisualStyleBackColor = false;
            this.btnDeletePeron.Click += new System.EventHandler(this.btnDeletePeron_Click);
            // 
            // btnGoCompany
            // 
            this.btnGoCompany.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGoCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGoCompany.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoCompany.Location = new System.Drawing.Point(298, 313);
            this.btnGoCompany.Name = "btnGoCompany";
            this.btnGoCompany.Size = new System.Drawing.Size(203, 51);
            this.btnGoCompany.TabIndex = 4;
            this.btnGoCompany.Text = "ŞİRKETLER";
            this.btnGoCompany.UseVisualStyleBackColor = false;
            this.btnGoCompany.Click += new System.EventHandler(this.btnGoCompany_Click);
            // 
            // TerminalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 490);
            this.Controls.Add(this.listViewPerons);
            this.Controls.Add(this.btnGoCompany);
            this.Controls.Add(this.btnGoDrivers);
            this.Controls.Add(this.btnUpdatePeron);
            this.Controls.Add(this.btnGoBuses);
            this.Controls.Add(this.btnBackToMainForm);
            this.Controls.Add(this.btnDeletePeron);
            this.Controls.Add(this.btnRentPeron);
            this.Controls.Add(this.btnAddPeron);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TerminalPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal Paneli";
            this.Load += new System.EventHandler(this.TerminalPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddPeron;
        private System.Windows.Forms.ListView listViewPerons;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnUnitPrice;
        private System.Windows.Forms.Button btnUpdatePeron;
        private System.Windows.Forms.Button btnGoDrivers;
        private System.Windows.Forms.Button btnGoBuses;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnRentPeron;
        private System.Windows.Forms.Button btnDeletePeron;
        private System.Windows.Forms.Button btnGoCompany;
    }
}