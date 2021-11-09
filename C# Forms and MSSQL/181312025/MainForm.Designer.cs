namespace _181312025
{
    partial class MainForm
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
            this.lblCoderName = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblCodeIsDate = new System.Windows.Forms.Label();
            this.btnExam = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCoderName
            // 
            this.lblCoderName.AutoSize = true;
            this.lblCoderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCoderName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCoderName.Location = new System.Drawing.Point(12, 9);
            this.lblCoderName.Name = "lblCoderName";
            this.lblCoderName.Size = new System.Drawing.Size(132, 22);
            this.lblCoderName.TabIndex = 0;
            this.lblCoderName.Text = "Hakan ÇELEBİ";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProject.Location = new System.Drawing.Point(21, 52);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(113, 22);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Final Projesi";
            // 
            // lblCodeIsDate
            // 
            this.lblCodeIsDate.AutoSize = true;
            this.lblCodeIsDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodeIsDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCodeIsDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblCodeIsDate.Location = new System.Drawing.Point(394, 9);
            this.lblCodeIsDate.Name = "lblCodeIsDate";
            this.lblCodeIsDate.Size = new System.Drawing.Size(102, 22);
            this.lblCodeIsDate.TabIndex = 0;
            this.lblCodeIsDate.Text = "17/06/2021";
            // 
            // btnExam
            // 
            this.btnExam.Enabled = false;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExam.Location = new System.Drawing.Point(184, 35);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(312, 56);
            this.btnExam.TabIndex = 3;
            this.btnExam.Text = "TERMİNAL OTOMASYON SİSTEMİ";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(130, 150);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(251, 52);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hoşgeldiniz.\r\nHenüz Giriş Yapılmadı!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Maroon;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(382, 97);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(113, 30);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Oturumu Kapat";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Visible = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(130, 240);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(254, 30);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "";
            this.txtUserName.Text = "Kullanıcı Adı";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(130, 309);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "";
            this.txtPassword.Text = "Parola";
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSign.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(130, 363);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(254, 33);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Giriş";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 438);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.lblCodeIsDate);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblCoderName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "181312025 Final Project";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoderName;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblCodeIsDate;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}