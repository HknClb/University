namespace vize_soru_3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoordinateX = new System.Windows.Forms.TextBox();
            this.textBoxCoordinateY = new System.Windows.Forms.TextBox();
            this.btnAddCoordinate = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            // 
            // textBoxCoordinateX
            // 
            this.textBoxCoordinateX.Location = new System.Drawing.Point(34, 35);
            this.textBoxCoordinateX.Name = "textBoxCoordinateX";
            this.textBoxCoordinateX.Size = new System.Drawing.Size(100, 30);
            this.textBoxCoordinateX.TabIndex = 0;
            // 
            // textBoxCoordinateY
            // 
            this.textBoxCoordinateY.Location = new System.Drawing.Point(34, 93);
            this.textBoxCoordinateY.Name = "textBoxCoordinateY";
            this.textBoxCoordinateY.Size = new System.Drawing.Size(100, 30);
            this.textBoxCoordinateY.TabIndex = 1;
            // 
            // btnAddCoordinate
            // 
            this.btnAddCoordinate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoordinate.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnAddCoordinate.Location = new System.Drawing.Point(16, 130);
            this.btnAddCoordinate.Name = "btnAddCoordinate";
            this.btnAddCoordinate.Size = new System.Drawing.Size(139, 57);
            this.btnAddCoordinate.TabIndex = 2;
            this.btnAddCoordinate.Text = "KOORDİNAT GİR";
            this.btnAddCoordinate.UseVisualStyleBackColor = true;
            this.btnAddCoordinate.Click += new System.EventHandler(this.btnAddCoordinate_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCalculate.Location = new System.Drawing.Point(16, 193);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(139, 57);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "HESAPLA";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddCoordinate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 263);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.btnAddCoordinate);
            this.Controls.Add(this.textBoxCoordinateY);
            this.Controls.Add(this.textBoxCoordinateX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vize Soru#3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoordinateX;
        private System.Windows.Forms.TextBox textBoxCoordinateY;
        private System.Windows.Forms.Button btnAddCoordinate;
        private System.Windows.Forms.Button buttonCalculate;
    }
}

