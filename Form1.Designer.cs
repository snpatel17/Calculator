
namespace Calculator
{
    partial class CalculatorForm
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
            this.lblShowOperations = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.rTxtDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnToggleSign = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowOperations
            // 
            this.lblShowOperations.AutoSize = true;
            this.lblShowOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOperations.Location = new System.Drawing.Point(128, 64);
            this.lblShowOperations.Name = "lblShowOperations";
            this.lblShowOperations.Size = new System.Drawing.Size(0, 20);
            this.lblShowOperations.TabIndex = 30;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(31, 103);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(259, 43);
            this.txtDisplay.TabIndex = 29;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Enabled = false;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.Location = new System.Drawing.Point(318, 34);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(70, 20);
            this.lblHistory.TabIndex = 28;
            this.lblHistory.Text = "History";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(405, 453);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(122, 39);
            this.btnClearHistory.TabIndex = 27;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            // 
            // rTxtDisplayHistory
            // 
            this.rTxtDisplayHistory.Location = new System.Drawing.Point(322, 64);
            this.rTxtDisplayHistory.Name = "rTxtDisplayHistory";
            this.rTxtDisplayHistory.ReadOnly = true;
            this.rTxtDisplayHistory.Size = new System.Drawing.Size(205, 366);
            this.rTxtDisplayHistory.TabIndex = 26;
            this.rTxtDisplayHistory.Text = "";
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(230, 415);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(60, 60);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(230, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 60);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(164, 415);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(60, 60);
            this.btnPoint.TabIndex = 22;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(230, 218);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 60);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(164, 349);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(60, 60);
            this.btnThree.TabIndex = 20;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(164, 218);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(60, 60);
            this.btnNine.TabIndex = 19;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(230, 283);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 60);
            this.btnSubtract.TabIndex = 25;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(97, 415);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(60, 60);
            this.btnZero.TabIndex = 6;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(230, 152);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 60);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(97, 349);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(60, 60);
            this.btnTwo.TabIndex = 15;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(164, 283);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(60, 60);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnToggleSign
            // 
            this.btnToggleSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleSign.Location = new System.Drawing.Point(31, 415);
            this.btnToggleSign.Name = "btnToggleSign";
            this.btnToggleSign.Size = new System.Drawing.Size(60, 60);
            this.btnToggleSign.TabIndex = 13;
            this.btnToggleSign.Text = "±";
            this.btnToggleSign.UseVisualStyleBackColor = true;
            this.btnToggleSign.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(97, 218);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(60, 60);
            this.btnEight.TabIndex = 12;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(31, 349);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 60);
            this.btnOne.TabIndex = 11;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(164, 152);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(60, 60);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "C";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(97, 283);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(60, 60);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(31, 218);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(60, 60);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(31, 283);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(60, 60);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNumberClick);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(97, 152);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(60, 60);
            this.btnClearEntry.TabIndex = 17;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(31, 152);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(60, 60);
            this.btnBackSpace.TabIndex = 18;
            this.btnBackSpace.Text = "⌫";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 537);
            this.Controls.Add(this.lblShowOperations);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.rTxtDisplayHistory);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnToggleSign);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnBackSpace);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowOperations;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.RichTextBox rTxtDisplayHistory;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnToggleSign;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnBackSpace;
    }
}

