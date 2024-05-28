using System;

namespace Clu
{
    partial class frmMain
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
			this.btnBackSpace = new System.Windows.Forms.Button();
			this.btnCE = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnRoot = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnPercent = new System.Windows.Forms.Button();
			this.btnNine = new System.Windows.Forms.Button();
			this.btnEight = new System.Windows.Forms.Button();
			this.btnSeven = new System.Windows.Forms.Button();
			this.btnSix = new System.Windows.Forms.Button();
			this.btnMultiple = new System.Windows.Forms.Button();
			this.btnEquation = new System.Windows.Forms.Button();
			this.btnFive = new System.Windows.Forms.Button();
			this.btnFour = new System.Windows.Forms.Button();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.btnThree = new System.Windows.Forms.Button();
			this.btnTwo = new System.Windows.Forms.Button();
			this.btnOne = new System.Windows.Forms.Button();
			this.btnEqual = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.btnPoint = new System.Windows.Forms.Button();
			this.btnZero = new System.Windows.Forms.Button();
			this.txtScreen = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnBackSpace
			// 
			this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackSpace.Location = new System.Drawing.Point(12, 98);
			this.btnBackSpace.Name = "btnBackSpace";
			this.btnBackSpace.Size = new System.Drawing.Size(44, 37);
			this.btnBackSpace.TabIndex = 0;
			this.btnBackSpace.TabStop = false;
			this.btnBackSpace.Text = "←";
			this.btnBackSpace.UseVisualStyleBackColor = true;
			this.btnBackSpace.Click += new System.EventHandler(this.BackSpace_Click);
			// 
			// btnCE
			// 
			this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCE.Location = new System.Drawing.Point(62, 98);
			this.btnCE.Name = "btnCE";
			this.btnCE.Size = new System.Drawing.Size(44, 37);
			this.btnCE.TabIndex = 1;
			this.btnCE.TabStop = false;
			this.btnCE.Text = "CE";
			this.btnCE.UseVisualStyleBackColor = true;
			this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(112, 98);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(44, 37);
			this.btnClear.TabIndex = 2;
			this.btnClear.TabStop = false;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinus.Location = new System.Drawing.Point(162, 98);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(44, 37);
			this.btnMinus.TabIndex = 3;
			this.btnMinus.TabStop = false;
			this.btnMinus.Text = "±";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.SingleOperational);
			// 
			// btnRoot
			// 
			this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoot.Location = new System.Drawing.Point(212, 98);
			this.btnRoot.Name = "btnRoot";
			this.btnRoot.Size = new System.Drawing.Size(44, 37);
			this.btnRoot.TabIndex = 4;
			this.btnRoot.TabStop = false;
			this.btnRoot.Text = "√";
			this.btnRoot.UseVisualStyleBackColor = true;
			this.btnRoot.Click += new System.EventHandler(this.SingleOperational);
			// 
			// btnDivide
			// 
			this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDivide.Location = new System.Drawing.Point(162, 141);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(44, 37);
			this.btnDivide.TabIndex = 5;
			this.btnDivide.TabStop = false;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.OperationClick);
			// 
			// btnPercent
			// 
			this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPercent.Location = new System.Drawing.Point(212, 141);
			this.btnPercent.Name = "btnPercent";
			this.btnPercent.Size = new System.Drawing.Size(44, 37);
			this.btnPercent.TabIndex = 6;
			this.btnPercent.TabStop = false;
			this.btnPercent.Text = "%";
			this.btnPercent.UseVisualStyleBackColor = true;
			this.btnPercent.Click += new System.EventHandler(this.SingleOperational);
			// 
			// btnNine
			// 
			this.btnNine.CausesValidation = false;
			this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNine.Location = new System.Drawing.Point(112, 141);
			this.btnNine.Name = "btnNine";
			this.btnNine.Size = new System.Drawing.Size(44, 37);
			this.btnNine.TabIndex = 7;
			this.btnNine.TabStop = false;
			this.btnNine.Text = "9";
			this.btnNine.UseVisualStyleBackColor = true;
			this.btnNine.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnEight
			// 
			this.btnEight.CausesValidation = false;
			this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEight.Location = new System.Drawing.Point(62, 141);
			this.btnEight.Name = "btnEight";
			this.btnEight.Size = new System.Drawing.Size(44, 37);
			this.btnEight.TabIndex = 8;
			this.btnEight.TabStop = false;
			this.btnEight.Text = "8";
			this.btnEight.UseVisualStyleBackColor = true;
			this.btnEight.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnSeven
			// 
			this.btnSeven.CausesValidation = false;
			this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeven.Location = new System.Drawing.Point(12, 141);
			this.btnSeven.Name = "btnSeven";
			this.btnSeven.Size = new System.Drawing.Size(44, 37);
			this.btnSeven.TabIndex = 9;
			this.btnSeven.TabStop = false;
			this.btnSeven.Text = "7";
			this.btnSeven.UseVisualStyleBackColor = true;
			this.btnSeven.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnSix
			// 
			this.btnSix.CausesValidation = false;
			this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSix.Location = new System.Drawing.Point(112, 184);
			this.btnSix.Name = "btnSix";
			this.btnSix.Size = new System.Drawing.Size(44, 37);
			this.btnSix.TabIndex = 10;
			this.btnSix.TabStop = false;
			this.btnSix.Text = "6";
			this.btnSix.UseVisualStyleBackColor = true;
			this.btnSix.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnMultiple
			// 
			this.btnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiple.Location = new System.Drawing.Point(162, 184);
			this.btnMultiple.Name = "btnMultiple";
			this.btnMultiple.Size = new System.Drawing.Size(44, 37);
			this.btnMultiple.TabIndex = 11;
			this.btnMultiple.TabStop = false;
			this.btnMultiple.Text = "*";
			this.btnMultiple.UseVisualStyleBackColor = true;
			this.btnMultiple.Click += new System.EventHandler(this.OperationClick);
			// 
			// btnEquation
			// 
			this.btnEquation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEquation.Location = new System.Drawing.Point(212, 184);
			this.btnEquation.Name = "btnEquation";
			this.btnEquation.Size = new System.Drawing.Size(44, 37);
			this.btnEquation.TabIndex = 12;
			this.btnEquation.TabStop = false;
			this.btnEquation.Text = "1/x";
			this.btnEquation.UseVisualStyleBackColor = true;
			this.btnEquation.Click += new System.EventHandler(this.SingleOperational);
			// 
			// btnFive
			// 
			this.btnFive.CausesValidation = false;
			this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFive.Location = new System.Drawing.Point(62, 184);
			this.btnFive.Name = "btnFive";
			this.btnFive.Size = new System.Drawing.Size(44, 37);
			this.btnFive.TabIndex = 13;
			this.btnFive.TabStop = false;
			this.btnFive.Text = "5";
			this.btnFive.UseVisualStyleBackColor = true;
			this.btnFive.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnFour
			// 
			this.btnFour.CausesValidation = false;
			this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFour.Location = new System.Drawing.Point(12, 184);
			this.btnFour.Name = "btnFour";
			this.btnFour.Size = new System.Drawing.Size(44, 37);
			this.btnFour.TabIndex = 14;
			this.btnFour.TabStop = false;
			this.btnFour.Text = "4";
			this.btnFour.UseVisualStyleBackColor = true;
			this.btnFour.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnSubtract
			// 
			this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubtract.Location = new System.Drawing.Point(162, 227);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(44, 37);
			this.btnSubtract.TabIndex = 16;
			this.btnSubtract.TabStop = false;
			this.btnSubtract.Text = "-";
			this.btnSubtract.UseVisualStyleBackColor = true;
			this.btnSubtract.Click += new System.EventHandler(this.OperationClick);
			// 
			// btnThree
			// 
			this.btnThree.CausesValidation = false;
			this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThree.Location = new System.Drawing.Point(112, 227);
			this.btnThree.Name = "btnThree";
			this.btnThree.Size = new System.Drawing.Size(44, 37);
			this.btnThree.TabIndex = 17;
			this.btnThree.TabStop = false;
			this.btnThree.Text = "3";
			this.btnThree.UseVisualStyleBackColor = true;
			this.btnThree.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnTwo
			// 
			this.btnTwo.CausesValidation = false;
			this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTwo.Location = new System.Drawing.Point(62, 227);
			this.btnTwo.Name = "btnTwo";
			this.btnTwo.Size = new System.Drawing.Size(44, 37);
			this.btnTwo.TabIndex = 18;
			this.btnTwo.TabStop = false;
			this.btnTwo.Text = "2";
			this.btnTwo.UseVisualStyleBackColor = true;
			this.btnTwo.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnOne
			// 
			this.btnOne.CausesValidation = false;
			this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOne.Location = new System.Drawing.Point(12, 227);
			this.btnOne.Name = "btnOne";
			this.btnOne.Size = new System.Drawing.Size(44, 37);
			this.btnOne.TabIndex = 19;
			this.btnOne.TabStop = false;
			this.btnOne.Text = "1";
			this.btnOne.UseVisualStyleBackColor = true;
			this.btnOne.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnEqual
			// 
			this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEqual.Location = new System.Drawing.Point(212, 227);
			this.btnEqual.Name = "btnEqual";
			this.btnEqual.Size = new System.Drawing.Size(44, 80);
			this.btnEqual.TabIndex = 20;
			this.btnEqual.Text = "=";
			this.btnEqual.UseVisualStyleBackColor = true;
			this.btnEqual.Click += new System.EventHandler(this.Result);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(162, 270);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(44, 37);
			this.btnPlus.TabIndex = 21;
			this.btnPlus.TabStop = false;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.OperationClick);
			// 
			// btnPoint
			// 
			this.btnPoint.CausesValidation = false;
			this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPoint.Location = new System.Drawing.Point(112, 270);
			this.btnPoint.Name = "btnPoint";
			this.btnPoint.Size = new System.Drawing.Size(44, 37);
			this.btnPoint.TabIndex = 22;
			this.btnPoint.TabStop = false;
			this.btnPoint.Text = ".";
			this.btnPoint.UseVisualStyleBackColor = true;
			this.btnPoint.Click += new System.EventHandler(this.NumbersClick);
			// 
			// btnZero
			// 
			this.btnZero.CausesValidation = false;
			this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnZero.Location = new System.Drawing.Point(12, 270);
			this.btnZero.Name = "btnZero";
			this.btnZero.Size = new System.Drawing.Size(94, 37);
			this.btnZero.TabIndex = 24;
			this.btnZero.TabStop = false;
			this.btnZero.Text = "0";
			this.btnZero.UseVisualStyleBackColor = true;
			this.btnZero.Click += new System.EventHandler(this.NumbersClick);
			// 
			// txtScreen
			// 
			this.txtScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScreen.Location = new System.Drawing.Point(12, 23);
			this.txtScreen.Name = "txtScreen";
			this.txtScreen.ReadOnly = true;
			this.txtScreen.Size = new System.Drawing.Size(244, 26);
			this.txtScreen.TabIndex = 25;
			this.txtScreen.TabStop = false;
			this.txtScreen.Text = "0";
			this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtScreen.WordWrap = false;
			// 
			// frmMain
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 325);
			this.Controls.Add(this.txtScreen);
			this.Controls.Add(this.btnZero);
			this.Controls.Add(this.btnPoint);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnEqual);
			this.Controls.Add(this.btnOne);
			this.Controls.Add(this.btnTwo);
			this.Controls.Add(this.btnThree);
			this.Controls.Add(this.btnSubtract);
			this.Controls.Add(this.btnFour);
			this.Controls.Add(this.btnFive);
			this.Controls.Add(this.btnEquation);
			this.Controls.Add(this.btnMultiple);
			this.Controls.Add(this.btnSix);
			this.Controls.Add(this.btnNine);
			this.Controls.Add(this.btnPercent);
			this.Controls.Add(this.btnDivide);
			this.Controls.Add(this.btnRoot);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCE);
			this.Controls.Add(this.btnBackSpace);
			this.Controls.Add(this.btnSeven);
			this.Controls.Add(this.btnEight);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		private void BackSpaceClick(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnEquation;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.TextBox txtScreen;
    }
}

