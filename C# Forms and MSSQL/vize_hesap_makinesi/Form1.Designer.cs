namespace vize_hesap_makinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFlipSign = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSqrtX = new System.Windows.Forms.Button();
            this.btnPowX = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearProcces = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.proccesLabel = new System.Windows.Forms.Label();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.btnNumberZero = new System.Windows.Forms.Button();
            this.btnNumberThree = new System.Windows.Forms.Button();
            this.btnNumberTwo = new System.Windows.Forms.Button();
            this.btnNumberOne = new System.Windows.Forms.Button();
            this.btnNumberSix = new System.Windows.Forms.Button();
            this.btnNumberFive = new System.Windows.Forms.Button();
            this.btnNumberFour = new System.Windows.Forms.Button();
            this.btnNumberNine = new System.Windows.Forms.Button();
            this.btnNumberEight = new System.Windows.Forms.Button();
            this.btnNumberSeven = new System.Windows.Forms.Button();
            this.btnClearNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFlipSign
            // 
            this.btnFlipSign.BackColor = System.Drawing.Color.White;
            this.btnFlipSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipSign.Location = new System.Drawing.Point(17, 429);
            this.btnFlipSign.Name = "btnFlipSign";
            this.btnFlipSign.Size = new System.Drawing.Size(70, 60);
            this.btnFlipSign.TabIndex = 0;
            this.btnFlipSign.TabStop = false;
            this.btnFlipSign.Text = "+/-";
            this.btnFlipSign.UseVisualStyleBackColor = false;
            this.btnFlipSign.Click += new System.EventHandler(this.btnFlipSign_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.White;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Location = new System.Drawing.Point(169, 429);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(71, 60);
            this.btnComma.TabIndex = 0;
            this.btnComma.TabStop = false;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.Color.DarkGray;
            this.btnShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResult.Location = new System.Drawing.Point(244, 429);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(70, 60);
            this.btnShowResult.TabIndex = 0;
            this.btnShowResult.TabStop = false;
            this.btnShowResult.Text = "=";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.Location = new System.Drawing.Point(244, 363);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(70, 60);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.TabStop = false;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstraction.Location = new System.Drawing.Point(244, 297);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(70, 60);
            this.btnSubstraction.TabIndex = 0;
            this.btnSubstraction.TabStop = false;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Location = new System.Drawing.Point(244, 231);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(70, 60);
            this.btnMultiplication.TabIndex = 0;
            this.btnMultiplication.TabStop = false;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Location = new System.Drawing.Point(244, 165);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(70, 60);
            this.btnDivision.TabIndex = 0;
            this.btnDivision.TabStop = false;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnSqrtX
            // 
            this.btnSqrtX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSqrtX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqrtX.Location = new System.Drawing.Point(169, 165);
            this.btnSqrtX.Name = "btnSqrtX";
            this.btnSqrtX.Size = new System.Drawing.Size(70, 60);
            this.btnSqrtX.TabIndex = 0;
            this.btnSqrtX.TabStop = false;
            this.btnSqrtX.Text = "√x";
            this.btnSqrtX.UseVisualStyleBackColor = false;
            this.btnSqrtX.Click += new System.EventHandler(this.btnSqrtX_Click);
            // 
            // btnPowX
            // 
            this.btnPowX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPowX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowX.Location = new System.Drawing.Point(93, 165);
            this.btnPowX.Name = "btnPowX";
            this.btnPowX.Size = new System.Drawing.Size(70, 60);
            this.btnPowX.TabIndex = 0;
            this.btnPowX.TabStop = false;
            this.btnPowX.Text = "x²";
            this.btnPowX.UseVisualStyleBackColor = false;
            this.btnPowX.Click += new System.EventHandler(this.btnPowX_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1x.Location = new System.Drawing.Point(17, 165);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(70, 60);
            this.btn1x.TabIndex = 0;
            this.btn1x.TabStop = false;
            this.btn1x.Text = "1/x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(244, 99);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 60);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "<=";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearProcces
            // 
            this.btnClearProcces.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClearProcces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProcces.Location = new System.Drawing.Point(93, 99);
            this.btnClearProcces.Name = "btnClearProcces";
            this.btnClearProcces.Size = new System.Drawing.Size(70, 60);
            this.btnClearProcces.TabIndex = 0;
            this.btnClearProcces.TabStop = false;
            this.btnClearProcces.Text = "CE";
            this.btnClearProcces.UseVisualStyleBackColor = false;
            this.btnClearProcces.Click += new System.EventHandler(this.btnClearProcces_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(17, 99);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(70, 60);
            this.btnMod.TabIndex = 0;
            this.btnMod.TabStop = false;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.operation_Click);
            // 
            // proccesLabel
            // 
            this.proccesLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.proccesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proccesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proccesLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proccesLabel.Location = new System.Drawing.Point(17, 9);
            this.proccesLabel.Name = "proccesLabel";
            this.proccesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.proccesLabel.Size = new System.Drawing.Size(296, 77);
            this.proccesLabel.TabIndex = 2;
            this.proccesLabel.Text = "0";
            this.proccesLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // bufferLabel
            // 
            this.bufferLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bufferLabel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bufferLabel.ForeColor = System.Drawing.Color.Gray;
            this.bufferLabel.Location = new System.Drawing.Point(18, 19);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(290, 22);
            this.bufferLabel.TabIndex = 2;
            this.bufferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNumberZero
            // 
            this.btnNumberZero.BackColor = System.Drawing.Color.White;
            this.btnNumberZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberZero.Location = new System.Drawing.Point(93, 429);
            this.btnNumberZero.Name = "btnNumberZero";
            this.btnNumberZero.Size = new System.Drawing.Size(70, 60);
            this.btnNumberZero.TabIndex = 0;
            this.btnNumberZero.TabStop = false;
            this.btnNumberZero.Text = "0";
            this.btnNumberZero.UseVisualStyleBackColor = false;
            this.btnNumberZero.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberThree
            // 
            this.btnNumberThree.BackColor = System.Drawing.Color.White;
            this.btnNumberThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberThree.Location = new System.Drawing.Point(169, 363);
            this.btnNumberThree.Name = "btnNumberThree";
            this.btnNumberThree.Size = new System.Drawing.Size(70, 60);
            this.btnNumberThree.TabIndex = 0;
            this.btnNumberThree.TabStop = false;
            this.btnNumberThree.Text = "3";
            this.btnNumberThree.UseVisualStyleBackColor = false;
            this.btnNumberThree.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberTwo
            // 
            this.btnNumberTwo.BackColor = System.Drawing.Color.White;
            this.btnNumberTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberTwo.Location = new System.Drawing.Point(93, 363);
            this.btnNumberTwo.Name = "btnNumberTwo";
            this.btnNumberTwo.Size = new System.Drawing.Size(70, 60);
            this.btnNumberTwo.TabIndex = 0;
            this.btnNumberTwo.TabStop = false;
            this.btnNumberTwo.Text = "2";
            this.btnNumberTwo.UseVisualStyleBackColor = false;
            this.btnNumberTwo.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberOne
            // 
            this.btnNumberOne.BackColor = System.Drawing.Color.White;
            this.btnNumberOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberOne.Location = new System.Drawing.Point(17, 363);
            this.btnNumberOne.Name = "btnNumberOne";
            this.btnNumberOne.Size = new System.Drawing.Size(70, 60);
            this.btnNumberOne.TabIndex = 0;
            this.btnNumberOne.TabStop = false;
            this.btnNumberOne.Text = "1";
            this.btnNumberOne.UseVisualStyleBackColor = false;
            this.btnNumberOne.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberSix
            // 
            this.btnNumberSix.BackColor = System.Drawing.Color.White;
            this.btnNumberSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberSix.Location = new System.Drawing.Point(169, 297);
            this.btnNumberSix.Name = "btnNumberSix";
            this.btnNumberSix.Size = new System.Drawing.Size(70, 60);
            this.btnNumberSix.TabIndex = 0;
            this.btnNumberSix.TabStop = false;
            this.btnNumberSix.Text = "6";
            this.btnNumberSix.UseVisualStyleBackColor = false;
            this.btnNumberSix.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberFive
            // 
            this.btnNumberFive.BackColor = System.Drawing.Color.White;
            this.btnNumberFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberFive.Location = new System.Drawing.Point(93, 297);
            this.btnNumberFive.Name = "btnNumberFive";
            this.btnNumberFive.Size = new System.Drawing.Size(70, 60);
            this.btnNumberFive.TabIndex = 0;
            this.btnNumberFive.TabStop = false;
            this.btnNumberFive.Text = "5";
            this.btnNumberFive.UseVisualStyleBackColor = false;
            this.btnNumberFive.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberFour
            // 
            this.btnNumberFour.BackColor = System.Drawing.Color.White;
            this.btnNumberFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberFour.Location = new System.Drawing.Point(17, 297);
            this.btnNumberFour.Name = "btnNumberFour";
            this.btnNumberFour.Size = new System.Drawing.Size(70, 60);
            this.btnNumberFour.TabIndex = 0;
            this.btnNumberFour.TabStop = false;
            this.btnNumberFour.Text = "4";
            this.btnNumberFour.UseVisualStyleBackColor = false;
            this.btnNumberFour.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberNine
            // 
            this.btnNumberNine.BackColor = System.Drawing.Color.White;
            this.btnNumberNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberNine.Location = new System.Drawing.Point(169, 231);
            this.btnNumberNine.Name = "btnNumberNine";
            this.btnNumberNine.Size = new System.Drawing.Size(70, 60);
            this.btnNumberNine.TabIndex = 0;
            this.btnNumberNine.TabStop = false;
            this.btnNumberNine.Text = "9";
            this.btnNumberNine.UseVisualStyleBackColor = false;
            this.btnNumberNine.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberEight
            // 
            this.btnNumberEight.BackColor = System.Drawing.Color.White;
            this.btnNumberEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberEight.Location = new System.Drawing.Point(93, 231);
            this.btnNumberEight.Name = "btnNumberEight";
            this.btnNumberEight.Size = new System.Drawing.Size(70, 60);
            this.btnNumberEight.TabIndex = 0;
            this.btnNumberEight.TabStop = false;
            this.btnNumberEight.Text = "8";
            this.btnNumberEight.UseVisualStyleBackColor = false;
            this.btnNumberEight.Click += new System.EventHandler(this.number_Click);
            // 
            // btnNumberSeven
            // 
            this.btnNumberSeven.BackColor = System.Drawing.Color.White;
            this.btnNumberSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberSeven.Location = new System.Drawing.Point(17, 231);
            this.btnNumberSeven.Name = "btnNumberSeven";
            this.btnNumberSeven.Size = new System.Drawing.Size(70, 60);
            this.btnNumberSeven.TabIndex = 0;
            this.btnNumberSeven.TabStop = false;
            this.btnNumberSeven.Text = "7";
            this.btnNumberSeven.UseVisualStyleBackColor = false;
            this.btnNumberSeven.Click += new System.EventHandler(this.number_Click);
            // 
            // btnClearNow
            // 
            this.btnClearNow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClearNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearNow.Location = new System.Drawing.Point(169, 99);
            this.btnClearNow.Name = "btnClearNow";
            this.btnClearNow.Size = new System.Drawing.Size(70, 60);
            this.btnClearNow.TabIndex = 0;
            this.btnClearNow.TabStop = false;
            this.btnClearNow.Text = "C";
            this.btnClearNow.UseVisualStyleBackColor = false;
            this.btnClearNow.Click += new System.EventHandler(this.btnClearNow_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShowResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 498);
            this.Controls.Add(this.btnNumberSeven);
            this.Controls.Add(this.bufferLabel);
            this.Controls.Add(this.btnNumberEight);
            this.Controls.Add(this.proccesLabel);
            this.Controls.Add(this.btnNumberNine);
            this.Controls.Add(this.btnNumberFour);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnNumberFive);
            this.Controls.Add(this.btnClearNow);
            this.Controls.Add(this.btnClearProcces);
            this.Controls.Add(this.btnNumberSix);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnNumberOne);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNumberTwo);
            this.Controls.Add(this.btnNumberThree);
            this.Controls.Add(this.btnPowX);
            this.Controls.Add(this.btnNumberZero);
            this.Controls.Add(this.btnSqrtX);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnFlipSign);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFlipSign;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSqrtX;
        private System.Windows.Forms.Button btnPowX;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearProcces;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label proccesLabel;
        private System.Windows.Forms.Label bufferLabel;
        private System.Windows.Forms.Button btnNumberZero;
        private System.Windows.Forms.Button btnNumberThree;
        private System.Windows.Forms.Button btnNumberTwo;
        private System.Windows.Forms.Button btnNumberOne;
        private System.Windows.Forms.Button btnNumberSix;
        private System.Windows.Forms.Button btnNumberFive;
        private System.Windows.Forms.Button btnNumberFour;
        private System.Windows.Forms.Button btnNumberNine;
        private System.Windows.Forms.Button btnNumberEight;
        private System.Windows.Forms.Button btnNumberSeven;
        private System.Windows.Forms.Button btnClearNow;
    }
}

